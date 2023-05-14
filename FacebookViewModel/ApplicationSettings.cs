using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Threading.Tasks;
using FacebookModel;

namespace FacebookViewModel
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;
        private static ApplicationSettings s_This;
        public bool m_AutoLogin { get; set; } 
        public string m_AccessToken { get; set; }

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        private ApplicationSettings()
        {
        }

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = ApplicationSettings.FromFileOrDefault();
                }

                return s_This;
            }
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static ApplicationSettings FromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new ApplicationSettings()
                                 {
                                     m_AutoLogin = false,
                                 };
            }

            return loadedThis;
        }
    }
}


