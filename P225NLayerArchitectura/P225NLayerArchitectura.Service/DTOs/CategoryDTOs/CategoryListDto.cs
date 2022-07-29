using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Service.DTOs.CategoryDTOs
{
    public class CategoryListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
    }
}
