using System;
using System.IO;

namespace FileComp
{
    class Program
    {
        //Create method for comparing the two files
        private static bool CompareFile(string file1, string file2)
        {
            bool isEqual = false;

            // Makes FileInfo objects using System.IO.FileInfo this provides the length of the string
            FileInfo info1 = new FileInfo(file1);
            FileInfo info2 = new FileInfo(file2);

            // If statement to compare file sizes, if they are both the same, then set isEqual to true
            if (info1.Length == info2.Length)
            {
                isEqual = true;
            }

            //return the value isEqual
            return isEqual;
        }

        static void Main(string[] args)
        {
            //Creates individual variables for each file to be compared
            string filePath1 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_1a.txt";
            string filePath2 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_1b.txt";
            string filePath3 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_2a.txt";
            string filePath4 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_2b.txt";
            string filePath5 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_3a.txt";
            string filePath6 = @"C:\Users\Martin\source\repos\FileComp\FileComp\Assessment 2 Files\GitRepositories_3b.txt";

            //To make sure the user can input the command
            Console.WriteLine("");

            //varaible to read users answer
            string userInp = Console.ReadLine();

            Console.WriteLine("Are these two files the same?, True = yes, False = no");


            //if else statment to go through all possible combinations of files the user enters
            if (userInp == "diff GitRepositories_1a.txt GitRepositories_1b.txt")
            {
                Console.WriteLine(CompareFile(filePath1, filePath2));
            }

            else if (userInp == "diff GitRepositories_2a.txt GitRepositories_2b.txt")
            {
                Console.WriteLine(CompareFile(filePath3, filePath4));
            }

            else if (userInp == "diff GitRepositories_3a.txt GitRepositories_3b.txt")
            {
                Console.WriteLine(CompareFile(filePath5, filePath6));
            }

            else if (userInp == "diff GitRepositories_1a.txt GitRepositories_2a.txt")
            {
                Console.WriteLine(CompareFile(filePath1, filePath3));
            }

            else if (userInp == "diff GitRepositories_1a.txt GitRepositories_3a.txt")
            {
                Console.WriteLine(CompareFile(filePath1, filePath5));
            }

            else if (userInp == "diff GitRepositories_2a.txt GitRepositories_3a.txt")
            {
                Console.WriteLine(CompareFile(filePath3, filePath5));
            }

            else if (userInp == "diff GitRepositories_1b.txt GitRepositories_2b.txt")
            {
                Console.WriteLine(CompareFile(filePath2, filePath4));
            }

            else if (userInp == "diff GitRepositories_1b.txt GitRepositories_3b.txt")
            {
                Console.WriteLine(CompareFile(filePath2, filePath6));
            }

            else if (userInp == "diff GitRepositories_2b.txt GitRepositories_3b.txt")
            {
                Console.WriteLine(CompareFile(filePath4, filePath6));
            }

            else if (userInp == "diff GitRepositories_1a.txt GitRepositories_2b.txt")
            {
                Console.WriteLine(CompareFile(filePath1, filePath4));
            }

            else if (userInp == "diff GitRepositories_1a.txt GitRepositories_3b.txt")
            {
                Console.WriteLine(CompareFile(filePath1, filePath6));
            }

            else if (userInp == "diff GitRepositories_1b.txt GitRepositories_2a.txt")
            {
                Console.WriteLine(CompareFile(filePath2, filePath3));
            }

            else if (userInp == "diff GitRepositories_2a.txt GitRepositories_3b.txt")
            {
                Console.WriteLine(CompareFile(filePath3, filePath6));
            }

            // if the user has not entered the files names correctly, the console will let them know that the file does not exist
            else
            {
                Console.WriteLine("Either one or both of the files specified do not exist");
            }

            // to make sure the user can see the output
            Console.ReadLine();
        }

        
    }

}
