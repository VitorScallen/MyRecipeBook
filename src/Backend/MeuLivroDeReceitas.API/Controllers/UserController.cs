using MeuLivroDeReceitas.Application.UseCases.User.Register;
using MeuLivroDeReceitas.Communication.Requests;
using MeuLivroDeReceitas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MeuLivroDeReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            var useCase = new RegisterUserUseCase();

            var result = useCase.Execute(request);

            return Created(string.Empty, result);
        }
    }
}
