using System;
using System.Windows;

namespace Math_Trainer_VC19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
        }

//         protected override void OnClosing(CancelEventArgs e)
//         {
//             MessageBoxResult result = MessageBox.Show("Do you really want to quit?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
//             if (result == MessageBoxResult.No) { e.Cancel = true; }
//         }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            // Switch to Trainer Window
            var trainerWindow = new Trainer();
            trainerWindow.Show();

            // Check for null and close current Window
            if (System.Windows.Application.Current.MainWindow != null)
                System.Windows.Application.Current.MainWindow.Close();
        }

        private void IsAdditionChecked(object sender, RoutedEventArgs e)
        {
            Handler.set_UsingAddition(true);
        }

        private void IsSubtractionChecked(object sender, RoutedEventArgs e)
        {
            Handler.set_UsingSubtraction(true);
        }

        private void IsMultiplicationChecked(object sender, RoutedEventArgs e)
        {
            Handler.set_UsingMultiplication(true);
        }

        private void IsDivisionChecked(object sender, RoutedEventArgs e)
        {
            Handler.set_UsingDivision(true);
        }
    }
}
