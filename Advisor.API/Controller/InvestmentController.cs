using Advisor.Core.Domain.DTOs;
using Advisor.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Advisor.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {

        private readonly IInvestmentService _service;

        private readonly IHttpContextAccessor _httpContext;

        public InvestmentController(IInvestmentService service, IHttpContextAccessor httpContext)
        {
            _service = service;
            _httpContext = httpContext;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<InvestmentDTO>> Create(InvestmentDTO request)
        {
            var email = string.Empty;
            if (_httpContext.HttpContext != null)
            {
                email = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            }
            var res = await _service.CreateInvestment(request,email);
            if (res == null)
                return BadRequest("Investment is already there.");
            return Ok("Investment Added.");
        }

        [HttpGet("Get")]
        public async Task<ActionResult<InvestmentDTO?>> GetInvestment(InvestmentDTO request )
        {

            var email = string.Empty;
            if (_httpContext.HttpContext != null)
            {
                email= _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            }

            InvestmentDTO res = await _service.GetInvestment(request,email);
            if (res is null)
                return NoContent();
            return Ok(res);
        }

        [HttpPut("Update")]
        public async Task<ActionResult<InvestmentDTO>> UpdateInvestment(InvestmentDTO request, string email)
        {
            var emaill = string.Empty;
            if (_httpContext.HttpContext != null)
            {
                emaill = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            }
            InvestmentDTO res = await _service.UpdateInvestment(request,email);
            if (res is null)
                return NoContent();
            return Ok(res);
        }


    }
}
