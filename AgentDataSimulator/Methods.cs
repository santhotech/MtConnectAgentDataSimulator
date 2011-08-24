using System;
using System.Collections.Generic;
using System.Text;

namespace AgentDataSimulator
{
    class Methods
    {
        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
