using Microsoft.Maui.Animations;
using System.Buffers.Text;

namespace Ejercicio4_1.Vista;

public partial class JuegoAlineacion : ContentPage
{
	public JuegoAlineacion()
	{
		InitializeComponent();
	}

	public void BtnStart_Clicked(object sender, EventArgs e)
	{
		lblCambiante.HorizontalOptions = LayoutOptions.Start;
		lblCambiante.HorizontalTextAlignment = TextAlignment.Start;
	}
	public void BtnHorizontalCenter_Clicked(object sender, EventArgs e)
	{
        lblCambiante.HorizontalOptions = LayoutOptions.Center;
        lblCambiante.HorizontalTextAlignment = TextAlignment.Center;
    }
	public void BtnHorizontalEnd_Clicked(object sender, EventArgs e)
	{
        lblCambiante.HorizontalOptions = LayoutOptions.End;
        lblCambiante.HorizontalTextAlignment = TextAlignment.End;
    }
    public void BtnHorizontalFill_Clicked(object sender, EventArgs e)
    {
        lblCambiante.HorizontalOptions = LayoutOptions.Fill;

    }

    ////
    public void BtnVerticalStart_Clicked(object sender, EventArgs e)
    {
        lblCambiante.VerticalOptions = LayoutOptions.Start;
        lblCambiante.VerticalTextAlignment = TextAlignment.Start;
    }
    public void BtnVerticalCenter_Clicked(object sender, EventArgs e)
    {
        lblCambiante.VerticalOptions = LayoutOptions.Center;
        lblCambiante.VerticalTextAlignment = TextAlignment.Center;
    }
    public void BtnVerticalEnd_Clicked(object sender, EventArgs e)
    {
        lblCambiante.VerticalOptions = LayoutOptions.End;
        lblCambiante.VerticalTextAlignment = TextAlignment.End;
    }
    public void BtnVerticalFill_Clicked(object sender, EventArgs e)
    {
        lblCambiante.VerticalOptions = LayoutOptions.Fill;

    }
}