using System;
using TestMoqs.Domain.Entities;

namespace TestMoqs.Interfaces
{
    public class Manager : Domain.Specs.ISociedade
    {
        public Socio GetSocioById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}