using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void DeveAtribuirNomeEMailNoConstrutor()
        {
            // Arrange
            var nome = "Denis";
            var email = "denisferrari@azys.com.br";

            // Act
            var usuario = new Usuario(nome, email);

            // Assert
            Assert.AreEqual(nome, usuario.Nome);
            Assert.AreEqual(email, usuario.Email);
        }
    }
}
