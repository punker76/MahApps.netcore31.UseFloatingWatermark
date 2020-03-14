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
using MahApps.Metro.Controls;

namespace WpfApp2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    public static readonly DependencyProperty MyPropertyProperty = DependencyProperty.Register(
        "MyProperty", typeof(string), typeof(MainWindow), new PropertyMetadata(default(string)));

    public string MyProperty
        {
        get { return (string) GetValue(MyPropertyProperty); }
        set { SetValue(MyPropertyProperty, value); }
    }
  }
}
