using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W11Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Museum' table. You can move, or remove it, as needed.
            this.museumTableAdapter.Fill(this.dataSet1.Museum);
            // TODO: This line of code loads data into the 'dataSet1.Art' table. You can move, or remove it, as needed.
            this.artTableAdapter.Fill(this.dataSet1.Art);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int museum;

            museum = (int)comboBox1.SelectedValue;
            this.artTableAdapter.Insert(museum,textBox3.Text,textBox1.Text,textBox2.Text);
            MessageBox.Show("Saved");
            this.artTableAdapter.Fill(this.dataSet1.Art);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID = 0;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.artTableAdapter.MyDelete(Sel_ID);
            MessageBox.Show("Deleted");
            this.artTableAdapter.Fill(this.dataSet1.Art);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDX,museum;
            int Sel_ID = 0;
            IDX = dataGridView1.CurrentRow.Index;
            museum = (int)comboBox1.SelectedValue;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.artTableAdapter.UpdateQuery(museum, textBox3.Text, textBox1.Text,textBox2.Text,Sel_ID,0);
            MessageBox.Show("Updated");
            this.artTableAdapter.Fill(this.dataSet1.Art);
        }
    }
}
