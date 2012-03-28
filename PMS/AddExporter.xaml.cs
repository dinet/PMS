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
    /// Interaction logic for AddExporter.xaml
    /// </summary>
    public partial class AddExporter : Page
    {
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();
        Exporter exporter;
        public AddExporter()
        {
            InitializeComponent();
            exporter = new Exporter();
        }

       

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            Validation validation = new Validation();
             //validation for emails
            if (validation.ValidateTextField(txtEmail.Text) ? validation.ValidateEmail(txtEmail.Text) : true)
            {
                
                exporter.Name = txtName.Text;
                exporter.RegNo = txtRegNo.Text;
                exporter.TelNo = txtTelNo.Text;
                exporter.ShortTag = txtShortTag.Text;
                exporter.Email = txtEmail.Text;
                exporter.Description = txtDescription.Text;
                exporter.Address = txtAddress.Text;
                //adding to data model
                model.AddToExporters(exporter);
                //applying changes to the database
                model.SaveChanges();
                ContentPresenter con = (ContentPresenter)this.VisualParent;
                con.Content = new AddDirector(exporter);       
            }
            else 
            {
                MessageBox.Show("Invalid Email");
            }
        }
    }
}
