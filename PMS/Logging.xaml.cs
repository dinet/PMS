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
using System.Windows.Shapes;

namespace PMS
{
    /// <summary>
    /// Interaction logic for Logging.xaml
    /// </summary>
    public partial class Logging : Window
    {

        PMS_Main_ModelContainer model;
        public Logging()
        {
            InitializeComponent();
            model = new PMS_Main_ModelContainer();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

    

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            User u = new User();
            var result=model.Users.Where(i=>i.UserName==txtUserName.Text).Where(p=>p.Password==txtPassword.Password);

            if (result.Count() == 0)
            {
                MessageBox.Show("Invalid Username or password", "Error in logging");

            }

            else
            {
                result.First().LastLoginDate = DateTime.Now;
                model.SaveChanges();
                new MainWindow().Show();
                this.Close();


            }
            
            
            
            
        }

       
    }
}
