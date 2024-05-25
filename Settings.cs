using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{

    /* This class contains the setting part of the circles; width, height, 
     * directions and all that */

    internal class Settings
    {

        public static int  Width { get; set; }
        public static int Height { get; set; }

        public static string directions;


        public Settings() {
            Width = 16; Height = 16;
            directions = "right";
        }
    }
}
