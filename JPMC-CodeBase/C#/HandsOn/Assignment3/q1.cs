using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class q1
{
    class User
    {
        public string userId;
        public string dob;
        public string fullname, gender, emailid, password;
        public User()
        {
            userId = "1234";
            dob = "22.03.2000";
            fullname = "John Wick";
            gender = "Male";
            emailid = "jjdjkjidj";
            password = "hduhiuhuie";

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
        public void createUser(User user)
        {
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
                user.userId = "12345";
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
                user.password = "hiudiuefiH12";
            }
        }
        public void showUserDetails(User user)
        {
            Console.WriteLine("Id= {0} DOB= {1} FullName= {2} Gender= {3} Email= {4}", user.userId, user.dob, user.fullname, user.gender, user.emailid);
        }
    }
    static void Main()
    {
        User u = new User();
        UserManager um = new UserManager();
        um.createUser(u);
        um.showUserDetails(u);
    }
}
}
