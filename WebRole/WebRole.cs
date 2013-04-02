using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace WebRole
{
    public class WebRole : RoleEntryPoint
    {
        public override bool OnStart()
        {
            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            return base.OnStart();
        }

        public override void Run()
        {
            Trace.WriteLine("WorkerRole in WebRole entry point called", "Information");

            while (true)
            {
                //add your own functionalilty
                Thread.Sleep(10000);
                Trace.WriteLine("WebRole Run Working", "Information");
            }
        }
    }
}
