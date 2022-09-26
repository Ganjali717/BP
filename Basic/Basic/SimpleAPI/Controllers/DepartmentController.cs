using Microsoft.AspNetCore.Mvc;
using SimpleAPI.DAL;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDbContext _context; 
        public DepartmentController(AppDbContext context) => _context = context;

        [HttpGet]
        public IActionResult GetAllIssues()
        {
            var issues = _context.Issues.ToList();
            if (issues == null) return BadRequest("404");
            return Ok(issues);
        }


        [HttpPost]
        public IActionResult AddIssue(Issue issue)
        {
            if (issue == null) return BadRequest("404");
            _context.Issues.Add(issue);
            return Ok();
        }
    }
}