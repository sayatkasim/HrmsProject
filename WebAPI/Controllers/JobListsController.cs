using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobListsController : ControllerBase
    {
        IJobListService _jobListService;

        public JobListsController(IJobListService jobListService)
        {
            _jobListService = jobListService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _jobListService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(JobList jobList)
        {
            var result = _jobListService.Add(jobList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(JobList jobList)
        {
            var result = _jobListService.Delete(jobList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
