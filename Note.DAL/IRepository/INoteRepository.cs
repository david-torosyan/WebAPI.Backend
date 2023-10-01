using API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DAL.IRepository
{
    public interface INoteRepository : IRepository<Note>
    {
        void Update(Note note);
        public void Insert(Note note);
        Note GetNoteByTitle(string title);
    }
}
