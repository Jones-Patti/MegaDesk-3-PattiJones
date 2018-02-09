using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_3_PattiJones
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
    }
}
