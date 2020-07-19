namespace SoundInvoker
{
    partial class AudioControl
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
            this.cmdName = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openAudioFileButton = new System.Windows.Forms.Button();
            this.shortcutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdName
            // 
            this.cmdName.Enabled = false;
            this.cmdName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdName.ForeColor = System.Drawing.Color.Gray;
            this.cmdName.Location = new System.Drawing.Point(5, 3);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(135, 26);
            this.cmdName.TabIndex = 0;
            this.cmdName.Text = "Twitch command";
            this.cmdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmdName.Click += new System.EventHandler(this.CmdName_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(383, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(46, 26);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(435, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(45, 26);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Enabled = false;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(636, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 26);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Gray;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(579, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(51, 26);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(513, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 26);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // openAudioFileButton
            // 
            this.openAudioFileButton.Enabled = false;
            this.openAudioFileButton.Location = new System.Drawing.Point(146, 3);
            this.openAudioFileButton.Name = "openAudioFileButton";
            this.openAudioFileButton.Size = new System.Drawing.Size(109, 26);
            this.openAudioFileButton.TabIndex = 7;
            this.openAudioFileButton.Text = "<Open Audio File>";
            this.openAudioFileButton.UseVisualStyleBackColor = true;
            this.openAudioFileButton.Click += new System.EventHandler(this.OpenAudioFileButton_Click);
            // 
            // shortcutButton
            // 
            this.shortcutButton.Enabled = false;
            this.shortcutButton.Location = new System.Drawing.Point(261, 3);
            this.shortcutButton.Name = "shortcutButton";
            this.shortcutButton.Size = new System.Drawing.Size(116, 26);
            this.shortcutButton.TabIndex = 8;
            this.shortcutButton.Text = "<Keyshortcut>";
            this.shortcutButton.UseVisualStyleBackColor = true;
            this.shortcutButton.Click += new System.EventHandler(this.ShortcutButton_Click);
            // 
            // AudioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.shortcutButton);
            this.Controls.Add(this.openAudioFileButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.cmdName);
            this.Name = "AudioControl";
            this.Size = new System.Drawing.Size(726, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmdName;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button openAudioFileButton;
        private System.Windows.Forms.Button shortcutButton;
    }
}
