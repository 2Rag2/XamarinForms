using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace TesteMercadinho.Models
{
    [Table("Anotacoes")]
    public class ModelNotas
    {
        [PrimaryKey, AutoIncrement]
       
        public int id { get; set; }
        [NotNull]
        public String titulo { get; set; }
        [NotNull]
        public String Dados { get; set; }
        [NotNull]
        public Boolean Favorito { get; set; }

    }
}
