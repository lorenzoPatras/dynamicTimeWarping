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

namespace DynamicTimeWarping {

  public partial class MainWindow : Window {

    private LinkedList<double> dynamicSignal = new LinkedList<double>();
    private LinkedList<double> staticSignal = new LinkedList<double>();

    public MainWindow() {
      InitializeComponent();

      InitDynamicSignal();
      PlotDynamicSignal();

      InitStaticSignal();
      PlotStaticSignal();
    }

    private void InitDynamicSignal()
    {
      dynamicSignal.AddLast(1.2);
      dynamicSignal.AddLast(2.8);
      dynamicSignal.AddLast(3.1);
      dynamicSignal.AddLast(3.4);
      dynamicSignal.AddLast(4.0);
      dynamicSignal.AddLast(1.9);
      dynamicSignal.AddLast(5.8);
      dynamicSignal.AddLast(6.4);
      dynamicSignal.AddLast(8.9);
      dynamicSignal.AddLast(9.8);
      
      dynamicSignal.AddLast(8.7);
      dynamicSignal.AddLast(8.2);
      dynamicSignal.AddLast(6.1);
      dynamicSignal.AddLast(2.4);
      dynamicSignal.AddLast(2.6);
      dynamicSignal.AddLast(2.8);
      dynamicSignal.AddLast(3.5);
      dynamicSignal.AddLast(4.1);
      dynamicSignal.AddLast(1.2);
      dynamicSignal.AddLast(4.9);

      dynamicSignal.AddLast(5.3);
      dynamicSignal.AddLast(5.9);
      dynamicSignal.AddLast(6.4);
      dynamicSignal.AddLast(6.9);
      dynamicSignal.AddLast(7.5);
      dynamicSignal.AddLast(8.0);
      dynamicSignal.AddLast(7.8);
      dynamicSignal.AddLast(6.1);
      dynamicSignal.AddLast(8.9);
      dynamicSignal.AddLast(9.7);
    }

    private void PlotDynamicSignal()
    {
      List<KeyValuePair<int, double>> dynamicValues = new List<KeyValuePair<int, double>>();
      int index = 0;

      foreach (double val in dynamicSignal)
      {
        dynamicValues.Add(new KeyValuePair<int, double>(index++, val));
      }

      dynamicSeries.DataContext = dynamicValues;
    }

    private void InitStaticSignal()
    {
      staticSignal.AddLast(1.2);
      staticSignal.AddLast(2.8);
      staticSignal.AddLast(3.1);
      staticSignal.AddLast(3.4);
      staticSignal.AddLast(4.0);
      staticSignal.AddLast(1.9);
      staticSignal.AddLast(5.8);
      staticSignal.AddLast(6.4);
      staticSignal.AddLast(8.9);
      staticSignal.AddLast(9.8);

      staticSignal.AddLast(8.7);
      staticSignal.AddLast(8.2);
      staticSignal.AddLast(6.1);
      staticSignal.AddLast(2.4);
      staticSignal.AddLast(2.6);
      staticSignal.AddLast(2.8);
      staticSignal.AddLast(3.5);
      staticSignal.AddLast(4.1);
      staticSignal.AddLast(1.2);
      staticSignal.AddLast(4.9);

      staticSignal.AddLast(5.3);
      staticSignal.AddLast(5.9);
      staticSignal.AddLast(6.4);
      staticSignal.AddLast(6.9);
      staticSignal.AddLast(7.5);
      staticSignal.AddLast(8.0);
      staticSignal.AddLast(7.8);
      staticSignal.AddLast(6.1);
      staticSignal.AddLast(8.9);
      staticSignal.AddLast(9.7);
    }

    private void PlotStaticSignal()
    {
      List<KeyValuePair<int, double>> staticValues = new List<KeyValuePair<int, double>>();
      int index = 0;

      foreach (double val in staticSignal)
      {
        staticValues.Add(new KeyValuePair<int, double>(index++, val));
      }

      staticSeries.DataContext = staticValues;
    }

    private void DTWBtn_Click(object sender, RoutedEventArgs e)
    {

    }

    private void showPathBtn_Click(object sender, RoutedEventArgs e)
    {

    }

    private void insertSampleBtn_Click(object sender, RoutedEventArgs e)
    {
      dynamicSignal.RemoveLast();
      Random rnd = new Random();
      dynamicSignal.AddFirst(rnd.NextDouble() * 9 + 1);
      PlotDynamicSignal();
    }
  }
}
