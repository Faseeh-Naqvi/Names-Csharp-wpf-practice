using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Names
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

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            string input = txtName.Text;
            if (!(string.IsNullOrWhiteSpace(txtName.Text)))
            {   
                int count = listNames.Items.Count;
                //can also use foreach
                
                if (!(listNames.Items.Contains(input)))
                {
                    listNames.Items.Add(input);
                    txtName.Clear();
                    System.Diagnostics.Debug.WriteLine($"The Name: {input} has been successfully added.");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error: Name found :(");
                }
                

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: Empty Input :(");
            }

        }
    }
}