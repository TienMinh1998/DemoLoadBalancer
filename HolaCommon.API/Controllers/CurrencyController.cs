using Core;
using HolaCommon.API.DTOs.Currencies;
using HolaCommon.API.Services.Currencies;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HolaCommon.API.Controllers
{
    [ApiController]
    [Route("Currency")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class CurrencyController : ControllerBase
    {
        private readonly CurrencyService _service;
        private readonly ILogger<CurrencyController> _logger;

        public CurrencyController(ILogger<CurrencyController> logger, CurrencyService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] GetCurrencyListRequest request)
        {
            var result = await _service.SearchAsync(request);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetCurrencyRequest request)
        {
            var result = await _service.GetAsync(request);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] AddCurrencyRequest request)
        {
            var result = await _service.AddNewAsync(request);
            return Ok(result);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> Edit([FromBody] EditCurrencyRequest request)
        {
            var result = await _service.UpdateAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCurrencyRequest request)
        {
            var result = await _service.DeleteAsync(request);
            return Ok(result);
        }
       static int count = 0;
       [HttpGet("TestLoadBalancer")] 
       public async Task<JsonResponseModel> TestLoadBalancer()
        {
            count++;
            JsonResponseModel responseModel = new JsonResponseModel();
            responseModel.Status = 200;
            responseModel.Message = "Connect to server Success";
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            responseModel.Data = myIP + " Visited_Count : " + count;
            return await Task.FromResult(responseModel);
        }
    }
}
