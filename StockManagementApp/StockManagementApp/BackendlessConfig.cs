using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp
{
    public class BackendlessConfig
    {
        private string APPKEY = "232AC1A7-F563-A545-FF10-0DA07F3F8700";
        private string NETAPI = "B34F7DA5-F291-4606-AA49-91E195178870";
       public void init()
       {
            Backendless.InitApp(APPKEY, NETAPI);
       }
    }
}
