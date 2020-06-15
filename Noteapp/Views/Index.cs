using Noteapp.Models;
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
using Noteapp.Views;

namespace Noteapp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Render_Rows();
        }
        private void Render_Rows()
        {
            dataGridView1.Rows.Clear();
            List<NotesSet> Notas = new NotesController().ListarNotas();
            foreach (NotesSet Nota in Notas)
            {
                dataGridView1.Rows.Add(Nota.CD_Notes,
                    Nota.CH_Name,
                    Nota.CH_Description,
                    Nota.DT_Creation);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new Add_Note().ShowDialog();
            Render_Rows();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirEdit();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex-1];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                new Edit(id).ShowDialog();
                Render_Rows();
            }
        }
        private void AbrirEdit()
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            new Edit(id).ShowDialog();
            Render_Rows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            new NotesController().RemoverNota(id);
            Render_Rows();
        }
    }
}
