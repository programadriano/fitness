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
{ //http://www.hipertrofia.org/forum/topic/112239-calcular-bf-porcentagem-de-gordura-sem-adipmetro/
    public partial class PageBf : PhoneApplicationPage
    {
        public PageBf()
        {
            InitializeComponent();
        }        

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            var peso = Convert.ToInt32(tbxPeso.Text);
            var cintura = Convert.ToInt32(tbxCintura.Text);

            var kgToLb = Convert.ToInt32(peso * 2.20462262);

            var calc1 = (kgToLb * 1.082) + 94.42;

            var cinturaToPolegada = cintura * 0.393700787;


            var calc2 = calc1 - (Convert.ToInt32(cinturaToPolegada.ToString().Substring(0, 2)) * 4.15);

            var massaCorporal = (kgToLb - calc2) * 100;

            var result = massaCorporal / kgToLb;

            MessageBox.Show(result.ToString());
        }
    }
}