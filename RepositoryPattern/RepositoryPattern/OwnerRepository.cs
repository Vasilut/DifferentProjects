using Data;
using Models;
using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepoContext repoContext) : base(repoContext)
        {
        }
    }
}
