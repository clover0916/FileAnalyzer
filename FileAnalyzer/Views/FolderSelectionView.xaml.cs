using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.IO;
using Windows.Storage.Pickers;
using Windows.Storage;

namespace FileAnalyzer.Views
{
    public sealed partial class FolderSelectionView : UserControl
    {
        public FolderSelectionView()
        {
            this.InitializeComponent();
            browseButton.Click += BrowseButton_Click;
            confirmButton.Click += ConfirmButton_Click;
        }

        private async void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FolderPicker();
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.FileTypeFilter.Add("*");

            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(App.Current.MainWindow);
            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);

            StorageFolder folder = await picker.PickSingleFolderAsync();
            if (folder != null)
            {
                folderPathTextBox.Text = folder.Path;
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = folderPathTextBox.Text;
            if (Directory.Exists(folderPath))
            {
                // Logic to handle the confirmed folder path
            }
            else
            {
                // Show error message
            }
        }
    }
}
