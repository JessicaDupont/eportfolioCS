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
    /*
     * Data annotaions
     */
    [Table("Texte")]
    public class TexteEntity : IEntityIdBase, IEntityDatesBase
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
        public string Contenu { get; set; }
        public int? Position { get;set; }

        #region FK Parent
        [ForeignKey("TexteEntity")]
        public int? ParentID { get; set; }
        public virtual TexteEntity Parent { get; set; }
        public virtual IEnumerable<TexteEntity> Enfants { get; set; }
        #endregion

        #region destinations FR
        public virtual IEnumerable<ExperienceEntity> Experiences { get; set; }
        public virtual IEnumerable<LangageEntity> Langages { get; set; }
        public virtual IEnumerable<ProjetEntity> Projets { get; set; }
        public virtual IEnumerable<TypeProjetEntity> TypeProjets { get; set; }
        public virtual IEnumerable<IdeEntity> IDEs { get; set; }
        public virtual IEnumerable<FrameworkEntity> Frameworks { get; set; }
        public virtual IEnumerable<SgbdEntity> SGBDs { get; set; }
        #endregion
    }
}
