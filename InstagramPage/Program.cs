using System;
using System.Collections.Generic;
using System.Linq;
using InstagramPage;
using InstagramPage.Models;
using static MyGrem.Program.MyUSerDefinedException;

namespace MyGrem
{
    class Program
    {
        static void Main()

        {
            NewClass<int> newClass = new NewClass<int>();
            newClass.Genericproperty = 23;
            newClass.NormalProperty = "Jordan";
            Console.WriteLine(newClass.NormalProperty + " Known as: " + newClass.Genericproperty);

            Console.WriteLine("");

            NormalClass myclase = new NormalClass();
            myclase.Something<int>(777, 999);            // normal generic method





            try
            {
                string mySelection = "";

                List<Users> userList = new List<Users>();
                Users myfirstUser = new Users();
                userList.Add(myfirstUser);
                myfirstUser.UserName = ("rosewell1151");
                myfirstUser.UserId = 1;
                myfirstUser.Email = "rosewell@grem.com";
                myfirstUser.CommentData = "Hello Im New :D";
                myfirstUser.Password = "Passw9dh2d";
                myfirstUser.Role = 1;                           //non-admin = 1 and Admin = 0

                Users mySecondUser = new Users();
                userList.Add(mySecondUser);
                mySecondUser.UserName = ("electro70");
                mySecondUser.UserId = 2;
                mySecondUser.Email = "electro70@grem.com";
                mySecondUser.CommentData = "What to do today?";
                mySecondUser.Password = "SE%GSCROS";
                mySecondUser.Role = 1;

                Users mythirdUser = new Users();
                userList.Add(mythirdUser);
                mythirdUser.UserName = ("maxjonson");
                mythirdUser.UserId = 3;
                mythirdUser.Email = "maxjonson@grem.com";
                mythirdUser.CommentData = "Learning to Code";
                mythirdUser.Password = "GOOWqwerty";
                mythirdUser.Role = 1;

                Users myfourUser = new Users();
                userList.Add(myfourUser);
                myfourUser.UserName = ("Pure41");
                myfourUser.UserId = 2;
                myfourUser.Email = "Pure41@grem.com";
                myfourUser.CommentData = "raining";
                myfourUser.Password = "1drowassap";
                myfourUser.Role = 1;

                Users myfiveUser = new Users();
                userList.Add(myfiveUser);
                myfiveUser.UserName = ("ipsec");
                myfiveUser.UserId = 5;
                myfiveUser.Email = "ipsec@grem.com";
                myfiveUser.CommentData = "stressfull";
                myfiveUser.Password = "IgotPwned";
                myfiveUser.Role = 1;

                Users mySixUser = new Users();
                userList.Add(mySecondUser);
                mySixUser.UserName = ("kevinhurt");
                mySixUser.UserId = 6;
                mySixUser.Email = "kevinhurt@grem.com";
                mySixUser.CommentData = "New show coming soon";
                mySixUser.Password = "1Sup3rH4rdp4ss";
                mySixUser.Role = 1;

                Users mySevenUser = new Users();
                userList.Add(mySecondUser);
                mySevenUser.UserName = ("floydmoney");
                mySevenUser.UserId = 7;
                mySevenUser.Email = "floydmoney@grem.com";
                mySevenUser.CommentData = "I need morecafeine";
                mySevenUser.Password = "Passwor34";
                mySevenUser.Role = 1;

                Users myeightUser = new Users();
                userList.Add(mySecondUser);
                myeightUser.UserName = ("rose");
                myeightUser.UserId = 8;
                myeightUser.Email = "rose@grem.com";
                myeightUser.CommentData = "HALF MOON Tomorrow WOW!";
                myeightUser.Password = "1drowassapoujp";
                myeightUser.Role = 1;

                Users mynineUser = new Users();
                userList.Add(mynineUser);
                mynineUser.UserName = ("mohamedraj");
                mynineUser.UserId = 9;
                mynineUser.Email = "mohamedraj@grem.com";
                mynineUser.CommentData = "Long Hours";
                mynineUser.Password = "jsdasdft";
                mynineUser.Role = 1;

                Users mytenUser = new Users();
                userList.Add(mytenUser);
                mytenUser.UserName = ("zero01");
                mytenUser.UserId = 10;
                mytenUser.Email = "zero01@grem.com";
                mytenUser.CommentData = ":)";
                mytenUser.Password = "Ilovemydog123";
                mytenUser.Role = 1;                                                     // Role 0 = admin and 1 = non-admin



                List<Users> result = userList.Where(user => user.UserId <= 10).ToList();

                if (result.Count == 0)
                {
                    // Console.WriteLine("User Admin Not Found");
                    //string myformating = "User Properties:" + "Email: {0}, UserId: {1}, Password: {2}, UsernName:{3}, UserRole: {4}";
                    throw new MyUSerDefinedException("ADMIN USER NOT FOUND");
                }

                else
                {
                    for (int i = 0; i < result.Count; i++)

                    {
                        Users myUser = userList[i];
                        userList.Add(myUser);
                        Console.WriteLine("Email: " + myUser.Email);
                        Console.WriteLine("HashPass: " + myUser.Password);
                        Console.WriteLine("ID: " + myUser.UserId);
                        Console.WriteLine("Username: " + myUser.UserName);
                        Console.WriteLine("Role:" + myUser.Role);
                    }


                }
            }


            catch (MyUSerDefinedException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            finally
            {
                Console.WriteLine("Grem has Ended");
            }
        }


        public class NewClass<T>
        {
            public string NormalProperty { get; set; }
            public T Genericproperty { get; set; }
        }


        public class MyUSerDefinedException : Exception
        {
            public MyUSerDefinedException(string errorMessage) : base(errorMessage)
            {

            }

            public class NormalClass
            {
                public void Something<T>(int parametro1, T parametro2)
                    {
                    Console.WriteLine("Parametes Values: ");
                    Console.WriteLine(parametro1);
                    Console.WriteLine(parametro2);

                }
            }
        }

    }
}