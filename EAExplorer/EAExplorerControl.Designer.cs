/*
 * Created by SharpDevelop.
 * User: wij
 * Date: 30/06/2011
 * Time: 4:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EAExplorer
{
	partial class EAExplorerControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.eaObjectName = new System.Windows.Forms.Label();
			this.eaObjectType = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.showEmbeddedObjects = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid
			// 
			this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid.HelpVisible = false;
			this.propertyGrid.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size(401, 144);
			this.propertyGrid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// eaObjectName
			// 
			this.eaObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eaObjectName.Location = new System.Drawing.Point(143, 27);
			this.eaObjectName.Name = "eaObjectName";
			this.eaObjectName.Size = new System.Drawing.Size(100, 23);
			this.eaObjectName.TabIndex = 2;
			this.eaObjectName.Text = "eaObjectName";
			// 
			// eaObjectType
			// 
			this.eaObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eaObjectType.Location = new System.Drawing.Point(143, 5);
			this.eaObjectType.Name = "eaObjectType";
			this.eaObjectType.Size = new System.Drawing.Size(100, 23);
			this.eaObjectType.TabIndex = 4;
			this.eaObjectType.Text = "eaObjectType";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Object Type:";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.propertyGrid);
			this.panel1.Location = new System.Drawing.Point(3, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(401, 144);
			this.panel1.TabIndex = 7;
			// 
			// showEmbeddedObjects
			// 
			this.showEmbeddedObjects.Appearance = System.Windows.Forms.Appearance.Button;
			this.showEmbeddedObjects.Location = new System.Drawing.Point(3, 50);
			this.showEmbeddedObjects.Name = "showEmbeddedObjects";
			this.showEmbeddedObjects.Size = new System.Drawing.Size(228, 24);
			this.showEmbeddedObjects.TabIndex = 8;
			this.showEmbeddedObjects.Text = "Show Embedded Objects";
			this.showEmbeddedObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.showEmbeddedObjects.UseVisualStyleBackColor = true;
			// 
			// EAExplorerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.showEmbeddedObjects);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.eaObjectType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.eaObjectName);
			this.Controls.Add(this.label1);
			this.Name = "EAExplorerControl";
			this.Size = new System.Drawing.Size(407, 227);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox showEmbeddedObjects;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label eaObjectType;
		private System.Windows.Forms.Label eaObjectName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PropertyGrid propertyGrid;
	}
}
