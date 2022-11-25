using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionExam.dao;
using GestionExam.models;

namespace GestionExam.interfaces {
    public partial class ProfesseurForm : Form {
        private ProfesseurDao professeurDao;

        public ProfesseurForm() {
            InitializeComponent();
            MySqlDatabase db = new MySqlDatabase("gestionprofesseur");
            professeurDao = new ProfesseurDao(db);
        }

        private void fillTableView() {
            List<Professeur> data = professeurDao.selectAll();

            for (int i = 0; i < data.Count; i++) {
                Professeur p = data.ElementAt(i);
                tableView.Rows.Add(p.GetCni(), p.GetNom(), p.GetPrenom(), p.GetTel());
            }
        }

        private void ProfesseurForm_Load(object sender, EventArgs e) {
            fillTableView();
        }

        private void submit_Click(object sender, EventArgs e) {
            Professeur p = new Professeur(input3.Text, input1.Text, input2.Text, input4.Text);
            professeurDao.insert(p);

            tableView.Rows.Add(input3.Text, input1.Text, input2.Text, input4.Text);

            input3.Text = "";
            input1.Text = "";
            input2.Text = "";
            input4.Text = "";
        }
    }
}
