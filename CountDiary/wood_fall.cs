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
    public partial class wood_fall : Form {
        public wood_fall() {
            InitializeComponent();
        }

        private void wood_fall_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/woods_fall.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
