using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Util
{
    class WinMutex
    {
        public static int count = 0;
        public static Mutex mutex = new Mutex();
    }
}
