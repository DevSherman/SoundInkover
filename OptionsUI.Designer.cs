namespace SoundInvoker
{
    partial class OptionsUI
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
            this.b1k2 = new System.Windows.Forms.Button();
            this.b2k1 = new System.Windows.Forms.Button();
            this.b2k2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barVolume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.b1k1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.barCache = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.lvolume = new System.Windows.Forms.Label();
            this.lmax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCache)).BeginInit();
            this.SuspendLayout();
            // 
            // b1k2
            // 
            this.b1k2.Enabled = false;
            this.b1k2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1k2.Location = new System.Drawing.Point(192, 39);
            this.b1k2.Name = "b1k2";
            this.b1k2.Size = new System.Drawing.Size(75, 23);
            this.b1k2.TabIndex = 2;
            this.b1k2.UseVisualStyleBackColor = true;
            // 
            // b2k1
            // 
            this.b2k1.Enabled = false;
            this.b2k1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2k1.Location = new System.Drawing.Point(111, 93);
            this.b2k1.Name = "b2k1";
            this.b2k1.Size = new System.Drawing.Size(75, 23);
            this.b2k1.TabIndex = 7;
            this.b2k1.UseVisualStyleBackColor = true;
            // 
            // b2k2
            // 
            this.b2k2.Enabled = false;
            this.b2k2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2k2.Location = new System.Drawing.Point(192, 93);
            this.b2k2.Name = "b2k2";
            this.b2k2.Size = new System.Drawing.Size(75, 23);
            this.b2k2.TabIndex = 6;
            this.b2k2.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(12, 93);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(93, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "EDIT";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Volume -";
            // 
            // barVolume
            // 
            this.barVolume.Location = new System.Drawing.Point(12, 155);
            this.barVolume.Maximum = 100;
            this.barVolume.Name = "barVolume";
            this.barVolume.Size = new System.Drawing.Size(254, 45);
            this.barVolume.TabIndex = 10;
            this.barVolume.Value = 50;
            this.barVolume.ValueChanged += new System.EventHandler(this.BarVolume_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Volume";
            // 
            // b1k1
            // 
            this.b1k1.Enabled = false;
            this.b1k1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1k1.Location = new System.Drawing.Point(111, 39);
            this.b1k1.Name = "b1k1";
            this.b1k1.Size = new System.Drawing.Size(75, 23);
            this.b1k1.TabIndex = 4;
            this.b1k1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume +";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 39);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(93, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "EDIT";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max sounds";
            // 
            // barCache
            // 
            this.barCache.Location = new System.Drawing.Point(12, 226);
            this.barCache.Maximum = 25;
            this.barCache.Minimum = 1;
            this.barCache.Name = "barCache";
            this.barCache.Size = new System.Drawing.Size(254, 45);
            this.barCache.TabIndex = 12;
            this.barCache.Value = 25;
            this.barCache.ValueChanged += new System.EventHandler(this.BarCache_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "perfomance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "more  sounds in simultanealy";
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(186, 293);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(80, 23);
            this.bApply.TabIndex = 16;
            this.bApply.Text = "APPLY";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(20, 293);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(80, 23);
            this.bCancel.TabIndex = 17;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(103, 293);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(80, 23);
            this.bReset.TabIndex = 18;
            this.bReset.Text = "RESET";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // lvolume
            // 
            this.lvolume.AutoSize = true;
            this.lvolume.Location = new System.Drawing.Point(237, 138);
            this.lvolume.Name = "lvolume";
            this.lvolume.Size = new System.Drawing.Size(19, 13);
            this.lvolume.TabIndex = 19;
            this.lvolume.Text = "50";
            this.lvolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lmax
            // 
            this.lmax.AutoSize = true;
            this.lmax.Location = new System.Drawing.Point(237, 210);
            this.lmax.Name = "lmax";
            this.lmax.Size = new System.Drawing.Size(19, 13);
            this.lmax.TabIndex = 20;
            this.lmax.Text = "25";
            this.lmax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OptionsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(279, 328);
            this.ControlBox = false;
            this.Controls.Add(this.lmax);
            this.Controls.Add(this.lvolume);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barCache);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b2k1);
            this.Controls.Add(this.b2k2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1k1);
            this.Controls.Add(this.b1k2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCache)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b1k2;
        private System.Windows.Forms.Button b2k1;
        private System.Windows.Forms.Button b2k2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar barVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b1k1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar barCache;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lvolume;
        private System.Windows.Forms.Label lmax;
    }
}