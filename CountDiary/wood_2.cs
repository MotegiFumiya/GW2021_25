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
    public partial class wood_2 : Form {
        public wood_2() {
            InitializeComponent();
        }

        private void wood_2_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/wood2.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
