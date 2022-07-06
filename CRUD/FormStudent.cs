using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, name, ra, @class, course;

        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblAddStudent.Text = "Atualizar aluno";
            btnSave.Text = "Atualizar";
            txtName.Text = name;
            txtRA.Text = ra;
            txtClass.Text = @class;
            txtCourse.Text = course;
        }

        public void SaveInfo()
        {
            lblAddStudent.Text = "Adicionar aluno";
            btnSave.Text = "Salvar";
        }

        public void Clear()
        {
            txtName.Text = txtRA.Text = txtClass.Text = txtCourse.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nome do estudante está vazio ou curto demais!");
                return;
            }
            if (txtRA.Text.Trim().Length != 7)
            {
                MessageBox.Show("RA de estudante inválido!");
                return;
            }
            if (txtClass.Text.Trim().Length != 3)
            {
                MessageBox.Show("Turma inválida!");
                return;
            }
            if (txtCourse.Text.Trim().Length < 3)
            {
                MessageBox.Show("Curso do estudante está vazio ou curto demais!");
                return;
            }
            if(btnSave.Text == "Salvar")
            {
                Student std = new Student(txtName.Text.Trim(), txtRA.Text.Trim(), txtClass.Text.Trim(), txtCourse.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            if(btnSave.Text == "Atualizar")
            {
                Student std = new Student(txtName.Text.Trim(), txtRA.Text.Trim(), txtClass.Text.Trim(), txtCourse.Text.Trim());
                DbStudent.UpdateStudent(std, id);
            }
            _parent.Display();
        }
    }
}
