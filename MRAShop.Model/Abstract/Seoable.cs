using System;
using System.ComponentModel.DataAnnotations;

namespace MRAShop.Model.Abstract
{
    public abstract class Seoable : ISeoable
    {
        [MaxLength(256)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}