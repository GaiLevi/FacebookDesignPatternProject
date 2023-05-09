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
        private Label m_Label;

        public PictureBoxCollection()
        {
            m_Label = new Label();
            m_Label.TextAlign = ContentAlignment.MiddleCenter;
            m_Label.Size = new Size(this.Width / 2, 20);
            m_Label.Location = new Point(0, 0);
            m_Label.BackColor = Color.FromArgb(100, Color.White);
            this.Controls.Add(m_Label);
        }
        public void SetList(ObservableCollection<string> list)
        {
            m_Index = -1;
            m_URLCollection = list;
            UpdateLabel();
            if(list.Count == 0)
            {
                this.Image = null;
                m_Label.Text = "Empty";
            }
        }

        public bool MoveNext()
        {
            if (m_Index < m_URLCollection.Count - 1)
            {
                m_Index++;
                this.LoadAsync(m_URLCollection[m_Index]);
                UpdateLabel();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            m_Index = -1;
            UpdateLabel();
        }

        public object Current
        {
            get
            {
                return m_URLCollection[m_Index];
            }
        }

        public bool Prev()
        {
            if (m_Index > 0)
            {
                m_Index--;
                this.LoadAsync(m_URLCollection[m_Index]);
                UpdateLabel();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateLabel()
        {
            if (m_URLCollection == null)
            {
                m_Label.Text = "";
                return;
            }
            int count = m_URLCollection.Count;
            if (count > 0)
            {
                m_Label.Text = $"{m_Index + 1}/{count}";
            }
            else
            {
                m_Label.Text = "";
            }
        }
    }
}
