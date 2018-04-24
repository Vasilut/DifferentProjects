using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAccountRepository Account { get; }
        IOwnerRepository Owner { get; }
    }
}
