using Moq;
using NUnit.Framework;
using System;
using TestMoqs.Domain.Entities;
using TestMoqs.Domain.Specs;

namespace Tests
{
    public class Tests
    {
        private Clube _target;
        private Mock<ISociedade> _mock;

        [SetUp]
        public void Setup()
        {
            _mock = new Mock<ISociedade>();
            _target = new Clube(_mock.Object);
        }

        [Test]
        public void Test1()
        {
            Socio _socio = new Socio()
            {
                Id = Guid.NewGuid(),
                Nome = "Renato ",
                Sobrenome = "Cantarino",
                Idade = 45,
                Limite = 5,
            };

            _mock.Setup(x => x.GetSocioById(It.IsAny<Guid>())).Returns(_socio);

            var socioID = _socio.Id;
            double esperado = 14;
            double obtido = _target.CalculaFrete(socioID);
            Assert.AreEqual(esperado, obtido);
        }
    }
}