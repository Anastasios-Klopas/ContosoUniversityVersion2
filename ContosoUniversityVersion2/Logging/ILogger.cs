using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversityVersion2.Logging
{
    interface ILogger
    {
        void Information(string message);
        void Information(string fat, params object[] vars);
        void Information(Exception exception, string fat, params object[] vars);

        void Warning(string message);
        void Warning(string fat, params object[] vars);
        void Warning(Exception exception, string fat, params object[] vars);
        void Error(string message);
        void Error(string fat, params object[] vars);
        void Error(Exception exception, string fat, params object[] vars);

        void TraceApi(string componentName, string method, TimeSpan timeSpan);
        void TraceApi(string componentName, string method, TimeSpan timeSpan, string properties);
        void TraceApi(string componentName, string method, TimeSpan timeSpan, string fat, params object[] vars);
    }
}
