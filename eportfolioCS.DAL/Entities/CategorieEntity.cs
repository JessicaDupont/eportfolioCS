using eportfolioCS.DAL.Entities.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    [Table("Categorie")]
    public class CategorieEntity : IEntityIdBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }

        #region FK parent
        [ForeignKey("CategorieEntity")]
        public int? ParentID { get; set; }
        public virtual CategorieEntity Parent { get; set; }
        public virtual IEnumerable<CategorieEntity> Enfants { get; set; }
        #endregion

        #region destinations FR
        public virtual IEnumerable<ExperienceEntity> Experiences { get; set; }
        #endregion

    }
}
