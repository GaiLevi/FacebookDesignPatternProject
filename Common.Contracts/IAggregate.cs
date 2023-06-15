using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IAggregate
    {
        void CreateIterator(ObservableCollection<string> i_StringCollection);
    }
}
