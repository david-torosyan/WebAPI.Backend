using API.BLL.Interfaces;
using API.DAL.IRepository;
using API.Domain;

namespace API.BLL.Services
{
    public class NoteService : INoteService
    {
        readonly IUnitOfWork _unitOfWork;

        public NoteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _unitOfWork._noteRepository.GetAll();
            return notes;
        }

        public Note GetNoteByID(Guid id)
        {
            Note obj = _unitOfWork._noteRepository.Get(u => u.Id == id);
            return obj;
        }

        public Note GetNoteByTitle(string title)
        {
            Note obj = _unitOfWork._noteRepository.Get(x => x.Title == title);
            return obj;
        }

        public IEnumerable<Note> GetNotesContains(string term)
        {
            var obj = _unitOfWork._noteRepository.GetAll(term);
            return obj;
        }

        public void Insert(Note note) 
        {
            _unitOfWork._noteRepository.Insert(note);
            _unitOfWork.Commit();
        }

        public void Update(Note model)
        {
            _unitOfWork._noteRepository.Update(model);
            _unitOfWork.Commit();
        }
        public void DeleteNote(Note note)
        {
            _unitOfWork._noteRepository.Remove(note);
            _unitOfWork.Commit();
        }
    }
}