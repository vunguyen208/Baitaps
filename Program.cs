using System.Text;

namespace Baitaps
{
    public class Program
    {
        private readonly object e;

        public static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();
            program.Start();
        }
        public void Start()
        {   
            EasyExercise easyExercise = new EasyExercise();
            HardExercise hardExercise = new HardExercise();
            MediumExercise mediumExercise = new MediumExercise();
            Baitap7 baitap7 = new Baitap7();
            Console.WriteLine("Chọn mức độ câu hỏi? (1: dễ; 2: trung bình; 3: khó)");
            string numberLevel = Console.ReadLine();
            
            switch (numberLevel)
            {
                case "1":
                    easyExercise.ShowMenu(); break;
                case "2":
                    mediumExercise.ShowMenu(); break;
                case "3":
                    hardExercise.ShowMenu(); break;
                default:
                    Console.WriteLine("Chọn sai, hãy chọn lại");
                    Start();
                    break;
            }
            Console.WriteLine("Bạn có muốn tiếp tục không? (0: No; other: Yes)");
            numberLevel = Console.ReadLine();
            if (numberLevel != "0")
            {
                Start();
            }
            else
            {
                Console.WriteLine("The end");

            }
        }

        
    }
}