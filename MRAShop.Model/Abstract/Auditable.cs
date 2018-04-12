using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRAShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {

        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]

        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
