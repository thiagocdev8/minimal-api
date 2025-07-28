using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entities;
using minimal_api.Dominio.Servicos;
using minimal_api.infraestrutura.Db;


namespace Test.Domain.Servicos
{
    [TestClass]
    public class AdministradorServicosTest
    {

        private DbContexto CriarContextoDeTeste()
        {
            var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // unique DB per test run
            .Options;

            return new DbContexto(options);
        }


        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
            // Arrange
            var context = CriarContextoDeTeste();
            context.Administradores.RemoveRange(context.Administradores);
            context.SaveChanges();
            
            var adm = new Administrador();
            adm.Id = 1;
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";
            
            var administradorServicos = new AdministradorServico(context);


            // Act
            administradorServicos.Incluir(adm);


            // Assert
            Assert.AreEqual(1, administradorServicos.Todos(1).Count());
   
        }
    }
}