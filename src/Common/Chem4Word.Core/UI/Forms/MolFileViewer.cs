﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chem4Word.Core.UI.Forms
{
    public partial class MolFileViewer : Form
    {
        public string Message { get; set; }
        public System.Windows.Point TopLeft { get; set; }

        public MolFileViewer(System.Windows.Point topLeft, string text)
        {
            InitializeComponent();

            TopLeft = topLeft;
            Message = text;
        }

        private void TextViewer_Load(object sender, EventArgs e)
        {
            if (TopLeft.X != 0 && TopLeft.Y != 0)
            {
                Left = (int)TopLeft.X;
                Top = (int)TopLeft.Y;
            }

            try
            {
                textBox1.Text = Message;
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = 1;
            }
            catch (Exception)
            {
                // Do Nothing
            }
        }
    }
}