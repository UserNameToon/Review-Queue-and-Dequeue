using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericsStuff
{
    public partial class Form1 : Form
    {
        List<Widget> myList = new List<Widget>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_BT_GEN_Click(object sender, EventArgs e)
        {
            myList.Clear();
            UI_LV_WG.Items.Clear();
            for (int i = 0; i < 500; i++)
            {
                myList.Add(new Widget());
            }
            DisplayList();
        }

        private void UI_BT_SHU_Click(object sender, EventArgs e)
        {

        }

        private void UI_BT_EDQ_Click(object sender, EventArgs e)
        {

        }

        private void DisplayList()
        {
            if (myList.Count == 0) throw new Exception("no widget in si list");
            foreach (var item in myList)
            {
                UI_LV_WG.Items.Add(item.Priority.ToString()).SubItems.Add(item.Name);
            }
        }
    }
}
