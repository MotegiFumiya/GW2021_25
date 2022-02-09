using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDiary {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {
            wood4.ImageLocation = "C:/Users/infosys/Desktop/木/wood.png";

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
