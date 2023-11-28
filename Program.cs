namespace Schleifen.Nr._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linie_Rechts();
        }
        static void Schleife()
        {
            int zahl = 6;
            do
            {
                zahl -= 1;
                Console.WriteLine("xxxxxxxxxx");

            } while (zahl >= 0);
        }
        static void Schleifen()
        {
            int zahl = 6;
            while (zahl >= 0)
            {
                while (zahl >= 0)
                {
                    Console.WriteLine("xxxxxxxxxx");
                    zahl -= 1;
                }

            }


        }
        static void Treppe()
        {
            Char Pyramid = 'X';
            int zahl = 1;
            int z = 0;

            while (true)
            {

                while (z < zahl)
                {
                    Console.Write(Pyramid);
                    z++;
                }
                Console.WriteLine();
                zahl++;
                z = 0;
                if (zahl == 13)
                {
                    break;
                }
            }
        }
        static void Pyramide()
        {
            char leerzeichen = ' ';
            Char Pyramid = 'X';
            int z = 0;
            int y = 1;
            int a = 7;
            int b = 7;
            //vielleicht ein paar mehr for schleifen verwenden; für mich selber

            while (y < 14)
            {
                while (a >= 1)
                {
                    Console.Write(leerzeichen);
                    a--;
                }
                while (z < y)
                {
                    Console.Write(Pyramid);
                    z++;
                }
                Console.WriteLine();
                y += 2;
                z = 0;
                b -= 1;
                a = b;

            }
        }
        static void Umgekehrte_Pyramide()
        {
            char leerzeichen = ' ';
            Char Pyramid = 'X';
            int z = 0;
            int y = 13;
            int a = 7;
            int b = 7;

            while (y >= 1)
            {
                while (a >= 14)
                {
                    Console.Write(leerzeichen);
                    a--;
                }
                while (z < y)
                {
                    Console.Write(Pyramid);
                    z++;
                }
                Console.WriteLine();
                y -= 2;
                z = 0;
                b -= 1;
                a = b;
            }

        }
        static void Linie_Links()
        {
            int zahl = 0;
            int z = 7;
            int y = 1;
            int x = 7;
            char mander = 'X';
            char coal = ' ';
            while (zahl <= 6)
            {
                while (z >= 1)
                {
                    Console.Write(coal);
                    z--;

                }
                while (y >= 1)
                {
                    Console.Write(mander);
                    y--;
                }
                //noch nicht fertig; und den rest auch mache
                Console.WriteLine();
                zahl++;
                x -= 1;
                z = x;
                y += 1;
            }



        }
        static void Linie_Rechts()
        {
            int zahl = 0;
            int z = 1;
            int y = 1;
            int x = 1;
            char mander = 'X';
            char coal = ' ';
            while (zahl <= 6)
            {
                while (z >= 1)
                {
                    Console.Write(coal);
                    z--;

                }
                while (y >= 1)
                {
                    Console.Write(mander);
                    y--;
                }
                Console.WriteLine();
                zahl++;
                x += 1;
                z = x;
                y += 1;

            }
        }
    }
}