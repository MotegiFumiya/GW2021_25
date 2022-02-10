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
    public partial class seeding_2 : Form {
        public seeding_2() {
            InitializeComponent();
        }

        private void seeding_2_Load(object sender, EventArgs e) {
            woodpic2.ImageLocation = "Image/nae2.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
