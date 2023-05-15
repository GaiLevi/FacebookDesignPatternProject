using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class PostAdapter : IPost,IObject
    {
        private readonly FacebookWrapper.ObjectModel.Post r_Post;
        public string m_Id { get; set; }
        public string m_MSG { get; set; }
        public DateTime? m_CreatedTime { get; set; }
        public DateTime? m_LastEditTime { get; set; }
        public string m_PictureUrl { get; set; }
        public List<string> m_Comments { get; set; }

        public PostAdapter(FacebookWrapper.ObjectModel.Post i_Post)
        {
            r_Post = i_Post;
            m_Id = i_Post.Id;
            m_MSG = setPostText(i_Post);
            m_CreatedTime = i_Post.CreatedTime;
            m_LastEditTime = i_Post.UpdateTime;
            m_PictureUrl = i_Post.PictureURL;
        }

        public PostAdapter(string i_Message)
        {
            m_Id = Guid.NewGuid().ToString();
            m_MSG = i_Message;
            m_CreatedTime = DateTime.Now;
            m_LastEditTime = m_CreatedTime;
            m_PictureUrl = null;
            m_Comments = null;
        }

        private string setPostText(FacebookWrapper.ObjectModel.Post i_Post)
        {
            string postText;
            if (i_Post.Message != null)
            {
                postText = string.Format($"{i_Post.Message}");
            }
            else if (i_Post.Caption != null)
            {
                postText = string.Format($"{i_Post.Caption}");
            }
            else
            {
                postText = string.Format($"Uploaded {i_Post.Type}, press to see");
            }

            return postText;
        }

        public void LoadComments()
        {
            if (m_Comments == null)
            {
                m_Comments = new List<string>();
                if (r_Post != null)
                {
                    if (r_Post.Comments.Count > 0)
                    {
                        foreach (FacebookWrapper.ObjectModel.Comment comment in r_Post.Comments)
                        {
                            if (comment != null)
                            {
                                m_Comments.Add(comment.Message);
                            }
                        }
                    }
                    else
                    {
                        m_Comments.Add(string.Format(@"Post has no Comments yet"));
                    }
                }
            }
        }
    }
}
