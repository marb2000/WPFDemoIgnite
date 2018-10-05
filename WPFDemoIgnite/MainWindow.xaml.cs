using Microsoft.Toolkit.Wpf.UI.XamlHost;
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

namespace WPFDemoIgnite
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

        private void OnButtonChanged(object sender, EventArgs e)
        {
            WindowsXamlHost wxh = (WindowsXamlHost)sender;

            Windows.UI.Xaml.Controls.Button btn = wxh.Child as Windows.UI.Xaml.Controls.Button;
            if (btn != null)
            {
                btn.Height = 100;
                btn.Width = 200;
                btn.Content = "Hello World";
                btn.Click += OnClick;
            }
        }

        private void OnClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageBox.Show("This is WPF message box"); 
        }
        Windows.UI.Xaml.Controls.ListView list;
        private void OnStackPanelChanged(object sender, EventArgs e)
        {
            WindowsXamlHost wxh = (WindowsXamlHost)sender;

            Windows.UI.Xaml.Controls.StackPanel stackPanel = wxh.Child as Windows.UI.Xaml.Controls.StackPanel;
            if (stackPanel != null)
            {
                list = new Windows.UI.Xaml.Controls.ListView();
                list.Items.Add("One");
                list.Items.Add("Two");
                list.Items.Add("Three");
                stackPanel.Children.Add(list);
                
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
               list.Items.Add((sender as TextBox).Text);
            }
        }

    }
}
