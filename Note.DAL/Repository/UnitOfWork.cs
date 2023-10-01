using API.DAL.Data;
using API.DAL.IRepository;

namespace API.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public INoteRepository _noteRepository { get ; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            _noteRepository = new NoteRepository(db);
        }


        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
