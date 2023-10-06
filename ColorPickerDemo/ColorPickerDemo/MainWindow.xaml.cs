﻿using System.Windows;
using ColorPicker.Models;

namespace ColorPickerDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        combobox.SelectionChanged += (sender, args) =>
        {
            square_picker.PickerType = combobox.SelectedIndex == 0 ? PickerType.HSV : PickerType.HSL;
        };
    }
}