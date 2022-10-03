using CarDealer.Application.Interface;
using CarDealer.Application.ViewModel;
using CarDealer.WebApi.Service;
using Microsoft.AspNetCore.Mvc;
using SecureIdentity.Password;

namespace CarDealer.WebApi.Controllers
{
    [Route("Login")]
    public class LoginController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private readonly IUserAppService _userAppService;

        public LoginController(TokenService tokenService, IUserAppService userAppService)
        {
            _tokenService = tokenService;
            _userAppService = userAppService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = _userAppService.GetByName(viewModel.Name);

            if (user.Result == null || user == null)
                return StatusCode(401);

            if (!PasswordHasher.Verify(user.Result.Password, viewModel.Password))
                return StatusCode(401);

            try
            {
                var token = _tokenService.GenerateToken(user.Result);

                return Ok(token);
            }
            catch
            {
                return StatusCode(400);
            }

        }

    }
}
