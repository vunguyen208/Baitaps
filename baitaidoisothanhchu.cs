using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaps
{
     class Baitap7
    {
        public long coin9;
        /*public static void Main(string[] args)
        {
            Baitap7 bt = new Baitap7();
            bt.coin();
        }*/
        public void coin()
        {
            Console.WriteLine("nhap vao 1 so:");
            long coin = Convert.ToInt64(Console.ReadLine());
            Baitap7 bt = new Baitap7();
            string tien= bt.money9( coin % (long)Math.Pow(10, 9));
            coin = coin / (long)Math.Pow(10, 9);
            while (coin >0)
            {
                coin9 = coin % (long)Math.Pow(10, 9);
                tien= bt.money9(coin9)+" ti " + tien;
                coin = coin / (long)Math.Pow(10, 9);
            }
            Console.WriteLine(tien);
        }
        public string money9(long coin9)
        {
            
            long coin = coin9;
            long sokhoang3;
            string tienchu;
            string[] tienchu3 = new string[3];
            string[] chuso = new string[] { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            long[] coin3 = new long[3];
             if (coin >= Math.Pow(10, 6))
            {
                sokhoang3 = 2;
                
                coin3[2] = coin / (long)Math.Pow(10, 6);
                coin3[1] = (coin % (long)Math.Pow(10, 6)) / 1000;
                coin3[0] = coin % 1000;

            }
            else if (coin >= Math.Pow(10, 3))
            {
                sokhoang3 = 1;
                coin3[2] = 0;
                coin3[1] = coin / 1000;
                coin3[0] = coin % 1000;

            }
            else
            {
                sokhoang3 = 0;
                coin3[2] = coin3[1] = 0;
                coin3[0] = coin;

            }
            for (int i = 0; i < 3; i++)
            {

                if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 == 0 && coin3[i] % 10 == 0)
                {
                    tienchu3[i] = "";
                }
                else if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 == 0 && coin3[i] % 10 != 0)
                {
                    if (i == sokhoang3)
                    {
                        tienchu3[i] = chuso[coin3[i] % 10];
                    }
                    else
                    {
                        tienchu3[i] = "khong tram le " + chuso[coin3[i] % 10];
                    }

                }
                else if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 != 0 && (coin3[i] / 10) % 10 != 1 && coin3[i] % 10 != 0)
                {
                    if (i == sokhoang3)
                    {
                        tienchu3[i] = chuso[(coin3[i] / 10) % 10] + " muoi " + chuso[coin3[i] % 10];
                    }
                    else
                    {
                        tienchu3[i] = " khong tram " + chuso[(coin3[i] / 10) % 10] + " muoi " + chuso[coin3[i] % 10];
                    }
                }
                else if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 != 0 && (coin3[i] / 10) % 10 != 1 && coin3[i] % 10 == 0)
                {
                    if (i == sokhoang3)
                    {
                        tienchu3[i] = chuso[(coin3[i] / 10) % 10] + " muoi";
                    }
                    else
                    {
                        tienchu3[i] = " khong tram " + chuso[(coin3[i] / 10) % 10] + " muoi";
                    }
                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 == 0 && coin3[i] % 10 == 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram";
                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 == 0 && coin3[i] % 10 != 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram le " + chuso[coin3[i] % 10];
                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 != 0 && (coin3[i] / 10) % 10 != 1 && coin3[i] % 10 == 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram " + chuso[(coin3[i] / 10) % 10] + " muoi";
                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 != 0 && (coin3[i] / 10) % 10 != 1 && coin3[i] % 10 != 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram " + chuso[(coin3[i] / 10) % 10] + " muoi " + chuso[coin3[i] % 10];
                }
                else if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 == 1 && coin3[i] % 10 == 0)
                {
                    if (i == sokhoang3)
                    {
                        tienchu3[i] = " muoi ";
                    }
                    else
                    {
                        tienchu3[i] = "khong tram muoi ";
                    }

                }
                else if (coin3[i] / 100 == 0 && (coin3[i] / 10) % 10 == 1 && coin3[i] % 10 != 0)
                {
                    if (i == sokhoang3)
                    {
                        tienchu3[i] = " muoi " + chuso[coin3[i] % 10];
                    }
                    else
                    {
                        tienchu3[i] = "khong tram muoi " + chuso[coin3[i] % 10];
                    }

                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 == 1 && coin3[i] % 10 == 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram muoi";
                }
                else if (coin3[i] / 100 != 0 && (coin3[i] / 10) % 10 == 1 && coin3[i] % 10 != 0)
                {
                    tienchu3[i] = chuso[coin3[i] / 100] + " tram muoi " + chuso[coin3[i] % 10];
                }

            }
            if (coin >= Math.Pow(10, 6))
            {
                if (coin3[1] == 0) { tienchu = tienchu3[2] + " trieu " + tienchu3[0]; }
                else { tienchu = tienchu3[2] + " trieu " + tienchu3[1] + " nghin " + tienchu3[0]; }
            }
            else if (coin >= Math.Pow(10, 3))
            {
                tienchu = tienchu3[1] + " nghin " + tienchu3[0];
            }
            else
            {
                tienchu = tienchu3[0];
            }

            return tienchu;


        }
    }
}
