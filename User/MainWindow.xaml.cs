using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace User
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "act.ico");
        }
    }
}
