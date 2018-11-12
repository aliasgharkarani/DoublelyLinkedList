using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
//To search given student Marksheet and print on console.
            DoubleLinkedList obj = new DoubleLinkedList();
            string[] array1=  new string[3] {"PF"   ,"90","8999"};
            string[] array2 = new string[3] { "IICT","60", "8741" };
            string[] array3 = new string[3] { "OOP","50", "9000" };           
            string[] array4 = new string[3] { "DS", "40", "9001" };
            string[] array5 = new string[3] { "DLD", "20", "7001" };

            //Task 1
            obj.InsertAtHead(array1);
            obj.InsertAtHead(array2);
            obj.InsertAtHead(array3);
            obj.InsertAtHead(array4);

            //Task 2
            obj.InsertAtTail(array1);
            obj.InsertAtTail(array2);
            obj.InsertAtTail(array3);
            obj.InsertAtTail(array4);

            //Task 3
            obj.InsertAfterGivenSid("9000", array5);

            //Task 4
            obj.PrintingMarks("9000");

            //Printing Process
            Console.WriteLine("Print Forward:");
            obj.PrintFwd();
            Console.WriteLine("\nPrint Backward:");
            obj.PrintBwd();

            Console.ReadLine();
        }
    }
}
