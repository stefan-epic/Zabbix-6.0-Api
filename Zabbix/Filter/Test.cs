using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Entities;

namespace Zabbix.Filter
{
    public class BaseEntity
    {
        // Base class implementation
    }

    public class DerivedEntity : BaseEntity
    {
        // Derived class implementation
    }

    public class Test<Entity>
        where Entity : BaseEntity, new()
    {
        public Test()
        {
            Entity t = new Entity();
            // You can now work with the instance 't' of the derived class.
        }
    }


}
