using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Converter
    {
        private readonly double usd, eur, rub;

        public Converter() { }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double GrnToUsd(double amount)
        {
            return amount / usd;
        }
        public double GrnToEur(double amount) => amount / eur;
        public double GrnToRub(double amount) => amount / rub;
        public double UsdToGrn(double amount) => amount * usd;
        public double EurToGrn(double amount) => amount * eur;
        public double RubToGrn(double amount) => amount * rub;
    }
}
