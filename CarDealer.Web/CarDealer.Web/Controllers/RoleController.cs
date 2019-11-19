namespace CarDealer.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using CarDealer.Web.Infrastructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRole)]
    public class RoleController : Controller
    {
        readonly RoleManager<IdentityRole> roleManager;

        /// 
        /// Injecting Role Manager
        /// 
        /// 
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

       
    }
}