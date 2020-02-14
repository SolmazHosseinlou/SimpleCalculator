using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Area
{
    class Rectangle : IRectangle
    {
        public uint Area(uint length, uint width)
        {
            return length * width;
        }

        public uint Perimeter(uint length, uint width)
        {
            return (length + width) * 2;
        }
    }
}
