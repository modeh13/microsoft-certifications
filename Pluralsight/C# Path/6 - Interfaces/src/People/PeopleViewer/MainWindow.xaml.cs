using System.Collections.Generic;
using System.Windows;
using PersonRepository;
using PersonRepository.Factory;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnService_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("Service");
        }

        private void BtnSql_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("SQL");
        }

        private void BtnCsv_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("CSV");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            PeopleListBox.Items.Clear();
        }

        private void PopulateListBox(string repositoryType)
        {
            IPersonRepository repository = RepositoryFactory.GetRepository(repositoryType);
            IEnumerable<Person> people = repository.Get();

            foreach (var person in people)
                PeopleListBox.Items.Add(person);
        }
    }
}