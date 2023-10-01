using API.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Backend.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteControllers : BaseController
    {
        public NoteControllers(INoteService noteService) : base(noteService) { }

        [HttpGet]
        public IActionResult GetNotes()
        {
            var Notes = _noteService.GetAllNotes();

            if (Notes == null)
            {
                return Error("Note is null");
            }
            return Success(Notes, "Success");
        }

        [HttpGet("{title}", Name = "GetNote")]
        public IActionResult GetNote(string title)
        {
            Note? note = _noteService.GetNoteByTitle(title);

            if (note == null)
            {
                return Error("Note is null");
            }
            return Success(note, "Success");
        }

        [HttpPost]
        public IActionResult CreateNote([FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return Error("Model is not valid");
            }
            if (note == null)
            {
                return Error("Note is null");
            }

            _noteService.Insert(note);

            return Success(note, "Successfully Created");
        }

        [HttpDelete]
        public IActionResult DeleteNote(string title)
        {

            var note = _noteService.GetNoteByTitle(title);

            if (note == null)
            {
                return Error("Note is null");
            }
            _noteService.DeleteNote(note);

            return Success();
        }

        [HttpPut]
        public IActionResult UpdateVilla(string title, [FromBody] Note Note)
        {
            if (title == null || title != Note.Title || ModelState.IsValid)
            {
                _noteService.Update(Note);
                return Success(Note, "Successfully Updated");
            }
            return Error("Something Went Wrong");
        }


    }
}
