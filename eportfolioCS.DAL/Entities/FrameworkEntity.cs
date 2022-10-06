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
    [Table("Framework")]
    public class FrameworkEntity : IEntityIdBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }
        public string ImageURL { get; set; }

        #region FK parent
        [ForeignKey("FrameworkEntity")]
        public int? ParentID { get; set; }
        public virtual FrameworkEntity Parent { get; set; }
        public virtual FrameworkEntity Enfant { get; set; }
        #endregion

        #region FK langage
        [ForeignKey("LangageEntity")]
        public int LangageID { get; set; }
        public virtual LangageEntity Langage { get; set; }
        #endregion

        #region FK texte
        [ForeignKey("TexteEntity")]
        public int? TexteID { get; set; }
        public virtual TexteEntity Texte { get; set; }
        #endregion

        #region destinations FR
        public virtual IEnumerable<FrameworkProjetEntity> FrameworkProjets { get; set; }
        #endregion
    }
}
