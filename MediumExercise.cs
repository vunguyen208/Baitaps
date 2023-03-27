using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaps
{
     class MediumExercise
    {
        public void ShowMenu()
        {
            MediumExercise mediumExercise = new MediumExercise();
            Console.WriteLine("Chọn bài số bao nhiêu? ( 1 -> 19)");
            int exerciseIndex = Convert.ToInt32(Console.ReadLine());
            mediumExercise.exerciseIndex(exerciseIndex);

        }
        public void exerciseIndex(int exerciseIndex)
        {
            MediumExercise mediumExercise = new MediumExercise();
            switch (exerciseIndex)
            {
                case 0:
                    break;
                case 1:
                    mediumExercise.exercise1();
                    chooseAgain(1);
                    break;
                case 2:
                    mediumExercise.exercise2();
                    chooseAgain(2);
                    break;
                case 3:
                    mediumExercise.exercise3();
                    chooseAgain(3);
                    break;
                case 4:
                    mediumExercise.exercise4();
                    chooseAgain(4);
                    break;
                case 5:
                    mediumExercise.exercise5();
                    chooseAgain(5);
                    break;
                case 6:
                    mediumExercise.exercise6();
                    chooseAgain(6);
                    break;
                case 7:
                    mediumExercise.exercise7();
                    chooseAgain(7);
                    break;
                case 8:
                    mediumExercise.exercise8();
                    chooseAgain(8);
                    break;
                case 9:
                    mediumExercise.exercise9();
                    chooseAgain(9);
                    break;
                case 10:
                    mediumExercise.exercise10();
                    chooseAgain(10);
                    break;
                case 11:
                    mediumExercise.exercise11();
                    chooseAgain(11);
                    break;
                case 12:
                    mediumExercise.exercise12();
                    chooseAgain(12);
                    break;
                case 13:
                    mediumExercise.exercise13();
                    chooseAgain(13);
                    break;
                case 14:
                    mediumExercise.exercise14();
                    chooseAgain(14);
                    break;
                case 15:
                    mediumExercise.exercise15();
                    chooseAgain(15);
                    break;
                case 16:
                    mediumExercise.exercise16();
                    chooseAgain(16);
                    break;
                case 17:
                    mediumExercise.exercise17();
                    chooseAgain(17);
                    break;
                case 18:
                    mediumExercise.exercise18();
                    chooseAgain(18);
                    break;
                case 19:
                    mediumExercise.theoryExcercise();
                    chooseAgain(19);
                    break;
                default:
                    break;
            }
        }
        public void chooseAgain(int newchoice)
        {
            Console.WriteLine("Bạn muốn làm lại bài này không? (0: Không; Khác: Có)");
            string chooseagain = Console.ReadLine();
            if (chooseagain == "0") { }
            else exerciseIndex(newchoice);
        }
        public string nhapchuoia()
        {
            Console.WriteLine("Nhập chuỗi lớn a:");
            String a = Console.ReadLine();
            return a;
        }
        public string nhapchuoib()
        {
            Console.WriteLine("Nhập chuỗi con b:");
            String b = Console.ReadLine();
            return b;
        }
        public int nhapsoluongmang()
        {
            Console.WriteLine("Nhập số lượng số hạng trong mảng:");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public int[] nhapmang(int n)
        {
            int[] array = new int[n];
            Console.WriteLine("Nhập các giá trị trong mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Số[" + (i+1) + "]="); array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        public int[] nhapmanga(int n)
        {
            int[] array1 = new int[n];
            Console.WriteLine("Nhập các giá trị trong mảng a: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Số[" + (i+1) + "]="); array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array1;
        }
        public int[] nhapmangb(int n)
        {
            int[] array2 = new int[n];
            Console.WriteLine("Nhập các giá trị trong mảng b: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Số[" + (i+1) + "]="); array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array2;
        }

        public void exercise1()
        {
            Console.WriteLine("Bài 1: sắp xếp mảng theo thứ tự tăng dần hoặc giảm dần");
            int n = nhapsoluongmang();
            int[] array = nhapmang(n);
            Console.Write("Sắp xếp 1 mảng theo thứ tự tăng hoặc giảm(+ : tăng, - : giảm): ");
            String sapxep = Console.ReadLine();
            try 
            {
                int[] newarray = ex1_Excute(array, sapxep);
                Console.WriteLine("--> Mảng được sắp xếp lại như sau:");
                for (int i = 0; i < newarray.Length; i++)
                {
                    Console.Write(newarray[i] + " ");
                }
                Console.WriteLine("");
            }
            catch(Exception e)
            {
                Console.WriteLine("--> Chọn sai.Làm lại bài này");
                exercise1(); 
            }
            
            
        }
        public int[] ex1_Excute(int[] array,string sapxep)
        {
            if (sapxep == "+")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (array[j] > array[i])
                        {
                            int t = array[j];
                            array[j] = array[i];
                            array[i] = t;

                        }
                    }
                }
            }   
            if (sapxep == "-")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (array[j] < array[i])
                        {
                            int t = array[j];
                            array[j] = array[i];
                            array[i] = t;

                        }
                    }
                }
            }
            else
            {
                throw new Exception();
            }
            return array;
            
        }
        public void exercise2()
        {
            Console.WriteLine("Bài 2: Nối 2 mảng số ");
            int n = nhapsoluongmang();
            int[] array1 = nhapmanga(n);
            int[] array2 = nhapmangb(n);
            Console.WriteLine("--> Ta có được mảng 2 số: ");
            int[] array=ex2_Excute(array1, array2);
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
        public int[] ex2_Excute(int[] array1, int[] array2)
        {
            int n = array1.Length;
            int[] array = new int[2 * n];
            System.Array.Copy(array1, 0, array, 0, n);
            System.Array.Copy(array2, 0, array, n, n);
            return array;
        }
        public void exercise3()
        {
            Console.WriteLine("Bài 3: Cộng 2 mảng số");
            int n = nhapsoluongmang();
            int[] array1 = nhapmanga(n);
            int[] array2 = nhapmangb(n);
            Console.WriteLine("--> Ta có mảng mới là tổng 2 mảng: ");
            int[] array=ex3_Excute(array1 , array2);
            for (int i = 0; i < n; i++)
            {
                
                Console.Write(array[i] + " "); ;
            }
            Console.WriteLine(" ");
        }
        public int[] ex3_Excute(int[] array1, int[] array2)
        {   
            int[] array = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i] + array2[i];
            }
            return array;
        }
        public void exercise4()
        {
            Console.WriteLine("Bài 4: Hiệu 2 mảng số");
            int n = nhapsoluongmang();
            int[] array1 = nhapmanga(n);
            int[] array2 = nhapmangb(n);
            Console.WriteLine("--> Ta có mảng mới là hiệu 2 mảng: ");
            int[] array = ex3_Excute(array1, array2);
            for (int i = 0; i < n; i++)
            {

                Console.Write(array[i] + " "); ;
            }
            Console.WriteLine(" ");
        }
        public int[] ex4_Excute(int[] array1, int[] array2)
        {
            int[] array = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i] - array2[i];
            }
            return array;
        }
        public void exercise5()
        {
            Console.WriteLine("Bài 5: Tích 2 mảng số");
            int n = nhapsoluongmang();
            int[] array1 = nhapmanga(n);
            int[] array2 = nhapmangb(n);
            Console.WriteLine("--> Ta có mảng mới là tích 2 mảng: ");
            int[] array = ex3_Excute(array1, array2);
            for (int i = 0; i < n; i++)
            {

                Console.Write(array[i] + " "); ;
            }
            Console.WriteLine(" ");
        }
        public int[] ex5_Excute(int[] array1, int[] array2)
        {
            int[] array = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i] * array2[i];
            }
            return array;
        }
        public void exercise6()
        {
            Console.WriteLine("Bài 6: Chia 2 mảng số");
            int n = nhapsoluongmang();
            int[] array1 = nhapmanga(n);
            int[] array2 = nhapmangb(n);
            Console.WriteLine("--> Ta có mảng mới là sô chia của 2 mảng: ");
            int[] array = ex3_Excute(array1, array2);
            for (int i = 0; i < n; i++)
            {

                Console.Write(array[i] + " "); ;
            }
            Console.WriteLine(" ");
        }
        public int[] ex6_Excute(int[] array1, int[] array2)
        {
            int[] array = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i] * array2[i];
                if (array2[i]== 0) { array[i] = 0; }
            }
            return array;
        }
        public void exercise7()
        {
            Console.WriteLine("Bài 7: Lấy 1 số phần tử của mảng");
            int n = nhapsoluongmang();
            int[] array = nhapmang(n);
            Console.WriteLine("Nhập vị trí đầu(lớn hơn 0 và nhỏ hơn hoặc bằng số lượng số hạng): ");
            int dau = Convert.ToInt32(Console.ReadLine());
            if (dau < 1 || dau > n) { Console.WriteLine("Nhập giá trị sai"); }
            else
            {
                Console.WriteLine("Nhập vị trí cuối(lớn hơn hoặc bằng vị trí đầu và nhỏ hơn hoặc bằng số lượng số hạng): ");
                int cuoi = Convert.ToInt32(Console.ReadLine());
                if (cuoi < dau || cuoi > n) { Console.WriteLine("--> Nhập giá trị sai,làm lại bài này."); exercise7(); }
                else 
                {
                    int[]array2=ex7_Excute(array,dau,cuoi);
                    Console.WriteLine("--> Ta có mảng mới như sau: ");
                    for (int i = 0; i <= cuoi - dau; i++)
                    {
                        Console.Write(array2[i] + " ");
                    }
                    Console.WriteLine(" ");
                }
                    
                    
            }
        }
        public int[] ex7_Excute(int[] array,int dau, int cuoi) 
        {
            int[] array2 = new int[cuoi - dau + 1];
            System.Array.Copy(array, dau - 1, array2, 0, cuoi - dau + 1);
            return array2;
        }
        public void exercise8()
        {
            Console.WriteLine("Bài 8: Vị trí 1 chuối trong 1 chuỗi khác ");
            String a =nhapchuoia();
            String b = nhapchuoib();
            int vitri=ex8_Excute(a, b);
            Console.WriteLine("--> Vị trí của chuỗi con b trong a là: " + (vitri+1));
        }
        public int ex8_Excute(string a,string b)
        {
            int vitri = a.IndexOf(b);
            return vitri;
        }
        public void exercise9()
        {
            Console.WriteLine("Bài 9: Tổng số các phần tử chuỗi a trong chuỗi b: ");
            String a = nhapchuoia();
            String b = nhapchuoib();
            int tong=ex9_Excute(a, b);
            Console.Write("--> Số các phần tử của a trong b là" + tong);
            Console.WriteLine("");
        }
        public int ex9_Excute(string a,string b)
        {
            int tong = 0;
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
            return tong;
        }
        public void exercise10()
        {
            Console.WriteLine("Bài 10: Tổng sô các phần tử chuỗi a không trong chuỗi b");
            String a = nhapchuoia();
            String b = nhapchuoib();
            int tong= ex10_Excute(a, b);
            Console.Write("--> Số các phần tử của b không có trong a là:" + (b.Length- tong));
        }
        public int ex10_Excute(string a, string b)
        {
            int tong = 0;
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
            return tong;
        }
        public void exercise11()
        {
            Console.WriteLine("Bài 11: Random giá trị từ 0 đến a");
            Console.WriteLine("Nhập 1 số a:");
            double a=Convert.ToDouble(Console.ReadLine());
            double b = ex11_Excute(a);
            Console.WriteLine("--> Số random trong khoảng từ 0 đến " + a+":"+b);
        }
        public double ex11_Excute(double a)
        {
            Random random = new Random();
            double b = a * random.Next(0, 10) / 10;
            return b;
        }
        public void exercise12()
        {
            Console.WriteLine("Bài 12: Random giá trị từ -a đến a");
            double a = Convert.ToDouble(Console.ReadLine());
            double sorandom=ex12_Excute(a);
            Console.WriteLine("--> Số random trong khoảng từ -a dến a: " + sorandom);
        }
        public double ex12_Excute(double a)
        {
            Random random = new Random();
            double b = a * random.Next(0, 10) / 10;
            int c = random.Next(-1, 1);
            return b * c;
        }
        public void exercise13()
        {
            Console.WriteLine("Bài 13: Tính giá tiền nhà nghỉ");
            int checkin, checkout,tongtien;
            Console.Write("Nhập giờ checkin:");
            checkin = Convert.ToInt32(Console.ReadLine());
            if(checkin>=24|| checkin < 0)
            {
                Console.Write("Nhập số giờ trong khoảng từ 0 đến 24,làm lại bài này.");
                exercise13();
                
            }
            else 
            {
                Console.Write("Nhập giờ checkout:");
                checkout = Convert.ToInt32(Console.ReadLine());
                if (checkout >= 24 || checkout < 0)
                {
                    Console.WriteLine("Nhập số giờ trong khoảng từ 0 đến 24, làm lại bài này.");
                    exercise13();
                }
                else
                {
                     tongtien = ex13_Excute(checkin, checkout);
                    Console.WriteLine("--> Số tiền khách hàng phải trả là: "+  tongtien);
                }
            }
        }
        public int ex13_Excute(int checkin,int checkout)
        {
            int tongtien = 0;
            if (checkin < 8)
            {
                if (checkout <= checkin)
                {
                    tongtien = 320 + 40 * 16;
                }
                else if (checkout > checkin && checkout < 8)
                {
                    tongtien = 160;
                }
                else
                {
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
                else if (checkout - checkin <= 2)
                {
                    tongtien = 70 * (checkout - checkin);
                }
                else
                {
                    tongtien = 70 * 2 + (checkout - checkin - 2) * 50;
                }
            }
            return tongtien;
        }
        public void exercise14()
        {
            Console.WriteLine("Bài 14: Tính tiền thuế thu nhập cá nhân");
            Console.Write("Nhập số tháng lương: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] luong = new double[n];
            
            Console.WriteLine("Nhập thu nhập trong " + n + " tháng (đơn vị triệu đồng): ");
            for(int i=0; i < n; i++)
            {
                Console.Write("Lương tháng " + (i+1) + "=");
                luong[i] = Convert.ToDouble(Console.ReadLine());
            }
            double thue = ex14_Excute(luong);
            Console.WriteLine("--> Tổng thuế cần đóng là: " + thue+" (triệu đồng)");

        }
        public double ex14_Excute(double[] luong)
        {
            double thue = 0;
            for(int i = 0; i < luong.Length; i++)
            {
                if (luong[i] > 50)
                {
                    thue += luong[i] * 0.2;
                }
                else if (luong[i] <= 50 && luong[i] >= 20)
                {
                    thue += luong[i] * 0.1;
                }
                else if (luong[i] < 20 && luong[i] > 0)
                {
                    thue += luong[i] * 0.05;
                }
            }
            return thue;
        }
        public void exercise15()
        {
            Console.WriteLine("Bài 15: Tổng các chữ số");
            Console.Write("Nhập số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
            int tongcs= ex15_Excute(n);
            Console.WriteLine("--> Tổng số chữ số là: " + tongcs);
        }
        public int ex15_Excute(int n)
        {
            int tongcs = 0;
            if (n < 0) { n = -n; }
            while (n > 0)
            {
                tongcs += (n % 10);
                n = n / 10;
            }
            return tongcs;
        }
        public void exercise16()
        {
            Console.WriteLine("Bài 16: Dãy số fibonaic");
            int n = nhapsoluongmang();
            int[] a = ex16_Excute(n);
            Console.WriteLine("--> Dãy số fibonaic với " + n + " số là: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
             
        }
        public int[] ex16_Excute(int n)
        {
            int[] a = new int[n];
            if (n == 1)
            {
                a[0] = 1;
            }
            if (n == 2) { a[0] = a[1] = 1; }
            if (n > 2)
            {
                a[0] = a[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    a[i] = a[i - 1] + a[i - 2];
                }
            }
            return a;
        }
        public void exercise17()
        {
            Console.WriteLine("Bài 17: Cắt string theo vị trí bắt đầu và vị trí kết thúc");
            Console.WriteLine("Nhập vào chuỗi: ");
            String str = Console.ReadLine();
            Console.Write("Nhập vào vị trí ban đầu: ");
            int a= Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Nhập vào vị trí lớn hơn 0,làm lại bài này");
                exercise17();

            }
            else if (a > str.Length)
            {
                Console.WriteLine("Nhập vào vị trí nhỏ hơn hoặc bằng số kí tự của chuỗi,làm lại bài này");
                exercise17();
            }
            else 
            {
                Console.Write("Nhập vào vị trí kết thúc:");
                int b = Convert.ToInt32(Console.ReadLine());
                if ( b < a) 
                {
                    Console.WriteLine("Nhập vào vi trí kết thúc lớn hơn vị trí ban đầu,làm lại bài này ");
                    exercise17();
                }
                else if (b > str.Length - a + 1)
                {
                    Console.WriteLine("Số kí tự cần cắt nằm ngoài số lượng cho phép,làm lại bài này");
                    exercise17();
                }
                else
                {
                    string newString = ex17_Excute(str, a, b);
                    Console.WriteLine("--> Chuỗi được cắt ra là: " + newString);
                    }
            }
        }
        public string ex17_Excute(string str,int a,int b)
        {
            string newString = str.Substring(a - 1, b - a + 1);
            return newString;
        }
        public void exercise18()
        {
            Console.WriteLine("Bài 18: Cắt string theo vị trí bắt đầu và số ký tự cần cắt");
            Console.WriteLine("Nhập vào chuỗi: ");
            String str = Console.ReadLine();
            Console.Write("Nhập vào vị trí ban đầu: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Nhập vào vị trí lớn hơn 0,làm lại bài này");
                exercise18();

            }
            else if (a > str.Length)
            {
                Console.WriteLine("Nhập vào vị trí nhỏ hơn hoặc bằng số kí tự của chuỗi");
                exercise18();
            }
            else
            {
                Console.Write("Nhập vào số kí tự cần cắt:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("Nhập vào số kí tự lớn hơn 0,làm lại bài này");
                    exercise18();
                }
                else if (b > str.Length - a + 1)
                {
                    Console.WriteLine("Số kí tự cần cắt nằm ngoài số lượng cho phép,làm lai bài này");
                    exercise18();
                }
                else
                {
                    string newString = ex18_Excute(str,a,b);
                    Console.WriteLine("--> Chuối được cắt ra là: " + newString);
                }
            }
        }
        public string ex18_Excute(string str,int a,int b)
        {
            string newString = str.Substring(a - 1, b);
            return newString;
        }
        public void theoryExcercise()
        {
            Console.WriteLine("--> Bài 21 :3");
            Console.WriteLine("--> Bài 22: Stack có 1 đầu để nhận dữ liệu và truy xuất dữ liệu , queue có 2 đầu: 1 đầu để nhận dữ liệu va 1 đầu truy xuất dữ liệu");
        }
    }
}
