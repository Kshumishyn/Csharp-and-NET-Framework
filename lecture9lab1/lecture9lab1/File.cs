using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9lab1
{
    class File
    {
        // Instance Variables
        protected string pathname;

        // Accessors
        // Gets the Pathname
        public string GetPathname()
        {
            return pathname;
        }

        // Utility Methods
        public override string ToString()
        {
            return String.Format("Pathname: {0}\nText: {1}",
                                  GetPathname(), base.ToString());
        }
    }
}
