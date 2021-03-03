using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Threading;


namespace Bombe
{
    class Arena
    {
        public int BorderHeight { get; set; }
        public int BorderWidth { get; set; }
        public int[] GroundHeightPosition { get; set; }
        public int[] GroundWidthPosition { get; set; }
        public int TextBoxHeight { get; set; }

		public Arena()
		{
            BorderWidth = Console.WindowWidth - 2;
            BorderHeight = Console.WindowHeight - 2;
            GroundHeightPosition = new int[BorderWidth];
            GroundWidthPosition = new int[BorderWidth];
        }

        public void InitialStage(int cannonOnePositionX, int cannonOnePositionY, int targetPositionX, int targetPositionY)
		{
            Cannon cannon = new Cannon(cannonOnePositionX, cannonOnePositionY);
            cannon.DrawArtillery();

            Target target = new Target(targetPositionX, targetPositionY, BorderWidth);
            //target.DrawTarget();
            //target.DrawATATtarget();
            target.DrawTargetTank();
        }

        public void DrawGround()
        {
            foreach (int i in GroundHeightPosition)
            {
                //Random random = new Random();
                GroundHeightPosition[i] = TextBoxHeight - 2;   //random.Next(BorderHeight/2, BorderHeight);
                GroundWidthPosition[i] += 1;
                Console.SetCursorPosition(GroundWidthPosition[i], GroundHeightPosition[i]);

                Console.WriteLine("_");
            }
        }

        public Bullet LoadBullet(int cannonOnePositionX,int cannonOnePositionY, Target target)
		{
            Bullet bullet = new Bullet(cannonOnePositionX, cannonOnePositionY, BorderWidth, BorderHeight, target.Xposition, target.Yposition, TextBoxHeight, target);
            Console.SetCursorPosition(3, TextBoxHeight + 1);
            Console.WriteLine("Player turn");

            bullet.ChargeLvl();

            Console.SetCursorPosition(3, TextBoxHeight + 2);
            Console.WriteLine("Charge level locked");
            Console.SetCursorPosition(3, TextBoxHeight + 4);
            Console.WriteLine("Press SPACE to shoot");
            Console.SetCursorPosition(3, TextBoxHeight + 5);
            Console.WriteLine("Press P to PASS turn");

            return bullet;
        }

        public void ClearText()
        {
            Console.SetCursorPosition(3, TextBoxHeight + 1);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 2);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 3);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 4);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 5);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 6);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 7);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 8);
            Console.WriteLine("                                                               ");
            Console.SetCursorPosition(3, TextBoxHeight + 9);
            Console.WriteLine("                                                               ");
        }
    
    }
}
