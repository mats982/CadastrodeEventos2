﻿namespace CadastrodeEventos2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEventoPage());
        }
    }
}
