using API.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected  readonly INoteService _noteService;

        public BaseController(INoteService noteService)
        {
            _noteService = noteService;
        }
    }
}
