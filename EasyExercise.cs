using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Baitaps
{
    class EasyExercise
    {
        public void ShowMenu()
        {
            EasyExercise easyExercise = new EasyExercise();
            Console.WriteLine("Chọn bài số(1->16)");
            int exerciseIndex = Convert.ToInt32(Console.ReadLine());

            switch (exerciseIndex)
            {
                case 0:
                    break;
                case 1:
                    easyExercise.excercise1();
                    break;
                case 2:
                    easyExercise.exercise2();
                    break;
                case 3:
                    easyExercise.exercise3();
                    break;
                case 4:
                    easyExercise.exercise4();
                    break;
                case 5:
                    easyExercise.exercise5();
                    break;
                case 6:
                    easyExercise.exercise6();
                    break;
                case 7:
                    easyExercise.exercise7();
                    break;
                case 8:
                    easyExercise.exercise8();
                    break;
                case 9:
                    easyExercise.exercise9();
                    break;
                case 10:
                    easyExercise.exercise10();
                    break;
                case 11:
                    easyExercise.exercise11();
                    break;
                case 12:
                    easyExercise.exercise12();
                    break;
                case 13:
                    easyExercise.exercise13();
                    break;
                case 14:
                    easyExercise.exercise14();
                    break;
                case 15:
                    easyExercise.exercise15();
                    break;
                case 16:
                    easyExercise.theoryExcercise();
                    break;
                default:
                    break;
            }

        }
        public int insertNuma()
        {
            Console.Write("Nhập số a:");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public int insertNumb()
        {
            Console.Write("Nhập số b:");
            int b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
        public int insertNumc()
        {
            Console.Write("Nhập số c:");
            int c = Convert.ToInt32(Console.ReadLine());
            return c;
        }
        public int[] insertArrray()
        {
            Console.Write("Nhập số số hạng:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhập các giá trị trong mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("number[" + (i+1) + "]="); a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }
        public void excercise1()
        {
            Console.WriteLine("Bài 1: Đổi vị trí 3 số:");
            Console.WriteLine("Nhập vào các số nguyên:");
            int a = insertNuma();
            int b= insertNumb();
            int c= insertNumc();

            int[] m = ex1_Excute(a, b, c);
            Console.WriteLine("Thay đổi vị trí 3 số : " + m[0] + "," + m[1] + "," + m[2] + "\n");
        }
        public int[] ex1_Excute(int a, int b, int c)
        {
            int t = a; a = b; b = c; c = t;
            return new int[] { a, b, c };
        }
        public void exercise2()
        {
            Console.WriteLine("Bài 2: Tính lũy thừa ");
            int a = insertNuma();
            int b = insertNumb();
            double A = ex2_Excute(a, b);
            Console.WriteLine("Giá trị của a lũy thừa b:" + A);
        }
        public double ex2_Excute(int a, int b)
        {
            return Math.Pow(a, b);
        }

        public void exercise3()
        {
            Console.WriteLine("Bài 3: Tính chẵn lẻ của 2 số");
            Console.WriteLine("Nhập vào các số nguyên:");
            int a = insertNuma();
            int b = insertNumb();
            string result = ex3_Excute(a, b);
            Console.WriteLine(result);
        }
        public string ex3_Excute(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                return "đồng chẵn";
            }
            else if
            (a % 2 == 1 && b % 2 == 1)
            {
                return "đồng lẻ";
            }
            else
            {
                return "một chẵn một lẻ";
            }
        }
        public void exercise4()
        {
            Console.WriteLine("Bài 4: Số lượng số chẵn");
            int[] a = insertArrray();
            int sochan = ex4_Excute(a);
            Console.WriteLine("Số lượng số chẵn:" + sochan);
        }
        public int ex4_Excute(int[] a)
        {
            int sochan = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                {
                    sochan++;
                }
            }
            return sochan;
        }
        public void exercise5()
        {
            Console.WriteLine("Bài 5: Số lượng số lẻ");
            int[] a = insertArrray();
            int sole = ex5_Excute(a);
            Console.WriteLine("Số lượng số lẻ" + sole);
        }
        public int ex5_Excute(int[] a)
        {
            int sole = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 1)
                {
                    sole++;
                }
            }
            return sole;
        }
        public void exercise6()
        {
            Console.WriteLine("Bài 6: Tổng các số chẵn");
            int[] a = insertArrray();
            int sochan = ex6_Excute(a);
            Console.WriteLine("Tổng các sô chẵn:" + sochan);

        }
        public int ex6_Excute(int[] a)
        {
            int sochan = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                {
                    sochan += a[i];
                }
            }
            return sochan;
        }
        public void exercise7()
        {
            Console.WriteLine("Bài 7: Tổng các số lẻ");
            int[] a = insertArrray();
            int sole = ex7_Excute(a);
            Console.WriteLine("Tổng các sô lẻ:" + sole);

        }
        public int ex7_Excute(int[] a)
        {
            int sole = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                {
                    sole += a[i];
                }
            }
            return sole;
        }
        public void exercise8()
        {
            Console.WriteLine("Bài 8: Kiểm tra số nguyên tố");
            Console.Write("Nhập một số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isprame = ex8_Excute(n);
            if (isprame == true)
            {
                Console.WriteLine(" Số " + n + " là số nguyên tố");
            }
            if (isprame == false)
            {
                Console.WriteLine(" Số " + n + " không là số nguyên tố");
            }

        }
        public bool ex8_Excute(int n)
        {
            bool isprame = true;
            if (n == 0 || n == 1)
            {
                isprame = false;
            }
            else if (n == 2 || n == 3)
            {
                isprame = true;
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isprame = false;
                        break;
                    }

                    if (i == n / 2 || i == (n - 1) / 2 && n % i != 0)
                    {
                        isprame = true;
                        break;
                    }
                }

            }
            return isprame;

        }
        public void exercise9()
        {
            Console.WriteLine("Bài 9: Tìm số dư");
            Console.Write("Nhập số bị chia a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số chia b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sodu = ex9_Excute(a, b);
            Console.WriteLine("Số dư là:" + sodu);
        }
        public int ex9_Excute(int a, int b)
        {
            int thuong = (int)a / b;
            int sodu = a - thuong * b;
            return sodu;
        }
        public void exercise10()
        {
            Console.WriteLine("Bài 10:Tìm số lớn nhất");
            int[] a = insertArrray();
            int max = ex10_Excute(a);
            Console.WriteLine("Giá trị lớn nhất:" + max);
        }
        public int ex10_Excute(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i] > a[i + 1])
                {
                    a[i + 1] = a[i];
                }

            }
            return a[a.Length - 1];
        }
        public void exercise11()
        {
            Console.WriteLine("Bài 11: Tìm số nhỏ nhất");
            int[] a = insertArrray();
            int min = ex11_Excute(a);
            Console.WriteLine("Giá trị nhỏ nhất:" + min);
        }
        public int ex11_Excute(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i] < a[i + 1])
                {
                    a[i + 1] = a[i];
                }

            }
            return a[a.Length - 1];
        }
        public void exercise12()
        {
            Console.WriteLine("Bài 12: Tính gia trị trung bình một mảng số");
            int[] a = insertArrray();
            int medium = ex12_Excute(a);
            Console.WriteLine("Giá trị trung bình là :" + medium);

        }
        public int ex12_Excute(int[] a)
        {
            int total = 0;

            for (int i = 0; i < a.Length; i++)
            {

                total += a[i];
            }

            return total / a.Length;
        }
        public void exercise13()
        {
            Console.WriteLine("Bài 13: Đảo ngược thứ tự mảng số");
            int[] a = insertArrray();
            int[] b = ex13_Excute(a);
            Console.WriteLine("Các số hạng sau khi đảo ngược");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("");
        }
        public int[] ex13_Excute(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < (int)n / 2; i++)
            {
                int t;
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;

            }
            return a;
        }
        public void exercise14()
        {
            Console.WriteLine("Bài 14: Tìm vị trí số trong mảng");
            int[] a = insertArrray();
            Console.WriteLine("Nhập số cần trả về vị trí:");
            int b = Convert.ToInt32(Console.ReadLine());
            int vitri = ex14_Excute(a, b);
            Console.WriteLine("Vị trí của số cần trả về:" + vitri);


        }
        public int ex14_Excute(int[] a, int b)
        {
            int vitri = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    vitri = i + 1;
                    break;
                }
                else
                {
                    if (i == a.Length - 1) { vitri = -1; break; }
                }
            }
            return vitri;
        }
        public void exercise15()
        {
            Console.WriteLine("Bài 15: Tính giai thừa ");
            Console.WriteLine("Nhập số n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int giaithua = ex15_Excute(n);
            Console.WriteLine(n+"! có giá trị là:" + giaithua);
        }
        public int ex15_Excute(int n)
        {
            int giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            return giaithua;
            
        }

        public void theoryExcercise()
        {
            Console.WriteLine("Bài 21 : true");
            Console.WriteLine("Bài 22: false");
            Console.WriteLine("Bài 23: false");
            Console.WriteLine("Bài 24: true");
            Console.WriteLine("Bài 25: true");
            Console.WriteLine("Bài 26: i++ thì cộng lần lượt 1 đơn vị, khi ++i thì công lần lượt i đơn vị");
            Console.WriteLine("Bài 27: i giảm dần nên không có chặn dưới, nên phương thức sẽ chạy vô tận");

        }
    }
}
