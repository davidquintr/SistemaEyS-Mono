
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox27;

	private global::Gtk.HBox hbox14;

	private global::Gtk.Label label25;

	private global::Gtk.HBox hbox10;

	private global::Gtk.VSeparator vseparator2;

	private global::Gtk.Image image1;

	private global::Gtk.HBox hbox15;

	private global::Gtk.VBox vbox34;

	private global::Gtk.Label label2;

	private global::Gtk.Fixed fixed21;

	private global::Gtk.Label label3;

	private global::Gtk.VBox vbox35;

	private global::Gtk.Entry entryID;

	private global::Gtk.Fixed fixed20;

	private global::Gtk.Entry entryPin;

	private global::Gtk.VSeparator vseparator1;

	private global::Gtk.HButtonBox hbuttonbox6;

	private global::Gtk.Button buttonAdmin;

	private global::Gtk.Button button41;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 480;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Inicio de Sesión");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox27 = new global::Gtk.VBox();
		this.vbox27.Name = "vbox27";
		this.vbox27.Spacing = 6;
		// Container child vbox27.Gtk.Box+BoxChild
		this.hbox14 = new global::Gtk.HBox();
		this.hbox14.HeightRequest = 50;
		this.hbox14.Name = "hbox14";
		this.hbox14.Spacing = 6;
		// Container child hbox14.Gtk.Box+BoxChild
		this.label25 = new global::Gtk.Label();
		this.label25.WidthRequest = 441;
		this.label25.Name = "label25";
		this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("Inicio de sesión");
		this.hbox14.Add(this.label25);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.label25]));
		w1.Position = 1;
		w1.Expand = false;
		w1.Fill = false;
		this.vbox27.Add(this.hbox14);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.hbox14]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox27.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.HeightRequest = 129;
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.vseparator2 = new global::Gtk.VSeparator();
		this.vseparator2.WidthRequest = 18;
		this.vseparator2.Name = "vseparator2";
		this.hbox10.Add(this.vseparator2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.vseparator2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.image1 = new global::Gtk.Image();
		this.image1.WidthRequest = 102;
		this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("ProyectoEyS.Texturas.iconPad.png");
		this.hbox10.Add(this.image1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.image1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hbox15 = new global::Gtk.HBox();
		this.hbox15.Name = "hbox15";
		this.hbox15.Spacing = 6;
		// Container child hbox15.Gtk.Box+BoxChild
		this.vbox34 = new global::Gtk.VBox();
		this.vbox34.Name = "vbox34";
		this.vbox34.Spacing = 6;
		// Container child vbox34.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.HeightRequest = 32;
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario: ");
		this.vbox34.Add(this.label2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.label2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox34.Gtk.Box+BoxChild
		this.fixed21 = new global::Gtk.Fixed();
		this.fixed21.HeightRequest = 12;
		this.fixed21.Name = "fixed21";
		this.fixed21.HasWindow = false;
		this.vbox34.Add(this.fixed21);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.fixed21]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox34.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.HeightRequest = 32;
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Contraseña");
		this.vbox34.Add(this.label3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.label3]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox15.Add(this.vbox34);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.vbox34]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox15.Gtk.Box+BoxChild
		this.vbox35 = new global::Gtk.VBox();
		this.vbox35.Name = "vbox35";
		this.vbox35.Spacing = 6;
		// Container child vbox35.Gtk.Box+BoxChild
		this.entryID = new global::Gtk.Entry();
		this.entryID.HeightRequest = 32;
		this.entryID.CanFocus = true;
		this.entryID.Name = "entryID";
		this.entryID.IsEditable = true;
		this.entryID.InvisibleChar = '•';
		this.vbox35.Add(this.entryID);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.entryID]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox35.Gtk.Box+BoxChild
		this.fixed20 = new global::Gtk.Fixed();
		this.fixed20.HeightRequest = 12;
		this.fixed20.Name = "fixed20";
		this.fixed20.HasWindow = false;
		this.vbox35.Add(this.fixed20);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.fixed20]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox35.Gtk.Box+BoxChild
		this.entryPin = new global::Gtk.Entry();
		this.entryPin.WidthRequest = 12;
		this.entryPin.HeightRequest = 32;
		this.entryPin.CanFocus = true;
		this.entryPin.Name = "entryPin";
		this.entryPin.IsEditable = true;
		this.entryPin.Visibility = false;
		this.entryPin.InvisibleChar = '•';
		this.vbox35.Add(this.entryPin);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.entryPin]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.hbox15.Add(this.vbox35);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.vbox35]));
		w12.Position = 1;
		this.hbox10.Add(this.hbox15);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.hbox15]));
		w13.Position = 2;
		// Container child hbox10.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator();
		this.vseparator1.WidthRequest = 18;
		this.vseparator1.Name = "vseparator1";
		this.hbox10.Add(this.vseparator1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.vseparator1]));
		w14.Position = 3;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox27.Add(this.hbox10);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.hbox10]));
		w15.Position = 1;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox27.Gtk.Box+BoxChild
		this.hbuttonbox6 = new global::Gtk.HButtonBox();
		this.hbuttonbox6.HeightRequest = 50;
		this.hbuttonbox6.Name = "hbuttonbox6";
		this.hbuttonbox6.Spacing = 4;
		this.hbuttonbox6.BorderWidth = ((uint)(10));
		this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.buttonAdmin = new global::Gtk.Button();
		this.buttonAdmin.HeightRequest = 30;
		this.buttonAdmin.CanFocus = true;
		this.buttonAdmin.Name = "buttonAdmin";
		this.buttonAdmin.UseUnderline = true;
		this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Iniciar Sesión");
		this.hbuttonbox6.Add(this.buttonAdmin);
		global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
		this.button41 = new global::Gtk.Button();
		this.button41.CanFocus = true;
		this.button41.Name = "button41";
		this.button41.UseUnderline = true;
		this.button41.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
		this.hbuttonbox6.Add(this.button41);
		global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.button41]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox27.Add(this.hbuttonbox6);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox27[this.hbuttonbox6]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		this.Add(this.vbox27);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 480;
		this.DefaultHeight = 241;
		this.Show();
		this.entryPin.Activated += new global::System.EventHandler(this.OnEntryPinActivated);
		this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonAdminClicked);
		this.button41.Clicked += new global::System.EventHandler(this.OnButton41Clicked);
	}
}
