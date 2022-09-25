using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.Entities
{
    public class TexteEntity
    {
        public int TexteID { get; set; }
#region FK TextePrecedent
        public int? TextePrecedentID { get; set; }
        public virtual TexteEntity TexteActuel { get; set; }
        public virtual TexteEntity TextePrecedent { get; set; }
#endregion
        public string Contenu { get; set; }
        public int? Position { get;set; }
        public string PieceJointe { get; set; }
    }
}
