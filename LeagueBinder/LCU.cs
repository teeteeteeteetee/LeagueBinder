using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using LCUSharp;
using System.Diagnostics;

namespace LeagueBinder
{
    public class LCU
    {

        public Boolean Status { get; set; }

        private async void Connect()
        {


            Status = true;

        }

        public void Load()
        {
            Status = false;
            Connect();
        }
    }
}
