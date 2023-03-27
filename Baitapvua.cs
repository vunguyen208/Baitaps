using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
     class Baitapvua
    {
        public static void Main(string[] args)
        {
            Baitapvua bai = new Baitapvua();
            bai.ShowMenu();
        }
        public void ShowMenu()
        { Baitapvua bai = new Baitapvua();
            Console.WriteLine("Chon bai so:");
            int i = Convert.ToInt32(Console.ReadLine());
            
                switch (i)
                {
                    
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
                    case 7:
                        bai.baitap7();
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
                    case 13:
                        bai.baitap13();
                        break;
                    case 14:
                        bai.baitap14();
                        break;
                    case 15:
                        bai.baitap15();
                        break;
                    case 16:
                        bai.baitap16();
                        break;
                    case 17:
                        bai.baitap17();
                        break;
                    case 18:
                        bai.baitap18();
                        break;
                    case 19:
                        bai.giaidapan();
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Ban co muon tiep tuc khong(khong thi chon so 0, co thi chon so khac)");
                i = Convert.ToInt32(Console.ReadLine());
                if (i != 0)
                {
                    ShowMenu();
                }
                else
                {
                    Console.WriteLine("ket thuc");

                }
            
        }
        public void baitap1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sap xep mang theo thu tu tang hay giam");
            String sapxep = Console.ReadLine();
            if (sapxep == "tang")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (a[j] > a[i])
                        {
                            int t = a[j];
                            a[j] = a[i];
                            a[i] = t;

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            if (sapxep == "giam")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (a[j] < a[i])
                        {
                            int t = a[j];
                            a[j] = a[i];
                            a[i] = t;

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }

        }
        public void baitap2()
        {
            Console.WriteLine("nhap so luong so hang trong 2 mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang a");
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri trong mang b");
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ta co mang duoc noi 2 so");
            int[] array = new int[2 * n];
            System.Array.Copy(array1, 0, array, 0, n);
            System.Array.Copy(array2, 0, array, n, n);
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public void baitap3()
        {
            Console.WriteLine("nhap so luong so hang trong 2 mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang a");
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri trong mang b");
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ta co tong 2 mang ");
            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                array[i] = array1[i] + array2[i];
                Console.Write(array[i] + " "); ;
            }
        }
        public void baitap4()
        {
            Console.WriteLine("nhap so luong so hang trong 2 mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang a");
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri trong mang b");
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ta co tong 2 mang ");
            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                array[i] = array1[i] - array2[i];
                Console.Write(array[i] + " ");
            }
        }
        public void baitap5()
        {
            Console.WriteLine("nhap so luong so hang trong 2 mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang a");
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri trong mang b");
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ta co tong 2 mang ");
            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                array[i] = array1[i] * array2[i];
                Console.Write(array[i] + " ");
            }
        }
        public void baitap6()
        {
            Console.WriteLine("nhap so luong so hang trong 2 mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang a");
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap gia tri trong mang b");
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ta co tong 2 mang ");
            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                if (array2[i] == 0) { array[i] = 0; }
                else { array[i] = array1[i] * array2[i]; }
                Console.Write(array[i] + " ");
            }
        }
        public void baitap7()
        {
            Console.WriteLine("nhap so luong so hang trong mang");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap gia tri trong mang ");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("nhap vi tri dau(lon hon 0 va nho hon so luong so hang)");
            int dau = Convert.ToInt32(Console.ReadLine());
            if (dau < 0 || dau > n) { Console.WriteLine("nhap lai gia tri"); }
            else
            {
                Console.WriteLine("nhap vi tri cuoi(lon hon vi tri dau va nho hon so luong so hang) ");
                int cuoi = Convert.ToInt32(Console.ReadLine());
                if (cuoi < dau || cuoi > n) { Console.WriteLine("nhap lai gia tri"); }
                else
                {
                    int[] array2 = new int[cuoi - dau + 1];
                    System.Array.Copy(array, dau - 1, array2, 0, cuoi - dau + 1);
                    for (int i = 0; i <= cuoi - dau; i++)
                    {
                        Console.Write(array2[i] + " ");
                    }
                }
            
            }
              
        }
        public void baitap8()
        {
            Console.WriteLine("nhap chuoi  a");
            String a = Console.ReadLine();
            Console.WriteLine("nhap chuoi con b");
            String b = Console.ReadLine();
            int vitri = a.IndexOf(b);
            Console.WriteLine("vi tri chuoi con a trong b la:"+ vitri+1);
        }
        public void baitap9()
        {
            Console.WriteLine("nhap chuoi a");
            String a = Console.ReadLine();
            Console.WriteLine("nhap chuoi b");
            String b = Console.ReadLine();
            
            int tong = 0;
            // tách string thành các char
            
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < b.Length; j++)
                {
                    if(a[i]== b[j])
                    
                    {
                        tong++;
                        break;
                    }
                }
            }
            Console.Write("So cac phan tu a trong b la:" + tong);


        }
        public void baitap10()
        {
            Console.WriteLine("nhap chuoi a");
            String a = Console.ReadLine();
            Console.WriteLine("nhap chuoi b");
            String b = Console.ReadLine();

            int tong = 0;
            // tách string thành các char

            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])

                    {
                        tong++;
                        break;
                    }
                }
            }
            Console.Write("So cac phan tu a khong co trong b la:" +(b.Length- tong));


        }
        public void baitap11()
        {
            Console.WriteLine("nhap so thap phan a lon hon 0 nho hon 1");
            double a=Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double b = a*random.Next(0, 10)/10;
            Console.WriteLine("so random trong khoang tu 0 den " +a+":"+b);
        }
        public void baitap12()
        {
            Console.WriteLine("nhap so thap phan a lon hon 0 nho hon 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double b = a * random.Next(0, 10) / 10;
            int c=random.Next(-1, 1);
            Console.WriteLine("so random trong khoang tu -1 den 1"+ b * c);
        }
        public void baitap13()
        {
            int checkin, checkout,tongtien;
            Console.WriteLine("Nhap gio checkin");
            checkin = Convert.ToInt32(Console.ReadLine());
            if(checkin>24|| checkin < 0)
            {
                Console.WriteLine("nhap so gio trong khoang tu 0 den 24");
                
            }
            else 
            {
                Console.WriteLine("Nhap gio checkout");
                checkout = Convert.ToInt32(Console.ReadLine());
                if (checkout > 24 || checkout < 0)
                {
                    Console.WriteLine("nhap so gio trong khoang tu 0 den 24");
                }
                else
                {
                    if (checkin < 8)
                    {
                        if (checkout <= checkin)
                        {
                            tongtien = 320 + 40 * 16;
                        }
                        else if(checkout >checkin && checkout < 8)
                        {
                            tongtien = 160;
                        }
                        else{
                            tongtien = 160 + (checkout - 8) * 40;
                        }
                    }
                    else
                    {
                        if (checkout < 8)
                        {
                            tongtien = 160 + 140 + (24 - checkin - 2) * 50;
                        }
                        else if (checkout <= checkin)
                        {
                            tongtien = 160 + 140 + (24 - 2 - checkin) * 50 + (checkout - 8) * 40;
                        }
                        else if(checkout - checkin <= 2)
                        {
                            tongtien=70*(checkout - checkin);
                        }
                        else
                        {
                            tongtien=70*2+(checkout- checkin-2)*50;
                        }
                    }
                    Console.WriteLine("Tong tien can tra la: " + tongtien);
                }
            }
           
            

        }
        public void baitap14()
        {
            
            Console.WriteLine("Nhap so thang tinh luong:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] luong = new double[n];
            double thue=0;
            Console.WriteLine("Nhap thu nhap trong " + n + "thang(don vi trieu dong) :");
            for(int i=0; i < n; i++)
            {
                luong[i] = Convert.ToDouble(Console.ReadLine());
                if (luong[i] > 50)
                {
                    thue += luong[i] * 0.2;
                }
                else if (luong[i] <= 50 && luong[i] >= 20)
                {
                    thue += luong[i] * 0.1;
                }
                else if (luong[i] < 20 && luong[i]>0)
                {
                    thue += luong[i] * 0.05;
                }
            }
            Console.WriteLine("Tong thue can dong la: "+ thue+"(trieu dong)");

        }
        public void baitap15()
        {
            Console.WriteLine("Viet so nguyen vao");
            int n = Convert.ToInt32(Console.ReadLine());
            int tongcs = 0;
            if (n < 0) { n = -n; }
                while (n >= 10)
                {
                    tongcs+=(n % 10);
                    n = n / 10;
                }
                tongcs = tongcs + n;
            
            Console.WriteLine("tong so chu so la: " + tongcs);
        }
        public void baitap16()
        {
            Console.WriteLine("Nhap so nguyen duong là so cac so trong day:");
                int n= Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("day so fibonaic voi " + n + " so la:");
            if (n == 1)
            {
                a[0]=1;
            }
            if (n == 2) { a[0] = a[1] = 1; }
            if (n > 2)
            {
                a[0] = a[1] = 1;
                for(int i = 2; i < n; i++)
                {
                    a[i] = a[i - 1] + a[i - 2];
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
             
        }
        public void baitap17()
        {
            Console.WriteLine("Nhap vao chuoi :");
            String str = Console.ReadLine();
            Console.WriteLine("Nhap vao vi tri ban dau:");
            int a= Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Nhap vi tri lon hon 0");

            }
            else 
            {
                Console.WriteLine("Nhap vao vi tri ket thuc:");
                int b = Convert.ToInt32(Console.ReadLine());
                if ( b < a) 
                {
                    Console.WriteLine("Nhap vao vi tri ket thuc lon hon vi tri bat dau ");
                }
                else{
                    string newString = str.Substring(a - 1, b - a+1);
                    Console.WriteLine("Chuoi duoc cat ra la:" + newString);
                    }
            }
        }
        public void baitap18()
        {
            Console.WriteLine("Nhap vao chuoi :");
            String str = Console.ReadLine();
            Console.WriteLine("Nhap vao vi tri ban dau:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Nhap vi tri lon hon 0");

            }
            else if (a > str.Length)
            {
                Console.WriteLine("Nhap vi tri nho hon hoac bang so ki tu cua chuoi");
            }
            else
            {
                Console.WriteLine("Nhap vao so ki tu can cat:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("can nhap so ki tu lon hon 0");
                }
                else if (b > str.Length - a + 1)
                {
                    Console.WriteLine("so ki tu can cat nam ngoai so luong cho phep");
                }
                else
                {
                    string newString = str.Substring(a - 1, b );
                    Console.WriteLine("Chuoi duoc cat ra la:" + newString);
                }
            }
        }
        public void giaidapan()
        {
            Console.WriteLine("Bai 21 :3");
            Console.WriteLine("Bai 22: Stack có 1 dau de nhan du lieu va truy xuat du lieu, queue co 2 dau: 1 dau nhan du lieu va 1 dau truy xuat du lieu");
        }
    }
}
