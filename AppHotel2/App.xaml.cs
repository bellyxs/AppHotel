using AppHotel2.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Threading;
using System.Globalization;

namespace AppHotel2
{
    public partial class App : Application
    {
        public List<Quarto> lista_suites= new List<Quarto>
        {
            new Quarto()
            {
               Nome = "Luxo",
               DiariaAdulto = 110.0,
               DiariaCrianca = 95.0
            },
            new Quarto()
            {
               Nome = "Executiva",
               DiariaAdulto = 90.0,
               DiariaCrianca = 75.0
            },
            new Quarto()
            {
               Nome = "Padrão",
               DiariaAdulto = 45.0,
               DiariaCrianca = 30.0
            }
        };


        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            else
                MainPage = new NavigationPage(new View.Login());
        }

        

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
