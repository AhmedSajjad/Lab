﻿using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student s1 = new Student();
            s1.Name = "SAJJAD";
            s1.Id = "18364571";
            s1.Department = "CSE";

            Student s2 = new Student("Jiad", "124124", "EEE");

            Student s3 = new Student("Sajjad", "252645", "CSE");

            //s1.showInfo();

            Book b1 = new Book("book1Name", "book1Author", "3453", "History", 3);

            Book b2 = new Book("book2Name", "book2Author", "5235", "Noble", 5);

            Book b3 = new Book("book3Name", "book3Author", "6264", "Commedy", 2);

            Book b4 = new Book("book4Name", "book4Author", "2345", "Horror", 4);

            Book b5 = new Book("book5Name", "book5Author", "6342", "Adventure", 3);

            Book b6 = new Book("book6Name", "book6Author", "2665", "Commedy", 2);


            s1.BorrowedBook = new Book[] { b1, b2 };
            s2.BorrowedBook = new Book[] { b3, b4, b5 };
            s3.BorrowedBook = new Book[] { b2, b6 };
            

            Library library = new Library("BookHouse", "Kuratoli", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

            library.showAllBooks();
        }
    }
}