﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    [Table("Type_Projet")]
    public class TypeProjetEntity : IEntityBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nom { get; set; }

        #region FK texte
        [ForeignKey("TexteEntity")]
        public int? TexteID { get; set; }
        public virtual TexteEntity Texte { get; set; }
        #endregion
    }
}
