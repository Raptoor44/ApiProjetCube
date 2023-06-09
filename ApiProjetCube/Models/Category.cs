﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProjetCube.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual List<Ressource> ?Ressources { get; set; }
        public virtual List<SubjectForum> ?SubjectsForums { get; set; }
    }
}
