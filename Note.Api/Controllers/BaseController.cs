using API.BLL.Interfaces;
using Backend.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly INoteService _noteService;

        public BaseController(INoteService noteService)
        {
            _noteService = noteService;
        }

        protected IActionResult Success(string? message = default)
        {
            return Ok(new ResponseModel(true, message));
        }
        protected IActionResult Success<T>(T data, string? message = default)
        {
            return Ok(new ResponseModel<T>(true, message, data));
        }

        protected IActionResult Error(string? message = default)
        {
            return Ok(new ResponseModel(false, message));
        }

    }
}
