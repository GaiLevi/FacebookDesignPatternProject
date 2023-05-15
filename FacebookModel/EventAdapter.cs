using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class EventAdapter : IEvent
    {
        private readonly FacebookWrapper.ObjectModel.Event r_Event;
        public string m_Id { get; set; }
        public string m_Name { get; set; }
        public string m_PictureUrl { get; set; }
        public string m_Description { get; set; }

        public EventAdapter(FacebookWrapper.ObjectModel.Event i_Event)
        {
            r_Event = i_Event;
            m_Id = i_Event.Id;
            m_Name = i_Event.Name;
            m_PictureUrl = i_Event.PictureNormalURL;
            m_Description = i_Event.Description ?? string.Format(@"Event has no description");
        }
    }
}
