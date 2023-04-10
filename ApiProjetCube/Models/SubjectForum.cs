﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProjetCube.Models
{
    public class SubjectForum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int IdCategorie { get; set; }
        public DateTime DateCreation { get; set; }
        public string Title { get; set; }
        public virtual Category Category { get; set; }
    }
}
