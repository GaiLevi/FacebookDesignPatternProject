using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookViewModel
{
    public class ImageURLIterator : IEnumerator<string>
    {
        private readonly ObservableCollection<string> r_UrlCollection;
        public int m_Index { get; private set; }

        public ImageURLIterator(ObservableCollection<string> i_UrlCollection)
        {
            this.r_UrlCollection = i_UrlCollection;
            m_Index = -1;
        }

        public string Current
        {
            get
            {
                if (m_Index >= 0 && m_Index < r_UrlCollection.Count)
                {
                    return r_UrlCollection[m_Index];
                }
                throw new InvalidOperationException("Index is out of range");
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (m_Index < r_UrlCollection.Count - 1)
            {
                m_Index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            m_Index = -1;
        }

        public bool MovePrevious()
        {
            if (m_Index > 0)
            {
                m_Index--;
                return true;
            }
            return false;
        }
    }
}
