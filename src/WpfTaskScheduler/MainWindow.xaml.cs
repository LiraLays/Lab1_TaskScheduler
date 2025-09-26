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
using Microsoft.VisualBasic;

namespace WpfTaskScheduler
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

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            FilterVbox.Visibility = (!(bool)checkBox.IsChecked ? Visibility.Collapsed : Visibility.Visible);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            string dateFilter = Interaction.InputBox("Введите дату для фильтра:","Фильтр");
            if (dateFilter == "") {checkBox1.IsChecked = false;return; }
        }

        private void checkBox1_Copy_Checked(object sender, RoutedEventArgs e)
        {
            string priorFilter = Interaction.InputBox("Введите приоритет для фильтра:", "Фильтр");
            if (priorFilter == "") { checkBox1.IsChecked = false; return; }
        }
    }
}