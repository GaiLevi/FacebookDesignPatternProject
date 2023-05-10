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

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        private ApplicationSettings()
        {
        }

        private static ApplicationSettings s_This;
       
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

        public bool AutoLogin { get; set; }
        //public Size LastWindowSize { get; set; }
        //public FormWindowState LastWindowState { get; set; }
        //public Point LastWindowLocation { get; set; }
        public string AccessToken { get; set; }

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
                                     AutoLogin = false,
                                     //LastWindowSize = new Size(800, 500),
                                     //LastWindowState = FormWindowState.Normal
                                 };
            }

            return loadedThis;
        }
    }
}


