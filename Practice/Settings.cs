using System;

namespace Practice
{

    /* This class contains the setting part of the circles; width, height, 
     * directions and all that.
     */

    internal class Settings
    {

        public int  Width { get; set; }
        public int Height { get; set; }

        public static string directions;


        public Settings() {
            Width = 16; Height = 16;
            directions = "right";
        }

        
    }
}
