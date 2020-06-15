using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Noteapp.Controllers;
using Noteapp.Models;
namespace Noteapp.Views
{
    public partial class Edit : Form
    {
        int id;
        public Edit(int ID)
        {
            id = ID;
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            var nota = new NotesController().ListarUmaNota(id);
            tb_Nome.Text = nota.CH_Name;
            tb_Description.Text = nota.CH_Description;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var nota = new NotesSet
            {
                CD_Notes = id,
                CH_Name = tb_Nome.Text,
                CH_Description = tb_Description.Text,
                DT_Creation = DateTime.Now
            };
            new NotesController().AtualizarNote(nota);
            Close();
        }
    }
}
