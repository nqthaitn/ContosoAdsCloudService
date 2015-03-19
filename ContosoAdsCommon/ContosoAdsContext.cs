using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoAdsCommon
{
    public class ContosoAdsContext: DbContext
    {
        public ContosoAdsContext()
            : base("name=ContosoAdsContext")
        {
            //Database.SetInitializer<ContosoAdsContext>(new DropCreateDatabaseAlways<ContosoAdsContext>());
        }
        public ContosoAdsContext(string connString)
            : base(connString)
        {
        }
        public System.Data.Entity.DbSet<Ad> Ads { get; set; }
    }
}
