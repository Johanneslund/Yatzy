﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Yatzy.GameEngine;
using Yatzy.Models;

namespace Yatzy.Views
{
    /// <summary>
    /// Interaction logic for DicesView.xaml
    /// </summary>
    public partial class DicesView : Window
    {
        //DicesViewModel dicesViewModel;

        public DicesView()
        {
            //dicesViewModel = new DicesViewModel();
            //this.DataContext = dicesViewModel;
            InitializeComponent();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {

        }
    }
}
