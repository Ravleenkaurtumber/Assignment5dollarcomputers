﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5dollarcomputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProductInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
