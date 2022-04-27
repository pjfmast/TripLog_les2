﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TripLog.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new TripLog.App());
            Xamarin.FormsMaps.Init("yqAJlXZzeOfa55Ickmio~1etyL81FOo65z_y0l1g7Xw~AnLt9yzS6dO9eUQlZk-HowrD6WtsTop8_uE8f6p-hUdh2_y2AalMKTsifo3zBT7Y");
        }
    }
}
