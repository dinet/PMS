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
    /// Interaction logic for AddAccessGroup.xaml
    /// </summary>
    public partial class AddAccessGroup : Page
    {
        //Create Entity model oblect
        private PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();
        Validation valid = new Validation();

        public AddAccessGroup()
        {
            InitializeComponent();

            //Load Data Grid
            LoadGrid();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Validate Group Name
            if (valid.ValidateTextField(txtGroupName.Text))
            {
                //Add access group from entity model
                AccessGroup ag = new AccessGroup();
                ag.Name = txtGroupName.Text;
                ag.Description = txtDescription.Text;
                model.AddToAccessGroups(ag);
                model.SaveChanges();

                //Clear all Textboxs
                ClearTextBox();

                LoadGrid();
            }
            else
            {
                MessageBox.Show(" * Field Required");
            }
        }

        //Load data grid by access group
        private void LoadGrid()
        {
            var acessGr = (from g in model.AccessGroups select new { Name = g.Name, Description = g.Description });
            grdAccessGroup.DataContext = acessGr;           
        }
        
        //Clear Textboxs
        private void ClearTextBox()
        {
            txtGroupName.Text = "";
            txtDescription.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBox();
        }
    }
}
