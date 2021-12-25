using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ii_computers.Classes;

namespace ii_computers
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        public Form1()
        {
            InitializeComponent();
        }

        ToolTip tip = new ToolTip();
        Computer pc1 = new Computer
                (
                    new CPU("Intel", 2, 1.2),
                    new GPU("Palit", 2, 1.3),
                    new RAM("Kingston", 2, 1.1),
                    "Windows 7",
                    "DirectX 9"
                );


        Computer pc2 = new Computer
            (
                new CPU("Intel", 4, 1.6),
                new GPU("MSI", 4, 1.8),
                new RAM("HyperX", 4, 1.2),
                "Windows 10",
                "DirectX 10"
            );


        Computer pc3 = new Computer
            (
                new CPU("Ryzen", 8, 3.6),
                new GPU("Palit", 12, 4.2),
                new RAM("Ptriot", 16, 2.5),
                "Windows 11",
                "Vulkan"
            );

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory()+@"\img\pc1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory()+@"\img\pc2.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory()+@"\img\pc3.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            Product prod1 = new Product("Компас 5Д", 6, 4, 6, "Windows 10 & Windows 11", "Vulkan & DirectX 10");
            Product prod2 = new Product("GTA 6", 8, 8, 16, "Windows 10 & Windows 11 & MacOS Catalina", "Vulkan & DirectX 11");
            Product prod3 = new Product("CATIA V5", 8, 12, 32, "Windows7 & Windows 10 & Windows 11", "DirectX 9 & DirectX 10");

            prodsBox.Items.Add(prod1);
            prodsBox.Items.Add(prod2);
            prodsBox.Items.Add(prod3);

            pc1Box.Text = pc1.ReturnComputerSpecsAsString();
            pc2Box.Text = pc2.ReturnComputerSpecsAsString();
            pc3Box.Text = pc3.ReturnComputerSpecsAsString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.SetState(1);
            progressBar2.SetState(1);
            progressBar3.SetState(1);

            CheckSpecifications c1 = new CheckSpecifications(pc1, (Product)prodsBox.SelectedItem);
            CheckSpecifications c2 = new CheckSpecifications(pc2, (Product)prodsBox.SelectedItem);
            CheckSpecifications c3 = new CheckSpecifications(pc3, (Product)prodsBox.SelectedItem);

            SetProgressWork s1 = new SetProgressWork(progressBar1,c1.min,tip);
            SetProgressWork s2 = new SetProgressWork(progressBar2,c2.min,tip);
            SetProgressWork s3 = new SetProgressWork(progressBar3,c3.min,tip);

            msg.Text =
                String.Format("\t{0}\t{1}\t{2}\t{3}\t{4}\t|\t{5}\n{6}\n", "CPU", "GPU", "RAM", "OS", "vP", "MIN",
                "____________________________________________________________") +
                c1.ReturnParametersAsString() +
                c2.ReturnParametersAsString() +
                c3.ReturnParametersAsString();
        }

        private void prodsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product prod = (Product)prodsBox.SelectedItem;
            reqBox.Text = prod.ReturnProduct(prod);
        }
    }


    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
