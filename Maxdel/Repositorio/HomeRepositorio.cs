using Maxdel.DB;
using Maxdel.Models;
using Microsoft.EntityFrameworkCore;

namespace Maxdel.Repositorio;

    public interface IHomeRepositorio
    {
        List<Producto> ObtenerProductos();
    }

    public class HomeRepositorio : IHomeRepositorio
    {
        private DbEntities _dbEntities;

        public HomeRepositorio(DbEntities dbEntities)
        {
            _dbEntities = dbEntities;
        }

        public List<Producto> ObtenerProductos()
        {
            return _dbEntities.Productos.ToList();
        }
    }


