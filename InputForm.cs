using System;
using System.Linq;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;

namespace Form
{
    public partial class InputForm : System.Windows.Forms.Form
    {

        public int Course_Index { get; private set; }
        public int Plan_index { get; private set; }
        public string Category { get; private set; }
        public string Sub_Category { get; private set; }
        public string Comment { get; private set; }


        public InputForm(ScriptContext context)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
            Patient patient = context.Patient;
            PatientInfo.Text = "Patient: " + patient.FirstName + " " + patient.LastName + " " + patient.Id;
            comboBox_Course.Items.AddRange(patient.Courses.ToArray());
            if(context.Course != null)
            {
                comboBox_Course.SelectedItem = context.Course;
                comboBox_Plan.Items.AddRange(context.Course.ExternalPlanSetups.ToArray());
            }
            if(context.ExternalPlanSetup != null)
            {
                comboBox_Plan.SelectedItem = context.ExternalPlanSetup;
            }

            comboBox_Course.SelectedIndexChanged += delegate (object sender, EventArgs e) { comboBoxCourse_SelectedIndexChanged(sender, e, patient); };

            string[] Categories = { "Prostata", "MAM", "H&N", "TC", "SRT", "SBRT", "GI", "Gyn", "Thorax", "Palliativ", "TBI", "Övrigt" };
            comboBox_Kategori.Items.AddRange(Categories);

            string[] Sub_Categories = { "Dosplan", "Behandling", "ARIA/CarePath", "Bilder", "EPID", "Mätning", "DoseCheck", "Undervisning", "Övrigt", "None" };
            comboBox_SubKategori.Items.AddRange(Sub_Categories);

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e, Patient patient)
        {
            comboBox_Plan.Text = "";
            comboBox_Plan.SelectedIndex = -1;
            comboBox_Plan.Items.Clear();
            comboBox_Plan.Items.AddRange(patient.Courses.ElementAt(comboBox_Course.SelectedIndex).ExternalPlanSetups.ToArray());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBox_Course.SelectedIndex == -1 || comboBox_Kategori.SelectedIndex == -1 || comboBox_SubKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Course, kategori och sub-kategori ska vara ifyllda");
            }
            else
            {
                Course_Index = comboBox_Course.SelectedIndex;
                if(comboBox_Plan.SelectedIndex == -1 || comboBox_Plan.SelectedItem.ToString() == "")
                {
                    Plan_index = -1;
                }
                else
                {
                    Plan_index = comboBox_Plan.SelectedIndex;
                }
                Category = comboBox_Kategori.SelectedItem.ToString();
                Sub_Category = comboBox_SubKategori.SelectedItem.ToString();
                Comment = textBox_Kommentar.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
