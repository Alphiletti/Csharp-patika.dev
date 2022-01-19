using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDB_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            // TODO: This line of code loads data into the 'dataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dataSet1.Doctor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index;
            index = dataGridView2.Rows.Count;
            int IDX;
            int Sel_ID = 0;
            int patientID = 0;


            this.patientTableAdapter.Insert(textBox1.Text, textBox2.Text);
            if (dataGridView2.Rows.Count < 2)
            {
                patientID = (int)dataGridView2.Rows[0].Cells[0].Value + 1;
            }
            else
            {
                patientID = (int)dataGridView2.Rows[index - 2].Cells[0].Value + 1;

            }

            int doctorID;
            doctorID = (int)comboBox1.SelectedValue;

            this.prescriptionTableAdapter.Insert(doctorID, patientID);
            MessageBox.Show("Patient registration has been made.");
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);
            this.doctorTableAdapter.Fill(this.dataSet1.Doctor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID = 0;
            int Sel_ID2 = 0;
            IDX = dataGridView2.CurrentRow.Index;
            int.TryParse(dataGridView2.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);

            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                if ((int)dataGridView3.Rows[i].Cells[2].Value == Sel_ID)
                {
                    Sel_ID2 = (int)dataGridView3.Rows[i].Cells[2].Value;

                    //this.patientTableAdapter.DeleteQuery(Sel_ID);

                }
            }
            
            this.prescriptionTableAdapter.DeleteQuery(Sel_ID2);
            this.patientTableAdapter.DeleteQuery(Sel_ID);


            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);



            MessageBox.Show("Deleted");
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDX, index;
            int Sel_ID = 0;

            int doctorID;
            doctorID = (int)comboBox1.SelectedValue;

            IDX = dataGridView2.CurrentRow.Index;
            int.TryParse(dataGridView2.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.patientTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, Sel_ID);
            this.prescriptionTableAdapter.UpdateQuery(doctorID, doctorID);
            MessageBox.Show("Updated");
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
            this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);
        }
    }
}
