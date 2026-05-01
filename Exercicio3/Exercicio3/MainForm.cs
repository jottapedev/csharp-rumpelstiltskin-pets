/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 30/04/2026
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercicio3
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			//DECLARAR AS VARIAVEIS
			int qtdFilhotes, qtdAdultos, qtdGravidos;
			int estoqueFilhotes, estoqueAdultos, estoqueGravidos;
			double totalFilhotes, totalAdultos, totalGravidos, totalGeral;
			double descontoFilhotes, descontoAdultos;
			string resultado;
			
			//LER ESTOQUE DOS LABEL
			estoqueFilhotes = int.Parse(lblestoquefilho.Text);
			estoqueAdultos  = int.Parse(lblestoqueadulto.Text);
			estoqueGravidos = int.Parse(lblestoquegravida.Text);

			//ENTRADA DE DADOS
			qtdFilhotes = int.Parse(txtqtdfilho.Text);
			qtdAdultos  = int.Parse(txtqtdadulto.Text);
			qtdGravidos = int.Parse(txtqtdgravido.Text);
			
			//VERIFICAR ESTOQUE E SÓ CALCULAR SE TIVER OK
			if (qtdFilhotes > estoqueFilhotes)
			{
				lblresultado.Text = "Sem estoque de filhotes! Disponivel: " + estoqueFilhotes;
			}
			else if (qtdAdultos > estoqueAdultos)
			{
				lblresultado.Text = "Sem estoque de Adultos! Disponivel: " + estoqueAdultos;
			}
			else if (qtdGravidos > estoqueGravidos)
			{
				lblresultado.Text = "Sem estoque de Gravidos! Disponivel: " + estoqueGravidos;
			}
			else if (qtdFilhotes == 0 && qtdAdultos == 0 && qtdGravidos == 0)
			{
				lblresultado.Text = "Informe pelo menos uma quantidade!";
			}
			else
			{
				//CALCULO DOS FILHOTES
				totalFilhotes    = qtdFilhotes * 1000;
				descontoFilhotes = 0;
				
				if (qtdFilhotes > 14)
				{
					descontoFilhotes = totalFilhotes * 0.07;
					totalFilhotes    = totalFilhotes - descontoFilhotes;
				}
				
				//CALCULO DOS ADULTOS
				totalAdultos    = qtdAdultos * 1000;
				descontoAdultos = 0;
				
				if (qtdAdultos > 7)
				{
					descontoAdultos = totalAdultos * 0.07;
					totalAdultos    = totalAdultos - descontoAdultos;
				}
				
				//CALCULO DOS GRAVIDOS
				totalGravidos = qtdGravidos * 1500;
				
				//TOTAL GERAL
				totalGeral = totalFilhotes + totalAdultos + totalGravidos;
				
				//MONTANDO RESULTADO
				resultado = "===============================\n";
				resultado = resultado + " COMPROVANTE RUMPELSTILTSKIN\n";
				resultado = resultado + "===============================\n";
				
				if (qtdFilhotes > 0)
				{
					resultado = resultado + "\n";
					resultado = resultado + " FILHOTES\n";
					resultado = resultado + " Quantidade : " + qtdFilhotes + "\n";
					resultado = resultado + " Preco unit : R$ 1000,00\n";
					
					if (qtdFilhotes > 14)
					{
						resultado = resultado + " Desconto 7%: -R$ " + descontoFilhotes + "\n";
					}
					else
					{
						resultado = resultado + " Desconto   : nao aplicado (min. 15 un.)\n";
					}
					
					resultado = resultado + " Total      : R$ " + totalFilhotes + "\n";
				}
				
				if (qtdAdultos > 0)
				{
					resultado = resultado + "\n";
					resultado = resultado + " ADULTOS\n";
					resultado = resultado + " Quantidade : " + qtdAdultos + "\n";
					resultado = resultado + " Preco unit : R$ 1000,00\n";
					
					if (qtdAdultos > 7)
					{
						resultado = resultado + " Desconto 7%: -R$ " + descontoAdultos + "\n";
					}
					else
					{
						resultado = resultado + " Desconto   : nao aplicado (min. 8 un.)\n";
					}
					
					resultado = resultado + " Total      : R$ " + totalAdultos + "\n";
				}
				
				if (qtdGravidos > 0)
				{
					resultado = resultado + "\n";
					resultado = resultado + " GRAVIDOS\n";
					resultado = resultado + " Quantidade : " + qtdGravidos + "\n";
					resultado = resultado + " Preco unit : R$ 1500,00 (+50%)\n";
					resultado = resultado + " Desconto   : sem desconto\n";
					resultado = resultado + " Total      : R$ " + totalGravidos + "\n";
				}
				
				resultado = resultado + "\n";
				resultado = resultado + "================================\n";
				resultado = resultado + " TOTAL GERAL: R$ " + totalGeral + "\n";
				resultado = resultado + "================================\n";
				
				lblresultado.Text = resultado;
				
				//ATUALIZAR ESTOQUE
				estoqueFilhotes = estoqueFilhotes - qtdFilhotes;
				estoqueAdultos  = estoqueAdultos  - qtdAdultos;
				estoqueGravidos = estoqueGravidos - qtdGravidos;
				
				lblestoquefilho.Text   = "" + estoqueFilhotes;
				lblestoqueadulto.Text  = "" + estoqueAdultos;
				lblestoquegravida.Text = "" + estoqueGravidos;
			}
		}
	}
}
