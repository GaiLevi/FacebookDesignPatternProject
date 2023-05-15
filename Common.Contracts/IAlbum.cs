using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IAlbum : IObject
    {
        string m_Name { get; set; }
        int m_Index { get; set; }
        ObservableCollection<string> m_PicturesUrl { get; set; }
        void LoadAlbumPictures();
    }
}
