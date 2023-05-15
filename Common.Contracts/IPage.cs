using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IPage : IObject
    {
        string m_Name { get; set; }
        string m_PictureUrl { get; set; }
        string m_Description { get; set; }
    }
}
