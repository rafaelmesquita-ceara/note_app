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
            using (var conexao = new NoteEntities())
            {
                var listaNotas = conexao.NotesSet.ToList();

                return listaNotas;

            }
        }
        public void AdicionarNota(NotesSet note)
        {
            using (var conexao = new NoteEntities())
            {
                conexao.NotesSet.Add(note);
                conexao.SaveChanges();

            }
        }
        public NotesSet ListarUmaNota(int id)
        {
            using (var conexao = new NoteEntities())
            {
                return conexao.NotesSet
                    .Where(x => x.CD_Notes == id)
                    .FirstOrDefault();
            }
        }
        public void AtualizarNote(NotesSet note)
        {
            using (var conexao = new NoteEntities())
            {
                var result = conexao.NotesSet.SingleOrDefault(b => b.CD_Notes == note.CD_Notes);
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
            using (var conexao = new NoteEntities())
            {
                var note = new NotesSet { CD_Notes = id };
                conexao.NotesSet.Attach(note);
                conexao.NotesSet.Remove(note);
                conexao.SaveChanges();
            }
            
        }

    }
}
