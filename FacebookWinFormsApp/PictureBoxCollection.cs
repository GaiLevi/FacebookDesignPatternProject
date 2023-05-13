using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class PictureBoxCollection : PictureBox, IEnumerator
    {
        private int m_Index;
        private ObservableCollection<string> m_URLCollection;
        private readonly Label r_LabelImageIndexer;
        public object Current { get { return m_URLCollection[m_Index]; } }

        public PictureBoxCollection()
        {
            r_LabelImageIndexer = new Label();
            r_LabelImageIndexer.TextAlign = ContentAlignment.MiddleCenter;
            r_LabelImageIndexer.Size = new Size(this.Width / 2, 20);
            r_LabelImageIndexer.AutoSize = true;
            r_LabelImageIndexer.Location = new Point(0, 0);
            r_LabelImageIndexer.BackColor = Color.FromArgb(100, Color.White);
            this.Controls.Add(r_LabelImageIndexer);
        }
        public void SetList(ObservableCollection<string> i_ImageList)
        {
            m_Index = -1;
            r_LabelImageIndexer.Text = string.Format(@"Loading Album");
            m_URLCollection = i_ImageList;
            updateLabel();
        }

        public bool MoveNext()
        {
            bool hasNext = false;
            if (m_Index < m_URLCollection.Count - 1)
            {
                m_Index++;
                this.LoadAsync(m_URLCollection[m_Index]);
                updateLabel();
                hasNext = true;
                
            }

            return hasNext;
        }

        public void Reset()
        {
            m_Index = -1;
            updateLabel();
        }


        public bool Prev()
        {
            bool hasPrev = false;
            if (m_Index > 0)
            {
                m_Index--;
                this.LoadAsync(m_URLCollection[m_Index]);
                updateLabel();
                hasPrev = true;
            }

            return hasPrev;
        }

        private void updateLabel()
        {
            if(m_URLCollection != null)
            {
                int count = m_URLCollection.Count;
                if (count == 0)
                {
                    this.Image = null;
                    r_LabelImageIndexer.Text = string.Format(@"No Images in album");
                }
                else
                {
                    r_LabelImageIndexer.Text = string.Format($@"{m_Index + 1}/{count}");
                }
            }
        }
    }
}
