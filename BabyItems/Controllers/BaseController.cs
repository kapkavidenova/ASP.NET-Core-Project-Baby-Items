using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BabyItems.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}
