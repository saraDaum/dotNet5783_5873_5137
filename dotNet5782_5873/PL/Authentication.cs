using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Authentication
    {

		public static  string ManagerUserName => ConfigurationManager.AppSettings["ManagerUserName"];

        public static  string ManagerPassword => ConfigurationManager.AppSettings["ManagerPassword"];

        public static bool IsManager { get => isManager;  }

        static bool isManager;

        internal static void AuothorizeManager(string text1, string text2)
        {
            if (text1 == ManagerUserName && text2 == ManagerPassword)
                isManager = true;
        }
    }
}
