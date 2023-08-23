using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;
using Travel.DrivenAdapters.SqlServer;
using System.Data;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;

namespace Travel.DrivenAdapters.SqlServer
{
    public class AtencionRepositoryServices : ILibroRepository<Persona>
    {
       private readonly string _cadenaSql;
        public AtencionRepositoryServices(IConfiguration configuration) 
        {
            _cadenaSql = configuration.GetConnectionString("AtencionConnectionString");
        }

        public Task<List<bool>> DeleteLibros(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Persona>> GetAllLibros()
        {
            List<Persona> _list = new List<Persona>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listaLibros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        _list.Add(new Persona
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            TipoIdentificacion = dr["TipoIdentificacion"].ToString(),
                            NroIdentificacion = dr["NroIdentificacion"].ToString(),
                            PrimerNombre = dr["PrimerNombre"].ToString(),
                            SegundoNombre = dr["SegundoNombre"].ToString(),
                            PrimerApellido = dr["PrimerApellido"].ToString(),
                            SegundoApellido = dr["SegundoApellido"].ToString(),
                            Sexo = dr["Sexo"].ToString(),
                            CodAsegurador = dr["CodAsegurador"].ToString(),
                            FechaNacimiento = Convert.ToDateTime((dr["FechaNacimiento"])),
                            CodMpioResidencia = dr["CodMpioResidencia"].ToString(),
                            FechaRegistro = Convert.ToDateTime((dr["FechaRegistro"])),
                        });
                    }
                }
                throw new NotImplementedException();
            }
            return _list;
        }

        public Task<List<bool>> SaveLibros(Persona modelo)
        {
            throw new NotImplementedException();
        }

        public Task<List<bool>> UpdateLibros(Persona modelo)
        {
            throw new NotImplementedException();
        }
    }
}
