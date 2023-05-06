using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class FacebookCollection<T> : INotifyPropertyChanged
    {
        private ObservableCollection<T> m_Items;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Post> Posts { get; } = new ObservableCollection<Post>();

        public ObservableCollection<T> Items
        {
            get => m_Items;
            set
            {
                if (m_Items != value)
                {
                    if (m_Items != null)
                    {
                        m_Items.CollectionChanged -= OnItemsCollectionChanged;
                    }

                    m_Items = value;

                    if (m_Items != null)
                    {
                        m_Items.CollectionChanged += OnItemsCollectionChanged;
                    }

                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public FacebookCollection(ObservableCollection<T> items)
        {
            Items = items;
        }

        private void OnItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Items));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
