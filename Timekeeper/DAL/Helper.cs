using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timekeeper.DAL
{
    public static class Helper
    {
        public static T GetAsyncResult<T>(Task<T> worker)
        {
            Task.WaitAll(worker);

            if (worker.IsCompletedSuccessfully)
            {
                return worker.Result;
            }
            else
            {
                return default(T);
            }
        }
    }
}
