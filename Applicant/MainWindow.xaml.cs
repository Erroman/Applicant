using Microsoft.EntityFrameworkCore;
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

namespace CollegeApplicants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollectionViewSource applicantsViewSource;
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new ApplicantContext()) 
            {
                context.Database.EnsureCreated();
            }
            applicantsViewSource = (CollectionViewSource)FindResource(nameof(applicantsViewSource));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicantContext())
            {
                var newApplicant = new Applicant() 
                {
                    Surname = txtSurname.Text,
                    GivenName = txtGivenName.Text,
                    Patronimic = txtPatronimic.Text,
                    YearOfBirth = txtYearOfBirth.Text,
                    YearOfGraduation = txtYearOfGraduation.Text,
                    GraduatedSchool= txtGraduatedSchool.Text,
                    ChosenSpeciality=txtChosenSpeciality.Text,
                    CodeOfClass=txtCodeOfClass.Text,
                    EGEGrade = txtEGEGrade.Text
                };
                context.Applicants.Add(newApplicant);
                context.SaveChanges();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicantContext())
            {
                context.Applicants.Load<Applicant>();
                applicantsViewSource.Source = context.Applicants.Local.ToObservableCollection();
            }
        }
    }
}
