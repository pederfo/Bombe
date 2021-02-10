using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bombe
{
    class Target
    {
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public int BorderWidth { get; set; }
        public Target(int xposition, int yposition, int borderWidth)
        {
            Xposition = xposition;
            Yposition = yposition;
            BorderWidth = borderWidth;
        }

        //   @
        // -(_)-
        //  / \

        public void DrawTarget()
        {
            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 2, Yposition);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition - 1, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("(");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine(")");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("@");
        }

        //      ___
        // >===(___)
        //      0 0

        #region TankTarget



        public void DrawTargetTank()
        {

            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("0");
            Console.SetCursorPosition(Xposition + 2, Yposition);
            Console.WriteLine("0");
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
            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 4, Yposition - 1);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 5, Yposition - 1);
            Console.WriteLine(">");

            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 2);
            Console.WriteLine("_");

        }

        public void TankMovement()
        {
            if (Xposition <= BorderWidth - 50)
            {
                TankMoveBackward();
            } else if (Xposition >= BorderWidth - 12)
            {
                TankMoveForward();

            } else
            {
                Random random = new Random();
                int directionOfMovement = random.Next(1, 2);
                if ( directionOfMovement == 1)
                {
                    TankMoveForward();
                }
                else
                {
                    TankMoveBackward();
                }

            }
        }

        public void TankMoveForward()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                TankGone();
                Xposition = Xposition - 1;
                DrawTargetTank();
            }
        }

        public void TankMoveBackward()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                TankGone();
                Xposition = Xposition + 1;
                DrawTargetTank();
            }
        }

        public void TankGone()
        {
            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition - 1, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 4, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 5, Yposition - 1);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 2);
            Console.WriteLine(" ");
        }

        #endregion


        //        _______    
        // -[_]==/       \
        //       \_______/
        //        ||   ||
        //        ||   ||
        //        ^^   ^^

        #region AT-AT Target

        public void DrawATATtarget()
        {

            // Legs

            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 4, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 5, Yposition);
            Console.WriteLine("^");

            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 4, Yposition - 2);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 5, Yposition - 2);
            Console.WriteLine("|");

            //Body

            Console.SetCursorPosition(Xposition, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 3, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition - 3);
            Console.WriteLine("_");

            Console.SetCursorPosition(Xposition -1, Yposition - 3);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition - 1, Yposition - 4);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 7, Yposition - 3);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 7, Yposition - 4);
            Console.WriteLine(@"\");

            Console.SetCursorPosition(Xposition, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 3, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition - 5);
            Console.WriteLine("_");

            // Head

            Console.SetCursorPosition(Xposition - 2, Yposition - 4);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 3, Yposition - 4);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 4, Yposition - 4);
            Console.WriteLine("]");
            Console.SetCursorPosition(Xposition - 5, Yposition - 4);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition - 6, Yposition - 4);
            Console.WriteLine("[");
            Console.SetCursorPosition(Xposition - 7, Yposition - 4);
            Console.WriteLine("-");
            
        }

        //        _______    
        // -[_]==/       \
        //       \_______/
        //        //   //
        //        ||   ||
        //        ^^   ^^

        public void DrawATATtargetMovement()
        {

            // Legs

            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 4, Yposition);
            Console.WriteLine("^");
            Console.SetCursorPosition(Xposition + 5, Yposition);
            Console.WriteLine("^");

            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 4, Yposition - 2);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(Xposition + 5, Yposition - 2);
            Console.WriteLine(@"/");

            //Body

            Console.SetCursorPosition(Xposition, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 3, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 3);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition - 3);
            Console.WriteLine("_");

            Console.SetCursorPosition(Xposition - 1, Yposition - 3);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition - 1, Yposition - 4);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 7, Yposition - 3);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(Xposition + 7, Yposition - 4);
            Console.WriteLine(@"\");

            Console.SetCursorPosition(Xposition, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 2, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 3, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition - 5);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition - 5);
            Console.WriteLine("_");

            // Head

            Console.SetCursorPosition(Xposition - 2, Yposition - 4);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 3, Yposition - 4);
            Console.WriteLine("=");
            Console.SetCursorPosition(Xposition - 4, Yposition - 4);
            Console.WriteLine("]");
            Console.SetCursorPosition(Xposition - 5, Yposition - 4);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition - 6, Yposition - 4);
            Console.WriteLine("[");
            Console.SetCursorPosition(Xposition - 7, Yposition - 4);
            Console.WriteLine("-");
        }

        public void ATATgone()
        {
            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 4, Yposition);
            Console.WriteLine("_");
            Console.SetCursorPosition(Xposition + 5, Yposition);
            Console.WriteLine("_");

            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 2);
            Console.WriteLine(" ");

            //Body

            Console.SetCursorPosition(Xposition, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 3);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition - 1, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 1, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 7, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 7, Yposition - 4);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition, Yposition - 5);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 5);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 5);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition - 5);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 5);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 5);
            Console.WriteLine(" ");

            // Head

            Console.SetCursorPosition(Xposition - 2, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 3, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 4, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 5, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 6, Yposition - 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 7, Yposition - 4);
            Console.WriteLine(" ");
        }

        public void ATATMoveForward()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(400);
                ATATgone();
                Xposition = Xposition - 1;
                DrawATATtargetMovement();

                Thread.Sleep(400);
                ATATgone();
                Xposition = Xposition - 1;
                DrawATATtarget();
            }
        }

        public void ATATMovement()
        {
                ATATMoveForward();
        }

        //      
        //        _______    
        // -[_]==/       \
        //       \_______/
        //        ||   ||
        //        ||   ||
        //        ^^   ^^

        //        _______    
        // -[_]==/       \
        //       \_______/
        //        //   //
        //        ||   ||
        //        ^^   ^^

        //  c=<

        #endregion

    }
}
