using System;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using SandwichFlow.Util;
using WP7GapClassLib.PhoneGap.Commands;
using Fitness;
using System.Collections.Generic;
using System.Collections;
using WP7GapClassLib.PhoneGap;
using WP7GapClassLib.PhoneGap.Commands;
using WP7GapClassLib.PhoneGap.JSON;



namespace SandwichFlow
{
    //https://nuget.org/packages/SimpleJson

    public partial class MainPage : PhoneApplicationPage
    {
        private WebBrowserHelper _browserHelper;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            new BackButtonHandler(this, PGView);
            _browserHelper = new WebBrowserHelper(PGView.Browser);

            PGView.Browser.ScriptNotify += Browser_ScriptNotify;
            PGView.Browser.Navigated += Browser_Navigated;

            EventHandler<NavigationEventArgs> hideSplashScreen = null;
            hideSplashScreen = (s, e) =>
              {
                  fadeOut.Begin();
                  PGView.Browser.Navigated -= hideSplashScreen;
              };
            PGView.Browser.Navigated += hideSplashScreen;
        }

        private void Browser_Navigated(object sender, NavigationEventArgs e)
        {
            // when we first navigate to a page, we assume that it can be scrolled
            _browserHelper.ScrollDisabled = false;
        }

        private void Browser_ScriptNotify(object sender, NotifyEventArgs e)
        {
            // if a page notifies that it should not be scrollable, disable
            // scrolling.
            if (e.Value == "noScroll")
            {
                _browserHelper.ScrollDisabled = true;
            }
        }

        private void fadeOut_Completed(object sender, EventArgs e)
        {
            splashImage.Visibility = Visibility.Collapsed;
        }

    }

    public class MyCommand : BaseCommand
    {
        public void DoThis(string args)
        {
            var json = SimpleJson.DeserializeObject(args);
            var idadeTmb = 0;
            var alturaTmb = 0;
            var pesoTmb = 0;

            foreach (KeyValuePair<string, object> item in (IEnumerable)json)
            {
                switch (item.Key)
                {
                    case "age":
                        idadeTmb = Convert.ToInt32(item.Value);
                        break;
                    case "height":
                        alturaTmb = Convert.ToInt32(item.Value.ToString());
                        break;
                    case "weight":
                        pesoTmb = Convert.ToInt32(item.Value.ToString());
                        break;
                }

            }

            var imc = pesoTmb / Math.Pow(alturaTmb, 2) * 10000;

            if (imc < 18.5)
            {
                //  Msg.Text = "Você esta:" + " " + "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                //  Msg.Text = "Você esta:" + " " + "Peso normal";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                //    Msg.Text = "Você esta:" + " " + "Acima do peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                //   Msg.Text = "Você esta:" + " " + "Muito Acima do peso";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                //  Msg.Text = "Você esta:" + " " + "Muito Muito Acima do peso";
            }
            else if (imc >= 40.0)
            {
                //  Msg.Text = "Você esta:" + " " + "Muito Muito Muito Acima do peso";
            }


            //this.c1lg1.DataContext = Convert.ToDouble(valor);

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

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "{result:'super awesome!'}"));
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
                //  tmbValor.Text = vresultado.ToString();
                //    MessageBox.Show(vresultado.ToString());

                double total = vresultado + (vresultado * 0.25);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;
                // NdcNValue.Text = vnenhuma.ToString();
                //     MessageBox.Show(vnenhuma.ToString());

                total = vresultado + (vresultado * 0.35);
                vmoderada = ((Int32)total);
                var moderada = vmoderada;
                //  NdcMValue.Text = moderada.ToString();
                //       MessageBox.Show(moderada.ToString());

                total = vresultado + (vresultado * 0.45);
                vintensa = ((Int32)total);
                var intensa = vintensa;
                //   NdcIValue.Text = intensa.ToString();
                //        MessageBox.Show(intensa.ToString());
            }
            else if (modo == "mulher")
            {
                vresultado = 655 + (9.6 * vpeso) + (1.7 * valtura) - (4.7 * vidade);
                var resultado = vresultado;

                //          MessageBox.Show(vresultado.ToString());

                var total = vresultado + (vresultado * 0.20);
                vnenhuma = ((Int32)total);
                var nenhuma = vnenhuma;

                //      MessageBox.Show(vnenhuma.ToString());

                total = vresultado + (vresultado * 0.30);
                vmoderada = ((Int32)total);
                var moderada = vmoderada;

                //       MessageBox.Show(moderada.ToString());

                total = vresultado + (vresultado * 0.40);
                vintensa = ((Int32)total);
                var intensa = vintensa;

                //       MessageBox.Show(intensa.ToString());
            }
        }

    }

}