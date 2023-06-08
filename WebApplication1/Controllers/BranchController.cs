using Ecommerce.Models;
using Ecommerce.Repositry;
using Ecommerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IgenricRepo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        BranchRepo branchRepo;
        public BranchController(BranchRepo _branchRepo)
        {
            branchRepo = _branchRepo;
        }

        [HttpGet]
        public IEnumerable<branch> Get() 
        {
          return branchRepo.GetBranches();
        }

        [HttpPost]
        public void Post()
        {
            branchRepo.Add(new branch
            {
                Name = "science",

            });
            branchRepo.save();
        }
    }
}
