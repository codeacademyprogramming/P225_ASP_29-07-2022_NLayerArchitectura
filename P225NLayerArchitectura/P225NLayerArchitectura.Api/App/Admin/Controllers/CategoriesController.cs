using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P225NLayerArchitectura.Service.DTOs.CategoryDTOs;
using P225NLayerArchitectura.Service.Exceptions;
using P225NLayerArchitectura.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Api.App.Admin.Controllers
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CategoryPostDto categoryPostDto)
        {
            await _categoryService.PostAsyn(categoryPostDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }
    }
}
