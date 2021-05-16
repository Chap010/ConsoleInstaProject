using System;
using InstagramPage.Models;
using InstagramPage.DTOS;

namespace InstagramPage
{
    class Program
    {
        

        static void Main(string[] args)
        {
            User Instagram = new User ();
            Instagram.UserId = 900;
            Instagram.UserName = "The Rock";
            Instagram.Role = "Movie Star";
            Instagram.Post ="Helping The Poor ";
            Instagram.CommentData ="@therock your the best";
            Instagram.email = "therock@celebrity.com";


            User Instagram = new User();
            Instagram.UserId = 700;
            Instagram.UserName = "Kevin Hart";
            Instagram.Role = "Comedian";
            Instagram.Post = "New Movie Coming soon ";
            Instagram.CommentData = "Great";
            Instagram.email = "kevinhartComedian@celebrity.com";
            Console.WriteLine(Instagram);


            User adminUser = new User();
            adminUser.UserId = 0;
            adminUser.UserName = "Don Pepe";
            adminUser.Password = "Admin123";
            adminUser.HashPassword();



            /*UserDTO newDTOUser = new UserDTO();    
            newDTOUser.cakeId = 10;
            neWDTOUser.Form ="square";
            */
        }
    }

}




