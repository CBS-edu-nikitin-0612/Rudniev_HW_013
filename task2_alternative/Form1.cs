using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_alternative
{
    public partial class Form1 : Form
    {
        Converter converter;
        public Form1()
        {
            InitializeComponent();
            converter = new Converter(28, 32, 0.35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)valute1.SelectedItem == "grn")
                if ((string)valuteTo.SelectedItem == "usd")
                    resLable.Text = "Получилось: " + Convert.ToString(converter.GrnToUsd((double)amount.Value));
                else if ((string)valuteTo.SelectedItem == "eur")
                    resLable.Text = "Получилось: " + Convert.ToString(converter.GrnToEur((double)amount.Value));
                else if ((string)valuteTo.SelectedItem == "rub")
                    resLable.Text = "Получилось: " + Convert.ToString(converter.GrnToRub((double)amount.Value));
            if ((string)valute1.SelectedItem == "usd")
                resLable.Text = "Получилось: " + Convert.ToString(converter.UsdToGrn((double)amount.Value));
            if ((string)valute1.SelectedItem == "eur")
                resLable.Text = "Получилось: " + Convert.ToString(converter.EurToGrn((double)amount.Value));
            if ((string)valute1.SelectedItem == "rub")
                resLable.Text = "Получилось: " + Convert.ToString(converter.RubToGrn((double)amount.Value));
        }
    }
}
