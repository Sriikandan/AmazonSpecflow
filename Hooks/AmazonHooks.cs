using AmazonTest.Drivers;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.Hooks
{
    [Binding]

    public class AmazonHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            //Initialize a shared BrowserDriver in the global container
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();

        }
    }
}
