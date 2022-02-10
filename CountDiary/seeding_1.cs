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
    public partial class seeding_1 : Form {
        public seeding_1() {
            InitializeComponent();
        }

        private void seeding_1_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/nae.png";

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
