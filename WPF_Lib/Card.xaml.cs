using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Lib
{
    public partial class Card : UserControl
    {
        public string Title { get; set; }
        public string Annotation { get; set; }
        public int Price { get; set; }
        
        public EventHandler Action { get; set; }

        public Card()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            Action?.Invoke(sender, e);
        }
    }
}