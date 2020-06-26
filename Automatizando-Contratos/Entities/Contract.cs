

using System;
using System.Collections.Generic;

namespace Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            Installment = new List<Installment>();
        }
        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }
    }

}
