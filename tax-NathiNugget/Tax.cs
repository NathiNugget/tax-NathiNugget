using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tax_NathiNugget
{
    public class Tax
    {
        private int taxToPay;
        private double taxPercent;

        public Tax(Role role, int income)
        {
            TaxPercent = role switch
            {
                Role.Studerende or Role.Pensionist => income switch
                {
                    < 0 => 0, 
                    _ => 0.05, 
                },
                Role.Underviser => income switch
                {
                    < 0 => 0,
                    <= 20000 => 0.1,
                    _ => 0.2,
                },
                _ => throw new ArgumentOutOfRangeException(),
            }; 
            TaxToPay = (int) (income * taxPercent); 
        }

        public int TaxToPay { get => taxToPay; private set => taxToPay = value; }
        public double TaxPercent { get => taxPercent; set => taxPercent = value; }
    }

    public enum Role
    {
        Studerende = 1, 
        Pensionist = 2, 
        Underviser = 3, 
    }
}
