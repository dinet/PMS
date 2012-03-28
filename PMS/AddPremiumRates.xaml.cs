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
    /// Interaction logic for AddPremiumRates.xaml
    /// </summary>
    public partial class AddPremiumRates : Page
    {
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();

        public AddPremiumRates()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.BindComodity();
            this.BindCountry();
            this.LoadGrid();
        }

        // bind Country to the dropdown
        private void BindCountry()
        {
            var countries = model.Countries;
            txtCountry.ItemsSource = countries;
            txtCountry.DisplayMemberPath = "Name";
        }

        // bind Commodity to the dropdown
        private void BindComodity()
        {
            var commodity = model.Commodities;
            txtCommodity.ItemsSource = commodity;
            txtCommodity.DisplayMemberPath = "Name";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            PremiumRate premium = new PremiumRate();
            premium.Rate = txtPremiumRate.Text;
            premium.Description = txtDescription.Text;
            premium.Commodity = (Commodity)txtCommodity.SelectedItem;
            premium.Country = (Country)txtCountry.SelectedItem;
            model.PremiumRates.AddObject(premium);
            model.SaveChanges();
        }

        //Load the Data Grid
        private void LoadGrid()
        {
            var premiums = from pre in model.PremiumRates select new{Country_Name = pre.Country.Name, Commodity_Name = pre.Commodity.Name, Premium_Rate = pre.Rate};
            dataGrid1.DataContext = premiums;
        }
    }
}
