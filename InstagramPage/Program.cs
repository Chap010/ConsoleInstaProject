using System;
using System.Collections.Generic;
using System.Linq;
using InstagramPage;
using InstagramPage.Models;
using static MyGrem.MyUSerDefinedException;


namespace MyGrem
{
    class Program
    {


        static void Main()

        {
            try {
                string mySelection = "";
                List<Users> userList = new List<Users>();
                List<Comments> CommentList = new List<Comments>();
                NewClass<String> newClass = new NewClass<String>();
                newClass.Genericproperty = "Mr Sosa";
                newClass.NormalProperty = "Credits: Thanks To my Mentor Mario Sosa";
                Console.WriteLine(newClass.NormalProperty + " Known as " + newClass.Genericproperty);

                Console.WriteLine("");

                NormalClass myclase = new NormalClass();
                myclase.Something<string>("Traveler This is my Grem", "Please Select an OPTION!");            // normal generic method


                while (mySelection != "7")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Select 1: User Registration ");
                    Console.WriteLine("Select 2: To Create a Comment ");
                    Console.WriteLine("Select 3: Print User List ");
                    Console.WriteLine("Select 4: Print Comment List ");
                    Console.WriteLine("Select 5: User Search ");
                    Console.WriteLine("Select 6: Comment Search ");
                    Console.WriteLine("Select 7: To Exit ");



                    mySelection = Console.ReadLine();

                    switch (mySelection)
                    {
                        case "1":
                            userList.Where(user => user.UserName == "").ToList();
                            Users myfirstUserComment = new Users();                                // USER LIST
                            userList.Add(myfirstUserComment);
                            myfirstUserComment.UserName = "rosewell1151";
                            myfirstUserComment.UserId = 1;
                            myfirstUserComment.Email = "rosewell@grem.com";
                            myfirstUserComment.Password = "Passw9dh2d";


                            Users mySecondUser = new Users();
                            userList.Add(mySecondUser);
                            mySecondUser.UserName = "electro70";
                            mySecondUser.UserId = 2;
                            mySecondUser.Email = "electro70@grem.com";
                            mySecondUser.Password = "SE%GSCROS";


                            Users mythirdUser = new Users();
                            userList.Add(mythirdUser);
                            mythirdUser.UserName = "maxjonson";
                            mythirdUser.UserId = 3;
                            mythirdUser.Email = "maxjonson@grem.com";
                            mythirdUser.Password = "GOOWqwerty";

                            Users myfourUser = new Users();
                            userList.Add(myfourUser);
                            myfourUser.UserName = "Pure41";
                            myfourUser.UserId = 4;
                            myfourUser.Email = "Pure41@grem.com";
                            myfourUser.Password = "1drowassap";

                            Users myfiveUser = new Users();
                            userList.Add(myfiveUser);
                            myfiveUser.UserName = ("ipsec");
                            myfiveUser.UserId = 5;
                            myfiveUser.Email = "ipsec@grem.com";
                            myfiveUser.Password = "IgotPwned";

                            Users mySixUser = new Users();
                            userList.Add(mySecondUser);
                            mySixUser.UserName = "kevinhurt";
                            mySixUser.UserId = 6;
                            mySixUser.Email = "kevinhurt@grem.com";
                            mySixUser.Password = "1Sup3rH4rdp4ss";

                            Users mySevenUser = new Users();
                            userList.Add(mySecondUser);
                            mySevenUser.UserName = "floydmoney";
                            mySevenUser.UserId = 7;
                            mySevenUser.Email = "floydmoney@grem.com";
                            mySevenUser.Password = "Passwor34";

                            Users myeightUser = new Users();
                            userList.Add(mySecondUser);
                            myeightUser.UserName = "rose";
                            myeightUser.UserId = 8;
                            myeightUser.Email = "rose@grem.com";
                            myeightUser.Password = "1drowassapoujp";

                            Users mynineUser = new Users();
                            userList.Add(mynineUser);
                            mynineUser.UserName = "mohamedraj";
                            mynineUser.UserId = 9;
                            mynineUser.Email = "mohamedraj@grem.com";
                            mynineUser.Password = "jsdasdft";

                            Users mytenUser = new Users();
                            userList.Add(mytenUser);
                            mytenUser.UserName = "zero01";
                            mytenUser.UserId = 10;
                            mytenUser.Email = "zero01@grem.com";
                            mytenUser.Password = "Ilovemydog123";

                            Console.WriteLine("You Created A User Welcome!");

                            break;

                        case "2":                                                                   //COMMENT LIST

                            Comments myfirstUserComment1 = new Comments();
                            CommentList.Add(myfirstUserComment1);
                            myfirstUserComment1.CommentData = "Hello Im New :D";
                            myfirstUserComment1.CommentId = 1;
                            myfirstUserComment1.UserId = 1;

                            Comments mySecondUserComment = new Comments();
                            CommentList.Add(mySecondUserComment);
                            mySecondUserComment.CommentData = "What to do today?";
                            mySecondUserComment.CommentId = 2;
                            mySecondUserComment.UserId = 2;

                            Comments mythirdUserComment = new Comments();
                            CommentList.Add(mythirdUserComment);
                            mythirdUserComment.CommentData = "Learning to Code";
                            mythirdUserComment.CommentId = 3;
                            mythirdUserComment.UserId = 3;

                            Comments myfourUserComment = new Comments();
                            CommentList.Add(myfourUserComment);
                            myfourUserComment.CommentData = "raining";
                            myfourUserComment.CommentId = 4;
                            myfourUserComment.UserId = 4;

                            Comments myfiveUserComment = new Comments();
                            CommentList.Add(myfiveUserComment);
                            myfiveUserComment.CommentData = "stressfull makes you stronger";
                            myfiveUserComment.CommentId = 5;
                            myfiveUserComment.UserId = 5;
                            Comments mysixUserComment = new Comments();
                            CommentList.Add(mysixUserComment);
                            mysixUserComment.CommentData = "New show coming soon";
                            mysixUserComment.CommentId = 6;
                            mysixUserComment.UserId = 6;

                            Comments mysevenUserComment = new Comments();
                            CommentList.Add(mysevenUserComment);
                            mysevenUserComment.CommentData = "I need more cafeine";
                            mysevenUserComment.CommentId = 7;
                            mysevenUserComment.UserId = 7;

                            Comments myeightUserComment = new Comments();
                            CommentList.Add(myeightUserComment);
                            myeightUserComment.CommentData = "HALF MOON Tomorrow WOW!";
                            myeightUserComment.CommentId = 8;
                            myeightUserComment.UserId = 8;

                            Comments mynineUserComment = new Comments();
                            CommentList.Add(mynineUserComment);
                            mynineUserComment.CommentData = "Long Hours";
                            mynineUserComment.CommentId = 9;
                            mynineUserComment.UserId = 9;

                            Comments mytenUserComment = new Comments();
                            CommentList.Add(mytenUserComment);
                            mytenUserComment.CommentData = ":)";
                            mytenUserComment.CommentId = 10;
                            mytenUserComment.UserId = 10;


                            Console.WriteLine("You Created A Comment Hoorah!");

                            break;

                        case "3":                                                                   //USER Output
                            Console.WriteLine("Current User List: ");

                            foreach (Users myUser in userList)
                            {

                                Console.WriteLine("Username: " + myUser.UserName);
                                Console.WriteLine("ID: " + myUser.UserId);

                                Console.WriteLine("Email: " + myUser.Email);
                                Console.WriteLine("HashPass: " + myUser.Password);




                            }
                            break;

                        case "4":                                                                  //Comment Output
                            Console.WriteLine("Current Comments List: ");
                            foreach (var InsideComment in CommentList)

                            {
                                Console.WriteLine("");
                                Console.WriteLine("UserID: " + InsideComment.UserId);
                                Console.WriteLine("CommentID: " + InsideComment.CommentId);
                                Console.WriteLine("Data: " + InsideComment.CommentData);

                            }

                            break;
                        case "5":                                                                     //USER Search
                            Console.WriteLine("Search A User: ");
                            foreach (var myUser in userList)
                                userList.Where(user => user.UserName == "pablo").ToList();
                            if (userList.Count > 0)
                                {
                                    Console.WriteLine("USER FOUND");
                                    string format0 = "USER Properties = " + "UserName: {0}, UserId: {1},  Email:{2},";
                                    foreach (var user in userList)
                                    {
                                        Console.WriteLine(format0, user.UserName, user.UserId, user.Email);
                                    }
                                }
                                else
                                {
                                    throw new MyUSerDefinedException("USER NOT FOUND");
                                }


                            break;

                        case "6":                                                                    //Comment Search
                            Console.WriteLine("Search A Comments : ");
                            foreach (var InsideComment in CommentList)
                                CommentList.Where(user => user.CommentData =="Hey").ToList();

                            if (CommentList.Count > 0)
                                {
                                    Console.WriteLine("COMMENTS FOUND");
                                    string format1 = "Comment Data :" + "UserId: {0},  CommentData: {1},";
                                    foreach (var user in CommentList)
                                    {
                                        Console.WriteLine(format1, user.UserId, user.CommentData);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("COMMENT NOT FOUND");
                                }
                            break;


                            List<Users> userresult = userList.Where(user => user.UserId <= 1).ToList();

                            List<Comments> commentresult = CommentList.Where(user => user.CommentId <= 10).ToList();

                    }



                }
            }
            catch(MyUSerDefinedException Exeption)
            {
                Console.WriteLine(Exeption.Message);
            }
            finally
            {
                Console.WriteLine("Prgram Has Ended");
            }
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
            public void Something<T>(string parametro1, T parametro2)
            {
                Console.WriteLine(" ~~~ Welcome ~~~  ");
                Console.WriteLine(parametro1);
                Console.WriteLine(parametro2);

            }

        }
    }
        }


