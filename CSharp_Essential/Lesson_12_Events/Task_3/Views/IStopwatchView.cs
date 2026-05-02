using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public interface IStopwatchView
    {
       
            // Події, які бачить Presenter
            event EventHandler StartClicked;
            event EventHandler StopClicked;
            event EventHandler ResetClicked;

            // Метод для оновлення тексту
            void UpdateDisplay(string time);
        
    }
}
