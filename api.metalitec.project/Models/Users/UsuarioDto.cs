using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.metalitec.project.Models.Users
{
    public class UsuarioDto
    {
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
