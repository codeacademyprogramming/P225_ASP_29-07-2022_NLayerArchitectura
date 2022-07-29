using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Service.DTOs.CategoryDTOs
{
    public class CategoryPostDto
    {
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public Nullable<int> ParentId { get; set; }
        public IFormFile File { get; set; }
    }
}
