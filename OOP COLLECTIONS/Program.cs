using System;
using System.Collections.Generic;

namespace OOP_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O'quvchi raqamini kiriting: ");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Iltimos, raqam kiriting: ");
            }

            StudentCollection studentCollection = new StudentCollection();
            studentCollection.PrintStudentName(input);

            Console.ReadKey();
        }
    }
    public class StudentCollection
    {
        private Dictionary<int, string> students;

        public StudentCollection()
        {
            students = new Dictionary<int, string>
            {
                { 1, "Abdulloh Halilov" },
                { 2, "Abdumuhtorov Xojianvar" },
                { 3, "Ahrorbek Yuldashboyev" },
                { 4, "Asadbek Murodaliyev" },
                { 5, "Asatov Ergash" },
                { 6, "Avazbek Muqumjonov" },
                { 7, "Azamat Giyosov" },
                { 8, "Aziz Samadov" },
                { 9, "Diyorbek Axmatov" },
                { 10, "G'offorov Humpyunmirzo" },
                { 11, "Maxmarajapov Dilshodbek" },
                { 12, "Nurbek Axmatov" },
                { 13, "Quvonchbek Abduroziqov" },
                { 14, "Rustambek Xayrullayev" },
                { 15, "Sharafiddin Muxtorov" },
                { 16, "Sharifov Muhammadali" },
                { 17, "Temurbek Amirov" },
                { 18, "Toleyorbek Berdiyev" },
                { 19, "Tursunboy Rahimjonov" },
                { 20, "Xurramov Chingizbek" },
                { 21, "Xusan Do'stmurodov" },
                { 22, "Zarina Uralova" },
                { 23, "Zikrillo Muhammadjonov" },
                { 24, "Abdumajidov Mahmudjon" }
            };
        }

        public void PrintStudentName(int number)
        {
            if (students.TryGetValue(number, out string name))
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Berilgan raqamga ega o'quvchi yo'q");
            }
        }
    }

}
