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

        #region FK TextePrecedent
        [ForeignKey("TexteEntity")]
        public int? TextePrecedentID { get; set; }
        public virtual TexteEntity TextePrecedent { get; set; }
        public virtual TexteEntity TexteSuivant { get; set; }
        #endregion

    }
}
