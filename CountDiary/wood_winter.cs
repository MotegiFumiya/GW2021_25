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
    public partial class wood_winter : Form {
        public wood_winter() {
            InitializeComponent();
        }

        private void wood_winter_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/woods_winter.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
