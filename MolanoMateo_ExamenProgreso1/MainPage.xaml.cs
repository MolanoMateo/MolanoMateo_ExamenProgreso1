using System.Diagnostics;

namespace MolanoMateo_ExamenProgreso1;

public partial class MainPage : ContentPage
{
	int op = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		

			CounterBtn.Text = $"RECARGANDO {op} Dolares... ESPERE";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
    void seleccionA(object sender, CheckedChangedEventArgs e)
    {
        // Perform required operation
        label.Text = "Se recargará 3 Dolares";
        op = 3;


    }
    void seleccionB(object sender, CheckedChangedEventArgs e)
    {
        // Perform required operation
        label.Text = "Se recargará 5 Dolares";
        op = 5;
    }
    void seleccionC(object sender, CheckedChangedEventArgs e)
    {
        // Perform required operation
        label.Text = "Se recargará 10 Dolares";
        op = 10;
    }
}

