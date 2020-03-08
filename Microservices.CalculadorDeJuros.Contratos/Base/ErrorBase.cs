using System.Collections.Generic;
using System.Linq;

namespace Microservices.CalculadorDeJuros.Contratos.Base
{
    public abstract class ErrorBase
    {
        protected ErrorBase() => Errors = new List<string>();

        public ICollection<string> Errors { get; protected set; }

        public bool IsValid => Errors.Count == 0;

        public void AddError(string erro)
        {
            if (!Errors.Contains(erro))
                Errors.Add(erro);
        }

        public void AddError(ICollection<string> erros) => erros.ToList().ForEach(AddError);
    }
}