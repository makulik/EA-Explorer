/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 12.04.2012
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EAExplorer
{
	partial class DlgAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAbout));
			this.buttonOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AuthorEmail = new System.Windows.Forms.LinkLabel();
			this.AssemblyDate = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.Version = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonOK.Location = new System.Drawing.Point(107, 148);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "EA Explorer";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(82, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "© 2012 Günther Makulik\r\n";
			// 
			// AuthorEmail
			// 
			this.AuthorEmail.Location = new System.Drawing.Point(82, 56);
			this.AuthorEmail.Name = "AuthorEmail";
			this.AuthorEmail.Size = new System.Drawing.Size(134, 23);
			this.AuthorEmail.TabIndex = 5;
			this.AuthorEmail.TabStop = true;
			this.AuthorEmail.Text = "g-makulik@t-online,de";
			// 
			// AssemblyDate
			// 
			this.AssemblyDate.Location = new System.Drawing.Point(140, 89);
			this.AssemblyDate.Name = "AssemblyDate";
			this.AssemblyDate.Size = new System.Drawing.Size(100, 23);
			this.AssemblyDate.TabIndex = 9;
			this.AssemblyDate.Text = "AssemblyDate";
			// 
			// DateLabel
			// 
			this.DateLabel.Location = new System.Drawing.Point(82, 89);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(100, 23);
			this.DateLabel.TabIndex = 8;
			this.DateLabel.Text = "Date:";
			// 
			// Version
			// 
			this.Version.Location = new System.Drawing.Point(140, 76);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(100, 23);
			this.Version.TabIndex = 7;
			this.Version.Text = "assemblyVersion";
			// 
			// VersionLabel
			// 
			this.VersionLabel.Location = new System.Drawing.Point(82, 76);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(100, 23);
			this.VersionLabel.TabIndex = 6;
			this.VersionLabel.Text = "Version:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// DlgAbout
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonOK;
			this.ClientSize = new System.Drawing.Size(290, 183);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.AssemblyDate);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.Version);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.AuthorEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DlgAbout";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "About EA Explorer AddIn";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label Version;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label AssemblyDate;
		private System.Windows.Forms.LinkLabel AuthorEmail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
