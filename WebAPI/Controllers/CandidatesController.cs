using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _candidateService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(Candidate candidate)
        {
            var result = _candidateService.Add(candidate);
            return Ok(result);
        }

        
    }
}
