﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Screens.Templates
{
    public partial class FormTemplate : Form
    {
        public FormTemplate()
        {
            InitializeComponent();
        }
        public bool IsUpdate { get; set; }
    }
}
