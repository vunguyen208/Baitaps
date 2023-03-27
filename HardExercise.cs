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
    class HardExercise
    {


        public void ShowMenu()
        {
            Console.WriteLine("Chọn bài số bao nhiêu? ( 1 -> 12)");
            int exerciseIndex = Convert.ToInt32(Console.ReadLine());
            HardExercise hardExercise = new HardExercise();
            hardExercise.exerciseIndex(exerciseIndex);

        }
        public void chooseAgain(int newchoice)
        {
            Console.WriteLine("Bạn muốn làm lại bài này không? (0: Không; Khác: Có)");
            string chooseagain = Console.ReadLine();
            if (chooseagain == "0") { }
            else exerciseIndex(newchoice);
        }
        public void exerciseIndex(int exerciseIndex)
        {
            HardExercise hardExercise = new HardExercise();
            switch (exerciseIndex)
            {
                case 0:
                    break;
                case 1:
                    hardExercise.exercise1();
                    chooseAgain(1);
                    break;
                case 2:
                    hardExercise.exercise2();
                    chooseAgain(2);
                    break;
                case 3:
                    hardExercise.exercise3();
                    chooseAgain(3);
                    break;
                case 4:
                    hardExercise.exercise4();
                    chooseAgain(4);
                    break;
                case 5:
                    hardExercise.exercise5();
                    chooseAgain(5);
                    break;
                case 6:
                    hardExercise.exercise6();
                    chooseAgain(6);
                    break;
                case 7:
                    Baitap7 bt7= new Baitap7();
                    bt7.coin();
                    chooseAgain(7);
                    break;
                case 8:
                    hardExercise.exercise8();
                    chooseAgain(8);
                    break;
                case 9:
                    hardExercise.exercise9();
                    chooseAgain(9);
                    break;
                case 10:
                    hardExercise.exercise10();
                    chooseAgain(10);
                    break;
                case 11:
                    hardExercise.exercise11();
                    chooseAgain(11);
                    break;
                case 12:
                    hardExercise.exercise12();
                    chooseAgain(12);
                    break;
                default:
                    break;
            }
        }
        public void exercise1()
        {
            Console.WriteLine("Bài 1: Đảo ngược các kí tự trong từ của câu");
            Console.WriteLine("Nhập một câu:");
            string sentence = Console.ReadLine();
            string[] reverse = ex1_Excute(sentence);
            Console.WriteLine("--> Câu mới sau khi thay đổi là :");
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }
            Console.WriteLine();
        }
        public string[] ex1_Excute(string sentence)
        {
            string[] word = sentence.Split(" ");
            string[] reverse = new string[sentence.Length];
            for (int i = 0; i < word.Length; i++)
            {
                reverse[i] = string.Empty;
                for (int j = word[i].Length - 1; j >= 0; j--)
                {
                    reverse[i] += word[i][j];
                }
            }
            return reverse;
        }
        public double numberRandom()
        {
            Random random = new Random();
            if (random.Next(0, 1) == 0) { return random.NextDouble(); }
            else { return 1; }
        }
        public void exercise2()
        {
            Console.WriteLine("Bài 2: Tìm số random");
            Console.Write("Nhập vào số thực a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập vào số thực b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            try
            {
                double c = ex2_Excute(a, b);
                Console.WriteLine("--> Giá trị random trong khoảng từ " + a + " đến " + b + " là: " + c);
            }
            catch (Exception ex) { Console.WriteLine("--> Giá trị của số b phải lớn hơn số a"); }

        }
        public double ex2_Excute(double a, double b)
        {
            double c;
            if (b > a)
            {

                if (b <= 0)
                {
                    c = b + numberRandom() * (a - b);
                }
                else
                {
                    c = a + numberRandom() * (b - a);
                }
            }
            else
            {
                throw (new Exception());
            }
            return c;

        }
        public int[] insertNumber()
        {
            Console.Write("Nhập số số hang của mảng 1: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số số hang của mảng 2: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return new int[] { m, n };
        }
        public int[] insertArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number["+ (i+1)+"]="); array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        public void exercise3()
        {
            Console.WriteLine("Bài 3: Sắp xếp mảng tổng theo thứ tự tăng dần");
            int[] totalNumber= insertNumber();
            int m = totalNumber[0];
            int n= totalNumber[1];
            Console.WriteLine("Nhập các giá trị của mảng 1 theo thứ tự tăng dần: ");
            int[] array1 = insertArray(m);
            Console.WriteLine("Nhập các giá trị của mảng 2 theo thứ tự tăng dần: ");
            int[] array2 = insertArray(n);
            int[] array = addArray(array1, array2);
            Console.WriteLine("--> Mảng tổng được sắp xếp theo thứ tự như sau: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }
            Console.WriteLine();
        }
        public int[] addArray(int[] array1, int[] array2)
        {
            int[] array=new int[array1.Length+array2.Length];
            System.Array.Copy(array1, 0, array, 0, array1.Length);
            System.Array.Copy(array2, 0, array, array1.Length, array2.Length);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j <array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            return array;
        }
        public void exercise4()
        {

            Console.WriteLine("Bài 4: Sắp xếp mảng tổng theo thứ tự giảm dần");
            int[] totalNumber = insertNumber();
            int m = totalNumber[0];
            int n = totalNumber[1];
            Console.WriteLine("Nhập các giá trị của mảng 1 theo thứ tự giảm dần: ");
            int[] array1 = insertArray(m);
            Console.WriteLine("Nhập các giá trị của mảng 2 theo thứ tự giảm dần: ");
            int[] array2 = insertArray(n);
            int[] array = addArray(array1, array2);
            Console.WriteLine("--> Mảng tổng được sắp xếp theo thứ tự như sau: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void exercise5()
        {

            Console.WriteLine("Bài 5: Sắp xếp mảng tổng theo thứ tự tăng dần");
            int[] totalNumber = insertNumber();
            int m = totalNumber[0];
            int n = totalNumber[1];
            Console.WriteLine("Nhập các giá trị của mảng 1 theo thứ tự giảm dần: ");
            int[] array1 = insertArray(m);
            Console.WriteLine("Nhập các giá trị của mảng 2 theo thứ tự giảm dần: ");
            int[] array2 = insertArray(n);
            int[] array = addArray(array1, array2);
            Console.WriteLine("--> Mảng tổng được sắp xếp theo thứ tự như sau:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void exercise6()
        {
            Console.WriteLine("Bài 6: Sắp xếp mảng tổng theo thứ tự giảm dần");
            int[] totalNumber = insertNumber();
            int m = totalNumber[0];
            int n = totalNumber[1];
            Console.WriteLine("Nhập các giá trị của mảng 1 theo thứ tự tăng dần: ");
            int[] array1 = insertArray(m);
            Console.WriteLine("Nhập các giá trị của mảng 2 theo thứ tự tăng dần: ");
            int[] array2 = insertArray(n);
            int[] array = addArray(array1, array2);
            Console.WriteLine("--> Mảng tổng được sắp xếp theo thứ tự như sau: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void exercise8()
        {
            Console.WriteLine("Bài 8: Tính số đồng tiền");
            Console.Write("Nhập vào 1 số là bội số của 1000: ");
            int tien=Convert.ToInt32(Console.ReadLine());
            int sodongtien = ex8_Excute(tien);
            Console.WriteLine("--> Số đồng tiền nhỏ nhất được quy đổi: " + sodongtien);
        }
        public int ex8_Excute(int tien)
        {
            int sodongtien = 0;
            int[] menhgia = new int[] { 500000, 100000, 50000, 10000, 5000, 2000, 1000 };
            for (int i = 0; i < menhgia.Length; i++)
            {
                while (tien >= menhgia[i])
                {
                    tien = tien - menhgia[i];
                    sodongtien++;
                }
            }
            return sodongtien;
        }
        public void exercise9()
        {
            Console.WriteLine("BÀi 9: Số lần chuỗi a xuất hiện trong chuỗi b");
            Console.Write("Nhập vào chuỗi a: ");
            string a = Console.ReadLine();
            Console.Write("Nhập vào chuỗi b: ");
            string b = Console.ReadLine();
            int t = ex9_Excute(a,b);
            Console.WriteLine("--> Số lần chuỗi xuát hiện trong chuỗi b: " + t);
        }
        public int ex9_Excute(string a,string b)
        {
            int t = 0;
            while (b.IndexOf(a) != -1)
            {
                t++;
                b = b.Remove(b.IndexOf(a), a.Length);
            }
            return t;
        }
        public void exercise10()
        {
            Console.WriteLine("Bài 10: Thay đổi vị trí trong mảng");
            MediumExercise mediumExercise= new MediumExercise();
            int n = mediumExercise.nhapsoluongmang();
            int[] a = mediumExercise.nhapmang(n);
            a = ex10_Excute(a);
            Console.WriteLine("--> Mảng sau khi thay đổi vị trí: ");
            for (int i = 0; i < n; i++)
            {
            Console.Write(a[i]+" ");
            }
            Console.WriteLine();
               
        }
        public int[] ex10_Excute(int[] a)
        {
            int n = a.Length;
            int[]b = new int[n];
            for(int i=0; i < n; i++)
            {
                b[i] = a[i];
            }
            for (int i = 0; i < n - 1; i++)
            {

                Random random = new Random();
                int j = random.Next(i + 1, n - 1);
                int k = a[i];
                a[i] = a[j];
                a[j] = k;

            }
            if (a[n - 1] == b[n - 1])
            {
                int k = a[n - 2];
                a[n - 2] = a[n - 1];
                a[n - 1] = k;
            }
            return a;
        }
        public void exercise11()
        {
            Console.WriteLine("Bài 11: Chứ số cuối cùng khác 0 trong giai thừa");
            Console.Write("Nhập vào số n: ");
            long n = Convert.ToInt64(Console.ReadLine());
            long t=ex11_Excute(n);
            Console.WriteLine("--> Chứ số cuối cùng khác 0 trong n! là : " + t);
            
        }
        public long ex11_Excute(long n)
        {
            long t=1;
            long giaithua = 1;
            for (long i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
                while (giaithua > 0)
                {
                    t = giaithua % 10;
                    if (t != 0)
                    {
                    return t;
                    break;
                    
                    }
                    else
                    {
                        giaithua = giaithua / 10;
                    }
                    
                }

            return t;
               
            
        }
        public void exercise12()
        {
            Console.WriteLine("Bài 12: Số chữ số 0 trong giai thừa");
            Console.Write("Nhập vào số n: ");
            long n = Convert.ToInt32(Console.ReadLine());
            long so0=ex12_Excute(n);
            Console.WriteLine("--> Số chữ số 0 xuất hiện trong n! là : " + so0);
        }
        public long ex12_Excute(long n)
        {
            long giaithua = 1;
            for (long i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            int so0 = 0;
            while (giaithua > 0)
            {
                long t = giaithua % 10;
                if (t == 0)
                {
                    so0++;
                }
                giaithua = giaithua / 10;
            }
            return so0;
        }
    }
}
