using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace AnimationTest
{
    class Game
    {
        bool gameOver = false;
        private Animation _playerAnimation;

        public void Run()
        {
            if (!gameOver)
                Update();
        }
        void Update()
        {

            Console.SetCursorPosition(0, 10);
            Console.WriteLine("             ");
            Console.WriteLine("    0 ");
            Console.WriteLine(@"   /|\ ");
            Console.WriteLine("    | ");
            Console.WriteLine(@"   | | ");

            _playerAnimation = new Animation();

            _playerAnimation.Background();

            ConsoleKeyInfo cki;

            Console.TreatControlCAsInput = true;

            cki = Console.ReadKey();

            while (cki.Key != ConsoleKey.Escape)
            {

                if ((cki.Key.ToString() == "UpArrow"))
                {
                    _playerAnimation.UpMovement();
                }
                else if ((cki.Key.ToString() == "DownArrow"))
                {
                    _playerAnimation.DownMovement();
                }
                else if ((cki.Key.ToString() == "LeftArrow"))
                {
                    _playerAnimation.LeftMovement();
                }
                else if ((cki.Key.ToString() == "RightArrow"))
                {
                    _playerAnimation.RightMovement();
                }
                else if ((cki.Key.ToString() == "Spacebar"))
                {
                    _playerAnimation.Background();
                }

                cki = Console.ReadKey();
            }
        }
    }
}
