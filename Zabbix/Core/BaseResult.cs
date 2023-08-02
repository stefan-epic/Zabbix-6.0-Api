using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zabbix.Core
{
    public class BaseResult
    {
        public virtual string[] Ids { get; set; }
    }
}
