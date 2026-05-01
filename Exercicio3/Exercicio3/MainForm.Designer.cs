/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 30/04/2026
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Exercicio3
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblestoquegravida = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblestoqueadulto = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblestoquefilho = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtqtdgravido = new System.Windows.Forms.TextBox();
			this.txtqtdadulto = new System.Windows.Forms.TextBox();
			this.txtqtdfilho = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btncalcular = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(878, 101);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(475, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "LOJA RUMPELSTILTSKIN";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Wheat;
			this.panel2.Controls.Add(this.lblestoquegravida);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.lblestoqueadulto);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.lblestoquefilho);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(14, 115);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(832, 88);
			this.panel2.TabIndex = 1;
			// 
			// lblestoquegravida
			// 
			this.lblestoquegravida.Location = new System.Drawing.Point(750, 26);
			this.lblestoquegravida.Name = "lblestoquegravida";
			this.lblestoquegravida.Size = new System.Drawing.Size(100, 23);
			this.lblestoquegravida.TabIndex = 6;
			this.lblestoquegravida.Text = "700";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(549, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(203, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "GRAVIDAS DISPONIVEL:";
			// 
			// lblestoqueadulto
			// 
			this.lblestoqueadulto.Location = new System.Drawing.Point(469, 26);
			this.lblestoqueadulto.Name = "lblestoqueadulto";
			this.lblestoqueadulto.Size = new System.Drawing.Size(100, 23);
			this.lblestoqueadulto.TabIndex = 4;
			this.lblestoqueadulto.Text = "21000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(270, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "ADULTOS DISPONIVEL:";
			// 
			// lblestoquefilho
			// 
			this.lblestoquefilho.Location = new System.Drawing.Point(207, 26);
			this.lblestoquefilho.Name = "lblestoquefilho";
			this.lblestoquefilho.Size = new System.Drawing.Size(100, 23);
			this.lblestoquefilho.TabIndex = 2;
			this.lblestoquefilho.Text = "7000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "FILHOTES DISPONIVEL:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Visitor TT1 BRK", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(978, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "ESTOQUE ATUAL -------------------------------------------------------------------" +
			"-----------------------------------";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.txtqtdgravido);
			this.panel3.Controls.Add(this.txtqtdadulto);
			this.panel3.Controls.Add(this.txtqtdfilho);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(17, 219);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(828, 236);
			this.panel3.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(267, 180);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(408, 17);
			this.label12.TabIndex = 15;
			this.label12.Text = "R$1.500.00 por unidade (-50%) | sem desconto por quantidade";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(267, 115);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(415, 17);
			this.label11.TabIndex = 14;
			this.label11.Text = "R$1.000.00 por unidade | desconto de 7% se comprar mais de 7";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(267, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(423, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "R$1.000.00 por unidade | desconto de 7% se comprar mais de 14";
			// 
			// txtqtdgravido
			// 
			this.txtqtdgravido.Location = new System.Drawing.Point(136, 177);
			this.txtqtdgravido.Name = "txtqtdgravido";
			this.txtqtdgravido.Size = new System.Drawing.Size(100, 22);
			this.txtqtdgravido.TabIndex = 12;
			// 
			// txtqtdadulto
			// 
			this.txtqtdadulto.Location = new System.Drawing.Point(136, 110);
			this.txtqtdadulto.Name = "txtqtdadulto";
			this.txtqtdadulto.Size = new System.Drawing.Size(100, 22);
			this.txtqtdadulto.TabIndex = 11;
			// 
			// txtqtdfilho
			// 
			this.txtqtdfilho.Location = new System.Drawing.Point(136, 52);
			this.txtqtdfilho.Name = "txtqtdfilho";
			this.txtqtdfilho.Size = new System.Drawing.Size(100, 22);
			this.txtqtdfilho.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DarkViolet;
			this.label10.Location = new System.Drawing.Point(12, 177);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 17);
			this.label10.TabIndex = 9;
			this.label10.Text = "GRAVIDOS:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label9.Location = new System.Drawing.Point(12, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "ADULTOS:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Visitor TT1 BRK", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(1088, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "QUANTIDADE PARA COMPRAR ---------------------------------------------------------" +
			"---------------------------------------------";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Crimson;
			this.label7.Location = new System.Drawing.Point(12, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "FILHOTES:";
			// 
			// btncalcular
			// 
			this.btncalcular.BackColor = System.Drawing.Color.Black;
			this.btncalcular.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.ForeColor = System.Drawing.Color.DarkOrange;
			this.btncalcular.Location = new System.Drawing.Point(29, 476);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(148, 51);
			this.btncalcular.TabIndex = 3;
			this.btncalcular.Text = "CALCULAR";
			this.btncalcular.UseVisualStyleBackColor = false;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// lblresultado
			// 
			this.lblresultado.BackColor = System.Drawing.SystemColors.WindowText;
			this.lblresultado.ForeColor = System.Drawing.SystemColors.Window;
			this.lblresultado.Location = new System.Drawing.Point(39, 568);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(787, 290);
			this.lblresultado.TabIndex = 4;
			this.lblresultado.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Visitor TT1 BRK", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(12, 539);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(1033, 17);
			this.label13.TabIndex = 16;
			this.label13.Text = "DETALHES DA COMPRA --------------------------------------------------------------" +
			"----------------------------------------";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 870);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Exercicio3";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RichTextBox lblresultado;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtqtdfilho;
		private System.Windows.Forms.TextBox txtqtdadulto;
		private System.Windows.Forms.TextBox txtqtdgravido;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblestoquefilho;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblestoqueadulto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblestoquegravida;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
