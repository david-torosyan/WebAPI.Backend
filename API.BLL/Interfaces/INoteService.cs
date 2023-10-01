using API.Domain;

namespace API.BLL.Interfaces
{
    public interface INoteService
    {
        Note GetNoteByID(Guid id);
        IEnumerable<Note> GetNotesContains(string term);
        IEnumerable<Note> GetAllNotes();
        Note GetNoteByTitle(string title);

        public void Insert(Note note);
        void DeleteNote(Note note);
        void Update(Note model);
    }
}
