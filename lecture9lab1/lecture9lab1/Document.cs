using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9lab1
{
    class Document
    {
        // Instance Variable
        protected string text;

        // Mutators
        // Sets Text
        public void SetText(string text)
        {
            this.text = text;
        }

        // Utility Methods
        // Overrides ToString
        public override string ToString()
        {
            return text;
        }
    }
}
