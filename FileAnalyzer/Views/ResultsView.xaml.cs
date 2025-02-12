using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace FileAnalyzer.Views
{
    public sealed partial class ResultsView : UserControl
    {
        public ResultsView()
        {
            this.InitializeComponent();
        }

        public void UpdateResults(List<FileAnalysisResult> analysisResults)
        {
            resultsListView.ItemsSource = analysisResults;
        }
    }

    public class FileAnalysisResult
    {
        public string FileName { get; set; }
        public string Importance { get; set; }
    }
}
