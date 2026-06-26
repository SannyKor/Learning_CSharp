using System;
using System.Collections.Generic;
using System.Text;
using Task_4;

namespace Task_4
{
    public class ApplicationSettings
    {
        public string HeaderText { get; set; } = "";
        public string WindowTitle { get; set; } = "";
        public int FontSize { get; set; }
        public string BackgroundColor { get; set; } = "White";
        public string TextColor { get; set; } = "Black";
    }
}
public class ConfigurationRoot
{
    public ApplicationSettings Application { get; set; } = new();
}
