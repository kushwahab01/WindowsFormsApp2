using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\Skillmine";
            try
            {
               if(Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exist");
                }
               else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created successfully");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"E:\Skillmine\skilline.txt";
            try
            {
                if (File.Exists(path)) 
                {
                    MessageBox.Show("File is already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created Successfully");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\Skillmine\Skillmine";
            try
            {
                if(Directory.Exists(path))
                {
                    Directory.Delete(path);
                    MessageBox.Show("Directory Deleted Succesfully");
                       
                }
                else
                {
                    MessageBox.Show("Does not exist");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(@"E:\emp.dat",FileMode.Create,FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(file);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Write(textBox2.Text);
                bw.Write(Convert.ToDouble(textBox3.Text));
                bw.Close();
                file.Close();
                MessageBox.Show("Data saved to file");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(@"E:\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(file);
                textBox1.Text = br.ReadInt32().ToString();
                textBox2.Text = br.ReadString();
                textBox3.Text = br.ReadDouble().ToString();
                br.Close();
                file.Close();
                MessageBox.Show("Open Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
