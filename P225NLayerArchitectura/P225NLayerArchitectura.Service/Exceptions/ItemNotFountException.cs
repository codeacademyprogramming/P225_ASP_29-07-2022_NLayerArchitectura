using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Service.Exceptions
{
    public class ItemNotFountException : Exception
    {
        public ItemNotFountException(string msg) : base(msg)
        {

        }
    }
}
