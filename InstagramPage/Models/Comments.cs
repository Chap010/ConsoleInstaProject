using System;
namespace InstagramPage.Models
{
    public class Comments
    {
        public Comments()
        {
        }

        public int CommentId { get; set; }
        public string CommentData { get; set; }
        public int UserId { get; set; }


    }
}
