using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Fitness.Pages
{
    public partial class PageTmb : PhoneApplicationPage
    {
        public PageTmb()
        {
            InitializeComponent();

            //IList<string> list = new List<string>(
            //    new List<string> { "Sedentário", "Levemente Ativo", "Moderadamente Ativo", "Bastante Ativo", "Muito Ativo" }
            //    );

            //ListAtividade.ItemsSource = list.ToList();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var peso = Convert.ToInt32(txtPeso.Text);
            var altura = Convert.ToInt32(txtAltura.Text);
            var idade = Convert.ToInt32(txtIdade.Text);
            var modo = "";

            if (rdbM.IsChecked == true)
            {
                modo = "homem";
            }
            else if (rdbF.IsChecked == true)
            {
                modo = "mulher";
            }

            //var atividade = ListAtividade.SelectedItem.ToString();

            //double formula = 0;
            //switch (atividade)
            //{
            //    case "Sedentário":
            //        formula = 1.2;
            //        break;
            //    case "Levemente Ativo":
            //        formula = 1.375;
            //        break;
            //    case "Moderadamente Ativo":
            //        formula = 1.55;
            //        break;
            //    case "Bastante Ativo":
            //        formula = 1.725;
            //        break;
            //    case "Muito Ativo":
            //        formula = 1.9;
            //        break;
            //}


            calcula(modo, peso, altura, idade);

            // MessageBox.Show(formulaMasculina.ToString());

        }

        public void calcula(string modo, double peso, double altura, int idade)
        {

            double vpeso = 0;
            double valtura = 0;
            var vidade = 0;
            double vresultado;
            var vnenhuma = 0;
            var vmoderada = 0;
            var vintensa = 0;

            if (peso > 0)
            {
                vpeso = peso;
            }

            if (altura > 0)
            {
                valtura = altura;
            }

            if (idade > 0)
            {
                vidade = idade;
            }           

            if (modo == "homem")
            {
                vresultado = 66 + (13.7 * vpeso) + (5 * valtura) - (6.8 * vidade);
                var result = vresultado; 

                double total = vresultado + (vresultado * 0.25);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;    

                total = vresultado + (vresultado * 0.35);
                vmoderada = ((Int32)total);
                var moderada = vmoderada; 

                total = vresultado + (vresultado * 0.45);
                vintensa = ((Int32)total);
                var intensa = vintensa;        
            }
            else if (modo == "mulher")
            {
                vresultado = 655 + (9.6 * vpeso) + (1.7 * valtura) - (4.7 * vidade);
                var resultado = vresultado; 

                var total = vresultado + (vresultado * 0.20);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;   

                total = vresultado + (vresultado * 0.30);
                vmoderada = ((Int32)total);
                var moderada = vmoderada;

                total = vresultado + (vresultado * 0.40);
                vintensa = ((Int32)total);
                var intensa = vintensa;          
            }
        }
    }
}