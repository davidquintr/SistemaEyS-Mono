
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class vistaUsuario
	{
		private global::Gtk.VBox vbox17;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VBox vbox18;

		private global::Gtk.HSeparator hseparator4;

		private global::Gtk.DrawingArea drawingarea2;

		private global::Gtk.Label labelHora;

		private global::Gtk.VBox vbox19;

		private global::Gtk.VBox vbox20;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.VBox vbox24;

		private global::Gtk.Label labelBienv;

		private global::Gtk.Label labelEnt;

		private global::Gtk.Label labelTiempo;

		private global::Gtk.VBox vbox22;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.VBox vbox23;

		private global::Gtk.Button buttonEntrada;

		private global::Gtk.Button buttonSalida;

		private global::Gtk.Button buttonAlmuerzo;

		private global::Gtk.Fixed fixed17;

		private global::Gtk.Label labelFecha;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonAdmin;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.vistaUsuario
			this.WidthRequest = 640;
			this.Name = "ProyectoEyS.vistaUsuario";
			this.Title = global::Mono.Unix.Catalog.GetString("Panel de Usuario");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.vistaUsuario.Gtk.Container+ContainerChild
			this.vbox17 = new global::Gtk.VBox();
			this.vbox17.WidthRequest = 512;
			this.vbox17.Name = "vbox17";
			this.vbox17.Spacing = 6;
			// Container child vbox17.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox18 = new global::Gtk.VBox();
			this.vbox18.WidthRequest = 250;
			this.vbox18.Name = "vbox18";
			this.vbox18.Spacing = 6;
			// Container child vbox18.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator();
			this.hseparator4.HeightRequest = 25;
			this.hseparator4.Name = "hseparator4";
			this.vbox18.Add(this.hseparator4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.hseparator4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox18.Gtk.Box+BoxChild
			this.drawingarea2 = new global::Gtk.DrawingArea();
			this.drawingarea2.WidthRequest = 200;
			this.drawingarea2.HeightRequest = 200;
			this.drawingarea2.Name = "drawingarea2";
			this.vbox18.Add(this.drawingarea2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.drawingarea2]));
			w2.Position = 1;
			// Container child vbox18.Gtk.Box+BoxChild
			this.labelHora = new global::Gtk.Label();
			this.labelHora.HeightRequest = 43;
			this.labelHora.Name = "labelHora";
			this.labelHora.Yalign = 0F;
			this.labelHora.LabelProp = global::Mono.Unix.Catalog.GetString("HH:MM:SS");
			this.vbox18.Add(this.labelHora);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.labelHora]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox5.Add(this.vbox18);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox18]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox19 = new global::Gtk.VBox();
			this.vbox19.WidthRequest = 357;
			this.vbox19.Name = "vbox19";
			this.vbox19.Spacing = 6;
			// Container child vbox19.Gtk.Box+BoxChild
			this.vbox20 = new global::Gtk.VBox();
			this.vbox20.Name = "vbox20";
			this.vbox20.Spacing = 6;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.HeightRequest = 25;
			this.hseparator2.Name = "hseparator2";
			this.vbox20.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.hseparator2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.vbox24 = new global::Gtk.VBox();
			this.vbox24.Name = "vbox24";
			this.vbox24.Spacing = 6;
			// Container child vbox24.Gtk.Box+BoxChild
			this.labelBienv = new global::Gtk.Label();
			this.labelBienv.Name = "labelBienv";
			this.labelBienv.Xalign = 0F;
			this.labelBienv.LabelProp = global::Mono.Unix.Catalog.GetString("Buenos días, empleado");
			this.vbox24.Add(this.labelBienv);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.labelBienv]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox24.Gtk.Box+BoxChild
			this.labelEnt = new global::Gtk.Label();
			this.labelEnt.Name = "labelEnt";
			this.labelEnt.Xalign = 0F;
			this.labelEnt.LabelProp = global::Mono.Unix.Catalog.GetString("Hora de entrada: HH:MM");
			this.vbox24.Add(this.labelEnt);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.labelEnt]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox24.Gtk.Box+BoxChild
			this.labelTiempo = new global::Gtk.Label();
			this.labelTiempo.Name = "labelTiempo";
			this.labelTiempo.Xalign = 0F;
			this.labelTiempo.LabelProp = global::Mono.Unix.Catalog.GetString("Tiempo trabajando: HH:MM");
			this.vbox24.Add(this.labelTiempo);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.labelTiempo]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox20.Add(this.vbox24);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.vbox24]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox19.Add(this.vbox20);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.vbox20]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.vbox22 = new global::Gtk.VBox();
			this.vbox22.Name = "vbox22";
			this.vbox22.Spacing = 6;
			// Container child vbox22.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator();
			this.hseparator3.HeightRequest = 25;
			this.hseparator3.Name = "hseparator3";
			this.vbox22.Add(this.hseparator3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.hseparator3]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.vbox23 = new global::Gtk.VBox();
			this.vbox23.Name = "vbox23";
			this.vbox23.Spacing = 6;
			// Container child vbox23.Gtk.Box+BoxChild
			this.buttonEntrada = new global::Gtk.Button();
			this.buttonEntrada.HeightRequest = 40;
			this.buttonEntrada.CanFocus = true;
			this.buttonEntrada.Name = "buttonEntrada";
			this.buttonEntrada.UseUnderline = true;
			this.buttonEntrada.Label = global::Mono.Unix.Catalog.GetString("Marcar entrada");
			this.vbox23.Add(this.buttonEntrada);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.buttonEntrada]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox23.Gtk.Box+BoxChild
			this.buttonSalida = new global::Gtk.Button();
			this.buttonSalida.HeightRequest = 40;
			this.buttonSalida.Sensitive = false;
			this.buttonSalida.CanFocus = true;
			this.buttonSalida.Name = "buttonSalida";
			this.buttonSalida.UseUnderline = true;
			this.buttonSalida.Label = global::Mono.Unix.Catalog.GetString("Marcar salida");
			this.vbox23.Add(this.buttonSalida);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.buttonSalida]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox23.Gtk.Box+BoxChild
			this.buttonAlmuerzo = new global::Gtk.Button();
			this.buttonAlmuerzo.HeightRequest = 40;
			this.buttonAlmuerzo.CanFocus = true;
			this.buttonAlmuerzo.Name = "buttonAlmuerzo";
			this.buttonAlmuerzo.UseUnderline = true;
			this.buttonAlmuerzo.Label = global::Mono.Unix.Catalog.GetString("Almuerzo");
			this.vbox23.Add(this.buttonAlmuerzo);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.buttonAlmuerzo]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox22.Add(this.vbox23);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.vbox23]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.fixed17 = new global::Gtk.Fixed();
			this.fixed17.Name = "fixed17";
			this.fixed17.HasWindow = false;
			this.vbox22.Add(this.fixed17);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.fixed17]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox19.Add(this.vbox22);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.vbox22]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox5.Add(this.vbox19);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox19]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox17.Add(this.hbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.hbox5]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.labelFecha = new global::Gtk.Label();
			this.labelFecha.Name = "labelFecha";
			this.labelFecha.LabelProp = global::Mono.Unix.Catalog.GetString("DD:MM:YY");
			this.vbox17.Add(this.labelFecha);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.labelFecha]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 2;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdmin = new global::Gtk.Button();
			this.buttonAdmin.WidthRequest = 90;
			this.buttonAdmin.HeightRequest = 30;
			this.buttonAdmin.CanFocus = true;
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.UseUnderline = true;
			this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Finalizar");
			this.hbuttonbox6.Add(this.buttonAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
			w21.Expand = false;
			w21.Fill = false;
			this.vbox17.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.hbuttonbox6]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.vbox17);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 640;
			this.DefaultHeight = 359;
			this.Show();
			this.buttonEntrada.Clicked += new global::System.EventHandler(this.OnButtonEntradaClicked);
			this.buttonSalida.Clicked += new global::System.EventHandler(this.OnButtonSalidaClicked);
			this.buttonAlmuerzo.Clicked += new global::System.EventHandler(this.OnButtonAlmuerzoClicked);
			this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonAdminClicked);
		}
	}
}
