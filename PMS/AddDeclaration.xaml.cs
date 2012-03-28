using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace PMS
{
	public partial class AddDeclaration
	{
        
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();

		public AddDeclaration()
		{
			this.InitializeComponent();

			
		}

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

         private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (this.Validate())
            {
                Declaration declaration = new Declaration();
                string exporterName = txtExporter.Text;
                Exporter exporter;
                try
                {
                     exporter= model.Exporters.Where(exp => exp.Name == exporterName).FirstOrDefault();
                     declaration.Exporter = exporter;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Exporter Name");
                    return;
                }
                Buyer buyer;
                try
                {
                    buyer = model.Buyers.Where(buy => buy.Name == txtBuyer.Text).FirstOrDefault();
                    declaration.Buyer = buyer;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid Buyer Name");
                    return;
                }
                Policy policy;
                try
                {
                    policy = model.Policies.Where(pol => pol.PolicyNumber == txtPolicyNo.Text).FirstOrDefault();
                    declaration.Policy = policy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Policy Number");
                    return;
                }
                declaration.TermOfPayment = txtPaymentTerm.Text;
                declaration.Commodity = (Commodity)txtCommodity.SelectedItem;
                declaration.Country = (Country)txtCountry.SelectedItem;
                PremiumRate premium;
                try
                {
                    premium = declaration.Country.PremiumRates.Where(prem => prem.CommodityId == declaration.CommodityId).FirstOrDefault();
                    declaration.PremiumRate = premium;
                }
                catch (Exception ex)
                {
                }
                declaration.ShipmentDate = dtPickerShpDate.SelectedDate.Value;
                declaration.StampDate = dtPickerStampDate.SelectedDate.Value;
                declaration.GrossValue = txtGross.Text;
                declaration.CreditDuration = txtCreditDuration.Text;

                //Adding the declaration to the model
                model.AddToDeclarations(declaration);

                //Saving to the database
                model.SaveChanges();

                //Reloading the Datagrid
                this.LoadGrid();

            }
            else
            {
                return;
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.BindCountry();
            this.BindComodity();
            this.BindExporters();
            this.BindBuyers();
            this.BindPolicies();
            this.LoadGrid();
            dtPickerShpDate.SelectedDate = DateTime.Now;
            dtPickerStampDate.SelectedDate = DateTime.Now;
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

        //bind Exporters to the autocomplete
        private void BindExporters()
        {
            var exporterNames = model.Exporters.Select(exp => exp.Name);
            txtExporter.ItemsSource = exporterNames;
        }

        //bind Buyer to the autocomplete
        private void BindBuyers()
        {
            var buyerNames = model.Buyers.Select(buyer => buyer.Name);
            txtBuyer.ItemsSource = buyerNames;
        }

        //bind Policy to the autocomplete
        private void BindPolicies()
        {
            var policies = model.Policies.Select(policy => policy.PolicyNumber);
            txtPolicyNo.ItemsSource = policies;
        }

        // Validating the Inputs
        private bool Validate()
        {
            return true;
        }

        //Loading the Grid
        private void LoadGrid()
        {
            var declarations = from d in model.Declarations select new {Policy_Number = d.Policy.PolicyNumber,Exporter_Name = d.Exporter.Name, Buyer_Name = d.Buyer.Name, Gross_Value = d.GrossValue, Credit_Duration = d.CreditDuration,Commodity_Name= d.Commodity.Name,d.ShipmentDate,d.StampDate };
            this.DataContext = declarations;

        }

        //Clearing the Fields
        private void ClearFields()
        {
            txtBuyer.Text ="";
            txtExporter.Text ="";
            txtPolicyNo.Text = "";
            dtPickerShpDate.SelectedDate = DateTime.Now;
            dtPickerStampDate.SelectedDate = DateTime.Now;
            txtGross.Text = "";
            txtCreditDuration.Text = "";
        }

        //Clear Button click event
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.ClearFields();
        }
        
	}
}