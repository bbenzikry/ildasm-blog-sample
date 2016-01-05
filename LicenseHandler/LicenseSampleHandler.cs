using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseExample.LicenseHandler
{
    public static class LicenseSampleHandler
    {
        public static void DoSomethingRelatedToFriendAssembly()
        {
            LicenseExample.LicenseInternal.
                LicenseInternalClass.
                DoSomethingRelatedToLicense();
        }
    }
}
