using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IEvent : IObject
    {
        string m_Name { get; set; }
        string m_PictureUrl { get; set; }
    }
}
