using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMembresia : Form
    {
        Random random = new Random();
        int[] numbers = { 1, 2, 3, 4 };
        int[] numbers1 = { 1, 2, 3 };
        int[] numbers2 = { 1, 2 };
        int[] numbers3 = { 1, 2, 3 };
        int[] numbers4 = { 1, 2, 3, 4 };

        List<int> selectedNumbers = new List<int>();

        public FormMembresia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormListaClientes hijo = new FormListaClientes();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();

            hijo.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = comboBox2.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a valid level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen dizinin belirlenmesi
            double[] selectedNumbersArray;
            switch (selectedIndex)
            {
                case 0:
                    selectedNumbersArray = new double[] { 16, 9, 2, 1.4, 1.4, 1.2, 1.1, 1, 0.5 };
                    break;
                case 1:
                    selectedNumbersArray = new double[] { 110, 41, 10, 5, 3, 1.5, 1, 0.5, 0.3 };
                    break;
                case 2:
                    selectedNumbersArray = new double[] { 100, 130, 26, 9, 4, 2, 0.2 };
                    break;
                default:
                    selectedNumbersArray = new double[0];
                    break;
            }

            // Rastgele bir sayı seçilmesi
            Random random = new Random();
            double selectedNumber = selectedNumbersArray[random.Next(selectedNumbersArray.Length)];

            // ListBox'a seçilen sayının eklenmesi
            List.Items.Clear(); // Liste temizlenir
            List.Items.Add(selectedNumber.ToString("0.0")); // Ondalık sayıyı bir ondalık basamakla göstermek için "0.0" formatını kullanıyoruz
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMembresia_Load(object sender, EventArgs e)
        {

        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a valid level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen dizinin belirlenmesi
            double[] selectedNumbersArray;
            switch (selectedIndex)
            {
                case 0:
                    selectedNumbersArray = new double[] { 16, 9, 2, 1.4, 1.4, 1.2, 1.1, 1, 0.5 };
                    break;
                case 1:
                    selectedNumbersArray = new double[] { 110, 41, 10, 5, 3, 1.5, 1, 0.5, 0.3 };
                    break;
                case 2:
                    selectedNumbersArray = new double[] { 100, 130, 26, 9, 4, 2, 0.2 };
                    break;
                default:
                    selectedNumbersArray = new double[0];
                    break;
            }

            Random random = new Random();

            while (true)
            {
                List.Items.Clear(); // Listbox temizlenir
                double selectedNumber = selectedNumbersArray[random.Next(selectedNumbersArray.Length)];
                List.Items.Add(selectedNumber.ToString("0.0")); // Ondalık sayıyı bir ondalık basamakla göstermek için "0.0" formatını kullanıyoruz
                await Task.Delay(2000); // 2 saniye bekle
            }
        }

        private async Task GenerateRandomNumbers(int[] selectedNumbersArray, int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(selectedNumbersArray.Length);
                int selectedNumber = selectedNumbersArray[index];

               
                while (selectedNumbers.Contains(selectedNumber))
                {
                    index = random.Next(selectedNumbersArray.Length);
                    selectedNumber = selectedNumbersArray[index];
                }

                selectedNumbers.Add(selectedNumber);
                List.Items.Add(selectedNumber);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }
    }
}
