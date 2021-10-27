using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PruebaMVCLogin.Models
{
    [Table("t_informacion")]
    public class Informacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("Telefono")]
        public string Telefono { get; set; }
        [Column("nombre")]
        public string Nombre {get; set;}
        [Column("apellido")]
        public string Apellido {get; set; }     
        

    }
}