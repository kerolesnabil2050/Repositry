using Ecommerce.Models;
using Ecommerce.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class BranchRepo
    {
        IgenricRepo<branch, int> igenricRepo;
        UnitOfWork UnitOfWork;
        public BranchRepo(IgenricRepo<branch, int> igenricRepo, UnitOfWork unitOfWork)
        {
            this.igenricRepo = igenricRepo;
            UnitOfWork = unitOfWork;
        }

        public branch Add(branch branch)

        {
          return  igenricRepo.Add(branch);
        }
        public IEnumerable<branch> GetBranches() 
        {
            return igenricRepo.GetAll().ToList();
        }
        public void save()
        {
            UnitOfWork.SaveChange();
        }

    }
}
