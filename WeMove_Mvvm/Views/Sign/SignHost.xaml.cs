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

namespace WeMove_Mvvm.Views.Sign
{
    /// <summary>
    /// SignHost.xaml 的交互逻辑
    /// </summary>
    public partial class SignHost : UserControl
    {
        public SignHost()
        {
            InitializeComponent();
        }

        public FrameworkElement CurrentViewContent
        {
            get { return (FrameworkElement)GetValue(CurrentViewContentProperty); }
            set { SetValue(CurrentViewContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentViewContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentViewContentProperty =
            DependencyProperty.Register("CurrentViewContent", typeof(FrameworkElement), typeof(SignHost), new UIPropertyMetadata(default(FrameworkElement), null, CurrentViewPropertyChanged));

        private static object CurrentViewPropertyChanged(DependencyObject d, object baseValue)
        {
            (d as SignHost).NewFrame.Content = baseValue;
            return baseValue;
        }
    }
}
