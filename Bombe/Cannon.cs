using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombe
{
    class Cannon
    {
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public Cannon(int xposition, int yposition)
        {
            Xposition = xposition;
            Yposition = yposition;
        }



        //  Cannon One
        // ___
        //(___)===<
        // / \

        #region Cannon One
        public void DrawCannonOne()
        {

            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 2, Yposition);

            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition - 1, Yposition - 1);
            Console.WriteLine("(");
            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine(")");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition + 6, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition + 7, Yposition - 1);
            Console.WriteLine("<");

            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 2);
            Console.WriteLine("_");

        }
        #endregion


        //  Artillery
        //      //
        //    _//_
        //  _(____)_
        // (:: :: ::)
        #region Artillery
        public void DrawArtillery()
        {
            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("(");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 2, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 4, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 5, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 7, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 8, Yposition);
            Console.WriteLine(":");
            Console.SetCursorPosition(Xposition + 9, Yposition);
            Console.WriteLine(")");

            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine("(");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 6, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 7, Yposition - 1);
            Console.WriteLine(")");
            Console.SetCursorPosition(Xposition + 8, Yposition - 1);
            Console.WriteLine("_");

            Console.SetCursorPosition(Xposition + 3, Yposition - 2);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 2);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 5, Yposition - 2);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 6, Yposition - 2);
            Console.WriteLine("_");

            Console.SetCursorPosition(Xposition + 5, Yposition - 3);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 6, Yposition - 3);
            Console.WriteLine("/");
        }
        #endregion

    }


    //    
    //  ___
    // [___]==-
    //  / \

    //
    //  ____    
    // [____]=[]
    //  |  |


    //      ____
    //     |____]-
    //      ##
    //     //
    //     \\
    //      \\

    //      
    //     _______    
    //    /       \==[_]-
    //    \_______/
    //     ||   ||
    //     ||   ||
    //     ^^   ^^

    //     _______    
    //    /       \==[_]-
    //    \_______/
    //     \\   \\
    //     ||   ||
    //     ^^   ^^

    //  c=<
}
