using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.ViewModel
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {
            Amounts = new List<decimal>();
        }
        public string Model { get; set; }
        public List<decimal> Amounts { get; set; }
        public string Brand { get; set; }
        public string CoverImgUrl { get; set; }
    }
}
