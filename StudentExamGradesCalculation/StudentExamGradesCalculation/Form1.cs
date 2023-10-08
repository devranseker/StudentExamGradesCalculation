using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentExamGradesCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            double exam1, exam2, proje;
            double average;
            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToInt16(textBox3.Text);
            exam2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            average = (exam1 + exam2 + proje) / 3;
            listBox1.Items.Add(name + " " + surname + " Ortalamanýz : " + average);

        }
    }
}
// bu projede eksik var double donduremedým
