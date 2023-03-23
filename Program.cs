namespace Baitaps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Batdau();
        }
        public void Batdau()
        {
            Baitapde baitapde = new Baitapde();
            Baitapkho baitapkho = new Baitapkho();
            Baitapvua baitapvua = new Baitapvua();
            Baitap7 baitap7 = new Baitap7();
            Console.WriteLine("Ban muon chon muc do bai tap nao");
            Console.WriteLine("1 de, 2 vua,3 kho,4 baitap7");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    baitapde.ShowMenu(); break;
                case 2:
                    baitapvua.ShowMenu(); break;
                case 3:
                    baitapkho.ShowMenu(); break;
                case 4:
                    baitap7.coin(); break;
                default:
                    Console.WriteLine("Vui long chon lai");
                    Batdau();
                    break;
            }
            Console.WriteLine("Ban co muon tiep tuc khong(khong thi chon so 0, co thi chon so khac)");
            i = Convert.ToInt32(Console.ReadLine());
            if (i != 0)
            {
                Batdau();
            }
            else
            {
                Console.WriteLine("ket thuc");

            }
        }
    }
}