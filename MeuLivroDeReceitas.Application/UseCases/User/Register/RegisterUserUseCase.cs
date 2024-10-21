using MeuLivroDeReceitas.Communication.Requests;
using MeuLivroDeReceitas.Communication.Responses;
using System.Security.Cryptography.X509Certificates;

namespace MeuLivroDeReceitas.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            Validate(request);

            return new ResponseRegisterUserJson();
        }

        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMenssages = result.Errors.Select(e => e.ErrorMessage);

                throw new Exception();
            }
        }
    }
}
