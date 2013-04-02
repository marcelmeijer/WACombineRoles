using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace WorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;

            return base.OnStart();
        }

        public override void Run()
        {
            Trace.WriteLine("WorkerRole entry point called", "Information");

            while (true)
            {
                //add your own functionalilty
                Thread.Sleep(10000);
                Trace.WriteLine("WorkerRole Run Working", "Information");
            }
        }
    }
}
