﻿using appHPotter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appHPotter.Formularios
{
    public partial class frmVerRegistros : Form
    {
        private object BDConnection { get; set; }
        private string BaseDatos { get; set; }

        public frmVerRegistros(string BaseDatos, object BDConnection)
        {
            InitializeComponent();
            switch (BaseDatos)
            {
                case "SQL":
                    this.BaseDatos = BaseDatos;
                    this.BDConnection = BDConnection;
                    break;
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            BDOperaciones BDO = new BDOperaciones(BaseDatos, BDConnection);
            BDO.CargarEnListViewSql(listView1, "SELECT * FROM Cliente");
        }
    }
}