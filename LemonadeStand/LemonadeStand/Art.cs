using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Art
    {

        List<string> titleScreenArt = new List<string>
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
                "%%    %%%%% %%   %%  %%%  %%   %%  %%%  %%%%  %%%%%",
                "%%    %%    %%% %%% %% %% %%%  %% %% %% %% %% %%   ",
                "%%    %%%%  %% % %% %% %% %% % %% %%%%% %% %% %%%% ",
                "%%    %%    %%   %% %% %% %%  %%% %% %% %% %% %%   ",
                "%%%%% %%%%% %%   %%  %%%  %%   %% %% %% %%%%  %%%%%",
                "                                                   ",
                "          %%%% %%%%%%  %%%  %%   %% %%%%           ",
                "         %%      %%   %% %% %%%  %% %% %%          ",
                "          %%%    %%   %%%%% %% % %% %% %%          ",
                "            %%   %%   %% %% %%  %%% %% %%          ",
                "         %%%%    %%   %% %% %%   %% %%%%           ",


            };

        List<string> lemonsArt = new List<string>
        {

                "                                                   ",
                "                                                   ",
                "       %%    %%%%% %%   %%  %%%  %%   %%  %%%%     ",
                "       %%    %%    %%% %%% %% %% %%%  %% %%        ",
                "       %%    %%%%  %% % %% %% %% %% % %%  %%%      ",
                "       %%    %%    %%   %% %% %% %%  %%%    %%     ",
                "       %%%%% %%%%% %%   %%  %%%  %%   %% %%%%      ",             
                "                                                   ",
                "                                                   ",
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

        };
        List<string> sugarArt = new List<string>
        {
            "   %%%%%  %%   %%    %%%%%     %%%%%    %%%%%%    ",
            "  %%      %%   %%   %%   %%   %%   %%   %%   %%   ",
            "  %%      %%   %%  %%         %%   %%   %%   %%   ",
            "   %%%%   %%   %%  %%   %%%  %%%%%%%%%  %%%%%%    ",
            "      %%  %%   %%  %%    %%  %%     %%  %%  %%    ",
            "      %%  %%   %%   %%   %%  %%     %%  %%   %%   ",
            "  %%%%%    %%%%%     %%%%%   %%     %%  %%    %%  ",
            "                                                  ",
            "                                                  ",
            "                                                  ",
            "                                                  ",
            "                           `.                     ",
            "                       :ohmNNNdo-                 ",
            "                    -smNNNNmmNNNNd+`              ",
            "                 .odmmmmmmmmmmmmmmmNy/`           ",
            "              `/ymmmmmmmmmmmmmmmmmmmmmmy/`        ",
            "         ``-/ymmmmmmdddddddddddddddmmmmmmmy/.     ",
            "``````.-/+yddddddddhdddddhhhhhhhdddddddddddddy/-.`",
            "    ` ```.-://++ooooooooooooooooooooooo++///:-.```",
            "                                                  ",
        };

        List<string> cupArt = new List<string>
        {
            "                                                  ",
            "                                                  ",
            "         %%%%%   %%   %%  %%%%%    %%%%%%         ",
            "        %%   %%  %%   %%  %%  %%  %%    %%        ",
            "       %%        %%   %%  %%  %%  %%              ",
            "       %%        %%   %%  %%%%%    %%%%%%         ",
            "       %%        %%   %%  %%            %%        ",
            "        %%   %%  %%   %%  %%      %%    %%        ",
            "         %%%%%    %%%%%   %%       %%%%%%         ",
            "                                                  ",
            "                               %%                 ",
            "                              %%                  ",
            "                `/+ossyyyyyys%%o/`                ",
            "                 -+oyyysoo++++/:-                 ",
            "                 `:/oo+/::----..`                 ",
            "                  -/+++/::------                  ",
            "                  .:+o+/::-----.                  ",
            "                  `:/++/::-----.                  ",
            "                  `:/++/::-----`                  ",
            "                   :/++/::-----                   ",
            "                   -/++/::----.                   ",
            "                   `////::----`                   ",
            "                    `.::-...``                    ",
            "                                                  ",
            "                                                  ",

        };



        List<string> iceArt = new List<string>
        {

            "                                                                ",
            "      %%%%%%  %%%% %%%%%   %%%% %% %% %%%%  %%%%%  %%%%         ",
            "        %%   %%    %%     %%    %% %% %% %% %%    %%            ",
            "        %%   %%    %%%%   %%    %% %% %%%%  %%%%   %%%          ",
            "        %%   %%    %%     %%    %% %% %% %% %%       %%         ",
            "      %%%%%%  %%%% %%%%%   %%%%  %%%  %%%%  %%%%% %%%%          ",
            "                                                                ",
            "                           `.-.......``                         ",
            "                       `/+/-..........---..                     ",
            "                      `o:-...--....-.....-:/.                   ",
            "                      o/:..-----.-.......-:::`                  ",
            "                      ho/---.............-://.                  ",
            "                     .o-`              ``.-//-                  ",
            "                    -`    ``.-::/::-..`    `.:                  ",
            "                    `.  `..-:/oooooo/:-.``   ``                 ",
            "                     .`/:-::---:oo/-..::-..` .                  ",
            "                     -/s+//+ososyhsooo/:-:/o``                  ",
            "                     -osoyyyyyosyyooyhysooso:`                  ",
            "                     .ss+osyyy++++//+ysso+++/.                  ",
            "                      /o++osyy+::/--+sso+///:.                  ",
            "                      .//+oo/://++/::-/+///-`                   ",
            "                      `.::/-://+oo+//:./:--`                    ",
            "                      `-`.-`://:..-/::`..`..                    ",
            "                     :/.:````.:/:-::-` ` `-::-`                 ",
            "                   -yh../-``   ````     `.-`.//-`               ",
            "               .-oydh/.-.:-.`          `....`-:/::.```          ",
            "             ::-:yhy/-.--.----.``````.....-.`.--/::.``.         ",
            "             ..-sso:....----.............-......-:/:.``         ",
            "             ../o/...```..::------.------...````.-::-``         ",
            "             .-//.`  ````.-:::::::::::::....```   `-:.`         ",
            "                                                                ",
            "                                                                ",
        };





        public void DrawTitleScreen()
        {
            
            foreach (string line in titleScreenArt)
            {
                Console.WriteLine(line);
            }
       

        }
        public void DrawSugarArt()
        {
            foreach (string line in sugarArt)
            {
                Console.WriteLine(line);
            }
        }

        public void DrawLemonArt()
        {
            foreach (string line in lemonsArt)
            {
                Console.WriteLine(line);
            }
        }

        public void DrawCupArt()
        {
            foreach(string line in cupArt)
            {
                Console.WriteLine(line);
            }
        }

        public void DrawIceArt()
        {
            foreach(string line in iceArt)
            {
                Console.WriteLine(line);
            }
        }
    }
    
}
