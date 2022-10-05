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
    public class ExperienceEntity : IEntityBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        [Column("date_debut", TypeName = "DateTime2")]
        public DateTime DateDebut { get; set; }
        [Column("date_fin", TypeName = "DateTime2")]
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
