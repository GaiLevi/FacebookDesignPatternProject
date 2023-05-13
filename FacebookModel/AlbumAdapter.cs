using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class AlbumAdapter : IAlbum
    {
        private readonly FacebookWrapper.ObjectModel.Album r_Album;
        public string m_Id { get; set; }
        public string m_Name { get; set; }
        public int m_Index { get; set; }
        public ObservableCollection<string> m_PicturesUrl { get; set; }

        public AlbumAdapter(FacebookWrapper.ObjectModel.Album i_Album)
        {
            r_Album = i_Album;
            m_Id = i_Album.Id;
            m_Name = i_Album.Name;
        }

        public void LoadAlbumPictures()
        {
            if (m_PicturesUrl == null)
            {
                m_PicturesUrl = new ObservableCollection<string>();
                if (r_Album.Photos.Count != 0)
                {
                    foreach (FacebookWrapper.ObjectModel.Photo photo in r_Album.Photos)
                    {
                        if (photo != null)
                        {
                            m_PicturesUrl.Add(photo.PictureNormalURL);
                        }
                    }
                }
            }
        }
    }
}
