using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRESTnaMOGILE
{
    internal class GAYme
    {
        private string[] symbol = { "X", "O" };
        private int steps = 0;
        private player[] pl = { new player("X"), new player("O")};
        public void Click(Button but, int n, Label lbl)
        {
            if (but.Text != "") return;
            int step = steps % symbol.Length;
            lbl.Text = pl[step].setcombo(n);
            steps++;
            but.Text = symbol[step];
        }
    }
}
