using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Art
    {

        List<string> lemonArt = new List<string>
            {

                "                                    -///-..-/o.    ",
                "                                   /ssssssssss/    ",
                "                    `-:/++++++/:-.`.:/osssssss+    ",
                "               .:oyddddddddddddddddhs+-`:+ssso.    ",
                "            .+hdddddddddddddddddddddddddo..:-`     ",
                "          /ydddddddddddddddddddddddddddddds`       ",
                "        /hdddddddddddddddddddddddddddddddddd:      ",
                "      .hdddddddddddddddddddddddddddddddddddddo-    ",
                "     .dddddddddddddddddddddddddddddddddddddddddh:  ",
                "     hddddddddddddddddddddddddddddddddddddddddddd- ",
                "    -dddddddddddddddddddddddddddddddddddddddddddh` ",
                "    -dddddddddddddddddddddddddddddddddddddddddh+`  ",
                "  --`ddddddddddddddddddddddddddddddddddddddddo     ",
                "  /s +ddddddddddddddddddddddddddddddddddddddh.     ",
                "   :. odddddddddddddddddddhhddddddddddddddds`      ",
                "       /ddddyddddddddddddddddddddddddddddy-        ",
                "        `odddddddddddddddddddydddddddddo-          ",
                "          `/yddddddddddddddddddddddy+-             ",
                "             `:+shddddddddddhys+:.                 ",
                "                   ``...``                         ",
                "$$    $$$$$ $$   $$  $$$  $$   $$  $$$  $$$$  $$$$$",
                "$$    $$    $$$ $$$ $$ $$ $$$  $$ $$ $$ $$ $$ $$   ",
                "$$    $$$$  $$ $ $$ $$ $$ $$ $ $$ $$$$$ $$ $$ $$$$ ",
                "$$    $$    $$   $$ $$ $$ $$  $$$ $$ $$ $$ $$ $$   ",
                "$$$$$ $$$$$ $$   $$  $$$  $$   $$ $$ $$ $$$$  $$$$$",
                "                                                   ",
                "          $$$$ $$$$$$  $$$  $$   $$ $$$$           ",
                "         $$      $$   $$ $$ $$$  $$ $$ $$          ",
                "          $$$    $$   $$$$$ $$ $ $$ $$ $$          ",
                "            $$   $$   $$ $$ $$  $$$ $$ $$          ",
                "         $$$$    $$   $$ $$ $$   $$ $$$$           ",


            };
        public void DrawTitleScreen()
        {
            
            foreach (string line in lemonArt)
            {
                Console.WriteLine(line);
            }
       

        }
    }
    
}
