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

        public Post(string i_Id, string i_Message)
        {
            Id = i_Id;
            Message = i_Message;
        }
    }
}
