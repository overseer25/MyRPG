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

        /// <summary>
        /// Event handler for clicking the north button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _session.MoveNorth();
        }

        /// <summary>
        /// Event handler for clicking the South button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _session.MoveSouth();
        }

        /// <summary>
        /// Event handler for clicking the East button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _session.MoveEast();
        }

        /// <summary>
        /// Event handler for clicking the West button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _session.MoveWest();
        }
    }
}
