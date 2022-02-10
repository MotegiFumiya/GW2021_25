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
    public partial class wood_3 : Form {
        public wood_3() {
            InitializeComponent();
        }

        private void wood_3_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/wood3.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
