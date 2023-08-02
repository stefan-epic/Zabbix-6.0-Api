using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Core
{
    public interface ICore : IDisposable
    {
        T SendRequest<T>(object @params, string method);
        T SendRequest<T>(object @params, string method, string token);

        Task<T> SendRequestAsync<T>(object @params, string method);
        Task<T> SendRequestAsync<T>(object @params, string method, string token);
    }
}
