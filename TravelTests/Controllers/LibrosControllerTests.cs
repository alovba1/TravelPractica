using Microsoft.VisualStudio.TestTools.UnitTesting;
using Travel.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Travel.DrivenAdapters.SqlServer;

namespace Travel.Controllers.Tests
{
    [TestClass()]
    public class AtencionControllerTests
    {
        public readonly AtencionDbContext? _inventarioDbContext;
        [TestMethod()]
        public void  GetAllLibrosTest()
        {
            List<Domain.Model.Persona> lis = new();
            lis.Add(new Domain.Model.Persona { TipoIdentificacion = "Desarrollo Aplicaciones" });
            lis.Add(new Domain.Model.Persona { NroIdentificacion = "Generacion" });
            lis.Add(new Domain.Model.Persona { PrimerNombre = "2444" });
            using var persona = _inventarioDbContext.Persona.ToListAsync();
            Assert.Equals(lis, persona);
            Assert.AreEqual(lis, persona);
          
        }
    }
}