﻿namespace GameReViews.View
{
    partial class VideogiocoYesReviewDetailView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._recensioneText = new System.Windows.Forms.TextBox();
            this._valutazione = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._customDataGridView = new GameReViews.CustomDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._customDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 649);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._recensioneText);
            this.panel2.Controls.Add(this._valutazione);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 132);
            this.panel2.TabIndex = 0;
            // 
            // _recensioneText
            // 
            this._recensioneText.BackColor = System.Drawing.Color.White;
            this._recensioneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recensioneText.Location = new System.Drawing.Point(32, 21);
            this._recensioneText.Multiline = true;
            this._recensioneText.Name = "_recensioneText";
            this._recensioneText.ReadOnly = true;
            this._recensioneText.Size = new System.Drawing.Size(846, 78);
            this._recensioneText.TabIndex = 2;
            // 
            // _valutazione
            // 
            this._valutazione.AutoSize = true;
            this._valutazione.Location = new System.Drawing.Point(111, 102);
            this._valutazione.Name = "_valutazione";
            this._valutazione.Size = new System.Drawing.Size(33, 13);
            this._valutazione.TabIndex = 1;
            this._valutazione.Text = "value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valutazione";
            // 
            // _customDataGridView
            // 
            this._customDataGridView.AutoSize = true;
            this._customDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customDataGridView.Location = new System.Drawing.Point(0, 132);
            this._customDataGridView.Name = "_customDataGridView";
            this._customDataGridView.Size = new System.Drawing.Size(1129, 517);
            this._customDataGridView.TabIndex = 1;
            // 
            // VideogiocoYesReviewDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoYesReviewDetailView";
            this.Size = new System.Drawing.Size(1129, 649);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _valutazione;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView _customDataGridView;
        private System.Windows.Forms.TextBox _recensioneText;
    }
}
