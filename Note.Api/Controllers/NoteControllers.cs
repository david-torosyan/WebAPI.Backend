using API.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.Domain;

namespace Backend.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteControllers : BaseController
    {
        public NoteControllers(INoteService noteService) : base(noteService) { }

        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetNotes()
        {
            var Notes = _noteService.GetAllNotes();
            return Ok(Notes);
        }

        [HttpGet("{title}", Name = "GetNote")]
        public ActionResult<Note> GetNote(string title)
        {
            Note? note = _noteService.GetNoteByTitle(title);

            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }

        [HttpPost]
        public ActionResult<Note> CreateNote([FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (note == null)
            {
                return BadRequest();
            }

            _noteService.Insert(note);

            return CreatedAtRoute("GetNote", new { title = note.Title }, note);
        }

        [HttpDelete]
        public ActionResult DeleteNote(string title)
        {

            var note = _noteService.GetNoteByTitle(title);

            if (note == null)
            {
                return BadRequest();
            }
            _noteService.DeleteNote(note);

            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateVilla(string title, [FromBody] Note Note)
        {
            if (title == null || title != Note.Title || ModelState.IsValid)
            {
                _noteService.Update(Note);
                return NoContent();
            }
            return BadRequest();
        }


    }
}
