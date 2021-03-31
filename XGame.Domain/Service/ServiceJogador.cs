using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {

            Guid id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação Realizada com sucesso!" };
        } 

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if(request == null)
            {
                throw new Exception("AutenticarJogadorRquest é obrigatório"); 
            }

            if(string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um email.");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe a senha correta.");
            }


            if (request.Senha.Length < 6)
            {
                throw new Exception("Digite uma senha com o minímo de 6 caractéres.");
            }

            var response  = _repositoryJogador.AutenticarJogador(request);

            return response;            
        }
    }
}
