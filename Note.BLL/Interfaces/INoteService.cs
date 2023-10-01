using API.Domain;

namespace Note.BLL.Interfaces
{
    public interface INoteService
    {
        Note GetUserByID(int id);
        IEnumerable<Note> GetUsersContains(string term);
        void Update(Note model);
    }
}
