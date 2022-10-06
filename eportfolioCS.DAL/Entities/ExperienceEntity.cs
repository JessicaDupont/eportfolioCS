using eportfolioCS.DAL.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    [Table("Experience")]
    public class ExperienceEntity : IEntityIdBase, IEntityDatesBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("Date_insert", TypeName = "DateTime2")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateInsert { get; set; }
        [Column("Date_update", TypeName = "DateTime2")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateUpdate { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        [Column("Date_debut", TypeName = "DateTime2")]
        public DateTime DateDebut { get; set; }
        [Column("Date_fin", TypeName = "DateTime2")]
        public DateTime? DateFin { get; set; }

        #region FK Etablissement
        [ForeignKey("EtablissementEntity")]
        public int FirmeID { get; set; }
        public EtablissementEntity Firme { get; set; }
        #endregion

        #region FK categorie
        [ForeignKey("CategorieEntity")]
        public int CategorieID { get; set; }
        public CategorieEntity Categorie { get; set; }
        #endregion

        #region FK parent
        [ForeignKey("ExperienceEntity")]
        public int? ParentID { get; set; }
        public virtual ExperienceEntity Parent { get; set; }
        public virtual ExperienceEntity Enfant { get; set; }
        #endregion

        #region FK texte
        [ForeignKey("TexteEntity")]
        public int? TexteID { get; set; }
        public virtual TexteEntity Texte { get; set; }
        #endregion
    }
}
