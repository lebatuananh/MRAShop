using System;

namespace MRAShop.Model.Abstract
{
    public abstract class Switchale : ISwitchable
    {
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}