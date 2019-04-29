using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Muhammad Khan
//Homework 2
//Date: 04/18/2019

namespace Homework02
{
    class Program
    {       
        static void Main(string[] args)
        {
            List<Models.User> users = new List<Models.User>();
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            var passwords = from pwd in users where pwd.Password == "hello" select pwd.Password;
            Console.WriteLine("All the passwords that are hello");
            foreach (string pwd in passwords)
                Console.WriteLine(pwd);
            Console.WriteLine("Lowercase name passwords are deleted");
            users.RemoveAll(item => item.Password == item.Name.ToLower());
            Console.WriteLine("Deleting the first hello password  ");
            var firstPwd = from pwd in users where pwd.Password == "hello" select pwd;
            users.Remove(firstPwd.First());
            Console.WriteLine("Display the name(s) and the password(s)");
            foreach (var usr in users)
                Console.WriteLine("Name: " + usr.Name + " " +"Password: "+ usr.Password);
        }
    }
}
