using System.Runtime.Intrinsics.X86;

namespace assignment4
{
    internal class Program
        {

            static void Main(string[] args)
            {


            #region part1
            //Question 1:
            //What is the primary purpose of an interface in C#?

            //b) To define a blueprint for a class


            //    Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private



            //Question 3:
            //Can an interface contain fields in C#?

            //b) No


            //Question 4:
            //In C#, can an interface inherit from another interface?

            //b) Yes, interfaces can inherit from multiple interfaces


            //qustion 5

            //Which keyword is used to implement an interface in a class in C#?

            //d) implements


            //QUESTION 6 
            //Can an interface contain static methods in C#?
            //a) Yes


            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?

            //b) No, all members are implicitly public


            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?

            //b) To provide a clear separation between interface and class members



            //Question 9:
            //In C#, can an interface have a constructor?

            //b) No, interfaces cannot have constructors




            //Question 10:
            //How can a C# class implement multiple interfaces?

            //c) By separating interface names with commas




            #endregion

            #region part 2

            #region question 1

            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(10, 5);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();


            #endregion


            #region question 2
            Console.WriteLine("enter your user name");
            string userName = Console.ReadLine();


            Console.WriteLine("enter your Password");
            string password = Console.ReadLine();



            BasicAuthenticationService basicAuthentication = new BasicAuthenticationService(userName,password);
            basicAuthentication.AuthenticateUser();
            basicAuthentication.AuthorizeUser();

            




            #endregion
            #endregion


        }
        }
    }

