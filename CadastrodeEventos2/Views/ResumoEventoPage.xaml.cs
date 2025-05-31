using ProjetoEventosMaui.Models;

namespace ProjetoEventosMaui.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}
