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
using System.Collections.ObjectModel;

namespace PMS
{
    /// <summary>
    /// Interaction logic for AddAccessToGroup.xaml
    /// </summary>
    public partial class AddAccessToGroup : Page
    {
        //Create Entity model oblect
        PMS_Main_ModelContainer model = new PMS_Main_ModelContainer();

        //Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.
        public ObservableCollection<BoolStringClass> TheList { get; set; }

        public AddAccessToGroup()
        {
            InitializeComponent();
            TheList = new ObservableCollection<BoolStringClass>();
          
            //Load values to combobox
            txtGrpName.ItemsSource = model.AccessGroups;
            txtGrpName.DisplayMemberPath = "Name";
            txtGrpName.SelectedItem = 1;
        }


        //When check add access to group
        private void Incheck(object sender, RoutedEventArgs e)
        {
            //Get Checkedboc value
            CheckBox chkZone = (CheckBox)sender;
            AccessGroup ag = (AccessGroup)txtGrpName.SelectedItem;
            int accId = Convert.ToInt32(chkZone.Tag);

            //Get Access control object according to access id
            AccessControl ac = model.AccessControls.Where(accContrl => accContrl.Id == accId).First();

            //Add Access to group
            ag.AccessControls.Add(ac);
            model.SaveChanges();
        }


        //When Unchecked remove access from group
        private void UnCheck(object sender, RoutedEventArgs e)
        {
            //Get Checkedboc value
            CheckBox chkZone = (CheckBox)sender;
            AccessGroup ag = (AccessGroup)txtGrpName.SelectedItem;
            int accId = Convert.ToInt32(chkZone.Tag);

            //Get Access control object according to access id
            AccessControl ac = model.AccessControls.Where(accContrl => accContrl.Id == accId).First();
            
            //Delete Access from group
            ag.AccessControls.Remove(ac);
            model.SaveChanges();
        } 
        

        //Check access to group
        private bool IsItCheck(int accessID)
        {
            
            bool result = false;
            AccessGroup ag = (AccessGroup) txtGrpName.SelectedItem;

            //Get object to access
            var grpAccess = ag.AccessControls.Where(controlID => controlID.Id == accessID);
            if (grpAccess.Count() > 0)
            {
                result = true;
            }

            return result;
        }

        //Load checkbox list
        private void LoadAccessList()
        {
            var ipm = (from a in model.AccessControls select new { accID = a.Id, accName = a.ActionDescription });
            this.DataContext = ipm;

            foreach (var item in ipm)
            {
                TheList.Add(new BoolStringClass { Name = item.accName, Id = item.accID, IsSelected = IsItCheck(item.accID) });
            }

            this.DataContext = this;
        }

        //When combobox change load access to access group
        private void txtGrpName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TheList.Clear();
            LoadAccessList();
        }
    }
    
    //To load checkbox list in WPF
    public class BoolStringClass
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string TheText { get; set; }
        public bool IsSelected { get; set; }
    }
}
