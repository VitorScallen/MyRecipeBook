using MeuLivroDeReceitas.Communication.Requests;

namespace MeuLivroDeReceitas.Communication.Responses
{
    public class ResponseRegisterUserJson
    {
        public string Name { get; set; }

        public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            return new ResponseRegisterUserJson
            {
                Name = request.Name,
            };
        }
    }
}
