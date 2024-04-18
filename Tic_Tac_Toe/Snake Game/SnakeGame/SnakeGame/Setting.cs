using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
     class Setting
    {
        public static int width { get; set; }
        public static int height { get; set; }

        public static string directions;

        public Setting()
        {
            width = 16;
            height = 16;
            directions = "left";
        }



    }
}
