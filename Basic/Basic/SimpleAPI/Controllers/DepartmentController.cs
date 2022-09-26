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
            return issues == null ? NotFound() : Ok(issues);
        }

        [HttpGet]
        public IActionResult GetbyId(Guid id)
        {
            var issue = _context.Issues.Where(x=> x.Id == id).FirstOrDefault();
            return issue == null ? NotFound() : Ok(issue);
        }
        

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddIssue(Issue issue)
        {
            if (issue == null) return BadRequest("404");
            _context.Issues.Add(issue);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetbyId), new {id = issue.Id}, issue);
        }
    }
}