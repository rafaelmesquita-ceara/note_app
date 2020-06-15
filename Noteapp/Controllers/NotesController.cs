using Noteapp.Database;
using Noteapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noteapp.Controllers
{
    public class NotesController
    {

        public List<NotesSet> ListarNotas()
        {
            using (var conexao = new NoteAppContext())
            {
                var listaNotas = conexao.Note.ToList();

                return listaNotas;

            }
        }
        public void AdicionarNota(NotesSet note)
        {
            using (var conexao = new NoteAppContext())
            {
                conexao.Note.Add(note);
                conexao.SaveChanges();

            }
        }
        public NotesSet ListarUmaNota(int id)
        {
            using (var conexao = new NoteAppContext())
            {
                return conexao.Note
                    .Where(x => x.ID == id)
                    .FirstOrDefault();
            }
        }
        public void AtualizarNote(NotesSet note)
        {
            using (var conexao = new NoteAppContext())
            {
                var result = conexao.Note.SingleOrDefault(b => b.ID == note.ID);
                if (result != null)
                {
                    result.CH_Name = note.CH_Name;
                    result.CH_Description = note.CH_Description;
                    result.DT_Creation = note.DT_Creation;
                    conexao.SaveChanges();
                }
            }
        }
        public void RemoverNota(int id)
        {
            using (var conexao = new NoteAppContext())
            {
                var note = new NotesSet { ID = id };
                conexao.Note.Attach(note);
                conexao.Note.Remove(note);
                conexao.SaveChanges();
            }
            
        }

    }
}
