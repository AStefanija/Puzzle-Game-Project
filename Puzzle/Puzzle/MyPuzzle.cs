using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    class MyPuzzle:PictureBox
    {
        int index = 0;
        public int Index { get { return index; } set { index = value; } }

        int imgIndex = 0;
        public int ImgIndex { get { return imgIndex; } set { imgIndex = value; } }

        public bool matching()
        {
            return (index == imgIndex);
        }
    }
}
