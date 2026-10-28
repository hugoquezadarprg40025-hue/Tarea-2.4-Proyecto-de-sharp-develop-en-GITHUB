/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 27/10/2026
 * Hora: 09:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace tarea_2.__German
{
	partial class Form1
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnCalcular.ForeColor = System.Drawing.Color.White;
			this.btnCalcular.Location = new System.Drawing.Point(183, 159);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(93, 39);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "numero A:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "numero B:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(56, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "numero C:";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(163, 24);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(248, 26);
			this.txtA.TabIndex = 4;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(163, 70);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(248, 26);
			this.txtB.TabIndex = 5;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(163, 115);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(248, 26);
			this.txtC.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(467, 222);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calcular formula general";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
	}
}
