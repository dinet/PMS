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
    /// Interaction logic for Exp_Add_Director.xaml
    /// </summary>
    public partial class AddDirector : Page
    {
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();
        Exporter _exporter;
        public AddDirector()
        {
            InitializeComponent();
        }

        public AddDirector(Exporter exporter)
        {

            _exporter = exporter;
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Validation validation = new Validation();
           //validating emails
            if (validation.ValidateTextField(txtEmail.Text) ? validation.ValidateEmail(txtEmail.Text) : true)
            {
                //validating nic
                if(validation.ValidateTextField(txtNIC.Text) ? validation.ValidateNIC(txtNIC.Text) :true)
                {
                    //checking whether nicor passport field fill
                    if (validation.ValidateTextField(txtNIC.Text) || validation.ValidateTextField(txtPassportId.Text))
                    {
                        //addig data to the model
                        Director director = new Director();
                        director.FirstName = txtFirstName.Text;
                        director.LastName = txtLastName.Text;
                        director.NIC = txtNIC.Text;
                        director.PassportNo = txtPassportId.Text;
                        director.JoinedDate = dtPickerJoinedDate.SelectedDate.Value;
                        director.DateOfBirth = dtPickerBirthDay.SelectedDate.Value;
                        director.Gender = txtGender.SelectedValue.ToString();
                        director.TelNo = txtTelNo.Text;
                        director.Type = txtType.SelectedValue.ToString();
                        director.Email = txtEmail.Text;
                        director.Address = txtAddress.Text;
                        model.AddToDirectors(director);
                        //saving changes to the database
                        model.SaveChanges();
                        Exporter expo = model.Exporters.Where(exp => exp.Id == _exporter.Id).First();
                        director.Exporters.Add(expo);
                        model.SaveChanges();
                        
                        //clearing fields
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtNIC.Clear();
                        txtPassportId.Clear();
                        dtPickerBirthDay.ClearValue(DatePicker.SelectedDateProperty);
                        dtPickerJoinedDate.ClearValue(DatePicker.SelectedDateProperty);
                        txtGender.ClearValue(ComboBox.SelectedItemProperty);
                        txtTelNo.Clear();
                        txtPassportId.Clear();
                        txtType.ClearValue(ComboBox.SelectedItemProperty);
                        txtAddress.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Either NIC or Passport number is required");
                    
                    }
                }
                else
                {
                    MessageBox.Show("Invalid NIC");
                
                }

            }
            else 
            {
                MessageBox.Show("Email address is invalid");
            }





        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
