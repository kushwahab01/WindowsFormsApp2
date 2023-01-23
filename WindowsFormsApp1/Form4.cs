using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dept.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Write(textBox2.Text);
                bw.Write(textBox3.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs=new FileStream(@"D:\Dept.dat",FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = br.ReadInt32().ToString();
                textBox2.Text = br.ReadString();
                textBox3.Text = br.ReadString();
                MessageBox.Show("Open Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
