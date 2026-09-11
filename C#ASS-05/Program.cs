//namespace C_ASS_05
//{
//    internal class Program
//    {


//        static void Main(string[] args)
//        {
//            double price;

//            if (TryGetPrice("Clean Code", out price))
//            {
//                Console.WriteLine(price);
//            }
//        }




//        // Q1
//        public static bool TryGetPrice(string title, out double price)
//        {
//            if (title == "Clean Code")
//            {
//                price = 25.5;
//                return true;
//            }
//            else
//            {
//                price = 0;
//                return false;
//            }
//        }
//    }
//}
