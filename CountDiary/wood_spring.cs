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
    public partial class wood_spring : Form {
        public wood_spring() {
            InitializeComponent();
        }

        private void wood_spring_Load(object sender, EventArgs e) {
            woodpic.ImageLocation = "Image/woods_spring.png";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
