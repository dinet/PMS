using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;

namespace PMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            // Insert code required on object creation below this point.
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddDeclaration();
         
        }

        private void LayoutRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //frame1.SetValue(WidthProperty, frame1.GetValue(Grid.WidthProperty));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddPremiumRates();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddBuyers();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddExporter();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddAccessGroup();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddAccessToGroup();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new AddUser();
        }

        
    }
}
