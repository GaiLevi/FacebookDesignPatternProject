using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class GroupAdapter:IGroup
    {
        private readonly FacebookWrapper.ObjectModel.Group r_Group;
        public string m_Id { get; set; }
        public string m_Name { get; set; }
        public string m_PictureUrl { get; set; }
        public string m_Description { get; set; }

        public GroupAdapter(FacebookWrapper.ObjectModel.Group i_Group)
        {
            r_Group = i_Group;
            m_Id = i_Group.Id;
            m_Name = i_Group.Name;
            m_PictureUrl = i_Group.PictureNormalURL;
            m_Description = i_Group.Description ?? string.Format(@"Page has no description");
        }
    }
}
