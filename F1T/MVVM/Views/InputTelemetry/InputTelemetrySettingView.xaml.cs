﻿using F1T.MVVM.ViewModels;
using F1T.Core;
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
using F1T.Themes;

namespace F1T.MVVM.Views.InputTelemetry
{
    /// <summary>
    /// Interaction logic for InputTelemetrySettingView.xaml
    /// </summary>
    public partial class InputTelemetrySettingView : BaseSettingView<InputTelemetryViewModel>
    {
        public InputTelemetrySettingView()
        {
            InitializeComponent();
            this.DataContext = Model;
        }

        public override InputTelemetryViewModel Model { get => InputTelemetryViewModel.GetInstance(); }

        protected override ToggleButton VisibilityButton { get => VisibilityButtonInstance; }
        protected override Slider OpacitySlider { get => OpacitySliderInstance; }


        public void OnToggleVisibilityButton_Click(object sender, RoutedEventArgs e){}
        public void ViewToggleVisibilityButton_Click(object sender, RoutedEventArgs e){ this.ToggleVisibilityButton_Click(sender, e); }

    }
}
