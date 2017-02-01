using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_CON
{
    public class Grid
    {
        char[,] _grid;
        int _gridSize;
        public int GetGridSize() { return _gridSize; }
        string _inputstring;

        public Grid(int size,string argInputString) { _grid = new char[size, size]; _gridSize = size; _inputstring = argInputString; buildFromStrings(_inputstring); }
        public Grid(int size) { _grid = new char[size, size]; _gridSize = size; }
        public Grid() { _grid = new char[4, 4]; _gridSize = 4; build4x4(); }

        // D X Z C
        // O Y Z I
        // G M A J
        // Z Z Z Z
        void build4x4() {
            _grid[0, 0] = 'd'; _grid[0, 1] = 'x'; _grid[0, 2] = 'z'; _grid[0, 3] = 'c';
            _grid[1, 0] = 'o'; _grid[1, 1] = 'y'; _grid[1, 2] = 'z'; _grid[1, 3] = 'i';
            _grid[2, 0] = 'g'; _grid[2, 1] = 'm'; _grid[2, 2] = 'a'; _grid[2, 3] = 'j';
            _grid[3, 0] = 'z'; _grid[3, 1] = 'z'; _grid[3, 2] = 'z'; _grid[3, 3] = 'z';
        }
        // dxzcoyzigmajzzzz
        void buildFromStrings(string s) {
            int stringNdx = 0;
            for (int x = 0; x < _gridSize; x++) {
                for (int y = 0; y < _gridSize; y++) {
                    _grid[x, y] = s[stringNdx++];
                }
            }
        }


       public void PrintGrid()
        {
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    Console.Write(  _grid[x, y]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
