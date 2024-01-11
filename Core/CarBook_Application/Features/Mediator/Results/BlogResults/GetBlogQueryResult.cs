﻿using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryID { get; set; }
    }
}
