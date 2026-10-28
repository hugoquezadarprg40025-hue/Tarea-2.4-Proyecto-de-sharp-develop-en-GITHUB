/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 27/10/2026
 * Hora: 09:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea_2.__German
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double A, B, C, X1, X2;
			A=Convert.ToDouble(txtA.Text);
			B=Convert.ToDouble(txtB.Text);
			C=Convert.ToDouble(txtC.Text);
			X1=(-(B)+Math.Sqrt((B)*(B)-4*(A)*(C)))/(2*(A));
			X2=(-(B)-Math.Sqrt((B)*(B)-4*(A)*(C)))/(2*(A));
			MessageBox.Show("El serultado de X1 es "+X1+" y el de X2 es: "+X2);
		}
	}
}
