using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Controls;

namespace RadControlThemeDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            StyleManager.ApplicationTheme = new Windows8Theme();
        }
        static App()
        {
            //FontSize Style
            Windows8Palette.Palette.FontSize = 15;
            Windows8Palette.Palette.FontSizeS = 14;
            Windows8Palette.Palette.FontSizeL = 15;
            Windows8Palette.Palette.FontSizeXL = 20;
            Windows8Palette.Palette.FontSizeXXL = 24;

            //FontFamily Style
            Windows8Palette.Palette.FontFamily = new FontFamily("Segoe UI Light, Microsoft JhengHei, Microsoft YaHei");
            Windows8Palette.Palette.FontFamilyLight = new FontFamily("Segoe UI Light, Microsoft JhengHei, Microsoft YaHei");
            Windows8Palette.Palette.FontFamilyStrong = new FontFamily("Segoe UI Light, Microsoft JhengHei, Microsoft YaHei");
            
            //Colors Style
            Windows8Palette.Palette.MainColor = Colors.Black;
            Windows8Palette.Palette.AccentColor = Colors.Orange;
            Windows8Palette.Palette.BasicColor = Colors.DarkGray;
            Windows8Palette.Palette.StrongColor = Colors.Gray;
            Windows8Palette.Palette.MarkerColor = Colors.LightGray;
            Windows8Palette.Palette.ValidationColor = Colors.Red;
            
        }
    }
}
