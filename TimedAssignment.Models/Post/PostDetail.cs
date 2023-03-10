using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAssignment.Models.Post
{
    public class PostDetail
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTimeOffset DateCreated { get; set; }
    }
}