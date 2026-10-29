/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 27/10/2026
 * Hora: 08:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCalcularClick(object sender, System.EventArgs e)
		{
			if(txtPeso.Text=="" || txtEstatura.Text=="")
				MessageBox.Show("Por favore, marque ambos apartados con sus datos para calcular su IMC","Marque sus datos");
			else
			{
				double estatura, peso, IMC;
				estatura=Convert.ToDouble(txtEstatura.Text);
				peso=Convert.ToDouble(txtPeso.Text);
				IMC=peso/(estatura*estatura);
				if(IMC<=18.4)
					lblIMC.Text="Su IMC es: "+string.Format("{0:F2}",IMC)+" (peso bajo)";
				else if(IMC>=18.5 && IMC<=24.9)
					lblIMC.Text="Su IMC es: "+string.Format("{0:F2}",IMC)+" (peso ideal)";
				else if(IMC>=25 && IMC<=30)
					lblIMC.Text="Su IMC es: "+string.Format("{0:F2}",IMC)+" (sobrepeso)";
				else if(IMC>=30.1)
					lblIMC.Text="Su IMC es: "+string.Format("{0:F2}",IMC)+" (obesidad)";
			}
		}
	}
}
