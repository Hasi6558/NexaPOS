using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexaPOS
{
    
    internal class DBConnect
    {
        private string con;
        public string myConnection()
        {
            string constring = "server=localhost;uid=root;pwd=Hasindu1234H;database=dbnexapos";
            return constring;
        }
    }
}
