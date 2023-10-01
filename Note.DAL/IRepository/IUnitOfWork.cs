namespace API.DAL.IRepository
{
    public interface IUnitOfWork
    {
        INoteRepository _noteRepository { get; }
        void Commit();
    }
}
