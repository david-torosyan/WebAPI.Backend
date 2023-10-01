using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DAL.IRepository
{
    public interface IUnitOfWork
    {
        INoteRepository _noteRepository { get; }
        void Commit();
    }
}
