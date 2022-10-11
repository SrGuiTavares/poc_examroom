using CarDealer.Application.Interface;
using CarDealer.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.WebApi.Controllers
{
    [Route("Car")]
    public class CarController : ControllerBase
    {
        private readonly ICarAppService _carAppService;

        public CarController(ICarAppService carAppService)
        {
            _carAppService = carAppService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _carAppService.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(CarViewModel viewModel)
        {
            try
            {
                return Ok(await _carAppService.Insert(viewModel));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(CarViewModel viewModel)
        {
            try
            {
                return Ok(await _carAppService.Update(viewModel));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(CarViewModel viewModel)
        {
            try
            {
                return Ok(await _carAppService.Delete(viewModel));
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
