using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_CON
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryBuilder d = new DictionaryBuilder();
            Grid grid = new Grid(4, "dxzcoyzigmajzzzz");
            grid.PrintGrid();
            d.ContainsWordStartWith("zxxnab");
            Boggles bogs = new Boggles(4);
            bogs.PrintVisitedGrid();



        }
    }
}
