using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class PostAdapter : IPost
    {
        private FacebookWrapper.ObjectModel.Post m_Post;
        public string m_Id { get; set; }
        public string m_MSG { get; set; }
        public DateTime? m_CreatedTime { get; set; }
        public DateTime? m_LastEditTime { get; set; }
        public string m_PictureUrl { get; set; }
        public List<string> m_Comments { get; set; }

        //public PostAdapter()
        //{
        //    m_Comments = new List<string>();
        //}

        public PostAdapter(FacebookWrapper.ObjectModel.Post i_Post)
        {
            m_Post = i_Post;
            m_Id = i_Post.Id;
            m_MSG = i_Post.Message;
            m_CreatedTime = i_Post.CreatedTime;
            m_LastEditTime = i_Post.UpdateTime;
            m_PictureUrl = i_Post.PictureURL;
        }

        public void LoadComments()
        {
            if(m_Comments == null)
            {
                m_Comments = new List<string>();
                if (m_Post.Comments.Count != 0)
                {
                    foreach (FacebookWrapper.ObjectModel.Comment comment in m_Post.Comments)
                    {
                        if (comment != null)
                        {
                            m_Comments.Add(comment.Message);
                        }
                    }
                }
            }
        }
    }
}
