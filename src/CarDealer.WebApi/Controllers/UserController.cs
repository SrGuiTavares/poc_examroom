using CarDealer.Application.Interface;
using CarDealer.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using SecureIdentity.Password;

namespace CarDealer.WebApi.Controllers
{
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(UserViewModel viewModel)
        {
            viewModel.Password = PasswordHasher.Hash(viewModel.Password);

            var response = await _userAppService.Insert(viewModel);

            return Ok(response);
        }

    }
}
