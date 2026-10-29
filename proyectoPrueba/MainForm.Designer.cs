/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 27/10/2026
 * Hora: 08:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoPrueba
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEstatura = new System.Windows.Forms.TextBox();
			this.lblIMC = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label1.Location = new System.Drawing.Point(82, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 57);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculadora de tu IMC";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(61, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "ingresa tu peso (kg):";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(176, 169);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(110, 44);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(243, 86);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(165, 26);
			this.txtPeso.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(61, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ingresa tu estatura(m):";
			// 
			// txtEstatura
			// 
			this.txtEstatura.Location = new System.Drawing.Point(243, 119);
			this.txtEstatura.Name = "txtEstatura";
			this.txtEstatura.Size = new System.Drawing.Size(165, 26);
			this.txtEstatura.TabIndex = 5;
			// 
			// lblIMC
			// 
			this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblIMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.lblIMC.Location = new System.Drawing.Point(61, 227);
			this.lblIMC.Name = "lblIMC";
			this.lblIMC.Size = new System.Drawing.Size(362, 43);
			this.lblIMC.TabIndex = 6;
			this.lblIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 288);
			this.Controls.Add(this.lblIMC);
			this.Controls.Add(this.txtEstatura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Calculadora de IMC v1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblIMC;
		private System.Windows.Forms.TextBox txtEstatura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
