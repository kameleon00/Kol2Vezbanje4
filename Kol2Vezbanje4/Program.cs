using System;
using System.Collections;
using System.Collections.Generic;

namespace Kol2Vezbanje4
{
    class Program
    {
        static void Main(string[] args)
        {
            //KREIRANJE ISTANCI KLASE STUDENT
            Student s1 = new Student("Marko" ,"Djokic", 75);
            Student s2 = new Student("Marko ","Mitrovic", 95);
            Student s3 = new Student("Stefan"," Majkic", 75);
            Student s4 = new Student("Filip"," Rajcetic", 35);
            Student s5 = new Student("Irina ","Lakovic", 65);

            Stack<Student> studenti = new Stack<Student>();
            studenti.Push(s1);
            studenti.Push(s2);
            studenti.Push(s3);          //DODAVANJE STUDENATA U STEK
            studenti.Push(s4);
            studenti.Push(s5);
            
            // Ispis elemenata steka
            Console.WriteLine("Ispis steka nakon dodavanja elemenata: ");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student  in studenti)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("==================================================");
            Console.WriteLine();
            
            // Uklanjanje elementa iz steka
            studenti.Pop();
            
            // Ispis elemenata steka
            Console.WriteLine("Ispis steka nakon brisanja elementa: ");
            Console.WriteLine("-------------------------------------------------");
            foreach (var student  in studenti)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("==================================================");
        }
    }
}