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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        //Create Entity model oblect
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();

        Validation valid = new Validation();

        public AddUser()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Validate username
            IEnumerable<User> users = model.Users.Where(u => u.UserName == txtUserName.Text);
            if (users.Count() == 0)
            {
                //Validate requiered fields
                if(valid.ValidateTextField(txtNIC.Text) && valid.ValidateTextField(txtEPFNo.Text) && valid.ValidateTextField(txtUserName.Text) && valid.ValidateTextField(txtPassword.Password) )
                {
                    //Validate Email
                    if ((valid.ValidateTextField(txtEmail.Text)) ? valid.ValidateEmail(txtEmail.Text) : true)
                    {
                        //Validate NIC
                        if (valid.ValidateNIC(txtNIC.Text))
                        {
                            //Validate password
                            if (txtPassword.Password.Equals(txtRePassword.Password, StringComparison.Ordinal))
                            {
                                //Add new user
                                User user = new User();
                                user.EpfNo = txtEPFNo.Text;
                                user.FirstName = txtFirstName.Text;
                                user.LastName = txtLastName.Text;
                                user.NIC = txtNIC.Text;
                                user.Gender = txtGender.Text;
                                user.Designation = txtDesignation.Text;
                                user.Address = txtAddress.Text;
                                user.MobileNo = txtMobileNo.Text;
                                user.LandPhone = txtLandPhone.Text;
                                user.Email = txtEmail.Text;
                                user.DateOfBirth = dtPickerDateOfBirth.SelectedDate.Value;
                                user.UserName = txtUserName.Text;
                                user.Password = txtPassword.Password;
                                user.AddedDate = DateTime.Now;

                                model.AddToUsers(user);
                                model.SaveChanges();

                                ClearTextBox();

                                LoadGrid();
                            }
                            else
                            {
                                MessageBox.Show("Passowrds not match");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid NIC");
                        }
                    }               
                    else
                    {
                        MessageBox.Show("Invalid Email");
                    }
                }
                else
                {
                     MessageBox.Show(" * Fields Required");
                }
            }
            else
            {
                MessageBox.Show("Username exist");
            }

        

        }

        //Load data grid from database
        private void LoadGrid()
        {
            var userDetails = (from u in model.Users select new { EPF_NO = u.EpfNo, Designation = u.Designation, Fist_Name = u.FirstName, Last_Name = u.LastName, User_Name = u.UserName, Mobile = u.MobileNo });
            grdUsers.DataContext = userDetails;
        }

        //Clear all textboxs
        private void ClearTextBox()
        {
            txtEPFNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNIC.Text = "";
            txtGender.Text = "";
            txtDesignation.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtLandPhone.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Password = "";
            txtRePassword.Password = "";
            dtPickerDateOfBirth.ClearValue(DatePicker.SelectedDateProperty);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBox();
        }

    }
}
