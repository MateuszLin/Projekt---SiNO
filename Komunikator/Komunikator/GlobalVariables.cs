using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikator
{
    static class GlobalVariables
    {
        private static int _loginCounter = 2;

        public static int loginCounter
        {
            get { return _loginCounter; }
            set { _loginCounter = value; }
        }
    }
}
