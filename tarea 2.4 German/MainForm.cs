/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 27/10/2026
 * Hora: 07:27 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tarea_2.__German
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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if(cmbOperaciones.Text=="")
				MessageBox.Show("Selecciona un tipo de operacion, pls");
			else
			{
				switch (cmbOperaciones.SelectedItem.ToString())
				{
					case "Suma":
					double num1, num2, R;
					num1=Convert.ToDouble(txt1.Text);
					num2=Convert.ToDouble(txt2.Text);
					R=num1+num2;
					MessageBox.Show("El reusltado de la Suma es: "+R);
					break;
					case "Resta":
					num1=Convert.ToDouble(txt1.Text);
					num2=Convert.ToDouble(txt2.Text);
					R=num1-num2;
					MessageBox.Show("El reusltado de la Resta es: "+R);
					break;
					case "Multiplicacion":
					num1=Convert.ToDouble(txt1.Text);
					num2=Convert.ToDouble(txt2.Text);
					R=num1*num2;
					MessageBox.Show("El reusltado de la Multiplicacion es: "+R);
					break;
					case "Division":
					num1=Convert.ToDouble(txt1.Text);
					num2=Convert.ToDouble(txt2.Text);
					R=num1/num2;
					MessageBox.Show("El reusltado de la Division es: "+R);
					break;
					case "Modulo":
					num1=Convert.ToDouble(txt1.Text);
					num2=Convert.ToDouble(txt2.Text);
					R=num1%num2;
					MessageBox.Show("El reusltado de la Division es: "+R);
					break;
				}
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 x=new Form1();
			x.ShowDialog();
		}
	}
}