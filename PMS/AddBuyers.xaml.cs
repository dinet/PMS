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
    /// Interaction logic for AddIndividual.xaml
    /// </summary>
    public partial class AddBuyers : Page
    {
        PMS_Main_ModelContainer model;
        public AddBuyers()
        {
            InitializeComponent();
            model = new PMS_Main_ModelContainer();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnIAdd_Click(object sender, RoutedEventArgs e)
        {
            
            IndividualBuyer ib=new IndividualBuyer();
            
            
            // set properties to indiviudaBuyer object
            ib.Name=txtIName.Text;
            ib.MobileNo=txtIMobileNo.Text;
            ib.TelephoneNo = txtITelephoneNo.Text;
            ib.NIC=txtINic.Text;
            ib.DateOfBirth = birthdaypicker.SelectedDate.Value;
            ib.Country =(Country) comboBox1.SelectedItem;
            
            ib.City=txtICity.Text;
            ib.ZipCode=txtIZipCode.Text;
            ib.Address = txtIAddress.Text;
            ib.Passport = txtIPassport.Text;
            ib.Email = txtIEmail.Text;
            ib.Fax = txtIFax.Text;
         
          model.AddToBuyers(ib);
        
          Validation v = new Validation();// validation class is used to validate in relevant way
          if (v.ValidateTextField(txtIName.Text) )
          {
              model.AddToBuyers(ib);
              model.SaveChanges();
              MessageBox.Show("Added to the database successfully");



          }
          else
          {
              MessageBox.Show("Need to enter details in required fields", "Error");

          }

          

            


           


        }

        private void btnCAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            BindCountry();
        }

        private void btnCAdd_Click_1(object sender, RoutedEventArgs e)
        {
            CompanyBuyer cb = new CompanyBuyer();
            cb.Country = (Country)comBoxCCountry.SelectedItem;

            cb.City = txtCCity.Text;
            cb.Address = txtCAddress.Text;
            cb.ZipCode = txtCZipCode.Text;
            cb.Name = txtCName.Text;
            cb.Fax = txtCFax.Text;
            cb.Email = txtCEmail.Text;
            cb.TelephoneNo = txtCTelephoneNo.Text;
            cb.ShortName = txtCShortTag.Text;
            model.AddToBuyers(cb);
            Validation v = new Validation();

            if (v.ValidateTextField(txtCName.Text))
            {

                if (v.ValidateEmail(txtCEmail.Text))
                {
                    model.AddToBuyers(cb);
                    model.SaveChanges();
                    MessageBox.Show("Successfully added to database", "Added the company");

                }

                else
                    MessageBox.Show("Email is in Invalide formate", "Error");
              

            }
            else
            {
                MessageBox.Show("Need to enter details in required fields", "Error");

            }



        }

       

        private void Page_Loaded_2(object sender, RoutedEventArgs e)
        {

        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnIReset_Click(object sender, RoutedEventArgs e)
        {
            txtIAddress.Text = "";
            txtICity.Text="";
            txtIEmail.Text="";
            txtIFax.Text="";
            txtIMobileNo.Text="";
            txtIName.Text="";
            txtINic.Text="";
            txtIPassport.Text="";
            txtITelephoneNo.Text="";
            txtIZipCode.Text="";

        }

        private void btnCReset_Click(object sender, RoutedEventArgs e)
        {

            txtCAddress.Text = "";
            txtCCity.Text = "";
            txtCEmail.Text = "";
            txtCFax.Text = "";
            txtCName.Text = "";
            txtCTelephoneNo.Text = "";
            txtCZipCode.Text = "";
            txtCShortTag.Text = "";
        }

        // bind Country to the dropdown
        private void BindCountry()
        {
            var countries = model.Countries;
            comboBox1.ItemsSource = countries;
            comboBox1.DisplayMemberPath = "Name";
            comBoxCCountry.ItemsSource = countries;
            comBoxCCountry.DisplayMemberPath = "Name";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded_3(object sender, RoutedEventArgs e)
        {
            this.BindCountry();
        }
        

       
        
       
    }
}
