
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmEstablecerEventos
	{
		private global::Gtk.VBox vbox6;

		private global::Gtk.Label labelTitulo;

		private global::Gtk.HBox hbox9;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table4;

		private global::Gtk.Entry entryRazon;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.VSeparator vseparator12;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label15;

		private global::Gtk.Calendar cldFechaInicio;

		private global::Gtk.Label label8;

		private global::Gtk.Calendar cldFechaFin;

		private global::Gtk.VSeparator vseparator11;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VSeparator vseparator9;

		private global::Gtk.Label labelSubTitulo;

		private global::Gtk.VSeparator vseparator7;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VSeparator vseparator10;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textvDescripcion;

		private global::Gtk.VSeparator vseparator8;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonAdmin;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmEstablecerEventos
			this.WidthRequest = 675;
			this.Name = "ProyectoEyS.frmEstablecerEventos";
			this.Title = global::Mono.Unix.Catalog.GetString("frmEstablecerEventos");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProyectoEyS.frmEstablecerEventos.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.labelTitulo = new global::Gtk.Label();
			this.labelTitulo.HeightRequest = 35;
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Xalign = 0.03F;
			this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Establecer evento con modalidad");
			this.vbox6.Add(this.labelTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.labelTitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.WidthRequest = 170;
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.Name = "vseparator3";
			this.hbox9.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), false);
			this.table4.WidthRequest = 625;
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.entryRazon = new global::Gtk.Entry();
			this.entryRazon.CanFocus = true;
			this.entryRazon.Name = "entryRazon";
			this.entryRazon.IsEditable = true;
			this.entryRazon.InvisibleChar = '•';
			this.table4.Add(this.entryRazon);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4[this.entryRazon]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 257;
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString(":");
			this.table4.Add(this.label2);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4[this.label2]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 128;
			this.label3.HeightRequest = 30;
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Tipo de evento:");
			this.table4.Add(this.label3);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table4[this.label3]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox9.Add(this.table4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.table4]));
			w6.Position = 1;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vseparator12 = new global::Gtk.VSeparator();
			this.vseparator12.WidthRequest = 18;
			this.vseparator12.Name = "vseparator12";
			this.hbox9.Add(this.vseparator12);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vseparator12]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox6.Add(this.hbox9);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox9]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox1.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator6]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.HeightRequest = 172;
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.WidthRequest = 135;
			this.label15.HeightRequest = 32;
			this.label15.Name = "label15";
			this.label15.Xalign = 0F;
			this.label15.Yalign = 0.1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Fechas:");
			this.hbox2.Add(this.label15);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label15]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.cldFechaInicio = new global::Gtk.Calendar();
			this.cldFechaInicio.WidthRequest = 220;
			this.cldFechaInicio.CanFocus = true;
			this.cldFechaInicio.Name = "cldFechaInicio";
			this.cldFechaInicio.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.hbox2.Add(this.cldFechaInicio);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.cldFechaInicio]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.WidthRequest = 32;
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("-");
			this.hbox2.Add(this.label8);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label8]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.cldFechaFin = new global::Gtk.Calendar();
			this.cldFechaFin.WidthRequest = 220;
			this.cldFechaFin.CanFocus = true;
			this.cldFechaFin.Name = "cldFechaFin";
			this.cldFechaFin.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.hbox2.Add(this.cldFechaFin);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.cldFechaFin]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator11 = new global::Gtk.VSeparator();
			this.vseparator11.WidthRequest = 18;
			this.vseparator11.Name = "vseparator11";
			this.hbox1.Add(this.vseparator11);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator11]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox6.Add(this.hbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox1]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator9 = new global::Gtk.VSeparator();
			this.vseparator9.WidthRequest = 18;
			this.vseparator9.Name = "vseparator9";
			this.hbox4.Add(this.vseparator9);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator9]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelSubTitulo = new global::Gtk.Label();
			this.labelSubTitulo.WidthRequest = 128;
			this.labelSubTitulo.Name = "labelSubTitulo";
			this.labelSubTitulo.Xalign = 0F;
			this.labelSubTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Descripción:");
			this.hbox4.Add(this.labelSubTitulo);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelSubTitulo]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator7 = new global::Gtk.VSeparator();
			this.vseparator7.WidthRequest = 18;
			this.vseparator7.Name = "vseparator7";
			this.hbox4.Add(this.vseparator7);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator7]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox6.Add(this.hbox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator10 = new global::Gtk.VSeparator();
			this.vseparator10.WidthRequest = 18;
			this.vseparator10.Name = "vseparator10";
			this.hbox5.Add(this.vseparator10);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator10]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.HeightRequest = 75;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textvDescripcion = new global::Gtk.TextView();
			this.textvDescripcion.HeightRequest = 50;
			this.textvDescripcion.CanFocus = true;
			this.textvDescripcion.Name = "textvDescripcion";
			this.textvDescripcion.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add(this.textvDescripcion);
			this.hbox5.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.GtkScrolledWindow]));
			w23.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator8 = new global::Gtk.VSeparator();
			this.vseparator8.WidthRequest = 18;
			this.vseparator8.Name = "vseparator8";
			this.hbox5.Add(this.vseparator8);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator8]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox6.Add(this.hbox5);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox5]));
			w25.Position = 4;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdmin = new global::Gtk.Button();
			this.buttonAdmin.WidthRequest = 90;
			this.buttonAdmin.HeightRequest = 30;
			this.buttonAdmin.CanFocus = true;
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.UseUnderline = true;
			this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbuttonbox6.Add(this.buttonAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w26 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox6.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbuttonbox6]));
			w28.Position = 5;
			w28.Expand = false;
			w28.Fill = false;
			this.Add(this.vbox6);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 675;
			this.DefaultHeight = 413;
			this.Show();
			this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
