using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayzLogParser.UI {
    public partial class OptionsForm : Form {

        private Point ownerWindowOffset = new Point(25, 25);

        public OptionsForm() {
            InitializeComponent();

            this.Shown += new EventHandler(OptionsForm_Shown);
        }

        void OptionsForm_Shown(object sender, EventArgs e) {
            this.Location = new Point(this.Owner.Location.X + ownerWindowOffset.X, this.Owner.Location.Y + ownerWindowOffset.Y);
        }

        private void optionsCancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void optionsSaveBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
