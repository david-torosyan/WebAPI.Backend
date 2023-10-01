using API.DAL.Data;
using API.DAL.IRepository;
using API.Domain;

namespace API.DAL.Repository
{
    public class NoteRepository : Repository<Note>, INoteRepository
    {
        private readonly ApplicationDbContext _db;
        public NoteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Note GetNoteByTitle(string title)
        {
            var note = _db.Notes.FirstOrDefault(x => x.Title == title);
            return note;
        }

        public void Insert(Note note)
        {
            var newNote = new Note()
            {
                Id = note.Id,
                UserId = note.UserId,
                Title = note.Title,
                Details = note.Details,
                CreationDate = note.CreationDate,
                EditDate = note.EditDate

            };
            _db.Notes.Add(newNote);
        }

        public void Update(Note Entity)
        {
            _db.Notes.Update(Entity);
        }
    }
}
