using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class q1
    {
        class User
        {
            public int userId;
            public string dob;
            public string username;
            public string guardianName;
            public char gender;
            public User()
            {

            }
            public User(int i,string d,string u,string g,char ge)
            {
                userId = i;
                dob = d;
                username = u;
                guardianName = g;
                gender = ge;
            }


        }
        class UserManager
        {
            public void createUser(User user)
            {
                user.userId = 123;
                user.dob = "22.01.2000";
                user.username = "harshitgarg3103";
                user.guardianName = "Manoj";
                user.gender = 'M';
            }
            public void showDetails(User user)
            {
                Console.WriteLine("Id= {0} Username= {1} GuardianName= {2} Gender= {3} DOB= {4}",user.userId,user.username,user.guardianName,user.gender,user.dob);
            }
        }
        static void Main(string[]args)
        {
            User user=new User();
            UserManager u = new UserManager();
            u.createUser(user);
            u.showDetails(user);
        }
    }
}
