﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ColorPicker.Visual
{
    public partial class RoundedButton : Button
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public int _cornerRadiusX { get; set; } = 15;
        public int _cornerRadiusY { get; set; } = 15;
        public RoundedButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = roundedPanel(1, 1, Width, Height, _cornerRadiusX, _cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }

    }
}
