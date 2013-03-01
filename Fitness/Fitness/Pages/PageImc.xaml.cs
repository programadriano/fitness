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
    public partial class PageImc : PhoneApplicationPage
    {
        public PageImc()
        {
            InitializeComponent();
        }      

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            var pesoTmb = Convert.ToInt32(txtPeso.Text);
            var alturaTmb = Convert.ToInt32(txtAltura.Text);
            var idadeTmb = Convert.ToInt32(txtPesoIdade.Text);


            var altura = Convert.ToInt32(txtPeso.Text) / Math.Pow(Convert.ToInt32(txtAltura.Text), 2) * 10000;

            var valor = Convert.ToDouble(altura.ToString().Substring(0, 4));

            if (valor < 18.5)
            {
                Msg.Text = "Abaixo do peso";
            }
            else if (valor >= 18.5 && valor <= 24.9)
            {
                Msg.Text = "Peso normal";
            }
            else if (valor >= 25.0 && valor <= 29.9)
            {
                Msg.Text = "Acima do peso";
            }
            else if (valor >= 30.0 && valor <= 34.9)
            {
                Msg.Text = "Muito Acima do peso";
            }
            else if (valor >= 35.0 && valor <= 39.9)
            {
                Msg.Text = "Muito Muito Acima do peso";
            }
            else if (valor >= 40.0)
            {
                Msg.Text = "Muito Muito Muito Acima do peso";
            }


            this.c1lg1.DataContext = Convert.ToDouble(valor);

            var modo = "homem";

            //if (rdbM.IsChecked == true)
            //{
            //    modo = "homem";
            //}
            //else if (rdbF.IsChecked == true)
            //{
            //    modo = "mulher";
            //}

            calcula(modo, pesoTmb, alturaTmb, idadeTmb);

            // MessageBox.Show(altura.ToString().Substring(4,2));

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

                MessageBox.Show(vresultado.ToString());

                double total = vresultado + (vresultado * 0.25);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;

                MessageBox.Show(vnenhuma.ToString());

                total = vresultado + (vresultado * 0.35);
                vmoderada = ((Int32)total);
                var moderada = vmoderada;

                MessageBox.Show(moderada.ToString());

                total = vresultado + (vresultado * 0.45);
                vintensa = ((Int32)total);
                var intensa = vintensa;

                MessageBox.Show(intensa.ToString());
            }
            else if (modo == "mulher")
            {
                vresultado = 655 + (9.6 * vpeso) + (1.7 * valtura) - (4.7 * vidade);
                var resultado = vresultado;

                MessageBox.Show(vresultado.ToString());

                var total = vresultado + (vresultado * 0.20);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;

                MessageBox.Show(vnenhuma.ToString());

                total = vresultado + (vresultado * 0.30);
                vmoderada = ((Int32)total);
                var moderada = vmoderada;

                MessageBox.Show(moderada.ToString());

                total = vresultado + (vresultado * 0.40);
                vintensa = ((Int32)total);
                var intensa = vintensa;

                MessageBox.Show(intensa.ToString());
            }
        }
    }
}