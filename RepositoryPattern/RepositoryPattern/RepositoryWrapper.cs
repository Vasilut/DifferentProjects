using Data;
using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private RepoContext _repoContext;
        private IOwnerRepository _owner;
        private IAccountRepository _account;
        private object lock1 = new object();
        private object lock2 = new object();

        public RepositoryWrapper(RepoContext context)
        {
            _repoContext = context;
        }

        public IAccountRepository Account
        {
            get
            {
                lock(lock1)
                {
                    if(_account == null)
                    {
                        _account = new AccountRepository(_repoContext);
                    }                    
                }
                return _account;
            }
        }

        public IOwnerRepository Owner
        {
            get
            {
                lock(lock2)
                {
                    if(_owner == null)
                    {
                        _owner = new OwnerRepository(_repoContext);
                    }
                }
                return _owner;
            }
        }
    }
}
