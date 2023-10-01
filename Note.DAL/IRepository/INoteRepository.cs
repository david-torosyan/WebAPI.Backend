using API.Domain;

namespace API.DAL.IRepository
{
    public interface INoteRepository : IRepository<Note>
    {
        void Update(Note note);
        public void Insert(Note note);
        Note GetNoteByTitle(string title);
    }
}
