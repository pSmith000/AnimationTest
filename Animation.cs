using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AnimationTest
{
    class Animation
    {
        public void UpMovement()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("    0 ");
            Console.WriteLine(@"   \|/ ");
            Console.WriteLine("    | ");
            Console.WriteLine(@"   / \ ");
            Console.WriteLine("         ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("    0 ");
            Console.WriteLine(@"   /|\ ");
            Console.WriteLine("    | ");
            Console.WriteLine(@"   | | ");
            Thread.Sleep(200);
        }

        public void DownMovement()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine(@"     0 ");
            Console.WriteLine(@"    |\ ");
            Console.WriteLine(@"    _| ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("    0 ");
            Console.WriteLine(@"   /|\ ");
            Console.WriteLine("    | ");
            Console.WriteLine(@"   | | ");
            Thread.Sleep(200);
        }

        public void LeftMovement()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("  0        ");
            Console.WriteLine(@"//|       ");
            Console.WriteLine("  |        ");
            Console.WriteLine(@" | |      ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("    0 ");
            Console.WriteLine(@"   /|\ ");
            Console.WriteLine("    | ");
            Console.WriteLine(@"   | | ");
            Thread.Sleep(200);
        }

        public void RightMovement()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("      0 ");
            Console.WriteLine(@"      |\\ ");
            Console.WriteLine("      | ");
            Console.WriteLine(@"     | | ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("             ");
            Console.WriteLine("    0        ");
            Console.WriteLine(@"   /|\      ");
            Console.WriteLine("    |        ");
            Console.WriteLine(@"   | |      ");
            Thread.Sleep(200);
        }

        public void Background()
        {

            for (int i = 89; i > 0; i--)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("          .-~~~-.  ");
                Console.SetCursorPosition(i, 1);
                Console.Write("  .- ~ ~-(       )_ _  ");
                Console.SetCursorPosition(i, 2);
                Console.Write(" /                     ~ -.  ");
                Console.SetCursorPosition(i, 3);
                Console.Write(@"|                           \  ");
                Console.SetCursorPosition(i, 4);
                Console.Write(@" \                         .'  ");
                Console.SetCursorPosition(i, 5);
                Console.Write("  ~- . _____________ . -~  ");

                Thread.Sleep(500);

                Console.SetCursorPosition(i + 30, 8);
                Console.Write("        # #### ####  ");
                Console.SetCursorPosition(i + 30, 9);
                Console.Write(@"      ### \/#|### |/####  ");
                Console.SetCursorPosition(i + 30, 10);
                Console.Write(@"     ##\/#/ \||/##/_/##/_#  ");
                Console.SetCursorPosition(i + 30, 11);
                Console.Write(@"   ###  \/###|/ \/ # ###  ");
                Console.SetCursorPosition(i + 30, 12);
                Console.Write(@" ##_\_#\_\## | #/###_/_####  ");
                Console.SetCursorPosition(i + 30, 13);
                Console.Write(@"## #### # \ #| /  #### ##/##  ");
                Console.SetCursorPosition(i + 30, 14);
                Console.Write(" __#_--###`  |{,###---###-~  ");
                Console.SetCursorPosition(i + 30, 15);
                Console.Write(@"           \ }{  ");
                Console.SetCursorPosition(i + 30, 16);
                Console.Write("            }}{  ");
                Console.SetCursorPosition(i + 30, 17);
                Console.Write("            }}{  ");
                Console.SetCursorPosition(i + 30, 18);
                Console.Write("            {{}  ");
                Console.SetCursorPosition(i + 30, 19);
                Console.Write("      , -=-~{ .-^- _  ");

                Console.SetCursorPosition(0, 20);
                Console.Write(new string( '_', 120));

                if (i == 1)
                {
                    i = 90;
                    Console.Clear();
                }
                    

            }
        }
    }
}
