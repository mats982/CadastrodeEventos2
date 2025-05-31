using CadastrodeEventos2.Views;
using ProjetoEventosMaui.Models;

namespace ProjetoEventosMaui.Views;

public partial class CadastroEventoPage : ContentPage
{
    private Evento _evento;

    public CadastroEventoPage()
    {
        InitializeComponent();
        _evento = new Evento
        {
            DataInicio = DateTime.Today,
            DataFim = DateTime.Today
        };
        BindingContext = _evento;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEventoPage(_evento));
    }
}
