using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;

namespace ZabbixIntegrationTests
{
    public abstract class TestBase
    {
        public ZabbixCore Core { get; }
        public Guid Id { get; }
        public HostGroup? TestGroup { get; set; }
        public Host? TestHost { get; set; }
        public UserGroup? TestUserGroup { get; set; }
        public Item? TestItem { get; set; }

        public TestBase()
        {
            string url = "";
            string username = "";
            string password = "";
            Core = new ZabbixCore(url, username, password);
            Id = Guid.NewGuid();
        }

        public abstract void SetUp();
        public abstract void CleanUp();

        [TestInitialize]
        public void BaseSetup()
        {
            SetUp();
        }

        [TestCleanup]
        public void BaseCleanUp()
        {
            CleanUp();
        }

        public void TestCycle<T>(T entity, string propertyName) where T : BaseEntity
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);

            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            var @params = new object[] { entity };
            Assert.IsNotNull(propVal);

            TestCreateInternal(entity, propVal, paramType, @params);
            TestUpdateInternal(entity, propVal, paramType, @params);
            TestDeleteInternal(entity, propVal, paramType, @params);
        }
        public void TestCycle<T>(T entity, string propertyName, List<string> setNullForUpdatePropNames) where T : BaseEntity
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);

            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            var @params = new object[] { entity };

            Assert.IsNotNull(propVal);
            TestCreateInternal(entity, propVal, paramType, @params);

            foreach (var name in setNullForUpdatePropNames) {
               var prop = entity.GetType().GetProperty(name);
               if (prop != null) {
                   prop.SetValue(entity, null);
               }
            }

            TestUpdateInternal(entity, propVal, paramType, @params);
            TestDeleteInternal(entity, propVal, paramType, @params);
        }

        private void TestCreateInternal<T>(T entity, object? propVal, Type[] paramType, object[] @params) where T : BaseEntity
        {
            Assert.IsNotNull(propVal);
            var createMethod = propVal.GetType().GetMethod("Create", paramType);
            entity.EntityId = (string?)createMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        private void TestUpdateInternal<T>(T entity, object propVal, Type[] paramType, object[] @params) where T : BaseEntity
        {
            Assert.IsNotNull(propVal);
            var updateMethod = propVal.GetType().GetMethod("Update", paramType);
            entity.EntityId = (string?)updateMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        private void TestDeleteInternal<T>(T entity, object propVal, Type[] paramType, object[] @params) where T : BaseEntity
        {
            Assert.IsNotNull(propVal);
            var deleteMethod = propVal.GetType().GetMethod("Delete", paramType);
            entity.EntityId = (string?)deleteMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        public object TestGet<T>(T? filter, string propertyName) where T : FilterOptions
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);
            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            Assert.IsNotNull(propVal);
            var getMethod = propVal.GetType().GetMethod("Get", paramType);
            var @params = new object?[] { filter };
            var obj = getMethod.Invoke(propVal, @params);
            Assert.IsNotNull(obj);
            return obj;
        }

        public void TestCreate<T>(T entity, string propertyName) where T : BaseEntity
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);
            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            Assert.IsNotNull(propVal);
            var createMethod = propVal.GetType().GetMethod("Create", paramType);
            var @params = new object[] { entity };

            entity.EntityId = (string?)createMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        public void TestUpdate<T>(T entity, string propertyName) where T : BaseEntity
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);
            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            Assert.IsNotNull(propVal);
            var updateMethod = propVal.GetType().GetMethod("Update", paramType);
            var @params = new object[] { entity };

            entity.EntityId = (string?)updateMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        public void TestDelete<T>(T entity, string propertyName) where T : BaseEntity
        {
            var propInfo = Core.GetType().GetProperty(propertyName);
            Assert.IsNotNull(propInfo);
            var paramType = new Type[] { typeof(T) };
            var propVal = propInfo.GetValue(Core);
            Assert.IsNotNull(propVal);
            var updateMethod = propVal.GetType().GetMethod("Delete", paramType);
            var @params = new object[] { entity };

            entity.EntityId = (string?)updateMethod.Invoke(propVal, @params);
            Assert.IsNotNull(entity.EntityId);
        }

        public void SetUpTestHost(HostGroup h)
        {
            TestHost = new Host("TestHost" + Id, new List<HostGroup>(){h});
            try
            {
                TestHost.EntityId = Core.Hosts.Create(TestHost);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of TestHost failed, failed to create TestHost", e);
            }
        }

        public void DestroyTestHost()
        {
            try
            {
                Core.Hosts.Delete(TestHost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Deleting of TestHost failed, failed to delete TestHost", e);
            }
        }

        public void DestroyTestGroup()
        {
            try
            {
                Core.HostGroups.Delete(TestGroup);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Deleting of TestGroup failed, failed to delete HostGroup", e);
            }
        }
        public void SetUpTestGroupAndHost()
        {
            SetUpTestGroup();
            SetUpTestHost(TestGroup);
        }

        public void DestroyTestGroupAndHost()
        {
            DestroyTestHost();
            DestroyTestGroup();
        }

        public void SetUpTestGroup()
        {
            TestGroup = new HostGroup("TestGroup" + Id);
            try
            {
                TestGroup.EntityId = Core.HostGroups.Create(TestGroup);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of TestGroup failed, failed to create HostGroup", e);

            }
        }
        public void SetUpTestUserGroup()
        {
            TestUserGroup = new UserGroup("TestUserGroup" + Id);
            try
            {
                TestUserGroup.EntityId = Core.UserGroups.Create(TestUserGroup);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of UserGroup failed, failed to create UserGroup", e);

            }
        }
        public void DestroyTestUserGroup()
        {
            try
            {
                Core.UserGroups.Delete(TestUserGroup);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of UserGroup failed, failed to create UserGroup", e);

            }
        }
        public void SetUpTestItem(Host h)
        {
            try
            {
                TestItem = new Item("1m", h.EntityId!, null!, "testKey" + Id, "testItem" + Id, 19, "test.com", 0);
                TestItem.EntityId = Core.Items.Create(TestItem);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of Item failed, failed to create Item", e);

            }
        }
        public void DestroyTestItem()
        {
            try
            {
                Core.Items.Delete(TestItem);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new AssertFailedException("Initializing of Item failed, failed to create Item", e);

            }
        }

    }
}