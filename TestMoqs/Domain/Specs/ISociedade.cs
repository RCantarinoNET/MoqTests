using System;
using TestMoqs.Domain.Entities;

namespace TestMoqs.Domain.Specs
{
    public interface ISociedade
    {
        Socio GetSocioById(Guid Id);
    }
}