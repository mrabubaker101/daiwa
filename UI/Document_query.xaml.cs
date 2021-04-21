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
using System.Windows.Shapes;

namespace Daiwa.UI
{
    /// <summary>
    /// Interaction logic for Document_query.xaml
    /// </summary>
    public partial class Document_query : Window
    {
        public Document_query()
        {
            InitializeComponent();
        }

        string options1 = "";
        string options2 = "";
        string options3 = "";
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.Multiple;
            listBox1.SelectAll();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            //ListBoxItem i = new ListBoxItem();
            //i = listBox2.SelectedItem as ListBoxItem;
            
           // listBox3.Items.Add(e.Source);
        }

        private void listBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string OP1 = options1;
            string OP2 = options2;
            string OP3 = options3;



        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {

        }

        private void opt3_Checked(object sender, RoutedEventArgs e)
        {
            options1 = opt3.Content.ToString();
        }

        private void opt2_Checked(object sender, RoutedEventArgs e)
        {
            
            options1 = opt2.Content.ToString();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            var fourth = opt4.ToString();

        }

        private void opt5_Checked(object sender, RoutedEventArgs e)
        {
            var fifth = opt5.ToString();
        }

        private void opt7_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void opt6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void opt1_Checked(object sender, RoutedEventArgs e)
        {
            options1 = opt1.Content.ToString();
        }
    }
}
