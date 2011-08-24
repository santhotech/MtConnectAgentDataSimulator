using System;
using System.Collections.Generic;
using System.Text;

namespace AgentDataSimulator
{
    class GeneralUtility
    {
        public bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public string Pluralize(int count,string str)
        {
            if (count > 1)
            {
                return str+"s";
            }
            else
                return str;
        }
    }
}
