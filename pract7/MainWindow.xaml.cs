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

namespace pract7
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
        Student man1 = new Student("", 0, "", 0, "", "", "");
        Student man2 = new Student("", 0, "", 0, "", "", "");
        
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = man1.ShowInformation() + "\n\n" + man2.ShowInformation();
        }

        private void ChangeParameters_Click(object sender, RoutedEventArgs e)
        {
            if (person1.IsChecked == true)
            {
                FillInformation(man1);
            }

            if (person2.IsChecked == true)
            {
                FillInformation(man2);
            }
            TextBox.Text = man1.ShowInformation() + "\n\n" + man2.ShowInformation();
        }

        private void FillInformation(Student somebody)
        {
            if (имя.Text != string.Empty)
            {
                somebody.Name = имя.Text;
            }

            if (пол.SelectedIndex == 0)
            {
                somebody.Sex = "мужской";
            }
            if (пол.SelectedIndex == 1)
            {
                somebody.Sex = "женский";
            }

            if (Int32.TryParse(возраст.Text, out int age))
            {
                if (age < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательным");
                }
                else
                {
                    somebody.Age = age;
                }
            }

            if (Int32.TryParse(вес.Text, out int weight))
            {
                if (weight < 0)
                {
                    MessageBox.Show("Вес не может быть отрицательным");
                }
                else
                {
                    somebody.Weight = weight;
                }
            }

            if (faculties.SelectedIndex == 0)
            {
                somebody.Faculty = "информатики";
            }
            if (faculties.SelectedIndex == 1)
            {
                somebody.Faculty = "экономики";
            }

            if (faculties.SelectedIndex == 0 && groups.SelectedIndex == 0)
            {
                somebody.Group = "Прикладная информатика";
            }
            if (faculties.SelectedIndex == 0 && groups.SelectedIndex == 1)
            {
                somebody.Group = "Информационные системы";
            }
            if (faculties.SelectedIndex == 1 && groups.SelectedIndex == 0)
            {
                somebody.Group = "Экономика и управление";
            }
            if (faculties.SelectedIndex == 1 && groups.SelectedIndex == 1)
            {
                somebody.Group = "Экономическая безопасность";
            }

            if (courses.SelectedIndex == 0)
            {
                somebody.Course = "1";
            }
            if (courses.SelectedIndex == 1)
            {
                somebody.Course = "2";
            }
            if (courses.SelectedIndex == 2)
            {
                somebody.Course = "3";
            }
            if (courses.SelectedIndex == 3)
            {
                somebody.Course = "4";
            }
        }

        private void выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void справка_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31\nПеревезенцева Полина\n\nЗадание:\nИспользовать класс Man (человек), с полями: имя, возраст, пол и вес.\nСоздать производный класс Student, имеющий поля факультет, курс, группа.\nОпределить методы изменения возраста, веса, перехода на следующий курс, перевода в другую группу.");
        }

        private void increment_Click(object sender, RoutedEventArgs e)
        {
            if (person1.IsChecked == true)
            {
                man1++;
                возраст.Text = man1.Age.ToString();
            }
            if (person2.IsChecked == true)
            {
                man2++;
                возраст.Text = man2.Age.ToString();
            }
        }

        private void сравнить_Click(object sender, RoutedEventArgs e)
        {
            if (man1 > man2)
            {
                MessageBox.Show("Вес 1 человека больше, чем вес 2 человека");
            }
            if (man1 < man2)
            {
                MessageBox.Show("Вес 1 человека меньше, чем вес 2 человека");
            }
            if (man1.Weight == man2.Weight)
            {
                MessageBox.Show("Вес 1 человека равен весу 2 человека");
            }
        }

        private void person1_Checked(object sender, RoutedEventArgs e)
        {
            имя.Text = "";
            возраст.Text = "";
            вес.Text = "";
            пол.SelectedIndex = -1;
        }

        private void person2_Checked(object sender, RoutedEventArgs e)
        {
            имя.Text = "";
            возраст.Text = "";
            вес.Text = "";
            пол.SelectedIndex = -1;
        }

        private void faculties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (faculties.SelectedIndex == 0)
            {
                groups.Items.Clear();
                groups.Items.Insert(0, "Прикладная информатика");
                groups.Items.Insert(1, "Информационные системы");
            }
            if (faculties.SelectedIndex == 1)
            {
                groups.Items.Clear();
                groups.Items.Insert(0, "Экономика и управление");
                groups.Items.Insert(1, "Экономическая безопасность");
            }
        }
    }
}
