using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinerOnTheHighway
{
    public partial class Form1 : Form
    {
        public int priceFirstCourse = 0;
        public int priceSalades = 0;
        public int priceDeserts = 0;
        public int priceBeverages = 0;
        public int priceAdditives = 0; public int result = 0;
        public int priceSause = 0; public int priceJam = 0; public int priceBox = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue == "Borsh")
            {
                textBox1.Text = (Convert.ToInt32(textBox9.Text) * Convert.ToInt32(comboBox5.Text)).ToString();
                priceFirstCourse = Convert.ToInt32(textBox1.Text);
            }
            else if (selectedValue == "Rassolnik")
            {
                textBox1.Text = (Convert.ToInt32(textBox23.Text) * Convert.ToInt32(comboBox5.Text)).ToString();
                priceFirstCourse = Convert.ToInt32(textBox1.Text);
            }
            else if (selectedValue == "Solyanka")
            {
                textBox1.Text = (Convert.ToInt32(textBox25.Text) * Convert.ToInt32(comboBox5.Text)).ToString();
                priceFirstCourse = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            if (selectedValue == "Greese")
            {
                textBox2.Text = (Convert.ToInt32(textBox24.Text) * Convert.ToInt32(comboBox6.Text)).ToString();
                priceSalades = Convert.ToInt32(textBox2.Text);
            }
            else if (selectedValue == "Cezar")
            {
                textBox2.Text = (Convert.ToInt32(textBox27.Text) * Convert.ToInt32(comboBox6.Text)).ToString();
                priceSalades = Convert.ToInt32(textBox2.Text);
            }
            else if (selectedValue == "Olivie")
            {
                textBox2.Text = (Convert.ToInt32(textBox26.Text) * Convert.ToInt32(comboBox6.Text)).ToString();
                priceSalades = Convert.ToInt32(textBox2.Text);
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox3.SelectedItem.ToString();
            if (selectedValue == "Napoleon")
            {
                textBox3.Text = (Convert.ToInt32(textBox29.Text) * Convert.ToInt32(comboBox7.Text)).ToString();
                priceDeserts = Convert.ToInt32(textBox3.Text);
            }
            else if (selectedValue == "Kartoshka")
            {
                textBox3.Text = (Convert.ToInt32(textBox28.Text) * Convert.ToInt32(comboBox7.Text)).ToString();
                priceDeserts = Convert.ToInt32(textBox3.Text);
            }
            
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox4.SelectedItem.ToString();
            if (selectedValue == "Tea")
            {
                textBox4.Text = (Convert.ToInt32(textBox31.Text) * Convert.ToInt32(comboBox8.Text)).ToString();
                priceBeverages = Convert.ToInt32(textBox4.Text);
            }
            else if (selectedValue == "Coffee")
            {
                textBox4.Text = (Convert.ToInt32(textBox30.Text) * Convert.ToInt32(comboBox8.Text)).ToString();
                priceBeverages = Convert.ToInt32(textBox4.Text);
            }

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            int result= 0;
            CheckBox checkBoxCheese = (CheckBox)checkBox1;
            CheckBox checkBoxOnion = (CheckBox)checkBox3;
            CheckBox checkBoxSweet = (CheckBox)checkBox4;
            if (checkBoxCheese.Checked)
            {
                result += Convert.ToInt32(textBox33.Text);
            }
            if (checkBoxOnion.Checked)
            {
                result += Convert.ToInt32(textBox38.Text);
            }
            if (checkBoxSweet.Checked)
            {
                result += Convert.ToInt32(textBox39.Text); ;
            }
            textBox5.Text = result.ToString();
            priceSause = result;

        }

        private void textBox46_Click(object sender, EventArgs e)
        {
            int result = 0;
            CheckBox checkBoxJam1 = (CheckBox)checkBox7;
            CheckBox checkBoxJam2 = (CheckBox)checkBox5;
            CheckBox checkBoxJam3 = (CheckBox)checkBox6;
            if (checkBoxJam1.Checked)
            {
                result += Convert.ToInt32(textBox43.Text);
            }
            if (checkBoxJam2.Checked)
            {
                result += Convert.ToInt32(textBox44.Text);
            }
            if (checkBoxJam3.Checked)
            {
                result += Convert.ToInt32(textBox45.Text); ;
            }
            textBox46.Text = result.ToString();
            priceJam = result;

        }

        private void textBox50_Click(object sender, EventArgs e)
        {
            int result = 0;
            CheckBox checkBoxBox1 = (CheckBox)checkBox10;
            CheckBox checkBoxBox2 = (CheckBox)checkBox8;
            CheckBox checkBoxBox3 = (CheckBox)checkBox9;
            if (checkBoxBox1.Checked)
            {
                result += Convert.ToInt32(textBox55.Text);
            }
            if (checkBoxBox2.Checked)
            {
                result += Convert.ToInt32(textBox54.Text);
            }
            if (checkBoxBox3.Checked)
            {
                result += Convert.ToInt32(textBox53.Text); ;
            }
            textBox50.Text = result.ToString();
            priceBox = result;

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)checkBox2;
            RadioButton radioButton = (RadioButton)radioButton2;
            RadioButton radioButton1 = (RadioButton)radioButton3;

            if (checkBox.Checked && radioButton.Checked)
            {
                textBox6.Text = (Convert.ToInt32(textBox32.Text) + Convert.ToInt32(textBox35.Text)).ToString();
                priceAdditives = Convert.ToInt32(textBox6.Text);
            }
            else if (checkBox.Checked && radioButton1.Checked)
            {
                textBox6.Text = (Convert.ToInt32(textBox32.Text) + Convert.ToInt32(textBox34.Text)).ToString();
                priceAdditives = Convert.ToInt32(textBox6.Text);
            }
            else if (checkBox.Checked == false && radioButton.Checked)
            {
                textBox6.Text = (Convert.ToInt32(textBox35.Text)).ToString();
                priceAdditives = Convert.ToInt32(textBox6.Text);
            }
            else if (checkBox.Checked == false && radioButton1.Checked)
            {
                textBox6.Text = (Convert.ToInt32(textBox34.Text)).ToString();
                priceAdditives = Convert.ToInt32(textBox6.Text);
            }
            else if (checkBox.Checked  && radioButton.Checked == false && radioButton1.Checked == false)
            {
                textBox6.Text = (Convert.ToInt32(textBox32.Text)).ToString();
                priceAdditives = Convert.ToInt32(textBox6.Text);
            }
            else if (checkBox.Checked == false && radioButton.Checked == false && radioButton1.Checked == false)
            {
                textBox6.Text = 0.ToString();
                priceAdditives =0;
            }
        }
        private void Check(object sender, EventArgs e)
        {
            string path = "Check.txt";
            result = priceFirstCourse 
        + priceSalades 
        + priceDeserts
        + priceBeverages
        + priceSause
        + priceAdditives;

            using (StreamWriter sr = new StreamWriter(path, false))
            {
                textBox7.Text = $"Чек:\n Первое блюдо: {priceFirstCourse}\n Салаты: {priceSalades}\n Десерты: {priceDeserts}\n Напитки: {priceBeverages}\n Соусы: {priceSause}\n " +
                    $"Добавки к напиткам: {priceAdditives}\n Джем: {priceJam}\n Контейнеры для еды: {priceBox} Итого: {result}";

                sr.WriteLine($"Чек:\n Первое блюдо: {priceFirstCourse}\n Салаты: {priceSalades}\n Десерты: {priceDeserts}\n " +
                    $"Напитки: {priceBeverages}\n Соусы: {priceSause}\n Добавки к напиткам: {priceAdditives}\n Джем: {priceJam}\n Контейнеры для еды: {priceBox} \nИтого: {result}"
);
            }












        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
