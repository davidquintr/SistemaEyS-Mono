
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmListarRoles
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label lbListaDep;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView twPermisos;

		private global::Gtk.Label lbID;

		private global::Gtk.Label lbIDRol;

		private global::Gtk.Label lbNombre;

		private global::Gtk.Label lbNombreRol;

		private global::Gtk.Label lbPermisos;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.VBox scrolled;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label label5;

		private global::Gtk.Entry txbBuscar;

		private global::Gtk.ScrolledWindow GTKscrolled;

		private global::Gtk.TreeView trvwRoles;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.HBox hbox7;

		private global::Gtk.HBox hbox6;

		private global::Gtk.HBox hbox8;

		private global::Gtk.ComboBox cbxEListarRol;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Button btnAntRol;

		private global::Gtk.Label lbCountRol;

		private global::Gtk.Button btnSigRol;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonFiltrar;

		private global::Gtk.Button btnAdmin;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmListarRoles
			this.Name = "ProyectoEyS.frmListarRoles";
			this.Title = global::Mono.Unix.Catalog.GetString("frmListarRoles");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmListarRoles.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lbListaDep = new global::Gtk.Label();
			this.lbListaDep.HeightRequest = 35;
			this.lbListaDep.Name = "lbListaDep";
			this.lbListaDep.Xalign = 0.03F;
			this.lbListaDep.LabelProp = global::Mono.Unix.Catalog.GetString("Listar roles");
			this.vbox1.Add(this.lbListaDep);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lbListaDep]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.Name = "vseparator3";
			this.hbox1.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.twPermisos = new global::Gtk.TextView();
			this.twPermisos.Sensitive = false;
			this.twPermisos.CanFocus = true;
			this.twPermisos.Name = "twPermisos";
			this.GtkScrolledWindow.Add(this.twPermisos);
			this.table1.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbID = new global::Gtk.Label();
			this.lbID.WidthRequest = 260;
			this.lbID.Name = "lbID";
			this.lbID.Xalign = 0F;
			this.lbID.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbID);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.lbID]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbIDRol = new global::Gtk.Label();
			this.lbIDRol.WidthRequest = 175;
			this.lbIDRol.HeightRequest = 20;
			this.lbIDRol.Name = "lbIDRol";
			this.lbIDRol.Xalign = 0F;
			this.lbIDRol.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table1.Add(this.lbIDRol);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.lbIDRol]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombre = new global::Gtk.Label();
			this.lbNombre.WidthRequest = 250;
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Xalign = 0F;
			this.lbNombre.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbNombre);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombre]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombreRol = new global::Gtk.Label();
			this.lbNombreRol.WidthRequest = 175;
			this.lbNombreRol.HeightRequest = 20;
			this.lbNombreRol.Name = "lbNombreRol";
			this.lbNombreRol.Xalign = 0F;
			this.lbNombreRol.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table1.Add(this.lbNombreRol);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombreRol]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbPermisos = new global::Gtk.Label();
			this.lbPermisos.WidthRequest = 175;
			this.lbPermisos.HeightRequest = 20;
			this.lbPermisos.Name = "lbPermisos";
			this.lbPermisos.Xalign = 0F;
			this.lbPermisos.LabelProp = global::Mono.Unix.Catalog.GetString("Permisos:");
			this.table1.Add(this.lbPermisos);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lbPermisos]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.HeightRequest = 19;
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolled = new global::Gtk.VBox();
			this.scrolled.Name = "scrolled";
			this.scrolled.Spacing = 6;
			// Container child scrolled.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar:");
			this.hbox10.Add(this.label5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.label5]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.txbBuscar = new global::Gtk.Entry();
			this.txbBuscar.CanFocus = true;
			this.txbBuscar.Name = "txbBuscar";
			this.txbBuscar.IsEditable = true;
			this.txbBuscar.InvisibleChar = '•';
			this.hbox10.Add(this.txbBuscar);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.txbBuscar]));
			w15.Position = 1;
			this.scrolled.Add(this.hbox10);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.hbox10]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child scrolled.Gtk.Box+BoxChild
			this.GTKscrolled = new global::Gtk.ScrolledWindow();
			this.GTKscrolled.Name = "GTKscrolled";
			this.GTKscrolled.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GTKscrolled.Gtk.Container+ContainerChild
			this.trvwRoles = new global::Gtk.TreeView();
			this.trvwRoles.HeightRequest = 150;
			this.trvwRoles.CanFocus = true;
			this.trvwRoles.Name = "trvwRoles";
			this.GTKscrolled.Add(this.trvwRoles);
			this.scrolled.Add(this.GTKscrolled);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.GTKscrolled]));
			w18.Position = 1;
			this.vbox1.Add(this.scrolled);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolled]));
			w19.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.WidthRequest = 18;
			this.vseparator4.Name = "vseparator4";
			this.hbox5.Add(this.vseparator4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator4]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.cbxEListarRol = global::Gtk.ComboBox.NewText();
			this.cbxEListarRol.WidthRequest = 210;
			this.cbxEListarRol.Name = "cbxEListarRol";
			this.hbox8.Add(this.cbxEListarRol);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.cbxEListarRol]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox8.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator6]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox6.Add(this.hbox8);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox8]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btnAntRol = new global::Gtk.Button();
			this.btnAntRol.WidthRequest = 48;
			this.btnAntRol.CanFocus = true;
			this.btnAntRol.Name = "btnAntRol";
			this.btnAntRol.UseUnderline = true;
			this.btnAntRol.Label = global::Mono.Unix.Catalog.GetString("<");
			this.hbox9.Add(this.btnAntRol);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btnAntRol]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.lbCountRol = new global::Gtk.Label();
			this.lbCountRol.WidthRequest = 98;
			this.lbCountRol.Name = "lbCountRol";
			this.lbCountRol.LabelProp = global::Mono.Unix.Catalog.GetString("999/999");
			this.hbox9.Add(this.lbCountRol);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lbCountRol]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btnSigRol = new global::Gtk.Button();
			this.btnSigRol.WidthRequest = 48;
			this.btnSigRol.CanFocus = true;
			this.btnSigRol.Name = "btnSigRol";
			this.btnSigRol.UseUnderline = true;
			this.btnSigRol.Label = global::Mono.Unix.Catalog.GetString(">");
			this.hbox9.Add(this.btnSigRol);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btnSigRol]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.hbox6.Add(this.hbox9);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox9]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.hbox7.Add(this.hbox6);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox6]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox7]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator();
			this.vseparator5.WidthRequest = 18;
			this.vseparator5.Name = "vseparator5";
			this.hbox4.Add(this.vseparator5);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator5]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.hbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w33.Position = 4;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonFiltrar = new global::Gtk.Button();
			this.buttonFiltrar.CanFocus = true;
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.UseUnderline = true;
			this.buttonFiltrar.Label = global::Mono.Unix.Catalog.GetString("Filtrar");
			this.hbuttonbox6.Add(this.buttonFiltrar);
			global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonFiltrar]));
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.btnAdmin = new global::Gtk.Button();
			this.btnAdmin.WidthRequest = 90;
			this.btnAdmin.HeightRequest = 30;
			this.btnAdmin.CanFocus = true;
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.UseUnderline = true;
			this.btnAdmin.Label = global::Mono.Unix.Catalog.GetString("Administrar");
			this.hbuttonbox6.Add(this.btnAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.btnAdmin]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w36 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w37.Position = 5;
			w37.Expand = false;
			w37.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 494;
			this.DefaultHeight = 488;
			this.Show();
			this.txbBuscar.Changed += new global::System.EventHandler(this.OnTxbBuscarChanged);
			this.trvwRoles.CursorChanged += new global::System.EventHandler(this.OnTrvwRolesCursorChanged);
			this.cbxEListarRol.Changed += new global::System.EventHandler(this.OnCbxEListarRolChanged);
			this.btnAntRol.Clicked += new global::System.EventHandler(this.OnBtnAntRolClicked);
			this.btnSigRol.Clicked += new global::System.EventHandler(this.OnBtnSigRolClicked);
			this.buttonFiltrar.Clicked += new global::System.EventHandler(this.OnButtonFiltrarClicked);
			this.btnAdmin.Clicked += new global::System.EventHandler(this.OnBtnAdminClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
