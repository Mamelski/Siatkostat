﻿using System.Collections.Generic;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Siatkostat
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StatisticsWindow : Page
    {
        private readonly List<ComboBoxItem> actionTypes = new List<ComboBoxItem> 
        { 
            new ComboBoxItem { Name = "sdf", Tag = 3 },
            new ComboBoxItem { Name = "sdfo", Tag = 2 }
        };

        public StatisticsWindow()
        {
            InitializeComponent();
            ActionTypeComboBox.ItemsSource = actionTypes;
        }

        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            e.Handled = true;
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
            Frame.Navigate(typeof(MainMatch));
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }
    }
}
