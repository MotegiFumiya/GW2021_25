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
    public partial class wood_1 : Form {
        public wood_1() {
            InitializeComponent();
        }

        private void wood_1_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/wood1.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
