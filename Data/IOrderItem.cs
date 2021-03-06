﻿/*
 * Author: Bhargav Marada
 * Class name: IOrderItem.cs
 * Purpose: an interface which contains the following propertie
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Price getter
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// Calories getter
        /// </summary>
        uint Calories
        {
            get;
        }

        /// <summary>
        /// Special Instructions getter
        /// </summary>
        List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// the description of the item
        /// </summary>
        string Description { get; }
    }
}
