using _07_Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _07_Identity.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        public AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;

        }



        //---------------------------------------
        //             CREATE ROLE
        //---------------------------------------

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole ir = new()
                {
                    Name = model.RoleName
                };
                var result = await _roleManager.CreateAsync(ir);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }
            return View(model);
        }



        //---------------------------------------
        //              LIST ROLES
        //---------------------------------------
        [HttpGet]
        public IActionResult ListRoles()
        {
            return View(_roleManager.Roles);
        }




        //---------------------------------------
        //              EDIT ROLE
        //---------------------------------------

        [HttpGet]
        public IActionResult EditRole()
        {
            return View(_roleManager.Roles);
        }


    }





}

