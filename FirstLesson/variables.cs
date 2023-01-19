//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstLesson
//{
//    internal class variables
//    {
//        struct Employee
//        {
//            public int id;
//        }

//// declare emp of struct Employee
//Employee emp;

//        // access member of struct      
//        emp.id = 1;
//    }
//}

using System;
namespace CsharpStruct
{

    // defining struct
    struct Employee
    {
        public int id;

        public void getId(int id)
        {
            Console.WriteLine("Employee Id: " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // declare emp of struct Employee
            Employee emp;

            // accesses and sets struct field
            emp.id = 1;

            // accesses struct methods
            emp.getId(emp.id);

            Console.ReadLine();
        }
    }
}