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
    /// Логика взаимодействия для AddGroups.xaml
    /// </summary>
    public partial class AddGroups : Page
    {
        public AddGroups()
        {
            InitializeComponent();

            txtSpecializationGroup.ItemsSource = ConnectClass.studLagerDeminEntities.Specialization.ToList();
        }

        private void CreateGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
                mes += "Введите название группы";
            if (string.IsNullOrWhiteSpace(txtSpecializationGroup.Text))
                mes += "Введите специальность группы";
            if (mes != "")
            {
                MessageBox.Show("Вы создали новую группу", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            Groups groups = new Groups()
            {
                Name = txtGroupName.Text,
                Specialization = txtSpecializationGroup.SelectedItem as Specialization
            };
            ConnectClass.studLagerDeminEntities.Groups.Add(groups);
            ConnectClass.studLagerDeminEntities.SaveChanges();
            MessageBox.Show("запись добавлена");

            txtGroupName.Text = "";
            txtSpecializationGroup.Text = "";
        }
    }
}
