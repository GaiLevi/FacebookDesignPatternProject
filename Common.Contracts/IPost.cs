using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IPost : IObject
    {
        string m_MSG { get; set; }
        DateTime? m_CreatedTime { get; set; }
        DateTime? m_LastEditTime { get; set; }
        string m_PictureUrl { get; set; }
        List<string> m_Comments { get; set; }
        void LoadComments();
    }
}
