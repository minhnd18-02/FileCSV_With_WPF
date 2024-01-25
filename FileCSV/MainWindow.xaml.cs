using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using Repository3.Services;
using FileCSV;
using Repository3;
using Repository3.Models;

namespace FileCSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MarkReport> markReports;
        private readonly MarkReportServices _markReportService;
        public MainWindow()
        {
            _markReportService = new MarkReportServices(new Repository3.Models.FileCsvContext());
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data when the window is loaded
            LoadData();
        }

        private void LoadData()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = ""; // Clear any initially set file name
            ofd.ShowDialog();

            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    markReports = csv.GetRecords<MarkReport>().ToList();
                }

                dtMark.ItemsSource = markReports;
            }
        }

        //private void btnCalculate_Click(object sender, RoutedEventArgs e)
        //{
        //    if (markReports == null || markReports.Count == 0)
        //    {
        //        MessageBox.Show("Please load data first.", "No Data", MessageBoxButton.OK, MessageBoxImage.Warning);
        //        return;
        //    }

        //    // Calculate average mathematics score
        //    decimal totalScore = 0;
        //    foreach (var markReport in markReports)
        //    {
        //        if (decimal.TryParse(markReport.Mathematics, out decimal score))
        //        {
        //            totalScore += score;
        //        }
        //    }
        //    decimal averageScore = totalScore / markReports.Count;

        //    // Display the average score
        //    // MessageBox.Show($"Average Mathematics Score: {averageScore:F2}", "Average Score", MessageBoxButton.OK, MessageBoxImage.Information);

        //    // Determine the top 3 provinces with the highest average scores
        //    var topProvinces = markReports
        //        .GroupBy(report => report.Province)
        //        .Select(group => new
        //        {
        //            Province = group.Key,
        //            AverageScore = group.Average(report => decimal.TryParse(report.Mathematics, out decimal score) ? score : 0)
        //        })
        //        .OrderByDescending(item => item.AverageScore)
        //        .Take(3)
        //        .ToList();

        //    // Display the top 3 provinces
        //    string topProvincesMessage = "Top 3 Provinces with Highest Average Scores:\n";
        //    foreach (var province in topProvinces)
        //    {
        //        topProvincesMessage += $"{province.Province}: {province.AverageScore:F2}\n";
        //    }

        //    MessageBox.Show(topProvincesMessage, "Top Provinces", MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        private void btnBrowseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = ""; // Clear any initially set file name
            ofd.ShowDialog();
            string sPath = ofd.FileName;
            txtFile.Text = sPath;
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var headers = csv.HeaderRecord;
                    markReports = csv.GetRecords<MarkReport>().ToList();
                    
                }
                dtMark.ItemsSource = markReports;
            }
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            if (markReports != null)
            {
                _markReportService.AddMany(markReports);
                MessageBox.Show("Student success");
            }

        }

        private void cbYear_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedYear = cbYear.SelectedItem as string;

            // Check if an item is selected
            if (!string.IsNullOrEmpty(selectedYear))
            {
                // Perform actions based on the selected year
                // For example, you can display a message box
                MessageBox.Show($"Selected year: {selectedYear}");
            }
        }

        private void btnShowStatistic_Click(object sender, RoutedEventArgs e)
        {
            using ( var context = new FileCsvContext())
            {
                var loaderData = new LoadData(context);

                List<DataStatistics> dataStatistics = loaderData.LoadStatistics();
                listView.ItemsSource = dataStatistics;
                
            }
        }
    }
}


