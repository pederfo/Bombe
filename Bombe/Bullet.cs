using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bombe
{
    class Bullet
    {
        #region Properties

        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public int BorderHeight { get; set; }
        public int BorderWidth { get; set; }
        public int TargetPositionX { get; set; }
        public int TargetPositionY { get; set; }
        public int Charge { get; set; }
        public bool TargetHit { get; set; }
        public bool PlayerHit { get; set; }
        public int TextBoxHeight { get; set; }
        #endregion

        public Bullet(int xposition, int yposition, int borderWidth, int borderHeight, int targetPositionX, int targetPositionY, int textBoxHeight, Target target)
        {
            Xposition = xposition;
            Yposition = yposition;
            BorderHeight = borderHeight;
            BorderWidth = borderWidth;
            TargetPositionX = targetPositionX;
            TargetPositionY = targetPositionY;
            Charge = 1;
            TargetHit = false;
            PlayerHit = false;
            TextBoxHeight = textBoxHeight;

        }

        // BULLET PROJECTION
        public void DrawBullet()
        {
            int startPosX = Xposition + 8;
            int startPosY = Yposition - 1;
            int currentPosX = 0;
            int currentPosY = 0;



            // weather effect
            Random random = new Random();
            int weatherEffect = random.Next(0, 10);
            int hit = BorderWidth - weatherEffect;

            if (Charge == 1)
            {

                for (int i = 0; i < hit - 50; i++)
                {
                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX + i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == TargetPositionX)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    } else if (currentPosX == hit - 50)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            } else if (Charge == 2)
            {
                for (int i = 0; i < hit - 30; i++)
                {
                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX + i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == TargetPositionX)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    }
                    else if (currentPosX == hit - 30)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            } else if (Charge == 3)
            {
                for (int i = 0; i < hit - 10; i++)
                {
                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX + i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX + i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == TargetPositionX)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    }
                    else if (currentPosX == hit - 10)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            }

            //xpos = startPosX + BorderWidth - Yposition;
            //ypos = startPosY;

        }

        // CHARGE LEVEL
        public void ChargeLvl()
        {
            bool chargeLevel = false;
            Console.SetCursorPosition(3, TextBoxHeight + 6);
            Console.WriteLine("Use UP ARROW to increase charge, DOWN ARROW to decrease charge, or C to lock charge. ");
            Console.SetCursorPosition(3, TextBoxHeight + 7);
            Console.WriteLine("Charge: #  ");
            while (!chargeLevel)
            {
                if (Charge == 1)
                {
                    Console.SetCursorPosition(3, TextBoxHeight + 7);
                    Console.WriteLine("Charge: #  ");
                    Console.SetCursorPosition(3, TextBoxHeight + 8);
                    Console.WriteLine("Minimum charge");
                } else if (Charge == 2)
                {
                    Console.SetCursorPosition(3, TextBoxHeight + 7);
                    Console.WriteLine("Charge: ## ");
                    Console.SetCursorPosition(3, TextBoxHeight + 8);
                    Console.WriteLine("Medium charge ");
                } else if (Charge == 3)
                {
                    Console.SetCursorPosition(3, TextBoxHeight + 7);
                    Console.WriteLine("Charge: ###");
                    Console.SetCursorPosition(3, TextBoxHeight + 8);
                    Console.WriteLine("Maximum charge");
                }

                if (Console.ReadKey(true).Key == ConsoleKey.C)
                {
                    chargeLevel = true;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                {
                    switch (Charge)
                    {
                        case 1:
                            Charge = 2;
                            break;
                        case 2:
                            Charge = 3;
                            break;
                        default:
                            break;
                    }

                }

                if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    switch (Charge)
                    {
                        case 3:
                            Charge = 2;
                            break;
                        case 2:
                            Charge = 1;
                            break;
                        default:
                            break;
                    }
                }

            }
            Console.SetCursorPosition(3, TextBoxHeight + 6);
            Console.WriteLine("                                                                                     ");
        }

        // BULLET PROJECTION ENEMY
        public void DrawBulletEnemy()
        {
            int startPosX = TargetPositionX - 6;
            int startPosY = TargetPositionY - 1;
            int currentPosX = 0;
            int currentPosY = 0;

            // weather effect
            Random random = new Random();
            int weatherEffect = 1; //random.Next(0, 5);
            

            // Bullet projection variable
            int bulletProjectMin = 20;
            int bulletProjectMed = 3;
            int bulletProjectMax = 3;

            // Total Bullet projection
            int hitMin = TargetPositionX - weatherEffect - bulletProjectMin;
            int hitMed = TargetPositionX - weatherEffect - bulletProjectMed;
            int hitMax = TargetPositionX - weatherEffect - bulletProjectMax;

            //Charge = random.Next(1, 4);
            Charge = 2;

            if (Charge == 1)
            {

                for (int i = 0; i < hitMin; i++)
                {
                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX - i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == Xposition + 3)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        PlayerHit = true;
                        break;
                    } else if (currentPosX == hitMin)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            } else if (Charge == 2)
            {
                for (int i = 0; i < hitMed; i++)
                {
                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX - i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == Xposition + 3)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        PlayerHit = true;
                        break;
                    }
                    else if (currentPosX == hitMed)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            } else if (Charge == 3)
            {
                for (int i = 0; i < hitMax; i++)
                {
                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine("o");
                    currentPosX = startPosX - i;
                    currentPosY = startPosY;

                    Thread.Sleep(50);

                    Console.SetCursorPosition(startPosX - i, startPosY);
                    Console.WriteLine(" ");

                    if (currentPosX == Xposition + 3)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        PlayerHit = true;
                        break;
                    }
                    else if (currentPosX == hitMax)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }

                }
            }


        }

        // Artillery Bullet PROJECTION
        public void DrawArtilleryBullet()
        {
            int startPosX = Xposition + 6;
            int startPosY = Yposition - 4;
            int currentPosX = startPosX;
            int currentPosY = startPosY;



            // weather effect
            Random random = new Random();
            int weatherEffect = random.Next(0, 3);
            int hit = BorderWidth - weatherEffect;


            // projectionLvlOne max = 5, mid = 5, min = 5
            // projectionLvlTwo max = 8, mid = 5, min = 2
            // projectionLvlThree max = 5, mid = 5, min = 5

            #region BulletChargeOne



            if (Charge == 1)
            {

                int projectionLvlOne = 5;
                int projectionLvlTwo = 4 - weatherEffect;
                int projectionLvlThree = 5;

                for (int i = 0; i < projectionLvlOne; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }

                for (int i = 0; i < projectionLvlThree; i++)
                {
                    Console.SetCursorPosition(currentPosX + 2, currentPosY);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 2;
                    //currentPosY = currentPosY;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlOne * 2; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");

                    int epsX = 3;
                    int epsY = 1;
                    if (Math.Abs(currentPosX - TargetPositionX) <= epsX && Math.Abs(currentPosY - TargetPositionY) <= epsY)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    }
                    else if (currentPosY == Yposition)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }
                }
            }
            #endregion

            #region BulletChargeTwo


            if (Charge == 2)
            {

                int projectionLvlOne = 5;
                int projectionLvlTwo = 6 - weatherEffect;
                int projectionLvlThree = 5;

                for (int i = 0; i < projectionLvlOne; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }

                for (int i = 0; i < projectionLvlThree; i++)
                {
                    Console.SetCursorPosition(currentPosX + 2, currentPosY);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 2;
                    //currentPosY = currentPosY;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlOne * 2; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");

                    int epsX = 3;
                    int epsY = 1;
                    if (Math.Abs(currentPosX - TargetPositionX) <= epsX && Math.Abs(currentPosY - TargetPositionY) <= epsY)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    }
                    else if (currentPosY == Yposition)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }
                }
            }

            #endregion

            #region BulletChargeThree



            if (Charge == 3)
            {

                int projectionLvlOne = 5;
                int projectionLvlTwo = 8 - weatherEffect;
                int projectionLvlThree = 5;

                for (int i = 0; i < projectionLvlOne; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY - 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY - 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }

                for (int i = 0; i < projectionLvlThree; i++)
                {
                    Console.SetCursorPosition(currentPosX + 2, currentPosY);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 2;
                    //currentPosY = currentPosY;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlTwo; i++)
                {
                    Console.SetCursorPosition(currentPosX + 3, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 3;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(100);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");
                }



                for (int i = 0; i < projectionLvlOne * 2; i++)
                {
                    Console.SetCursorPosition(currentPosX + 1, currentPosY + 1);
                    Console.WriteLine("o");
                    currentPosX = currentPosX + 1;
                    currentPosY = currentPosY + 1;

                    Thread.Sleep(80);

                    Console.SetCursorPosition(currentPosX, currentPosY);
                    Console.WriteLine(" ");

                    int epsX = 3;
                    int epsY = 1;
                    if (Math.Abs(currentPosX - TargetPositionX) <= epsX && Math.Abs(currentPosY - TargetPositionY) <= epsY)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.Explode();
                        TargetHit = true;
                        break;
                    }
                    else if (currentPosY == Yposition)
                    {
                        var explode = new Explosion(currentPosX, currentPosY);
                        explode.ExplosionSmall();
                        break;
                    }
                }
            }

            #endregion

        }

        //  c=<
        // ATAT missile

        public void DrawATATmissile()
        {
            //Console.SetCursorPosition(Xposition - 10, Yposition - 4);
            //Console.WriteLine("c=<");

            int startPosX = TargetPositionX - 10;
            int startPosY = TargetPositionY - 4;
            int currentPosX = startPosX;
            int currentPosY = startPosY;

            // weather effect
            //Random random = new Random();
            //int weatherEffect = 1; //random.Next(0, 5);


            // Bullet projection variable
            //int bulletProjectMin = 20;
            //int bulletProjectMed = 3;
            //int bulletProjectMax = 3;

            // Total Bullet projection
            //int hitMin = TargetPositionX - weatherEffect - bulletProjectMin;
            //int hitMed = TargetPositionX - weatherEffect - bulletProjectMed;
            //int hitMax = TargetPositionX - weatherEffect - bulletProjectMax;

            //Charge = random.Next(1, 4);
            Charge = 1000;
            
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(currentPosX - 1, currentPosY);
                Console.WriteLine("c=<");
                currentPosX = currentPosX - 1;
                currentPosY = currentPosY;

                Thread.Sleep(100);

                Console.SetCursorPosition(currentPosX, currentPosY);
                Console.WriteLine("   ");

                if (currentPosX == Xposition + 3)
                {
                    var explode = new Explosion(currentPosX, currentPosY);
                    explode.Explode();
                    PlayerHit = true;
                    break;
                }
                else if (currentPosY == Yposition)
                {
                    var explode = new Explosion(currentPosX, currentPosY);
                    explode.ExplosionSmall();
                    break;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(currentPosX - 2, currentPosY + 1);
                Console.WriteLine("c=<");
                currentPosX = currentPosX - 2;
                currentPosY = currentPosY + 1;

                Thread.Sleep(100);

                Console.SetCursorPosition(currentPosX, currentPosY);
                Console.WriteLine("   ");

                if (currentPosX == Xposition + 3)
                {
                    var explode = new Explosion(currentPosX, currentPosY);
                    explode.Explode();
                    PlayerHit = true;
                    break;
                }
                else if (currentPosY == Yposition)
                {
                    var explode = new Explosion(currentPosX, currentPosY);
                    explode.ExplosionSmall();
                    break;
                }

            }

        }
    }
}
