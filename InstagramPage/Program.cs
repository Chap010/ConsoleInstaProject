using System;
using System.Collections.Generic;
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
            List<Comments> CommentList = new List<Comments>();



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

                        foreach (var myUser in userList)
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