using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrative_Systems_Solution
{
    internal class RecoveryData:ConfigurationSection
    {
        [ConfigurationProperty("Current Operation", DefaultValue = 0)]
        public IntPtr CurrentOperation
        { 
            get { return (IntPtr)this["Current Operation"]; }
            set { this["Current Operation"] = value; }
        }

        [ConfigurationProperty("Current Page", DefaultValue = 0)]
        public int CurrentPage
        {
            get { return (int)this["Current Page"]; }
            set { this["Current Page"] = value; }
        }
    }
}
