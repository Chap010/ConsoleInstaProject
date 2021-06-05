using System;
namespace InstagramPage
{
    public class Users
    {


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Role { get; internal set; }     // admin = 0  non admin = 1
        // public string Post { get; internal set;} // delete after not useful
        public string CommentData { get; set; }
        public string Password { get; set; }
        private string HashPassword { get; set; }


        /*  public void HashPassword();
            userList.Add(new Users("rosewell1151"));
            userList.Add(new Users("electro70"));
            userList.Add(new Users("maxjonson"));
            userList.Add(new Users("kevinhurt"));
            userList.Add(new Users("Pure41"));
            userList.Add(new Users("ipsec"));
            userList.Add(new Users("floydmoney"));
            userList.Add(new Users("rose"));
            userList.Add(new Users("admin"));
            userList.Add(new Users("zero01"));        */
    }
}
