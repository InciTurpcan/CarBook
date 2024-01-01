using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public int? BrandID { get; set; }
        public string Name { get; set; }
      
    }
}
