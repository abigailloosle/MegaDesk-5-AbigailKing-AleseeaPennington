using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_AbigailKing
{
    public struct Desk
    {
        //properties
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }
        public Surface SurfaceMaterial { get; set; }

        //enum
        public enum Surface
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
    }
}
