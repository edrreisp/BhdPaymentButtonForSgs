using System.Threading.Tasks;
using BhdPaymentButtonForSgs.Infrastructure.Dtos;
using BhdPaymentButtonForSgs.Services;
using Microsoft.AspNetCore.Mvc;

namespace BhdPaymentButtonForSgs.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class BhdPaymentButtonController: ControllerBase
    {
        readonly IBhdPaymentButtonService _bhdPaymentButtonService;
        public BhdPaymentButtonController(IBhdPaymentButtonService bhdPaymentButtonService)
        {
            _bhdPaymentButtonService = bhdPaymentButtonService;
        }

        [HttpPost("PayWithBhdButtonClient")]
        public async Task<IActionResult> PayWithBhdButton([FromBody] BhdPaymentButtonApiDto dto)
        {
            return Ok(await _bhdPaymentButtonService.PayWithBhdButton(dto));
        }
    }
}
