using System;
namespace InstagramPage
{
    public class Users
    {


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; internal set; }
        public string Post { get; internal set; }
        public string CommentData { get; set; }
        public string Password { get; set; }
        
        private string HashPassword { get; set; }
        //public void HashPassword();
    }

}
