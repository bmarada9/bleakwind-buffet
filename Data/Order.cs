using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Specialized;
using System.Collections;
namespace BleakwindBuffet.Data
{
    class Order: ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        List<IOrderItem> items = new List<IOrderItem>();
        
    
    }
}
