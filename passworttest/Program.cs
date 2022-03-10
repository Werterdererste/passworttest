using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace passworttest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string speicherort = @"C:\Users\arsla\Desktop\C# Projecte\passwort.txt";

            ulong i = 0;
            string passwort = "99999";

            string rate = "";
            StringBuilder sb = new StringBuilder(rate);

            int eins = 0;
            int zwei = 1;
            int drei = 1;
            int vier = 1;
            int fünf = 0;
            int sechs = 0;
            int sieben = 0;
            int acht = 0;

            Stopwatch watch = new Stopwatch();
            watch.Start();


            while (passwort != rate)
            {
                rate = "";
                //stellen erhöhen
                i++;
                eins++;
                //Zahl erhöhen
                if (eins == 37)
                {
                    eins = 1;
                    zwei++;
                    if (zwei == 37)
                    {
                        zwei = 1;
                        drei++;
                        if (drei == 37)
                        {
                            drei = 1;
                            vier++;
                            if (vier == 37)
                            {
                                vier = 1;
                                fünf++;
                                if (fünf == 37)
                                {
                                    fünf = 1;
                                    sechs++;
                                    if (sechs == 37)
                                    {
                                        sechs = 1;
                                        sieben++;
                                        if (sieben == 37)
                                        {

                                            sieben = 1;
                                            acht++;
                                            if (acht == 37)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }  

                //umwandeln
                for (int j = 8; j > 0; j--)
                {
                    int var = 0;
                    //stellen duch gehen
                    switch (j)
                    {
                        case 8:
                            var = acht;
                            break;
                        case 7:
                            var = sieben;
                            break;
                        case 6:
                            var = sechs;
                            break;
                        case 5:
                            var = fünf;
                            break;
                        case 4:
                            var = vier;
                            break;
                        case 3:
                            var = drei;
                            break;
                        case 2:
                            var = zwei;
                            break;
                        case 1:
                            var = eins;
                            break;
                    }

                    //zahl zu buchstabe
                    switch (var)
                    {
                        case 0:
                            break;
                        case 1:
                            sb = sb.Append("a");
                            break;
                        case 2:
                            sb = sb.Append("b");
                            break;
                        case 3:
                            sb = sb.Append("c");
                            break;
                        case 4:
                            sb = sb.Append("d");
                            break;
                        case 5:
                            sb = sb.Append("e");
                            break;
                        case 6:
                            sb = sb.Append("f");
                            break;
                        case 7:
                            sb = sb.Append("g");
                            break;
                        case 8:
                            sb = sb.Append("h");
                            break;
                        case 9:
                            sb = sb.Append("i");
                            break;
                        case 10:
                            sb = sb.Append("j");
                            break;
                        case 11:
                            sb = sb.Append("k");
                            break;
                        case 12:
                            sb = sb.Append("l");
                            break;
                        case 13:
                            sb = sb.Append("m");
                            break;
                        case 14:
                            sb = sb.Append("n");
                            break;
                        case 15:
                            sb = sb.Append("o");
                            break;
                        case 16:
                            sb = sb.Append("p");
                            break;
                        case 17:
                            sb = sb.Append("q");
                            break;
                        case 18:
                            sb = sb.Append("r");
                            break;
                        case 19:
                            sb = sb.Append("s");
                            break;
                        case 20:
                            sb = sb.Append("t");
                            break;
                        case 21:
                            sb = sb.Append("u");
                            break;
                        case 22:
                            sb = sb.Append("v");
                            break;
                        case 23:
                            sb = sb.Append("w");
                            break;
                        case 24:
                            sb = sb.Append("x");
                            break;
                        case 25:
                            sb = sb.Append("y");
                            break;
                        case 26:
                            sb = sb.Append("z");
                            break;
                        case 27:
                            sb = sb.Append("0");
                            break;
                        case 28:
                            sb = sb.Append("1");
                            break;
                        case 29:
                            sb = sb.Append("2");
                            break;
                        case 30:
                            sb = sb.Append("3");
                            break;
                        case 31:
                            sb = sb.Append("4");
                            break;
                        case 32:
                            sb = sb.Append("5");
                            break;
                        case 33:
                            sb = sb.Append("6");
                            break;
                        case 34:
                            sb = sb.Append("7");
                            break;
                        case 35:
                            sb = sb.Append("8");
                            break;
                        case 36:
                            sb = sb.Append("9");
                            break;
                    }
                }
                rate = sb.ToString();
                sb.Clear();
                //Console.WriteLine(rate);
            }
            //rate = eins.ToString() + zwei.ToString() + drei.ToString() + vier.ToString();
            //Console.WriteLine(rate);

            Console.WriteLine("passwort ist:" + rate);
            Console.WriteLine("versuche:" + i.ToString());

            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.ReadKey();
        }
    }
}