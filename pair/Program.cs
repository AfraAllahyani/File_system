using System;
using System.IO;

namespace pair
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name : ");
            string UserFirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Welcome " + UserFirstName + 
                              " To creat a new file enter (1)\n" +
                              "To update an exist file enter (2) \n" +
                              "To delet an exisit file enter (3) ");
        
            int expression = Convert.ToInt32(Console.ReadLine());
            string content = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Type file name : ");
            string path = "/Users/afra/desktop/cSharp";
            string fileName = Convert.ToString(Console.ReadLine());

            switch (expression)
            {
                case 1:

                    if (!File.Exists(path + fileName))
                    {
                        File.Create(path + fileName);
                        Console.WriteLine("File (" + fileName + ") created.");
                    }
                    else
                    {
                        Console.WriteLine("File (" + fileName + ") exists.");
                    }
                    break;
                case 2:
                    if (!File.Exists(path + fileName))
                    {
                        File.Create(path + fileName);
                        File.WriteAllText(path + fileName, content);
                        Console.WriteLine("File (" + fileName + ") created");
                    }
                    else
                    {
                        File.WriteAllText(path + fileName, content);
                        Console.WriteLine("File (" + fileName + ") Updated");
                    }
                    break;
                case 3:
                    if (!File.Exists(path + fileName))
                    {
                        Console.WriteLine("File (" + fileName + ") not exists.");
                    }
                    else
                    {
                        File.Delete(path + fileName);
                        Console.WriteLine("File (" + fileName + ") deleted.");
                    }
                    break;

            }
        }
 
    }
}
/*
 char[] array = { 'q', 'w', 'w' };

            string str = "";
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                str += array[i];

                if (str.Contains(array[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(str);



class Program
    {
        public static int SockPairs( string socks)
        {
            int cnt = 0;
            char[] arr = socks.ToCharArray();
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    cnt++;
                    i++;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SockPairs("BBQAQA"));
           
        }

    }



// folders
             string path = "/Users/afra/desktop/cSharp";
            //string[] files = { "/testFile.txt", "/testFile2.txt", "/testFile3.txt", "/testFile4.txt" , "/testFile5.txt" , "/testFile6.txt" , "/testFile7.txt" , "/testFile8.txt" ,  "/ testFile9.txt"  , "/testFile10.txt"};
            string fileName = "/testFile";


            if (!File.Exists(path +  fileName))
             {
                for (int i = 1; i < 10; i++)
                {
                    File.Create(path +  fileName + i + ".txt");
                    Console.WriteLine("File ( " + fileName + i + ".txt"  + ") created.");
                }
                    
                
             }
             else
             {
                 Console.WriteLine("File ( " + fileName + ") exists.");
             }
 
 */

