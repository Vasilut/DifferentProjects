using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        //if we add more methods
    }
}
