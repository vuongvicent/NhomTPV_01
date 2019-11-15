using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of student:");
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k+ c: comment
            //ctrl+k+u: uncomment
            //ctrl+k+d: lam dep code, format code
            int numOfStudent;
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());
                //ham Pare chuyen tu kieu String sang kieu so
                InputStudentList(numOfStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input!");
            }
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danhs sach sinh vien
            Student[] studentList = new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("Fullname = ");
                student.FullName = string.Format(Console.ReadLine());
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Faculty = ");
                student.Faculty = string.Format(Console.ReadLine());
                studentList[i] = student;
            }
        }
    }
}
