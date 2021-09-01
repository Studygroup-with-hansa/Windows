﻿using System;
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

namespace Studygroup_with_Hansa.Views
{
    /// <summary>
    /// Interaction logic for DuringStudyPage.xaml
    /// </summary>
    public partial class DuringStudyPage : Page
    {
        private static Page beforePage = null;

        public DuringStudyPage()
        {
            InitializeComponent();
        }

        public DuringStudyPage(Page page)
        {
            InitializeComponent();
            beforePage = page;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(beforePage);
        }
    }
}
