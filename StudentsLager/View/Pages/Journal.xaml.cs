using StudentsLager.AppData;
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
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Page
    {
        public Journal()
        {
            InitializeComponent();

            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Mark.ToList();
            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Groups.ToList();
            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Specialization.ToList();
            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Competitions.ToList();
            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Status.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            CustomersList.ItemsSource = ConnectClass.studLagerDeminEntities.Journal.ToList();


        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Journal journal = (Journal)CustomersList.SelectedItem;


        }
    }
}
