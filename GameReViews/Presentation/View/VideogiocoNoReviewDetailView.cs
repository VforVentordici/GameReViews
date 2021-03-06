﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.View
{
    public partial class VideogiocoNoReviewDetailView : UserControl
    {
        public event EventHandler aggiuntaRecensione;

        public Sessione _sessione;

        public VideogiocoNoReviewDetailView(Sessione sessione)
        {
            InitializeComponent();

            _sessione = sessione;

            _sessione.SessionChanged += SessioneChanged;

            SessioneChanged(null, EventArgs.Empty);
        }

        private void _aggiungiRecensione_Click(object sender, EventArgs e)
        {

        }

        private void SessioneChanged(object sender, EventArgs e)
        {
            if (!(_sessione.UtenteCorrente is Recensore))
            {
                _aggiungiRecensione.Visible = false;
            }
            else
            {
                _aggiungiRecensione.Visible = true;
            }
        }

    }
}
