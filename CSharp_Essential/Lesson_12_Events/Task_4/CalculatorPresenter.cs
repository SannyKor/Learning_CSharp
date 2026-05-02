using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public class CalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly CalculatorModel _model;
        public CalculatorPresenter(ICalculatorView view, CalculatorModel model)
        {
            _view = view;
            _model = model;
            _view.CalcClick += OnCalcClick;
        }
        private void OnCalcClick(object sender, EventArgs e)
        {
            try
            {
                double value1 = _view.Value1;
                double value2 = _view.Value2;
                string operation = _view.Operation;

                _view.Result = _model.Calculate(value1, value2, operation);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}
