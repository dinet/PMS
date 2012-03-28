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

namespace PMS
{
    /// <summary>
    /// Interaction logic for exporter_Page.xaml
    /// </summary>
    public partial class ViewExporter : Page
    {
        public ViewExporter()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();
            dataGrid1.AutoGenerateColumns = true;
            //
            dataGrid1.ItemsSource = model.Exporters.Select(i => new { i.Name,i.ShortTag, i.RegNo ,i.Address,i.Description,i.Email,i.TelNo});
              
            

        }

        private void companiesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
