using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    [Table("framework_projet")]
    public class FrameworkProjetEntity : IEntityBase
    {
        [Key]
        public int ID { get; set; }
        public string VersionIDE { get; set; }
        public string VersionFramework { get; set; }

        #region FK projet
        [ForeignKey("ProjetEntity")]
        public int ProjetID { get; set; }
        public ProjetEntity Projet { get; set; }
        #endregion

        #region FK IDE
        [ForeignKey("IdeEntity")]
        public int IdeID { get; set; }
        public IdeEntity IDE { get; set; }
        #endregion

        #region FK DB
        [ForeignKey("SgbdEntity")]
        public int? SgbdID { get; set; }
        public virtual SgbdEntity SGBD { get; set; }
        #endregion
        
        #region FK framework
        [ForeignKey("FrameworkEntity")]
        public int FrameworkID { get; set; }
        public FrameworkEntity Framework { get; set; }
        #endregion

    }
}
