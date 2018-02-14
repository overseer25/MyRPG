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
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // The game session for the program.
        private GameSession _session;

        public MainWindow()
        {
            InitializeComponent();

            _session = new GameSession();

            DataContext = _session; // Tells the XAML file the data context. Important for displaying data to the screen (using Binding).
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            _session.CurrentPlayer.ExperiencePoints += 10;
        }
    }
}
