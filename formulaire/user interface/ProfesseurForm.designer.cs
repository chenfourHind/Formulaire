﻿namespace GestionExam.interfaces
{
    partial class ProfesseurForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input1 = new System.Windows.Forms.RichTextBox();
            this.input3 = new System.Windows.Forms.RichTextBox();
            this.input4 = new System.Windows.Forms.RichTextBox();
            this.input2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.mySqlGeometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(409, 52);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(339, 42);
            this.input1.TabIndex = 7;
            this.input1.Text = "";
            // 
            // input3
            // 
            this.input3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input3.Location = new System.Drawing.Point(409, 209);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(339, 42);
            this.input3.TabIndex = 8;
            this.input3.Text = "";
            // 
            // input4
            // 
            this.input4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input4.Location = new System.Drawing.Point(409, 289);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(339, 42);
            this.input4.TabIndex = 9;
            this.input4.Text = "";
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(409, 132);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(339, 42);
            this.input2.TabIndex = 10;
            this.input2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "CNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tel";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(585, 372);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(163, 42);
            this.submit.TabIndex = 17;
            this.submit.Text = "Insert";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // tableView
            // 
            this.tableView.AccessibleName = "";
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cni,
            this.nom,
            this.prenom,
            this.tel});
            this.tableView.Location = new System.Drawing.Point(781, 37);
            this.tableView.Name = "tableView";
            this.tableView.RowTemplate.Height = 24;
            this.tableView.Size = new System.Drawing.Size(484, 360);
            this.tableView.TabIndex = 18;
            // 
            // mySqlGeometryBindingSource
            // 
            this.mySqlGeometryBindingSource.DataSource = typeof(MySql.Data.Types.MySqlGeometry);
            // 
            // cni
            // 
            this.cni.HeaderText = "cni";
            this.cni.Name = "cni";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // tel
            // 
            this.tel.HeaderText = "tel";
            this.tel.Name = "tel";
            // 
            // ProfesseurForm
            // 
            this.AccessibleName = "tableView";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1291, 426);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input1);
            this.Name = "ProfesseurForm";
            this.Text = "ProfesseurForm";
            this.Load += new System.EventHandler(this.ProfesseurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input1;
        private System.Windows.Forms.RichTextBox input3;
        private System.Windows.Forms.RichTextBox input4;
        private System.Windows.Forms.RichTextBox input2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.BindingSource mySqlGeometryBindingSource;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
    }
}