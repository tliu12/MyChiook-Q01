using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additiona1 Namespaces
using System.Data.Entity;
using ChiookSystem.Data.Entities;
#endregion
namespace ChiookSystem.DAL
{
    //This is an internal class for secuity reasons
    //Access is restricted to within this class library project
    //Inher DbContext for Entity Framework ,which requires
    //   System.Data.Entity
    internal class ChiookContext :DbContext
    {
        //Pass the connection string name to the 
        //   DbContext using :base()
        //   i.e. connection string name is "ChiookDB"
        public ChiookContext() : base("ChiookDB")
        {

        }
        //Setup all Dbset properties once Entity classes are created
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
