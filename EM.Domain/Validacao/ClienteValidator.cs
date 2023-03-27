using EM.Domain.Entidades;
using FluentValidation;

namespace EM.Domain.Validacao
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Nome).Length(0, 10);
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}

