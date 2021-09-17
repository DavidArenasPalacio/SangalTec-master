using Microsoft.EntityFrameworkCore;
using SangalTec.Bunsiness.Abstract;
using SangalTec.DAL;
using SangalTec.Models.EntitiesUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangalTec.Bunsiness.Bunsiness
{
    public class UsuarioBunsiness : IUsuarioBunsiness
    {
        private readonly SangalDbContext _context;

        public UsuarioBunsiness(SangalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
