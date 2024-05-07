using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRESTnaMOGILE
{
    internal class player
    { 
        bool[] combo = { false, false, false, false, false, false, false, false, false};
        private string name;
        public player(string name)
        {
            this.name = name;
        }
        public string setcombo(int n)
        {
            combo[n] = true;
            if (iswin())
                return "Win" + name;
            return "Win";
        }

        private bool iswin()
        {
            if (combo[0] && combo[1] && combo[2]) return true;
            if (combo[3] && combo[4] && combo[5]) return true;
            if (combo[6] && combo[7] && combo[8]) return true;
            if (combo[0] && combo[4] && combo[8]) return true;
            if (combo[6] && combo[4] && combo[2]) return true;
            if (combo[0] && combo[3] && combo[6]) return true;
            if (combo[1] && combo[4] && combo[7]) return true;
            if (combo[2] && combo[5] && combo[8]) return true;
            else return false;
        }
    }
}
