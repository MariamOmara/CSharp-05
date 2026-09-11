//namespace C_ASS_05
//{
//    internal class Program
//    {


//        //            //Q2
//        static void Main(string[] args)
//        {
//            //Q9

//            Console.WriteLine((int)Genre.Fiction);
//            Console.WriteLine((int)Genre.NonFiction);
//            Console.WriteLine((int)Genre.Science);
//        }






        //            //Q8
        //            Book book = new Book();

//            book.Genre = Genre.Science;

//            Console.WriteLine(book.Genre);
//        }






//            //Q7
//            Book book = new Book();

//            book.Title = "Clean Code";

//            Console.WriteLine(book.Title);
//        }






//Q6

//            Book book = new Book();

//            Console.WriteLine(book.copiesInStock);
//        }




//            //Q5

//            Book book = new Book();

//            Console.WriteLine(book.Password);
//        }
//    }






//            //Q4
//            PrintAllTitles("Clean Code", "C# Basics", "The Pragmatic Programmer");
//        }




//    //Q3
//    PrintBookInfo(pages: 500, title: "Clean Code");
//}





//                PrintBookInfo("Clean Code");

//                PrintBookInfo("C# Basics", 400);
//            }







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


// Q2
//Q3
//    static void PrintBookInfo(string title, int pages = 300)
//{
//    Console.WriteLine(title);
//    Console.WriteLine(pages);
//}
//        }
//    }





//Q4
//        static void PrintAllTitles(params string[] titles)
//        {
//            foreach (string title in titles)
//            {
//                Console.WriteLine(title);
//            }
//        }
//    }

//}

//Q5
//    class Book
//    {
//        private string password = "secret";
//        public string Password => password;
//    }
//}


//Q6
//        class Book
//        {
//            internal int copiesInStock = 5;
//        }
//    }
//}


//Q7
//            class Book
//        {
//            public string Title;
//        }
//    }
//}



//Q8
//Q9
//        enum Genre
//        {
//            Fiction,
//            NonFiction,
//            Science
//        }

//        class Book
//        {
//            public Genre Genre { get; set; }
//        }
//    }
//}