using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray;
            //myArray = new int[5];

            //int[] myArray = new int[5];

            //int[] myArray = { 1, 2, 4, 6 };

            //int[] myArray = new int[5] { 1, 2, 4, 7, 9 };

            //int x = 5;
            //int[] myArray = new int[x];

            //const int x = 5;
            //int [] myArray = new int[x] { 1, 2, 3, 4, 5 };

            //string[] friends = { "Taher", "Kamran", "Shirin", null, "" };
            //WriteLine("Here are {0} of my friends : ", friends.Length);
            //WriteLine($"Here are {friends.Length} of my friends");

            //for (int i = 0; i < friends.Length; i++)
            //    WriteLine(friends[i]);

            //foreach (string f in friends)
            //    WriteLine(f);

            //foreach(string f in friends)
            //{
            //    switch(f)
            //    {
            //        case string s when s.StartsWith("T"):
            //            WriteLine($"name of {s} starts with T");
            //            break;
            //        case string x when x.Length == 0:
            //            WriteLine($"{x} has zero lenght");
            //            break;
            //        case null:
            //            WriteLine($"{f} is null");
            //            break;
            //        case string x:
            //            WriteLine($"type of {x} is string");
            //            break;
            //        default:
            //            WriteLine("nothing");
            //            break;
            //    }
            //}
            //آیا نام دوست من با حرف ت ط شروع میشود؟
            // آیا نام این شخص، طول صفر دارد یا خیر؟
            // آیا نام، نال است یا خیر؟
            // آیا نام این شخص، یک متن استرینگ است؟
            // default


            //int intValue = 0;
            //int count = 0;
            ////int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            //Nullable<int> [] myIntArray = new Nullable<int>[7] { 5, intValue, 9, 10, null, 2, 99 };
            //foreach(int? x in myIntArray)
            //{
            //    switch(x)
            //    {
            //        case 0:
            //            WriteLine($"number[{count}] is 0");
            //            count++;
            //            break;
            //        case int z:
            //            WriteLine($"number[{count}] is nonzero integer");
            //            count++;
            //            break;
            //        case null:
            //            WriteLine($"number[{count}] is null");
            //            count++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //// 0
            //// int
            //// null
            //// default
            ///

            //int[,] twoDimArr = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            //foreach(var element in twoDimArr)
            //{
            //    WriteLine(element);
            //}

            //int[][] twoDimJaggedArr = new int[4][];
            //twoDimJaggedArr[0] = new int[3] { 1, 2, 3 };
            //twoDimJaggedArr[1] = new int[2] { 4, 5 };
            //twoDimJaggedArr[2] = new int[1] { 6 };
            //twoDimJaggedArr[3] = new int[4] { 7, 8, 9, 10 };

            //int[][] twoDimJaggedArr = new int[4][] { new int[3] { 1, 2, 3 }, new int[2] { 4, 5 }, new int[1] { 6 }, 
            //    new int[4] { 7, 8, 9, 10 }};

            //int[][] twoDimJaggedArr = { new int[3] { 1, 2, 3 }, new int[2] { 4, 5 }, new int[1] { 6 },
            //    new int[4] { 7, 8, 9, 10 }};

            int[][] twoDimJaggedArr = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6 },
                new int[] { 7, 8, 9, 10 }};

            int rowCount = 0;
            foreach(int[] firstDim in twoDimJaggedArr)
            {
                int colCount = 0;
                foreach (int element in firstDim)
                {
                    WriteLine($"twoDimJaggedArray[{rowCount}][{colCount}] = {element}");
                    //WriteLine("twoDimJaggedArray[{0}][{1}] = {2}", rowCount, colCount, element);
                    colCount++;
                }
                rowCount++;
            }

            ReadKey();
        }
    }
}
