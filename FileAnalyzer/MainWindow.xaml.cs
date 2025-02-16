using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Gemini.v2;
using Google.Apis.Gemini.v2.Data;
using FileAnalyzer.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FileAnalyzer
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavigateToFolderSelectionView();
        }

        private void NavigateToFolderSelectionView()
        {
            MainFrame.Navigate(typeof(FolderSelectionView));
        }

        private void NavigateToTokenConfigurationView()
        {
            MainFrame.Navigate(typeof(TokenConfigurationView));
        }

        private void NavigateToExecutionView()
        {
            MainFrame.Navigate(typeof(ExecutionView));
        }

        private void NavigateToResultsView()
        {
            MainFrame.Navigate(typeof(ResultsView));
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToFolderSelectionView();
        }

        private async Task<List<FileAnalysisResult>> AnalyzeFilesAsync()
        {
            // Initialize the Google Gemini 2.0 Flash API client
            var credential = await GoogleCredential.GetApplicationDefaultAsync();
            var service = new GeminiService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "FileAnalyzer",
            });

            // Simulate file analysis process
            await Task.Delay(2000); // Simulate delay for analysis

            // Create dummy analysis results
            var results = new List<FileAnalysisResult>
            {
                new FileAnalysisResult { FileName = "file1.txt", Importance = "High" },
                new FileAnalysisResult { FileName = "file2.txt", Importance = "Medium" },
                new FileAnalysisResult { FileName = "file3.txt", Importance = "Low" }
            };

            return results;
        }

        private void UpdateListView(List<FileAnalysisResult> analysisResults)
        {
            // Logic to update the ListView with analysis results
        }
    }

    public class FileAnalysisResult
    {
        public string FileName { get; set; }
        public string Importance { get; set; }
    }
}
