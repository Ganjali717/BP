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
        [ProducesResponseType(typeof(Issue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetbyId(Guid id)
        {
            var issue = _context.Issues.FirstOrDefault(x => x.Id == id);
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

        [HttpGet]
        [ProducesResponseType(typeof(Issue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetbyTitle(string title)
        {
            var issue = _context.Issues.FirstOrDefault(x => x.Title == title);
            return issue == null ? NotFound() : Ok(issue);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateIssue(Issue model)
        {
            var issue = _context.Issues.FirstOrDefault(x => x.Id == model.Id);
            if (issue == null) return NotFound();
            issue.Title = model.Title;
            issue.Description = model.Description;
            issue.Completed = model.Completed; 
            issue.Created = model.Created;
            issue.IssueType = model.IssueType;
            issue.Priority = model.Priority;
            _context.SaveChanges();
            return Ok();
        }
    }
}