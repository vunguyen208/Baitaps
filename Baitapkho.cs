using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baitaps
{
     class Baitapkho
    {
        /*public static void Main(string[] args)
        {
            Baitapkho bai = new Baitapkho();
            bai.ShowMenu();
        }*/
        
        public void ShowMenu()
        {
            Console.WriteLine("Chon bai so:");
            int i = Convert.ToInt32(Console.ReadLine());
            Baitapkho bai = new Baitapkho();

            
                switch (i)
                {   case 0:
                        break;
                    case 1:
                        bai.baitap1();
                        break;
                    case 2:
                        bai.baitap2();
                        break;
                    case 3:
                        bai.baitap3();
                        break;
                    case 4:
                        bai.baitap4();
                        break;
                    case 5:
                        bai.baitap5();
                        break;
                    case 6:
                        bai.baitap6();
                        break;
                    case 8:
                        bai.baitap8();
                        break;
                    case 9:
                        bai.baitap9();
                        break;
                    case 10:
                        bai.baitap10();
                        break;
                    case 11:
                        bai.baitap11();
                        break;
                    case 12:
                        bai.baitap12();
                        break;
                    default:
                        break;
                }
                /*Console.WriteLine("Ban co muon tiep tuc khong(khong thi chon so 0, co thi chon so khac)");
                int t= Convert.ToInt32(Console.ReadLine());
                if (t != 0)
                {
                    ShowMenu();
                }
                else 
                {
                Console.WriteLine("ket thuc");
                    
                }*/
            
            

        }
        public void baitap1()
        {
            Console.WriteLine("Nhap 1 cau:");
            string sentence = Console.ReadLine();
            string[] word = sentence.Split(" ");
            string[] reverse = new string[sentence.Length];
            for (int i = 0; i < word.Length; i++)
            {
                reverse[i] = string.Empty;
                for(int j = word[i].Length - 1; j >= 0; j--)
                {
                    reverse[i] += word[i][j];
                }
                Console.Write(reverse[i] + " ");
            }
        }
        public double random()
        { 
                Random random = new Random();
            if (random.Next(0, 1) == 0) { return random.NextDouble(); }
            else { return 1; }
        }
        public void baitap2()
        {
            Baitapkho bt = new Baitapkho();
            Random random = new Random();
            double c;
            Console.Write("Nhap so thuc a:");
                 double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thuc b:");
                 double b = Convert.ToDouble(Console.ReadLine());
            if (b > a)
            {
                 
                 if ( b<=0)
                {
                    c = b + bt.random() * (a - b);
                    Console.WriteLine("Gia tri random khoang tu a den b la: " + c);
                }
               else 
                {
                    c = a + bt.random() * (b - a);
                    Console.WriteLine("Gia tri random khoang tu a den b la: " + c);
                }
                
            }
            else
            {
                Console.WriteLine("Gia tri b phai lon hon a");
            }
        }
        public void baitap3()
        {
            Console.WriteLine("Nhap so so hang cua mang 1");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so so hang cua mang 2");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac gia tri cua mang 1 theo thu tu tang dan");
            int[] mang1 = new int[n];
            int[] mang2 = new int[m];
            int[] mang = new int[m + n];
            for (int i = 0; i < n; i++)
            {
                mang1[i]= Convert.ToInt32(Console.ReadLine());
                mang[i] = mang1[i];
            }
            Console.WriteLine("Nhap cac gia tri cua mang 2 theo thu tu tang dan");
            for (int i = 0; i < m; i++)
            {
                mang2[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Array.Copy(mang1, 0, mang, 0, n);
            System.Array.Copy(mang2, 0, mang, n, m);
            for (int i = 0; i < n + m; i++)
            {
                for (int j = i + 1; j < m + n ; j++)
                {
                    if (mang[i] > mang[j])
                    {
                        int t = mang[i];
                        mang[i] = mang[j];
                        mang[j] = t;
                    }
                }
            }
            
            Console.WriteLine("mang tong duoc sap xep theo thu tu tang dan:");
            for(int i = 0; i < n+m; i++)
            {
                Console.Write(mang[i]);
            }
            
            
        }
        public void baitap4()
        {
            Console.WriteLine("Nhap so so hang cua mang 1");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so so hang cua mang 2");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac gia tri cua mang 1 theo thu tu giam dan");
            int[] mang1 = new int[n];
            int[] mang2 = new int[m];
            int[] mang = new int[m + n];
            for (int i = 0; i < n; i++)
            {
                mang1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Nhap cac gia tri cua mang 2 theo thu tu giam dan");
            for (int i = 0; i < m; i++)
            {
                mang2[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Array.Copy(mang1, 0, mang, 0, n);
            System.Array.Copy(mang2, 0, mang, n, m);
            for (int i = 0; i < n + m; i++)
            {
                for (int j = i + 1; j < m + n ; j++)
                {
                    if (mang[i] < mang[j])
                    {
                        int t = mang[i];
                        mang[i] = mang[j];
                        mang[j] = t;
                    }
                }
            }
            Console.WriteLine("mang tong duoc sap xep theo thu tu giam dan:");
            for (int i = 0; i < n + m; i++)
            {
                Console.Write(mang[i]);
            }


        }
        public void baitap5()
        {
            Console.WriteLine("Nhap so so hang cua mang 1");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so so hang cua mang 2");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac gia tri cua mang 1 theo thu tu giam dan");
            int[] mang1 = new int[n];
            int[] mang2 = new int[m];
            int[] mang = new int[m + n];
            for (int i = 0; i < n; i++)
            {
                mang1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Nhap cac gia tri cua mang 2 theo thu tu giam dan");
            for (int i = 0; i < m; i++)
            {
                mang2[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Array.Copy(mang1, 0, mang, 0, n);
            System.Array.Copy(mang2, 0, mang, n, m);
            for (int i = 0; i < n + m; i++)
            {
                for (int j = i + 1; j < m + n ; j++)
                {
                    if (mang[i] > mang[j])
                    {
                        int t = mang[i];
                        mang[i] = mang[j];
                        mang[j] = t;
                    }
                }
            }
            Console.WriteLine("mang tong duoc sap xep theo thu tu tang dan:");
            for (int i = 0; i < n + m; i++)
            {
                Console.Write(mang[i]);
            }


        }
        public void baitap6()
        {
            Console.WriteLine("Nhap so so hang cua mang 1");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so so hang cua mang 2");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac gia tri cua mang 1 theo thu tu tang dan");
            int[] mang1 = new int[n];
            int[] mang2 = new int[m];
            int[] mang = new int[m + n];
            for (int i = 0; i < n; i++)
            {
                mang1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Nhap cac gia tri cua mang 2 theo thu tu tang dan");
            for (int i = 0; i < m; i++)
            {
                mang2[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Array.Copy(mang1, 0, mang, 0, n);
            System.Array.Copy(mang2, 0, mang, n, m);
            for (int i = 0; i < n + m; i++)
            {
                for (int j = i + 1; j < m + n ; j++)
                {
                    if (mang[i] < mang[j])
                    {
                        int t = mang[i];
                        mang[i] = mang[j];
                        mang[j] = t;
                    }
                }
            }
            Console.WriteLine("mang tong duoc sap xep theo thu tu giam dan:");
            for (int i = 0; i < n + m; i++)
            {
                Console.Write(mang[i]);
            }
        }
        public void baitap8()
        {
            Console.WriteLine("nhap vao mot so la boi so 1000");
            int tien=Convert.ToInt32(Console.ReadLine());
            int sodongtien=0;
            int[] menhgia = new int[] { 500000, 100000, 50000, 10000, 5000, 2000, 1000 };
            for(int i = 0;i< menhgia.Length; i++)
            {
                while (tien >= menhgia[i])
                {
                    tien=tien- menhgia[i];
                    sodongtien++;
                }
            }
            Console.WriteLine(sodongtien);
        }
        public void baitap9()
        {

            Console.WriteLine("nhap vao chuoi a");
            string a = Console.ReadLine();
            Console.WriteLine("nhap vao chuoi b");
            string b = Console.ReadLine();
            int t=0;
            while(b.IndexOf(a)!= -1)
            {
                t++;
                b=b.Remove(b.IndexOf(a),a.Length);
            }
            Console.WriteLine(t);
        }
        public void baitap10()
        {   
            Console.WriteLine("nhap vao so phan tu mang");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap cac phan tu mang");
            int[] a = new int[n];
            int[] b= new int[n];
            Random ra = new Random();
            for(int i = 0;i< n; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
                b[i] = a[i];
            }
            
            for (int i = 0;i< n-1; i++)
            {
                
                    Random random=new Random();
                    int j = random.Next(i + 1,n-1) ;
                    int k = a[i];
                    a[i] = a[j];
                    a[j] =k ;
                
            }
            if (a[n - 1] == b[n - 1])
            {
                int k = a[n-2];
                a[n-2] = a[n-1];
                a[n-1] = k ;
            }
            Console.WriteLine("mang sau khi thay doi vi tri");
            for (int i = 0; i < n; i++)
            {
            Console.Write(a[i]+" ");
            }
               
        }
        public void baitap11()
        {
            Console.WriteLine("nhap vao so n");
            long n = Convert.ToInt32(Console.ReadLine());
            long giaithua = 1;
            for(long i = 1; i <= n;i++)
            {
                giaithua=giaithua* i;
            }
            Console.WriteLine("so giai thua la: "+giaithua);
            while (giaithua > 0)
            {
                long t = giaithua%10;
                if (t != 0)
                {
                    Console.WriteLine("chu so cuoi cung khac 0 la:" + t);
                    break;
                }
                else
                {
                    giaithua = giaithua / 10;
                }
                
            }
        }
        public void baitap12()
        {
            Console.WriteLine("nhap vao so n");
            long n = Convert.ToInt32(Console.ReadLine());
            long giaithua = 1;
            for (long i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            int so0 = 0;
            Console.WriteLine("so giai thua la: " + giaithua);
            while(giaithua > 0)
            {
                long t= giaithua%10;
                if (t == 0)
                {
                    so0++;
                }
                giaithua=giaithua / 10;
            }
            Console.WriteLine("So chu so 0 la:"+ so0);
        }
    }
}
