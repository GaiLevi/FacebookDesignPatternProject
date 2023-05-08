using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class PageAdapter:IPage
    {
        private FacebookWrapper.ObjectModel.Page m_Page;
        public string m_Id { get; set; }
        public string m_Name { get; set; }
        public string m_PictureUrl { get; set; }
        public string m_Description { get; set; }

        public PageAdapter(FacebookWrapper.ObjectModel.Page i_Page)
        {
            m_Page = i_Page;
            m_Id = i_Page.Id;
            m_Name = i_Page.Name;
            m_PictureUrl = i_Page.PictureNormalURL;
            m_Description = i_Page.Description;
        }
    }
}
