using StudentsLager.View.Pages;
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

namespace StudentsLager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AddGroupsHl_Click(object sender, RoutedEventArgs e)
        {
            NavigateFrm.Navigate(new AddGroups());
        }

        private void AddCompetitionsHl_Click(object sender, RoutedEventArgs e)
        {
            NavigateFrm.Navigate(new AddCompetitions());
        }

        private void AccountihgHl_Click(object sender, RoutedEventArgs e)
        {
            NavigateFrm.Navigate(new AddValuation());
        }

        private void JournalHl_Click(object sender, RoutedEventArgs e)
        {
            NavigateFrm.Navigate(new Journal());
        }
    }
}
