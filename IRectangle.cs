using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Area
{
    interface IRectangle
    {
        uint Perimeter(uint length, uint width);
        uint Area(uint length, uint width);
    }
}
