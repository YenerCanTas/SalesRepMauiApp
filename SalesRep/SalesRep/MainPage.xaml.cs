
using System.Security.Cryptography.X509Certificates;

namespace SalesRep
{
    public partial class MainPage : ContentPage
    {
       
        public List<SalesRep> SalesRepList = new List<SalesRep>();

        private string gender;
        private string team;
        private int ID;
        public MainPage()
        {
            InitializeComponent();

            gender = string.Empty;
            team = string.Empty;
            ID= 1;
            

        }

       private void Add_Clicked(object sender, EventArgs e)
        {

            if (FemaleRadioButton.IsChecked)
            {
                gender = "Female";
            }
            else if (MaleRadioButton.IsChecked)
            {
                gender = "Male";
            }

            if (BoatRadioButton.IsChecked)
            {
                team = "Boat";
            }else if (BankRadioButton.IsChecked)
            {
                team = "Bank";
            }else if  (PaintRadioButton.IsChecked)
            {
                team = "Paint";
            }else if (FootballRadioButton.IsChecked)
            {
                team = "Football";
            }
            
            SalesRepList.Add( new SalesRep(ID,EntryName.Text, EntryLastName.Text, EntryTelNo.Text,gender,team));
            ID++;
            Sales_Rep_View.ItemsSource = null;

           


        }

        private void Show_Clicked(object sender, EventArgs e)
        {
            Sales_Rep_View.ItemsSource = SalesRepList;
        }

        

    }

}
