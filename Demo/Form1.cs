using Demo.Presenter;
using Demo.View;

namespace Demo
{
    public partial class Form1 : Form, ICalculator
    {
        CalculatorPresenter presenter;
        public Form1()
        {
            InitializeComponent();

            presenter = new CalculatorPresenter(this);
        }

        
        string ICalculator.TxtNumberOne { get => TxtNumberOne.Text; set => TxtNumberOne.Text = value; }
        string ICalculator.TxtNumberTwo { get => TxtNumberTwo.Text; set => TxtNumberTwo.Text = value; }
        string ICalculator.TxtResult { get => TxtResult.Text; set => TxtResult.Text = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.Add();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            presenter.Subtract();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            presenter.Multiple();
        }

        private void btnDiviton_Click(object sender, EventArgs e)
        {
            presenter.Diviton();
        }
    }
}