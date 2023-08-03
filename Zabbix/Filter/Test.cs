using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Entities;
using static Zabbix.Filter.BaseEntity;

namespace Zabbix.Filter
{
    public class BaseEntity
    {
        public enum test
        {
            A, B, C
        }

        
        // Base class implementation
    }

    public class Derived : BaseEntity
    {
        public new enum test
        {
            D, E, F
        }
    }

    public class Test<Entity>
        where Entity : BaseEntity
    {
        public Test()
        {
        }
    }


}
