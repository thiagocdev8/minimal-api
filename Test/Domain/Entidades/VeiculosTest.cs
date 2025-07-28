using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minimal_api.Dominio.Entities;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculosTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Civic";
            veiculo.Marca = "Honda";
            veiculo.Ano = 1400;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Civic", veiculo.Nome);
            Assert.AreEqual("Honda", veiculo.Marca);
            Assert.AreEqual(1400, veiculo.Ano);
        }
    }
}