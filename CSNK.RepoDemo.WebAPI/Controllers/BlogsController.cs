using CSNK.RepoDemo.Domain.Models;
using CSNK.RepoDemo.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CSNK.RepoDemo.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;   
        public BlogsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var blogs = _unitOfWork.Blog.GetAll().Result.ToList();

            return Ok(blogs);                       
        }
        

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.Blog.Get(id).Result);
        }
    }
}
