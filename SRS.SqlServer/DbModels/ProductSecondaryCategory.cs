using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SRS.SqlServer.DbModels
{
    [Table("FAProductSecondaryCategory")]
    public partial class ProductSecondaryCategory
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string CreationContext { get; set; }
        public long Id { get; set; }

        public bool Deleted { set; get; }

        public bool IsDeactive { set; get; }
        public int OrderPosition { set; get; }

        public string Name { get; set; }
        public long CompanyId { get; private set; }

        public long ProductPrimaryCategoryId { get; set; }

        //public virtual Company Company { get; private set; }

        //public virtual ProductPrimaryCategory ProductPrimaryCategory { get; set; }

        //public virtual ICollection<CompanyProduct> CompanyProducts { get; set; }

    }
}
