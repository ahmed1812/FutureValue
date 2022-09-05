using System;
using System.ComponentModel.DataAnnotations;

namespace csharp.FutureValue.Models
{
    public class FutureValue
    {
        [Required(ErrorMessage = "Please enter a monthly investment")]
        [Range(1, 500, ErrorMessage = "monthly investment amount must be between 1 and 500")]
        public decimal? MonthyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a yearky rate")]
        [Range(0.1, 10.0, ErrorMessage = "yearky interest rate must be between 0.1 and 10.0")]
        public decimal? YearlyInter { get; set; }

        [Required(ErrorMessage = "Please enter a number of years")]
        [Range(1, 50, ErrorMessage = "number of years must be between 1 and 50")]
        public int? Years { get; set; }



        public decimal? CalculatFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyIner = YearlyInter / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthyInvestment) * (1 + monthlyIner);
            }
            return futureValue;
        }
    }
}

