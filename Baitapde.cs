using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaps
{
     class Baitapde
    { 
        /*public static void Main(string[] args)
        {
            Baitapde bai = new Baitapde();
            bai.ShowMenu();
           
        }*/
        public void ShowMenu()
        {
            Baitapde bai = new Baitapde();
            Console.WriteLine("Chon bai so:");
            int i = Convert.ToInt32(Console.ReadLine());
            
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        bai.Baitap1();
                        break;
                    case 2:
                        bai.Baitap2();
                        break;
                    case 3:
                        bai.Baitap3();
                        break;
                    case 4:
                        bai.Baitap4();
                        break;
                    case 5:
                        bai.Baitap5();
                        break;
                    case 6:
                        bai.Baitap6();
                        break;
                    case 7:
                        bai.Baitap7();
                        break;
                    case 8:
                        bai.Baitap8();
                        break;
                    case 9:
                        bai.Baitap9();
                        break;
                    case 10:
                        bai.Baitap10();
                        break;
                    case 11:
                        bai.Baitap11();
                        break;
                    case 12:
                        bai.Baitap12();
                        break;
                    case 13:
                        bai.Baitap13();
                        break;
                    case 14:
                        bai.Baitap14();
                        break;
                    case 15:
                        bai.Baitap15();
                        break;
                    case 21:
                        bai.Baitap21();
                        break;
                    default:
                        break;
                }
                /*Console.WriteLine("Ban co muon tiep tuc khong(khong thi chon so 0, co thi chon so khac)");
                i= Convert.ToInt32(Console.ReadLine());
                if (i != 0)
                {
                    ShowMenu();
                }
                else
                {
                Console.WriteLine("ket thuc");

                }*/
        }
        
        public void Baitap1()
        {
            Console.WriteLine("nhap 3 so hang:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int t;
            t = a; a = b; b = c; c = t;
            Console.WriteLine(a + "," + b + "," + c);
        }
        public void Baitap2()
        {
            Console.WriteLine("Nhap 2 so");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(a, b));
        }
        public void Baitap3()
        {
            Console.WriteLine("Nhap 2 so nguyen");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a%2 == 0 && b%2==0)
            {
                Console.WriteLine("dong chan");
            }
            else if
            (a%2==1 && b%2==1)
            {
                Console.WriteLine("dongle");
            }   
            else
            {
                Console.WriteLine("Mot chan mot le");
            }
            
        }
        public void Baitap4()
        {
            Console.WriteLine("Nhap so so hang");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhap cac gia tri trong mang");
            for (int i=0;i<n;i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());

            }
            int sochan = 0;
            for (int i = 0; i < n; i++)
            {
                
                if (a[i] % 2 == 0)
                {
                    sochan++;
                }
            }
            
            Console.WriteLine("So luong so chan:"+sochan);
        }
        public void Baitap5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sole = 0;
            for (int i = 0; i < n; i++)
            {

                if (a[i] % 2 == 1)
                {
                    sole++;
                }
            }
            Console.WriteLine("So luong so le:" + sole);
        }
        public void Baitap6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sochan = 0;
            for (int i = 0; i < n; i++)
            {

                if (a[i] % 2 == 0)
                {
                    sochan += a[i];
                }
            }
            Console.WriteLine("Tong cac so chan:" + sochan);
        }
        public void Baitap7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sole = 0;
            for (int i = 0; i < n; i++)
            {

                if (a[i] % 2 == 1)
                {
                    sole += a[i];
                }
            }
            Console.WriteLine("Tong cac so le:" + sole);
        }
        public void Baitap8()
        {
            Console.WriteLine("nhap mot so nguyen:");
            bool isprame=true;
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==0 || n == 1)
            {
                Console.WriteLine("khong");
            }
            else if(n==2 || n == 3)
            {
                Console.WriteLine("co");
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isprame = false;
                        Console.WriteLine("khong la so nguyen to");
                        break;
                    }
                     
                    if(isprame=true)
                     {
                    Console.WriteLine("co la so nguyen to");
                        break;
                     }
                }

            }
        }
        public void Baitap9()
        {
            Console.WriteLine("nhap so a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so b");
            int b= Convert.ToInt32(Console.ReadLine());
            int thuong = (int)a / b;
            int sodu = a - thuong * b;
            
            Console.WriteLine("So du la:"+sodu);
        }
        public void Baitap10()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < n-1; i++)
            {
               
                if (a[i] > a[i + 1])
                {
                    a[i + 1] = a[i];
                }
                
            }
            Console.WriteLine("Gia tri lon nhat:"+a[n-1]);
        }
        public void Baitap11()
        {
            Console.WriteLine("nhap so luong so hang trong mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap cac so trong bang");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n - 1; i++)
            {

                if (a[i] < a[i + 1])
                {
                    a[i + 1] = a[i];
                }

            }
            Console.WriteLine("Gia tri nho nhat"+a[n - 1]);
        }
        public void Baitap12()
        {
            Console.WriteLine("nhap so luong so hang trong mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap cac so trong bang");
            double[] a = new double[n];
            double tong =0;
            
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                tong += a[i];
            }
            
            Console.WriteLine(tong / n);
        }
        public void Baitap13()
        {
            Console.WriteLine("nhap so luong so hang trong mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap cac so trong bang");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < (int)n/2; i++)
            {
                int t;
                t = a[i];
                a[i] = a[n-i-1];
                a[n - i-1] = t;

            }
            Console.WriteLine("cac so hang sau khi dao nguoc");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
        public void Baitap14()
        {
            Console.WriteLine("nhap so luong so hang trong mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so luong so hang trong mang");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap so can tra ve vi tri:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vi tri cua so can tra ve:");
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
                else
                {
                    if (i == n - 1) { Console.WriteLine(-1); }
                }
            }
        }
        public void Baitap15()
        {
            Console.WriteLine("Nhap so n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int giaithua=1;
            for(int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine("N! co gia tri la:"+giaithua);
        }
        
        public void Baitap21()
        {
            Console.WriteLine("bai 21 : true");
            Console.WriteLine("bai 22: false");
            Console.WriteLine("bai 23: false");
            Console.WriteLine("bai 24: true");
            Console.WriteLine("bai 25: true");
            Console.WriteLine("bai 26: i++ thì cong lan luot 1 don vi, ++i thì cộng lần lượt i đơn vị");
            Console.WriteLine("bai 27: i giảm dần nên không có chặn dưới, nên phương thức sẽ chạy vô tận");
            Console.WriteLine("16");
        }
        }
}
