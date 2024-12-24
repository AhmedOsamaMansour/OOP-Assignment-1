using Common;
using System.Drawing;
using System.Security;

namespace OOP_Assignment_1
{
    enum Permissions
    {
        Read, write, Delete, Execute
    }
    enum grades
    {
        a=0 , b , c , d , e , f
    }
    enum gender {
        Male=1,Female=2,M=1,F=2
    } 
    enum WeekDays {
        Saturday,Sunday,Monday,Tuesday,Wednesday,Thursday,Friday
    }
    enum Season
    {
        spring, summer, autumn, winter
    }
    enum Colors
    {
        red, green, blue
    }
    internal class Program
    {
        static Permissions userPermissions = Permissions.Read | Permissions.write;

        // Function to add a permission
        static Permissions AddPermission(Permissions permVariable, Permissions perm)
        {
            return permVariable | perm;
        }

        // Function to remove a permission
        static Permissions RemovePermission(Permissions permVariable, Permissions perm)
        {
            return permVariable & ~perm;
        }

        // Function to check if a permission exists
        static bool HasPermission(Permissions permVariable, Permissions perm)
        {
            return (permVariable & perm) == perm;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static double CalculateDistance(PointAssignment p1, PointAssignment p2)
        {
            double temp = (double)Math.Pow(Math.Abs(p1.X - p2.X), 2) + Math.Pow(Math.Abs(p1.Y - p2.Y), 2);
            return Math.Sqrt(temp);
        }
        static void doSomeCode()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine(z);
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
                arr[100] = 45;
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            } 
            catch (Exception e)
            {
                /*
                 exception types:
                1- system exception:
                    1- format exception
                    2- Index out of range exception
                    3- null reference exception
                    4- Invalid operation exception
                    5- arithmetic exception (divided by zero)        
                2- application exception (hardware or software or os or ... exception)
                 
                 */
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            #region Session 06
            #region Demo
            #region Exception Handling and protective code
            //doSomeCode();
            #endregion
            #region access modifiers
            //TypeA obj = new TypeA();
            // obj.z = 1;
            //// obj.y = 2;  invalid
            //// obj.x = 3;  invalid

            #endregion
            #region Enum
            //grades grade = grades.a;
            //if (grade == grades.a)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else {
            //    Console.WriteLine("Bla Bla Bla");
            //}
            //employee e = new employee();
            //e.sex = gender.Male;
            #endregion
            #region Struct
            //point p1;
            ////Console.WriteLine(p1.x); invalid
            //p1 = new point();
            //Console.WriteLine(p1.x);
            //point p2 = new point(5,4);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2);
            #endregion
            #region Encapsulation
            //Employees emp = new Employees(10,"Ahmed",15000);
            //Console.WriteLine(emp);
            //Console.WriteLine(emp.Name);
            //emp.Name = "Ahmed Osama";
            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.getName());
            //emp.setName("Ahmed Osama");
            //Console.WriteLine(emp.getName());
            //emp.Salary = 10;
            //Console.WriteLine(emp.Salary);

            //emp.Age = 10;
            //Console.WriteLine(emp.Age);
            #endregion
            #region Indexer

            #endregion


            #endregion
            #region Assignment
            #region Question 1
            // 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion
            #region Question 2
            // 2-	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person p1 = new Person("Ahmed",25);
            //Person p2 = new Person("Rana", 27);
            //Person p3 = new Person("Ayman",29);
            //Person[] persons = {p1,p2,p3};
            //foreach (Person p in persons)
            //{
            //    Console.WriteLine(p);
            //} 
            #endregion
            #region Question 3
            // 3- Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season = (Season)Enum.Parse(typeof(Season),Console.ReadLine().ToLower(),true);
            //switch (season)
            //{
            //    case Season.spring:
            //        Console.WriteLine("March - April - May");
            //        break;
            //    case Season.summer:
            //        Console.WriteLine("June  - July - August");
            //        break;
            //    case Season.winter:
            //        Console.WriteLine("September  - October - November");
            //        break;
            //    case Season.autumn: 
            //        Console.WriteLine("December  - January - February");
            //        break;
            //    default:
            //        Console.WriteLine("Not Defiend");
            //        break;
            //}
            #endregion
            #region Question 4
            userPermissions = AddPermission(userPermissions, Permissions.Execute);
            Console.WriteLine($"After Adding Execute: {userPermissions}");

            // Remove Write permission
            userPermissions = RemovePermission(userPermissions, Permissions.write);
            Console.WriteLine($"After Removing Write: {userPermissions}");

            // Check if Read permission exists
            Console.WriteLine($"Has Read Permission: {HasPermission(userPermissions, Permissions.Read)}");

            // Check if Delete permission exists
            Console.WriteLine($"Has Delete Permission: {HasPermission(userPermissions, Permissions.Delete)}");
            #endregion
            #region Question 5
            // 5- Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //string input = Console.ReadLine().ToLower();

            //if (Enum.TryParse(typeof(Colors), input, true, out object colorObj))
            //{
            //    Colors color = (Colors)colorObj;

            //    if (color == Colors.red || color == Colors.blue || color == Colors.green)
            //    {
            //        Console.WriteLine("primary color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("not primary color");
            //}

            #endregion
            #region Question 6
            // 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //PointAssignment p1 = new PointAssignment(0, 0);
            //PointAssignment p2 = new PointAssignment(8, 5);
            //Console.WriteLine(CalculateDistance(p1, p2));
            #endregion
            #region Question 7
            // 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //PersonAssignment[] persons;
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //PersonAssignment p1 = new PersonAssignment(name , age);
            //name = Console.ReadLine();
            //age = int.Parse(Console.ReadLine());
            //PersonAssignment p2 = new PersonAssignment(name, age);
            //name = Console.ReadLine();
            //age = int.Parse(Console.ReadLine());
            //PersonAssignment p3 = new PersonAssignment(name, age);
            //persons = new PersonAssignment [] {p1,p2,p3};
            //if (persons[0].Age > persons[1].Age && persons[0].Age > persons[2].Age)
            //{
            //    Console.WriteLine($"oldest person = {persons[0].Name} - {persons[0].Age}");
            //}
            //else if (persons[1].Age > persons[0].Age && persons[1].Age > persons[2].Age)
            //{
            //    Console.WriteLine($"oldest person = {persons[1].Name} - {persons[1].Age}");
            //}
            //else
            //{
            //    Console.WriteLine($"oldest person = {persons[2].Name} - {persons[2].Age}");
            //}
            #endregion
            /*
             * 
             */
            #endregion
            #endregion

        }
    }
}
