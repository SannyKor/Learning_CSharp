using System;
using System.Collections.Generic;
using System.Text;
using Task_3;


namespace Task_3
{
    internal class StopwatchPresenter
    {

        private readonly IStopwatchView _view;
        private readonly StopwatchModel _model;

        public StopwatchPresenter(IStopwatchView view, StopwatchModel model)
        {
            _view = view;
            _model = model;

            // Підписка на події View
            _view.StartClicked += (s, e) => _model.Start();
            _view.StopClicked += (s, e) => _model.Stop();
            _view.ResetClicked += (s, e) => _model.Reset();

            // Підписка на зміни в Model
            _model.OnTimeChanged += (time) =>
            {
                _view.UpdateDisplay(time.ToString(@"hh\:mm\:ss\.ff"));
            };
        }
    }
}
