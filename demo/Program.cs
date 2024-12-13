using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loops
            #region for-foreach
            //for
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < 5; i++) { 
            //Console.WriteLine(numbers[i]);  

            //}
            //Console.WriteLine("************************");
            //foreach

            //foreach (int i in numbers) {
            //    Console.WriteLine(i);
            //}


            #endregion
            #region while - do while
            //do while
            // int number;
            //Console.WriteLine("pls, enter even number");
            //number = int.Parse(Console.ReadLine());
            //while (!(number % 2 == 0)) {
            //    Console.WriteLine("pls, enter number even");
            //number =int.Parse(Console.ReadLine());

            //}
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter even number");
            //    // number=int.TryParse(Console.ReadLine(),out );
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}while (!(number % 2 == 0)||  ! flag== true );

            // while
            //int x=4;
            //while (x % 2 == 0)
            //{
            //    Console.WriteLine("even number");
            //    Console.WriteLine("enter odd num");
            //    x=int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("odd number");

            #endregion



            #endregion
            #region string and string builder
            //string name1 ; // null
            //name1 = new string("hatem"); 

            //string name2 = "ashraf";/// sentax sugar 
            //name2=name1 ;
            //name1 = "omar";
            ///  Console.WriteLine($"name1 : {name1}"); 
            /// Console.WriteLine($"name2 : {name2}");   
            // string type  is  an imutable  type  cannot change  it is  value
            //string message = "hello,";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message += "hatem";
            //Console.WriteLine(message.GetHashCode());

            //StringBuilder sb = new StringBuilder();
            //sb.Append("hello,");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append("hatem");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            /// sb  is refernce type 



            #endregion
            #region 1d array
            //int[] n;
            //n = new int[5];

            //for (int i = 0; i < n.Length; i++) {
            //    n[i]=Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine($"size of array={n.Length}, number of dimension={n.Rank}");


            ///reference type





            #endregion
            #region 2d array

            //int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);


            // to get input 
            //   int[,] marks = new int[2, 4];
            //   Console.WriteLine(marks.GetLength(0));// rows
            //   Console.WriteLine(marks.GetLength(1)); // columns
            //   for (int i = 0; i < marks.GetLength(0); i++) {
            //       Console.WriteLine($"enter marks of student num{i+1}");
            //       for (int j = 0; j < marks.GetLength(1); j++) {
            //           Console.WriteLine($"subject num {j+1}");
            //           marks[i, j] = int.Parse(Console.ReadLine());

            //       }
            //Console.Clear();   


            //   }
            //   for (int i = 0; i < marks.GetLength(0); i++) {
            //       Console.WriteLine($"grades of student{i+1}");
            //       for (int j = 0; j < marks.GetLength(1); j++) {
            //           Console.WriteLine( $"sub num {j+1}= {marks[i,j]}" );

            //       }


            //   }


            #endregion
            #region judged array
            //int[][] arr = new int[3][]; 
            //arr[0] = new int[] {1,2,3} ;
            //arr[1] = new int[] { 4, 5 };
            //arr[2] = new int[] { 6 };

            //for (int i = 0; i < arr.Length; i++) {

            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine(arr[i][j]);
            //    }
            //}

            #endregion
            #region array methods
            //int[] n = { 5, 1, 5, 4, 3, 10, 7 };
            //int[] n2 = { 1, 2, 3 };
            //int[] n3 = new int[5];
            #region class member methods [static methods]
            //Array.Sort(n); // sort  array in asc order
            //Array.Copy(n2, n3, 2);
            //foreach (int i in n3)
            //{
            //    Console.WriteLine(i);

            // Array.Clear(n); // defult values
            // Array.ConstrainedCopy(n2, 1, n3, 1, 2);
            // int[] arr = (int[])Array.CreateInstance(typeof(int), 10);

            #region object member method

            //n2.CopyTo(n3, 1);
            //foreach (int i in n3) {
            //    Console.WriteLine(i);
            //  }

           // n2.SetValue(100, 1);
         //   foreach (int i in n2) { Console.WriteLine(i); }

            #endregion
            #endregion


            #endregion




        }
    }
    }

