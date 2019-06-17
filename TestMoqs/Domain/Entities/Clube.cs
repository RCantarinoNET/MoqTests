using System;
using TestMoqs.Domain.Specs;

namespace TestMoqs.Domain.Entities
{
    public class Clube
    {
        private readonly ISociedade _socio;

        public Clube(ISociedade socio)
        {
            this._socio = socio;
        }

        public double CalculaFrete(Guid idSocio)
        {
            double _valorFrete = 0;
            var socio = _socio.GetSocioById(idSocio);
            _valorFrete = 10 + socio.Limite * 0.8;

            return _valorFrete;
        }
    }
}