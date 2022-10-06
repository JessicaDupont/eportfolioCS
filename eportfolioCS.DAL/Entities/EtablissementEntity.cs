using eportfolioCS.DAL.Entities.Bases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eportfolioCS.DAL.Entities
{
    [Table("Etablissement")]
    public class EtablissementEntity : IEntityIdBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Description { get; set; }
        [Required]
        public string Pays { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        public int CodePostal { get; set; }
        public string Adresse { get; set; }
        public string SiteWeb { get; set; }
    }
}