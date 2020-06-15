using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Noteapp.Models;
using Noteapp.Controllers;
namespace Noteapp.Views
{
    public partial class Add_Note : Form
    {
        public Add_Note()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var note = new NotesSet {
                CH_Name = tb_Nome.Text,
                CH_Description = tb_Description.Text,
                DT_Creation = DateTime.Now
            };
            new NotesController().AdicionarNota(note);
            Close();
        }
    }
}
