using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    [Table("Projet")]
    public class ProjetEntity : IEntityBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Titre { get; set; }
        public string Description { get; set; }
        [Required]
        [Column("date_debut", TypeName = "DateTime2")]
        public DateTime DateDebut { get; set; }
        [Column("date_fin", TypeName = "DateTime2")]
        public DateTime? DateFin { get; set; }
        public string URL { get; set; }
        public string GitURL { get; set; }

        #region FK typeProjet
        [ForeignKey("TypeProjetEntity")]
        public int TypeProjetID { get; set; }
        public TypeProjetEntity TypeProjet { get; set; }
        #endregion

        #region FK experience
        [ForeignKey("ExperienceEntity")]
        public int? ExperienceID { get; set; }
        public virtual ExperienceEntity Experience { get; set; }
        #endregion

        #region FK texte
        [ForeignKey("TexteEntity")]
        public int? TexteID { get; set; }
        public virtual TexteEntity Texte { get; set; }
        #endregion
    }
}
