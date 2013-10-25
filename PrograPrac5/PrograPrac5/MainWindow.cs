using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void clicked (object sender, EventArgs e)
	{

		double pes;
		double cam;
		double res;

		if (double.TryParse (pesos.Text, out pes) && double.TryParse (camb.Text, out cam)) {
			if(pes == 0 || cam == 0){
				MessageDialog cero;
				cero = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Conversion invalida entre cero");
				cero.Run();
				cero.Destroy();
		}
			else{
				res = pes / cam;
				dol.Text = Convert.ToString (res);
			}
		} 
		else if(pesos.Text == "" || camb.Text == ""){
			MessageDialog d;
			d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Campos vacios, ingrese numeros");
			d.Run();
			d.Destroy();
		}else {
			MessageDialog dia;
			dia = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Ingrese solo numeros");
			dia.Run();
			dia.Destroy();
		}
		

	}

}
