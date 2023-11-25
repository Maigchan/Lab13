using Demo2023API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo2023API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductCustomController : ControllerBase
    {

        private readonly InvoiceContext _context;

        [HttpGet]
        public List<Product> GetProductWithCategoryName(string CategoryName)
        {
            //Inner Join para inclusion de categoria y producto
            var response = _context.Products.Include(x => x.Category).
                Where(x => x.Category.Name.Contains(CategoryName)).
                ToList();

            return response;
        }

        [HttpGet]
        public List<Product> GetProductWithCategory(string CategoryName)
        {
            //Inner Join para inclusion de categoria y producto
            var response = _context.Products.Include(x => x.Category).ToList();

            return response;
        }
    }
}
