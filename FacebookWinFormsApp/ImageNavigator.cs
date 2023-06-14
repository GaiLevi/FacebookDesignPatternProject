using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookViewModel;

namespace BasicFacebookFeatures
{
    public class ImageNavigator : PictureBox
    {
        private readonly Label r_LabelImageIndexer;
        private ImageURLIterator m_ImageURLIterator;

        public int m_AlbumCount { get; set; }

        public ImageNavigator()
        {
            r_LabelImageIndexer = new Label
                                      {
                                          TextAlign = ContentAlignment.MiddleCenter,
                                          AutoSize = true,
                                          Location = new Point(0, 0),
                                          BackColor = Color.FromArgb(100, Color.White)
                                      };
            this.Controls.Add(r_LabelImageIndexer);
        }

        public void SetImageUrls(ObservableCollection<string> i_ImageUrls)
        {
            m_ImageURLIterator = new ImageURLIterator(i_ImageUrls);
            m_AlbumCount = i_ImageUrls.Count;
            ShowNext();
            updateLabel();

        }

        public bool ShowNext()
        {
            if(m_ImageURLIterator.MoveNext())
            {
                this.LoadAsync(m_ImageURLIterator.Current);
                updateLabel();
                return true;
            }

            return false;
        }

        public bool ShowPrevious()
        {
            if(m_ImageURLIterator.MovePrevious())
            {
                this.LoadAsync(m_ImageURLIterator.Current);
                updateLabel();
                return true;
            }

            return false;
        }

        private void updateLabel()
        {
            if(m_ImageURLIterator != null)
            {
                if(m_AlbumCount == 0)
                {
                    this.Image = null;
                    r_LabelImageIndexer.Text = string.Format("No Images in album");
                }
                else
                {
                    int currentIndex = m_ImageURLIterator.m_Index + 1;
                    r_LabelImageIndexer.Text = string.Format($"{currentIndex}/{m_AlbumCount}");
                }
            }
        }
    }

}
