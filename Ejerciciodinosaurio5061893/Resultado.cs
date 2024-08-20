using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejerciciodinosaurio5061893
{
    [SQLite.Table("Resultado")]
    public class Resultado
    {
        [PrimaryKey, AutoIncrement]
        [SQLite.Column("id")]
        public int Id { get; set; }

        [SQLite.Column("nombredino")]

        public string? Nombredino { get; set; }
        [SQLite.Column("longitudpie")]

        public string? Longitudpies { get; set; }
        [SQLite.Column("pesolibras")]

        public string? Pesolibras { get; set; }

        [SQLite.Column("convertir")]
        public string? Convertir { get; set; }

    }
}
