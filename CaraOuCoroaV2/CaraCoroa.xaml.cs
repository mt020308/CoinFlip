namespace CaraOuCoroaV2;

public partial class CaraCoroa : ContentPage
{
    int numsort = 0;

    public CaraCoroa()
	{
		InitializeComponent();
	}

    private void GirarMoeda_Clicked(object sender, EventArgs e)
    {
        int max = 2;
        numsort = new Random().Next(1, max + 1);

        int ladoselec = CaraCoroaPicker.SelectedIndex;

        if (numsort == 1)
        {
            if (ladoselec == 0)
            {
                Moeda.Source = "cara.png";
                Result.Text = "Sua escolha ganhou! Coroa perdeu!";
            }
            if (ladoselec == 1)
            {
                Moeda.Source = "cara.png";
                Result.Text = "Sua escolha perdeu! Cara ganhou!";
            }
        }

        if (numsort == 2)
        {
            if (ladoselec == 1)
            {
                Moeda.Source = "coroa.png";
                Result.Text = "Sua escolha ganhou! Cara Perdeu!";
            }
            if (ladoselec == 0)
            {
                Moeda.Source = "coroa.png";
                Result.Text = "Sua escolha perdeu! Coroa Ganhou!";
            }
        }
    }
}