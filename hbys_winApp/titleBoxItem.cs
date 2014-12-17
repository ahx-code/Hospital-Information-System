using System;
using System.Collections.Generic;
using System.Text;

namespace hbys_winApp
{
    class titleBoxItem
    {
        string txt;

        public string Txt
        {
            get { return txt; }
            set { txt = value; }
        }
        string val;

        public string Val
        {
            get { return val; }
            set { val = value; }
        }

        public override string ToString()
        {
            return txt;
        }
    }
}
