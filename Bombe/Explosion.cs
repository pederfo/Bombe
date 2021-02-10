using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bombe
{
    class Explosion
    {
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public Explosion(int xposition, int yposition)
        {
            Xposition = xposition;
            Yposition = yposition;
        }

        //      \     /
        //       \ @ /
        //   ---( @@@ )---
        //       / @ \
        //      /     \

        //   @
        // -(_)-
        //  / \

        //   \ /
        // -- @ --
        //   / \

        // HIT EXPLOSION
        public void Explode()
        {
            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine("@");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine("@");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("@");

            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine("(");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine(")");

            Thread.Sleep(100);

            Console.SetCursorPosition(Xposition - 1, Yposition - 2);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition + 3, Yposition - 2);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition - 1, Yposition);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 3, Yposition);
            Console.WriteLine(@"\");

            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine("-");

            Thread.Sleep(100);

            Console.SetCursorPosition(Xposition - 2, Yposition - 3);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition + 4, Yposition - 3);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition - 2, Yposition + 1);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 4, Yposition + 1);
            Console.WriteLine(@"\");



            Console.SetCursorPosition(Xposition - 4, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition - 5, Yposition - 1);
            Console.WriteLine("-");

            Thread.Sleep(300);

            Console.SetCursorPosition(Xposition + 6, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition + 7, Yposition - 1);
            Console.WriteLine("-");


            Thread.Sleep(200);

            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition, Yposition);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition, Yposition+1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition+1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition+1);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition, Yposition-1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition+1, Yposition-1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition+2, Yposition-1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition+3, Yposition-1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition+4, Yposition-1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 6, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 7, Yposition - 1);
            Console.WriteLine(" ");



            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 1);
            Console.WriteLine(" ");


            Console.SetCursorPosition(Xposition - 1, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 1, Yposition);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition);
            Console.WriteLine(" ");

            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 5, Yposition - 1);
            Console.WriteLine(" ");

 

            Console.SetCursorPosition(Xposition - 2, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition - 3);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 2, Yposition + 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 4, Yposition + 1);
            Console.WriteLine(" ");



            Console.SetCursorPosition(Xposition - 4, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 5, Yposition - 1);
            Console.WriteLine(" ");



            Console.SetCursorPosition(Xposition + 6, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 7, Yposition - 1);
            Console.WriteLine(" ");
        }


        //   \ /
        // -- @ --
        //   / \

        public void ExplosionSmall()
        {
            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine("@");

            Thread.Sleep(50);

            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine("-");
            Console.SetCursorPosition(Xposition - 1, Yposition - 2);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition - 1, Yposition);
            Console.WriteLine("/");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine(@"\");

            Thread.Sleep(200);

            Console.SetCursorPosition(Xposition, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 3, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 2, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 3, Yposition - 1);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 1, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition - 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition - 1, Yposition);
            Console.WriteLine(" ");
            Console.SetCursorPosition(Xposition + 1, Yposition);
            Console.WriteLine(" ");
        }

        //       
        //      (@@@@@)
        //        |@|     
        //        |@|  
        //    ((  @@@  ))
        //           
        //            
    }
}
