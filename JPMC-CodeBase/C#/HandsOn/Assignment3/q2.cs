using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class q2
    {
        class User
        {
            public string userId;
            public string dob;
            public string fullname, gender, emailid, password;
            public User()
            {
                userId = "123456";
                dob = "22.03.2000";
                fullname = "John Wick";
                gender = "Male";
                emailid = "jjdjkjidj";
                password = "hduhiuhuieH12";
            }
        }
        class UserConsole
        {
            public User acceptUserDetails()
            {
                User u = new User();
                return u;
            }
            public void showUserDetails(User user)
            {
                Console.WriteLine("Id= {0} DOB= {1} FullName= {2} Gender= {3} Email= {4}", user.userId, user.dob, user.fullname, user.gender, user.emailid);
            }
            public void printMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
        class UserManager
        {
            public class InvalidPasswordException : Exception
            {
                public InvalidPasswordException(string message) : base(message) { }
            }
            public class InvalidUserIdException : Exception
            {
                public InvalidUserIdException(string message) : base(message) { }
            }
            UserConsole us = new UserConsole();
            public void createUser()
            {
                User user=us.acceptUserDetails();
                try
                {
                    if (user.userId.Length < 5)
                    {
                        throw (new InvalidUserIdException("Invalid Id"));
                    }
                }
                catch (InvalidUserIdException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    var hasNumber = new Regex(@"[0-9]+");
                    if (user.password.Length < 5 || !user.password.Any(char.IsUpper) || !user.password.Any(char.IsLower) || !hasNumber.IsMatch(user.password))
                    {
                        throw (new InvalidPasswordException("Invalid password"));
                    }
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    us.showUserDetails(user);
                    us.printMessage("Welcome user");
                }
            }
        }
        
        static void Main()
        {
            UserManager um = new UserManager();
            um.createUser();
        }
    }
}

