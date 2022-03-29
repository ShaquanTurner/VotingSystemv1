using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // checkedListBox1.Items.Add("testing ");
        
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            if (comboBox2.SelectedItem.ToString() == "Kingston")
            {
                // comboBox2.Items.Clear();
                comboBox1.Items.Clear();
                checkedListBox1.Items.Clear();
                comboBox1.Items.Remove("Savanna-La-Mar ");
                comboBox1.Items.Add("Red Hills");
                comboBox1.Items.Add("Old hope road ");
                checkedListBox1.Items.Add("Water pipe brust ");
                checkedListBox1.Items.Add("noise pollution");
                checkedListBox1.Items.Add("Scamming ");
                checkedListBox1.Items.Add("Corruption  ");
                checkedListBox1.Items.Add("Break-ins   ");
                this.checkedListBox1.Items.Add("stealing");


            }
            
            else if (comboBox2.SelectedItem.ToString() == "Westmoreland")
            {
                comboBox1.Items.Clear();
                checkedListBox1.Items.Clear();
                 checkedListBox1.Items.Remove("Water pipe brust ");
                comboBox1.Items.Remove("Red Hills");
                comboBox1.Items.Remove("Old hope road ");
                comboBox1.Items.Add("Savanna-La-Mar");
                checkedListBox1.Items.Add("Lack of Electricity ");

            }
                else
            {
                comboBox1.Items.Clear();
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Remove("Water pipe brust ");
                comboBox1.Items.Remove("Red Hills");
                comboBox1.Items.Remove("Old hope road ");
                comboBox1.Items.Remove("Savanna-La-Mar");
                comboBox1.Items.Add("Santa Cruz");
                checkedListBox1.Items.Add("Lack of water ");
                checkedListBox1.Items.Add("Crime ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            //comboBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Red Hills")
            {

                this.checkedListBox1.Items.Add("Water Pipe Brust  ");
            }
            else
            {
                this.checkedListBox1.Items.Add("stealing");
                checkedListBox1.Items.Add("Noise Pollution");

                //this.checkedListBox1.Items.Add("Lack of Electricity ");

            }

            

            //comboBox1.Items.Clear();
            /*checkedListBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Red Hills")
            {

                this.checkedListBox1.Items.Add("Water Supply problem ");
            }


            else if (comboBox1.SelectedItem.ToString() == "Old hope road")
            {

                this.checkedListBox1.Items.Add("noise pollution");
            }
            else
            {


                this.checkedListBox1.Items.Add("Lack of Electricity ");//this.checkedListBox1.Items.Add("Lack of Electricity ");
                
            }

            */


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
