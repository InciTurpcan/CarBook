﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Dto.BlogDtos
{
    public class ResultLast3BlogsWithAuthorsDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryID { get; set; }
        public string AuthorName { get; set; }
    }
}
