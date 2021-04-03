using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {

        }
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.Endereco, "Informe um e-mail válido")
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve conter entre 6 a 32 caracteres")

        //    if (string.IsNullOrEmpty(request.Email))
        //    {
        //        throw new Exception("Informe um email.");
        //    }

        //    if (IsEmail(request.Email))
        //    {
        //        throw new Exception("Informe um email.");
        //    }

        //    if (string.IsNullOrEmpty(request.Senha))
        //    {
        //        throw new Exception("Informe a senha correta.");
        //    }


        //    if (request.Senha.Length < 6)
        //    {
        //        throw new Exception("Digite uma senha no minímo de 6 caractéres.");
        //    }

        //    var response = _repositoryJogador.AutenticarJogador(request);

        //    return response;
        //}
    }

        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumStatusJogador Status { get; set; }
    }
}
