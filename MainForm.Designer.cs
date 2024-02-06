using System.Windows.Forms;


namespace CycleInstructor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSelectTrainingFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTrainingFile = new System.Windows.Forms.Label();
            this.buttonPlayMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectTrainingFile
            // 
            this.buttonSelectTrainingFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectTrainingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectTrainingFile.Location = new System.Drawing.Point(805, 12);
            this.buttonSelectTrainingFile.Name = "buttonSelectTrainingFile";
            this.buttonSelectTrainingFile.Size = new System.Drawing.Size(181, 40);
            this.buttonSelectTrainingFile.TabIndex = 2;
            this.buttonSelectTrainingFile.Text = "Select Training...";
            this.buttonSelectTrainingFile.UseVisualStyleBackColor = true;
            this.buttonSelectTrainingFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(805, 456);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(181, 40);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTrainingFile
            // 
            this.labelTrainingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrainingFile.Location = new System.Drawing.Point(12, 12);
            this.labelTrainingFile.Name = "labelTrainingFile";
            this.labelTrainingFile.Size = new System.Drawing.Size(787, 40);
            this.labelTrainingFile.TabIndex = 4;
            this.labelTrainingFile.Text = "...";
            this.labelTrainingFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPlayMusic
            // 
            this.buttonPlayMusic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPlayMusic.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPlayMusic.FlatAppearance.BorderSize = 2;
            this.buttonPlayMusic.Image = global::CycleInstructor.Properties.Resources.ButtonPlay;
            this.buttonPlayMusic.Location = new System.Drawing.Point(410, 316);
            this.buttonPlayMusic.Name = "buttonPlayMusic";
            this.buttonPlayMusic.Size = new System.Drawing.Size(180, 180);
            this.buttonPlayMusic.TabIndex = 5;
            this.buttonPlayMusic.UseVisualStyleBackColor = false;
            this.buttonPlayMusic.Click += new System.EventHandler(this.buttonPlayMusic_Click);
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Cycle Instructor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 508);
            this.Controls.Add(this.buttonPlayMusic);
            this.Controls.Add(this.labelTrainingFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSelectTrainingFile);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cycle Instructor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        internal System.Windows.Forms.Label labelTrainingFile;
        private System.Windows.Forms.Button buttonSelectTrainingFile;
        private System.Windows.Forms.Button buttonPlayMusic;
    }
}

