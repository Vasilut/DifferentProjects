using Data;
using Models;
using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepoContext repoContext) : base(repoContext)
        {
        }
    }
}
