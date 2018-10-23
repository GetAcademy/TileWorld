using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileWorld
{
    public class TileBoard
    {
        private int _rowCount;
        private int _colCount;

        public TileBoard(int rowCount, int colCount)
        {
            _rowCount = rowCount;
            _colCount = colCount;
        }

        public string GetBoard()
        {
            var twoRowTemplate = new[] { GetRow(), GetRow(false) };
            var rows = Enumerable.Repeat(twoRowTemplate, (_rowCount + 1) / 2).SelectMany(x=>x);
            return string.Join("\n", rows.Take(_rowCount)) + "\n";
        }

        public string GetRow(bool startWithWhite = true)
        {
            var cols = Enumerable.Repeat("█░", (_colCount + 2) / 2);
            var rowTemplate = string.Join(string.Empty, cols);
            return rowTemplate.Substring(startWithWhite ? 0 : 1, _colCount);
        }
    }
}
