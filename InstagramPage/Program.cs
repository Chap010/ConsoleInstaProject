using System;
using System.Collections.Generic;
using System.Linq;
using InstagramPage;
using InstagramPage.Models;



namespace MyGrem
{
    class Program
    {
        static void Main()

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
            myfourUser.Role = 4;

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
            mytenUser.Role = 1;



            List<Users> result = userList.Where(user => user.Role == 1).ToList();
            foreach(var user in result)
            {
                Console.WriteLine(user.UserName);
                Console.WriteLine(user.CommentData);
            }

            ////                            ////



            List<Comments> CommentList = new List<Comments>();

            /*  
                        10 Users
            userList.Add(new Users("rosewell1151"));
            userList.Add(new Users("electro70"));
            userList.Add(new Users("maxjonson"));
            userList.Add(new Users("kevinhurt"));
            userList.Add(new Users("Pure41"));
            userList.Add(new Users("ipsec"));
            userList.Add(new Users("floydmoney"));
            userList.Add(new Users("rose"));
            userList.Add(new Users("mohamedraj"));
            userList.Add(new Users("zero01"));

            */

            while (mySelection != "5")
            {
                Console.WriteLine("Select 1: User Registration ");
                Console.WriteLine("Select 2: To Create a Comment ");
                Console.WriteLine("Select 3: Print User List ");
                Console.WriteLine("Select 4: Print Comment List");
                Console.WriteLine("Select 5: To Exit ");

                Console.WriteLine("");
                Console.WriteLine("SELECT ONLY WITH NUMBERS");

                mySelection = Console.ReadLine();



                switch (mySelection)
                {
                    case "1":
                        Users myuser = new Users();
                        userList.Add(myuser);
                        myuser.Email = "chicharones@rtx.com";
                        myuser.Password = "bochito2351";
                        myuser.UserId = 1;
                        myuser.UserName = "rosewell51";

                        Console.WriteLine("You Created A Username!");
                        break;


                    case "2":


                        Comments myComment = new Comments();
                        CommentList.Add(myComment);
                        myComment.CommentID = 1;
                        myComment.CommentData = "Hey Bro";

                        Console.WriteLine("You Created A Comment hoorah!");

                        break;


                    case "3":
                        Console.WriteLine("Current User List: ");

                        foreach (Users myUser in userList)
                        {
                            userList.Add(myUser);
                            Console.WriteLine("Email: " + myUser.Email);
                            Console.WriteLine("HashPass: " + myUser.Password);
                            Console.WriteLine("ID: " + myUser.UserId);
                            Console.WriteLine("Username: " + myUser.UserName);


                        }
                        break;

                    case "4":
                        Console.WriteLine("Current Comments List: ");

                        foreach (var InsideComment in CommentList)
                        {
                            Console.WriteLine("CommentID: " + InsideComment.CommentID);
                            Console.WriteLine("Data: " + InsideComment.CommentData);

                        }
                        break;


                        //   case "5":
                        //     Exit();
                        //    break;

                }

            }
        }
    }
}