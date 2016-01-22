namespace Trekking
{
    partial class Form1
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
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxwaarde = new System.Windows.Forms.TextBox();
            this.txtGewenst = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLaatzien = new System.Windows.Forms.Button();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnTrek = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(12, 12);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(329, 329);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(347, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 329);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maxwaarde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aantal gewenst";
            // 
            // txtMaxwaarde
            // 
            this.txtMaxwaarde.Location = new System.Drawing.Point(347, 359);
            this.txtMaxwaarde.Name = "txtMaxwaarde";
            this.txtMaxwaarde.Size = new System.Drawing.Size(120, 31);
            this.txtMaxwaarde.TabIndex = 4;
            // 
            // txtGewenst
            // 
            this.txtGewenst.Location = new System.Drawing.Point(347, 396);
            this.txtGewenst.Name = "txtGewenst";
            this.txtGewenst.Size = new System.Drawing.Size(120, 31);
            this.txtGewenst.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(484, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 44);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLaatzien
            // 
            this.btnLaatzien.Location = new System.Drawing.Point(484, 62);
            this.btnLaatzien.Name = "btnLaatzien";
            this.btnLaatzien.Size = new System.Drawing.Size(120, 44);
            this.btnLaatzien.TabIndex = 7;
            this.btnLaatzien.Text = "Laat zien";
            this.btnLaatzien.UseVisualStyleBackColor = true;
            this.btnLaatzien.Click += new System.EventHandler(this.btnLaatzien_Click);
            // 
            // btnSorteer
            // 
            this.btnSorteer.Location = new System.Drawing.Point(484, 112);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(120, 44);
            this.btnSorteer.TabIndex = 8;
            this.btnSorteer.Text = "Sorteer";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(484, 162);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(120, 44);
            this.btnSerie.TabIndex = 9;
            this.btnSerie.Text = "Serie";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            // 
            // btnTrek
            // 
            this.btnTrek.Location = new System.Drawing.Point(484, 212);
            this.btnTrek.Name = "btnTrek";
            this.btnTrek.Size = new System.Drawing.Size(120, 44);
            this.btnTrek.TabIndex = 10;
            this.btnTrek.Text = "Trek";
            this.btnTrek.UseVisualStyleBackColor = true;
            this.btnTrek.Click += new System.EventHandler(this.btnTrek_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(484, 262);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 44);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 445);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnTrek);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.btnLaatzien);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtGewenst);
            this.Controls.Add(this.txtMaxwaarde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.imgBox);
            this.Name = "Form1";
            this.Text = "Trekking";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxwaarde;
        private System.Windows.Forms.TextBox txtGewenst;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLaatzien;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnTrek;
        private System.Windows.Forms.Button btnStart;
    }
}

