using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_CON
{
   public class Boggles
    {
        bool [,] _visitedGrid;
        int _visitedGridSize;
        Tuple<int, int> _curloc;
        Grid _grid;
        public Boggles(Grid argGrid) {  _grid = argGrid;_visitedGridSize = _grid.GetGridSize();_visitedGrid = new bool[_visitedGridSize, _visitedGridSize];  _curloc = new Tuple<int, int>(0, 0); }

        public void PrintVisitedGrid()
        {
            for (int x = 0; x < _visitedGridSize; x++)
            {
                for (int y = 0; y < _visitedGridSize; y++)
                {
                    Console.Write(_visitedGrid[x, y] ? "t":"f");
                }
                Console.WriteLine();
            }
        }

      
        
       // Tuple<int,int> curloc = new Tuple<int,int>(12, 2);
    }
}
