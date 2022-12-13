using StudentsLager.AppData;
using StudentsLager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentsLager.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddValuation.xaml
    /// </summary>
    public partial class AddValuation : Page
    {
        public AddValuation()
        {
            InitializeComponent();
            
            txtStatusCompetitions.ItemsSource = ConnectClass.studLagerDeminEntities.Status.ToList();
            txtCompetitionsName.ItemsSource = ConnectClass.studLagerDeminEntities.Competitions.ToList();
            txtStatusCompetitions.ItemsSource = ConnectClass.studLagerDeminEntities.Competitions.ToList();
            txtGroupName.ItemsSource = ConnectClass.studLagerDeminEntities.Groups.ToList();           
            txtSpecializationGroup.ItemsSource = ConnectClass.studLagerDeminEntities.Specialization.ToList();
        }

        private void CreateAccoutingBtn_Click(object sender, RoutedEventArgs e)
        {


            string mes = "";
            if (string.IsNullOrWhiteSpace(txtCompetitionsName.Text))
                mes += "Выберите название соренования\n";

            if (string.IsNullOrWhiteSpace(txtStatusCompetitions.Text))
                mes += "Выберите статус соревнования\n";
            
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
                mes += "Выберите название группы\n";

            if (string.IsNullOrWhiteSpace(txtSpecializationGroup.Text))
                mes += "Выберите специальность группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            
            Model.Journal journal = new Model.Journal()
            {
                Groups = txtGroupName.SelectedItem as Groups,                      
                Competitions = txtCompetitionsName.SelectedItem as Competitions,
                
            };
            ConnectClass.studLagerDeminEntities.Journal.Add(journal);
            ConnectClass.studLagerDeminEntities.SaveChanges();
            MessageBox.Show("запись добавлена");

           

        }

        private void txtFocusActivity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int View = Convert.ToInt32(txtStatusCompetitions.SelectedValue);
            //txtCompetitionsName.ItemsSource = ConnectClass.studLagerDeminEntities.Competitions.Where(x => x.Id == View).ToList();
        }

        private void txtViewGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int View = Convert.ToInt32(txtSpecializationGroup.SelectedValue);
            //txtGroupName.ItemsSource = ConnectClass.studLagerDeminEntities.Groups.Where(x => x.IdSpecialization == View).ToList();
        }
    }
}
