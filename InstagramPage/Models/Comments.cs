using System;
namespace InstagramPage.Models
{
    public class Comments
    {
        public Comments()
        {
        }

        public int UserId { get; set; }
        public string CommentData { get; set; }
        public int CommentId { get; internal set; }
    }
}
