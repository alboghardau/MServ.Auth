using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MServ.Auth.Common.Interfaces
{
    public  interface IConfigManager
    {
        public string GetString(string jsonPath);
        public bool GetBool(string jsonPath);
    }
}
