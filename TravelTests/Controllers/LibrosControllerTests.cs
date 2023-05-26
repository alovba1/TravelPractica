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
    public class LibrosControllerTests
    {
        public readonly InventarioDbContext? _inventarioDbContext;
        [TestMethod()]
        public void  GetAllLibrosTest()
        {
            List<Domain.Model.Libros> lis = new();
            lis.Add(new Domain.Model.Libros {Titulo="Desarrollo Aplicaciones" });
            lis.Add(new Domain.Model.Libros { Sinopsis = "Generacion" });
            lis.Add(new Domain.Model.Libros { N_paginas = "2444" });
            using var libros = _inventarioDbContext.Libros.ToListAsync();
            Assert.Equals(lis, libros);
            Assert.AreEqual(lis, libros);
          
        }
    }
}