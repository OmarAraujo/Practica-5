/*
 * Creado por SharpDevelop.
 * Usuario: Ing. Omar
 * Fecha: 28/04/2014
 * Hora: 16:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_4_Examen
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
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
						string Responder = "";
						Responder = this.button1.Text; 
			
			if(this.checkBox1.Checked & this.checkBox4.Checked){
				Responder = " 1 Preguntas Correctas de 4";
			}

			  if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked){
				Responder = "2 Preguntas Correctas de 4";
			}
			
			if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked
			   & this.numericUpDown1.Text == "31"){
				Responder = "3 Preguntas correstas de 4";
			}
			
			if(this.checkBox1.Checked & this.checkBox4.Checked & this.radioButton2.Checked
			   & this.numericUpDown1.Text == "31" & 
			   this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				Responder = "4 Preguntas de 4 , Felicidades!!  ";				
			}
			
			 System.Windows.Forms.MessageBox.Show(Responder); 
		}
		
		
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
		
		
}
