using Demo.Models;
using Demo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Presenter
{
    public class CalculatorPresenter
    {
        private Calculator calculator = new Calculator();
        ICalculator view;

        public CalculatorPresenter(ICalculator view)
        {
            this.view = view;
        }

        public void GetData()
        {
            calculator.NumberOne = Convert.ToDouble(view.TxtNumberOne);
            calculator.NumberTwo = Convert.ToDouble(view.TxtNumberTwo);
        }

        public void Add()
        {
            GetData();
            view.TxtResult = calculator.Add().ToString();
        }

        public void Subtract()
        {
            GetData();
            view.TxtResult = calculator.Subtract().ToString();
        }
        public void Multiple()
        {
            GetData();
            view.TxtResult = calculator.Multiple().ToString();
        }

        public void Diviton()
        {
            GetData();
            if (Convert.ToDouble(view.TxtNumberOne) == 0)
            {
                MessageBox.Show("Can't Diviton", "Error", MessageBoxButtons.OK);
            }
            view.TxtResult = calculator.Diviton().ToString();
        }
    }

}
