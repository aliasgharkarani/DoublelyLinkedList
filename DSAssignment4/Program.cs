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
//Make a program that will handle double way linked list of maintaining the marksheet of students (PF,IICT,OOP,AND DS) list of marks will be maintain by an array of string data type. each marksheet will be identified by a unique key which is student's id, 
//such that each node in list will have an array (probably 2d) of subject name with their marks, student id and linkers to link previous and next node of list .

//since this list is dynamic so there is no limit of students

//Your program must have following features
//1). Student's Marksheet can be inserted at Head.
//2).Student's Marksheet can be inserted at Tail.
//3).Student's Marksheet can be inserted after given student id.
//4). To search given student Marksheet and print on console.

//Note: Read carefully before asking questions 
//due date: tuesday 11:59 pm. 
//#KeepLearning

            DoubleLinkedList obj = new DoubleLinkedList();
            string[] array1=  new string[3] {"PF","90","8999"};
            string[] array2 = new string[3] { "IICT", "60", "8741" };
            string[] array3 = new string[3] { "OOP", "50", "9000" };           
            string[] array4 = new string[3] { "DS", "40", "9001" };
            obj.InsertAtHead(array1);
            obj.InsertAtHead(array2);
            obj.InsertAtHead(array3);
            obj.InsertAtHead(array4);
            //obj.InsertAtHead(array4);


            Console.WriteLine("Print Forward:");
            obj.PrintFwd();
            Console.WriteLine("\nPrint Backward:");
           // obj.PrintBwd();
            //Console.WriteLine("\nInsert After And Print Backward:");
            //obj.insertafter(20, 200);
            obj.PrintBwd();
            Console.ReadLine();
        }
    }
}
