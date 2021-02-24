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
        public int[] CannonOne { get; set; }
        public int[] CannonTwo { get; set; }
        public bool GameOn { get; set; }
        public bool PlayerTurn { get; set; }
        public int TextBoxHeight { get; set; }
        public int Life { get; set; }
        public bool IsWinner { get; set; }

        // This is the true master of the game.
        public Arena()
        {
            BorderWidth = Console.WindowWidth - 2;
            BorderHeight = Console.WindowHeight - 2;
            GroundHeightPosition = new int[BorderWidth];
            GroundWidthPosition = new int[BorderWidth];
            CannonOne = new int[14];
            CannonTwo = new int[14];
            GameOn = true;
            TextBoxHeight = 20;
            Life = 3;
            IsWinner = false;
        }
        public void DrawMap()
        {

            DrawGround();


            int buffer = 5;
            
            // Position of cannon ###

            int cannonOnePositionX = GroundWidthPosition[1] + buffer;
            int cannonOnePositionY = TextBoxHeight - 2; //GroundHeightPosition[1];

            // Position of target

            int targetPositionX = 80; //GroundWidthPosition[GroundWidthPosition.Length -1] - buffer;
            int targetPositionY = TextBoxHeight - 2;

            Cannon cannon = new Cannon(cannonOnePositionX, cannonOnePositionY);
            //cannon.DrawCannonOne();
            cannon.DrawArtillery();

            Target target = new Target(targetPositionX, targetPositionY, BorderWidth);
            //target.DrawTarget();
            target.DrawATATtarget();
            

            Console.SetCursorPosition(3, TextBoxHeight + 1);           // Set position of text
            Console.WriteLine("Press SPACE to shoot");
            Console.SetCursorPosition(3, TextBoxHeight + 8);
            Console.WriteLine(".. or X to end game (maybe press it a couple of times)");
            Console.SetCursorPosition(3, TextBoxHeight + 9);
            Console.WriteLine("... or ENTER to exit");

            // Check if bullet hits target
            bool isPlayerDead;
            bool isEnemyDead;

            while (GameOn)
            {
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("                 ");
                Console.SetCursorPosition(3, 3);
                for (int i = 0; i < Life; i++)
                {
                    Console.Write("<3 ");
                }

                ClearText();
                Console.SetCursorPosition(3, TextBoxHeight + 2);
                Console.WriteLine("Press ENTER to fight! Or press X to exit..");

                if (Console.ReadKey(true).Key == ConsoleKey.X)
                {
                    GameOn = false;
                    break;
                }

                Console.ReadLine();

                Console.SetCursorPosition(3, TextBoxHeight + 2);
                Console.WriteLine("                                              ");

                isPlayerDead = false;
                isEnemyDead = false;
                PlayerTurn = true;
                //DrawGround();
                target.ATATMovement();

                while (PlayerTurn)
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
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        
                        //bullet.DrawBullet();
                        bullet.DrawArtilleryBullet();

                        if (bullet.TargetHit == true)
                        {
                            isEnemyDead = true;
                        }

                        PlayerTurn = false;
                    } else if ((Console.ReadKey(true).Key == ConsoleKey.P))
                    {
                        PlayerTurn = false;
                    }

                }

                if (isEnemyDead)
                {
                    IsWinner = true;
                    break;
                }

                while (!PlayerTurn)
                {
                    ClearText();
                    Console.SetCursorPosition(3, TextBoxHeight + 1);
                    Console.WriteLine("Enemy turn ");
                    target.ATATMovement();
                    Bullet bullet = new Bullet(cannonOnePositionX, cannonOnePositionY, BorderWidth, BorderHeight, target.Xposition, target.Yposition, TextBoxHeight, target);
                    bullet.DrawATATmissile();
                    Console.SetCursorPosition(3, TextBoxHeight + 3);
                    Console.WriteLine($"Charge: {bullet.Charge}");

                    Thread.Sleep(2000);

                    if (bullet.PlayerHit == true)
                    {
                        Life -= 1;
                    }

                    PlayerTurn = true;

                }




                // Check if Player is dead
                if (Life <= 0)
                {
                    isPlayerDead = true;
                    
                } else
                {
                    cannon.DrawArtillery();
                }


                // Check if someone died
                if (isPlayerDead)
                {
                    GameOn = false;
                    break;

                } else if (isEnemyDead)
                {
                    GameOn = false;
                    IsWinner = true;
                    break;
                }

                ClearText();
                Console.SetCursorPosition(3, TextBoxHeight + 2);
                Console.WriteLine("Press ENTER to fight! Or press X to exit..");
            }

            Thread.Sleep(500);

            if (IsWinner)
            {
                Console.Clear();
                Console.SetCursorPosition(57, TextBoxHeight - 10);
                Console.WriteLine("YOU WON");
                Console.SetCursorPosition(50, TextBoxHeight);
                Console.WriteLine("Press any key to exit");
            } else
            {

                Console.Clear();
                Console.SetCursorPosition(56, TextBoxHeight - 10);
                Console.WriteLine("GAME OVER");
                Console.SetCursorPosition(50, TextBoxHeight);
                Console.WriteLine("Press any key to exit");
            }



            Console.ReadLine();

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
