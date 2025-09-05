namespace GerenciadorLivrosBackend.Services
{
    public class ApiResponseService
    {
        public class Response
        {
            public bool Status { get; set; }
            public string Mensagem { get; set; }
            public object? Dados { get; set; }
        }

        public Response ApiResponse (bool status, string mensagem, object dados = null)
        {
            return new Response
            {
                Status = status,
                Mensagem = mensagem,
                Dados = dados
            };
        }
    }
}
