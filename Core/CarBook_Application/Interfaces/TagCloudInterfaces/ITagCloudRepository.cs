using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        public List<TagCloud> GetTagCloudsByBlogId(int id);
    }
}
