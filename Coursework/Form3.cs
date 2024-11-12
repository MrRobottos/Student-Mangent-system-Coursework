using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //locates filepath for textfile
            string[] lines = File.ReadAllLines(@"C:\Users\BIPIN\source\repos\Coursework\data.txt");
            string[] values;

            //loops though arraay lines to populate the datagridview with data from textfile
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridStudentView.Rows.Add(row);
            }
        }

        private void dataGridStudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
