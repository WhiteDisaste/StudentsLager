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
    /// Логика взаимодействия для AddCompetitions.xaml
    /// </summary>
    public partial class AddCompetitions : Page
    {
        public AddCompetitions()
        {
            InitializeComponent();

            txtCompetitionsStatus.ItemsSource = ConnectClass.studLagerDeminEntities.Status.ToList();
        }

        private void CreateCompetitionsBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtCompetitionsName.Text))
                mes += "Введите название соревнования";
            if (string.IsNullOrWhiteSpace(txtCompetitionsStatus.Text))
                mes += "Введите статус соревнования";
            if (mes != "")
            {
                MessageBox.Show("Вы создали новое соревнования", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            Competitions competitions = new Competitions()
            {
                Name = txtCompetitionsName.Text,
                Status = txtCompetitionsStatus.SelectedItem as Status
            };
            ConnectClass.studLagerDeminEntities.Competitions.Add(competitions);
            ConnectClass.studLagerDeminEntities.SaveChanges();
            MessageBox.Show("запись добавлена");

            txtCompetitionsName.Text = "";
            txtCompetitionsStatus.Text = "";
        }
    }
    
}
