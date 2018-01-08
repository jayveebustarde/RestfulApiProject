using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Variation : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid ProductId { get; set; }

        #region Navigation
        public Product Product { get; set; }
        #endregion
    }
}
