using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChiookSystem.Data.Entities
{
    [Table("Tracks")]
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int Ablum { get; set; }
        public int MediaTypeId { get; set; }
        public int GenerId { get; set; }
        public string Composer { get; set; }
        public int Millisecond { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set;}
        public virtual Album Album { get; set; }
    }
}
