using System;
namespace InstagramPage
{
    public class User
    {
        public Users()
        {

        }


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string Role { get; internal set; }
        public string Post { get; internal set; }
        public string CommentData { get; set; }
        public string Password { get; set; }
        private string HashPassword { get; set; }


        public void HashPassword();
        {
            this.EncryptedPassword =/*Hash as234k2kkjh2k3jk3jnwe9skLOL*/ ;
        }

 


    }
}
