using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FileAnalyzer.Views
{
    public sealed partial class TokenConfigurationView : UserControl
    {
        public TokenConfigurationView()
        {
            this.InitializeComponent();
            saveButton.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string token = tokenTextBox.Text;
            string config = configTextBox.Text;

            // Logic to save the token and configuration
        }
    }
}
