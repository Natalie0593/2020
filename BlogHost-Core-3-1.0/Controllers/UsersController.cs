using System.Threading.Tasks;
using ViewModels;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.IO;

namespace BlogHost.Controllers
{
    public class UsersController : Controller
    {

        //private IUser @object;
        UserManager<User> _userManager;
        IUserService _userService;
        //private readonly IUser _user; //заменить
        //private readonly IPublication _publication;
        IPublicationService _publicationService;
        ITopicService _topicService;
        private IUserService object1;
        //private readonly ITopic _topic; //заменить

        public UsersController(UserManager<User> userManager, IUserService iUser, IPublicationService iPublication, ITopicService iTopic)
        {
            _userService = iUser;
            _publicationService = iPublication;
            _topicService = iTopic;
            _userManager = userManager;
        }

        public UsersController(IUserService object1)
        {
            _userService = object1;
        }

        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }


        public IActionResult Profile()
        {

            return View(_userService.GetUserDB(_userManager.GetUserId(User)));
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email, Year = model.Year };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Profile");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }


        public IActionResult GetUser(string id)
        {
            if (id == null)
                return BadRequest();
            User user = _userService.GetUserDB(id);
            if (user == null)
                return NotFound();
            return View(user);
        }

        public async Task<IActionResult> Edit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            EditUserViewModel model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Year = user.Year,
                Gender = user.Gender,
                Name = user.Name,
                SecondName = user.SecondName,
                Profession = user.Profession,


            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(model.Avatar.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)model.Avatar.Length);
                }
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.Year = model.Year;
                    user.Name = model.Name;
                    user.SecondName = model.SecondName;
                    user.Profession = model.Profession;
                    user.Gender = model.Gender;
                    user.Avatar = imageData;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Profile");
        }
        public async Task<IActionResult> ChangePassword(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ChangePasswordViewModel model = new ChangePasswordViewModel { Id = user.Id, Email = user.Email };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    var _passwordValidator =
                        HttpContext.RequestServices.GetService(typeof(IPasswordValidator<User>)) as IPasswordValidator<User>;
                    var _passwordHasher =
                        HttpContext.RequestServices.GetService(typeof(IPasswordHasher<User>)) as IPasswordHasher<User>;

                    IdentityResult result =
                        await _passwordValidator.ValidateAsync(_userManager, user, model.NewPassword);
                    if (result.Succeeded)
                    {
                        user.PasswordHash = _passwordHasher.HashPassword(user, model.NewPassword);
                        await _userManager.UpdateAsync(user);
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }
            return View(model);
        }
    }
}