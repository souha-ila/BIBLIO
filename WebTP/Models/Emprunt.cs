using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebTP.Models
{
    public class Emprunt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Livre")]
        public int LivreId { get; set; }

        [ForeignKey("Abonne")]
        public int AbonneId { get; set; }

        [Required]
        public DateTime DateEmprunt { get; set; }

        public DateTime DateRetour { get; set; }
    }
}
