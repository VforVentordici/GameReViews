﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews
{
    public partial class VideogiocoRootView : UserControl
    {
        public VideogiocoRootView()
        {
            InitializeComponent();
        }

        public CustomDataGridView getCustomDataGrid()
        {
            return _preferenzeList;
        }
    }
}
