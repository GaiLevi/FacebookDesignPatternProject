using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class Post
    {
        public string Id { get; set; }
        public string Message { get; set; }

        public Post(string id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}
