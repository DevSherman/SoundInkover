namespace SoundInvoker
{
    partial class ItemUI
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.vCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Enabled = false;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(15, 54);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(95, 23);
            this.b1.TabIndex = 0;
            this.b1.TabStop = false;
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Enabled = false;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(108, 54);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(92, 23);
            this.b2.TabIndex = 1;
            this.b2.TabStop = false;
            this.b2.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(125, 83);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 0;
            this.bSave.TabStop = false;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // vCancel
            // 
            this.vCancel.Location = new System.Drawing.Point(13, 83);
            this.vCancel.Name = "vCancel";
            this.vCancel.Size = new System.Drawing.Size(75, 23);
            this.vCancel.TabIndex = 0;
            this.vCancel.TabStop = false;
            this.vCancel.Text = "Cancel";
            this.vCancel.UseVisualStyleBackColor = true;
            this.vCancel.Click += new System.EventHandler(this.VCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press any keys";
            // 
            // bLoad
            // 
            this.bLoad.CausesValidation = false;
            this.bLoad.Location = new System.Drawing.Point(12, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(188, 23);
            this.bLoad.TabIndex = 0;
            this.bLoad.TabStop = false;
            this.bLoad.Text = "Load Sound";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // ItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(210, 111);
            this.ControlBox = false;
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.vCancel);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Item";
            this.Load += new System.EventHandler(this.ItemUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button vCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLoad;
    }
}