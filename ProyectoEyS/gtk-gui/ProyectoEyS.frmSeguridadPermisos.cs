
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmSeguridadPermisos
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelMainOpc;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox2;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.RadioButton rbPers;

		private global::Gtk.RadioButton rbControl;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.Table table1;

		private global::Gtk.CheckButton ckbAdmCrg;

		private global::Gtk.CheckButton ckbAdmDep;

		private global::Gtk.CheckButton ckbAdmEmp;

		private global::Gtk.CheckButton ckbAdmRol;

		private global::Gtk.CheckButton ckbAdmUsr;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.Label GtkLabel8;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.HBox hbox6;

		private global::Gtk.VSeparator vseparator7;

		private global::Gtk.Table table2;

		private global::Gtk.CheckButton ckbLisCrg;

		private global::Gtk.CheckButton ckbLisDep;

		private global::Gtk.CheckButton ckbLisEmp;

		private global::Gtk.CheckButton ckbLisRol;

		private global::Gtk.CheckButton ckbLisUsr;

		private global::Gtk.VSeparator vseparator8;

		private global::Gtk.Label GtkLabel14;

		private global::Gtk.Frame frame4;

		private global::Gtk.Alignment GtkAlignment3;

		private global::Gtk.HBox hbox7;

		private global::Gtk.VSeparator vseparator9;

		private global::Gtk.Table table3;

		private global::Gtk.CheckButton ckbAgrCrg;

		private global::Gtk.CheckButton ckbAgrDep;

		private global::Gtk.CheckButton ckbAgrEmp;

		private global::Gtk.CheckButton ckbAgrRol;

		private global::Gtk.CheckButton ckbAgrUsr;

		private global::Gtk.VSeparator vseparator10;

		private global::Gtk.Label GtkLabel20;

		private global::Gtk.Frame frame5;

		private global::Gtk.Alignment GtkAlignment4;

		private global::Gtk.HBox hbox8;

		private global::Gtk.VSeparator vseparator11;

		private global::Gtk.Table table4;

		private global::Gtk.CheckButton ckbConEve;

		private global::Gtk.CheckButton ckbConHor;

		private global::Gtk.CheckButton ckbParGen;

		private global::Gtk.CheckButton ckbResEnt;

		private global::Gtk.VSeparator vseparator12;

		private global::Gtk.Label GtkLabel24;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonGuardar;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmSeguridadPermisos
			this.Name = "ProyectoEyS.frmSeguridadPermisos";
			this.Title = global::Mono.Unix.Catalog.GetString("frmSeguridadPermisos");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmSeguridadPermisos.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelMainOpc = new global::Gtk.Label();
			this.labelMainOpc.HeightRequest = 35;
			this.labelMainOpc.Name = "labelMainOpc";
			this.labelMainOpc.Xalign = 0.03F;
			this.labelMainOpc.LabelProp = global::Mono.Unix.Catalog.GetString("Seguridad: Opciones de rol [NOMBRE ROL]");
			this.labelMainOpc.UseMarkup = true;
			this.vbox1.Add(this.labelMainOpc);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelMainOpc]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.HeightRequest = 50;
			this.vseparator3.Name = "vseparator3";
			this.hbox2.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.rbPers = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Personalizado"));
			this.rbPers.CanFocus = true;
			this.rbPers.Name = "rbPers";
			this.rbPers.Active = true;
			this.rbPers.DrawIndicator = true;
			this.rbPers.UseUnderline = true;
			this.rbPers.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox2.Add(this.rbPers);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.rbPers]));
			w3.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.rbControl = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Control total"));
			this.rbControl.CanFocus = true;
			this.rbControl.Name = "rbControl";
			this.rbControl.DrawIndicator = true;
			this.rbControl.UseUnderline = true;
			this.rbControl.Group = this.rbPers.Group;
			this.hbox2.Add(this.rbControl);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.rbControl]));
			w4.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.WidthRequest = 18;
			this.vseparator4.Name = "vseparator4";
			this.hbox2.Add(this.vseparator4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator4]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.GtkAlignment.Add(this.hbox2);
			this.frame1.Add(this.GtkAlignment);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Permisos</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox1.Add(this.frame1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.HeightRequest = 27;
			this.vseparator6.Name = "vseparator6";
			this.hbox5.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator6]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(5)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.ckbAdmCrg = new global::Gtk.CheckButton();
			this.ckbAdmCrg.CanFocus = true;
			this.ckbAdmCrg.Name = "ckbAdmCrg";
			this.ckbAdmCrg.Label = global::Mono.Unix.Catalog.GetString("Cargo");
			this.ckbAdmCrg.DrawIndicator = true;
			this.ckbAdmCrg.UseUnderline = true;
			this.table1.Add(this.ckbAdmCrg);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.ckbAdmCrg]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ckbAdmDep = new global::Gtk.CheckButton();
			this.ckbAdmDep.CanFocus = true;
			this.ckbAdmDep.Name = "ckbAdmDep";
			this.ckbAdmDep.Label = global::Mono.Unix.Catalog.GetString("Departamento");
			this.ckbAdmDep.DrawIndicator = true;
			this.ckbAdmDep.UseUnderline = true;
			this.table1.Add(this.ckbAdmDep);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.ckbAdmDep]));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ckbAdmEmp = new global::Gtk.CheckButton();
			this.ckbAdmEmp.CanFocus = true;
			this.ckbAdmEmp.Name = "ckbAdmEmp";
			this.ckbAdmEmp.Label = global::Mono.Unix.Catalog.GetString("Empleado");
			this.ckbAdmEmp.DrawIndicator = true;
			this.ckbAdmEmp.UseUnderline = true;
			this.table1.Add(this.ckbAdmEmp);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.ckbAdmEmp]));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ckbAdmRol = new global::Gtk.CheckButton();
			this.ckbAdmRol.CanFocus = true;
			this.ckbAdmRol.Name = "ckbAdmRol";
			this.ckbAdmRol.Label = global::Mono.Unix.Catalog.GetString("Rol");
			this.ckbAdmRol.DrawIndicator = true;
			this.ckbAdmRol.UseUnderline = true;
			this.table1.Add(this.ckbAdmRol);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.ckbAdmRol]));
			w14.LeftAttach = ((uint)(4));
			w14.RightAttach = ((uint)(5));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ckbAdmUsr = new global::Gtk.CheckButton();
			this.ckbAdmUsr.CanFocus = true;
			this.ckbAdmUsr.Name = "ckbAdmUsr";
			this.ckbAdmUsr.Label = global::Mono.Unix.Catalog.GetString("Usuario");
			this.ckbAdmUsr.DrawIndicator = true;
			this.ckbAdmUsr.UseUnderline = true;
			this.table1.Add(this.ckbAdmUsr);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.ckbAdmUsr]));
			w15.LeftAttach = ((uint)(3));
			w15.RightAttach = ((uint)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox5.Add(this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.table1]));
			w16.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator();
			this.vseparator5.WidthRequest = 18;
			this.vseparator5.Name = "vseparator5";
			this.hbox5.Add(this.vseparator5);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator5]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.GtkAlignment1.Add(this.hbox5);
			this.frame2.Add(this.GtkAlignment1);
			this.GtkLabel8 = new global::Gtk.Label();
			this.GtkLabel8.HeightRequest = 32;
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Administrar entidades</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel8;
			this.vbox1.Add(this.frame2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame2]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vseparator7 = new global::Gtk.VSeparator();
			this.vseparator7.WidthRequest = 18;
			this.vseparator7.HeightRequest = 27;
			this.vseparator7.Name = "vseparator7";
			this.hbox6.Add(this.vseparator7);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.vseparator7]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(1)), ((uint)(5)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.ckbLisCrg = new global::Gtk.CheckButton();
			this.ckbLisCrg.CanFocus = true;
			this.ckbLisCrg.Name = "ckbLisCrg";
			this.ckbLisCrg.Label = global::Mono.Unix.Catalog.GetString("Cargo");
			this.ckbLisCrg.DrawIndicator = true;
			this.ckbLisCrg.UseUnderline = true;
			this.table2.Add(this.ckbLisCrg);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.ckbLisCrg]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ckbLisDep = new global::Gtk.CheckButton();
			this.ckbLisDep.CanFocus = true;
			this.ckbLisDep.Name = "ckbLisDep";
			this.ckbLisDep.Label = global::Mono.Unix.Catalog.GetString("Departamento");
			this.ckbLisDep.DrawIndicator = true;
			this.ckbLisDep.UseUnderline = true;
			this.table2.Add(this.ckbLisDep);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2[this.ckbLisDep]));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ckbLisEmp = new global::Gtk.CheckButton();
			this.ckbLisEmp.CanFocus = true;
			this.ckbLisEmp.Name = "ckbLisEmp";
			this.ckbLisEmp.Label = global::Mono.Unix.Catalog.GetString("Empleado");
			this.ckbLisEmp.DrawIndicator = true;
			this.ckbLisEmp.UseUnderline = true;
			this.table2.Add(this.ckbLisEmp);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2[this.ckbLisEmp]));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ckbLisRol = new global::Gtk.CheckButton();
			this.ckbLisRol.CanFocus = true;
			this.ckbLisRol.Name = "ckbLisRol";
			this.ckbLisRol.Label = global::Mono.Unix.Catalog.GetString("Rol");
			this.ckbLisRol.DrawIndicator = true;
			this.ckbLisRol.UseUnderline = true;
			this.table2.Add(this.ckbLisRol);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2[this.ckbLisRol]));
			w25.LeftAttach = ((uint)(4));
			w25.RightAttach = ((uint)(5));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ckbLisUsr = new global::Gtk.CheckButton();
			this.ckbLisUsr.CanFocus = true;
			this.ckbLisUsr.Name = "ckbLisUsr";
			this.ckbLisUsr.Label = global::Mono.Unix.Catalog.GetString("Usuario");
			this.ckbLisUsr.DrawIndicator = true;
			this.ckbLisUsr.UseUnderline = true;
			this.table2.Add(this.ckbLisUsr);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2[this.ckbLisUsr]));
			w26.LeftAttach = ((uint)(3));
			w26.RightAttach = ((uint)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox6.Add(this.table2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.table2]));
			w27.Position = 1;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vseparator8 = new global::Gtk.VSeparator();
			this.vseparator8.WidthRequest = 18;
			this.vseparator8.Name = "vseparator8";
			this.hbox6.Add(this.vseparator8);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.vseparator8]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.GtkAlignment2.Add(this.hbox6);
			this.frame3.Add(this.GtkAlignment2);
			this.GtkLabel14 = new global::Gtk.Label();
			this.GtkLabel14.HeightRequest = 32;
			this.GtkLabel14.Name = "GtkLabel14";
			this.GtkLabel14.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Listar entidades</b>");
			this.GtkLabel14.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel14;
			this.vbox1.Add(this.frame3);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame3]));
			w31.Position = 4;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator9 = new global::Gtk.VSeparator();
			this.vseparator9.WidthRequest = 18;
			this.vseparator9.HeightRequest = 27;
			this.vseparator9.Name = "vseparator9";
			this.hbox7.Add(this.vseparator9);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator9]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(5)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.ckbAgrCrg = new global::Gtk.CheckButton();
			this.ckbAgrCrg.CanFocus = true;
			this.ckbAgrCrg.Name = "ckbAgrCrg";
			this.ckbAgrCrg.Label = global::Mono.Unix.Catalog.GetString("Cargo");
			this.ckbAgrCrg.DrawIndicator = true;
			this.ckbAgrCrg.UseUnderline = true;
			this.table3.Add(this.ckbAgrCrg);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3[this.ckbAgrCrg]));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ckbAgrDep = new global::Gtk.CheckButton();
			this.ckbAgrDep.CanFocus = true;
			this.ckbAgrDep.Name = "ckbAgrDep";
			this.ckbAgrDep.Label = global::Mono.Unix.Catalog.GetString("Departamento");
			this.ckbAgrDep.DrawIndicator = true;
			this.ckbAgrDep.UseUnderline = true;
			this.table3.Add(this.ckbAgrDep);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table3[this.ckbAgrDep]));
			w34.LeftAttach = ((uint)(2));
			w34.RightAttach = ((uint)(3));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ckbAgrEmp = new global::Gtk.CheckButton();
			this.ckbAgrEmp.CanFocus = true;
			this.ckbAgrEmp.Name = "ckbAgrEmp";
			this.ckbAgrEmp.Label = global::Mono.Unix.Catalog.GetString("Empleado");
			this.ckbAgrEmp.DrawIndicator = true;
			this.ckbAgrEmp.UseUnderline = true;
			this.table3.Add(this.ckbAgrEmp);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table3[this.ckbAgrEmp]));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ckbAgrRol = new global::Gtk.CheckButton();
			this.ckbAgrRol.CanFocus = true;
			this.ckbAgrRol.Name = "ckbAgrRol";
			this.ckbAgrRol.Label = global::Mono.Unix.Catalog.GetString("Rol");
			this.ckbAgrRol.DrawIndicator = true;
			this.ckbAgrRol.UseUnderline = true;
			this.table3.Add(this.ckbAgrRol);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table3[this.ckbAgrRol]));
			w36.LeftAttach = ((uint)(4));
			w36.RightAttach = ((uint)(5));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ckbAgrUsr = new global::Gtk.CheckButton();
			this.ckbAgrUsr.CanFocus = true;
			this.ckbAgrUsr.Name = "ckbAgrUsr";
			this.ckbAgrUsr.Label = global::Mono.Unix.Catalog.GetString("Usuario");
			this.ckbAgrUsr.DrawIndicator = true;
			this.ckbAgrUsr.UseUnderline = true;
			this.table3.Add(this.ckbAgrUsr);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table3[this.ckbAgrUsr]));
			w37.LeftAttach = ((uint)(3));
			w37.RightAttach = ((uint)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox7.Add(this.table3);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.table3]));
			w38.Position = 1;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator10 = new global::Gtk.VSeparator();
			this.vseparator10.WidthRequest = 18;
			this.vseparator10.Name = "vseparator10";
			this.hbox7.Add(this.vseparator10);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator10]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			this.GtkAlignment3.Add(this.hbox7);
			this.frame4.Add(this.GtkAlignment3);
			this.GtkLabel20 = new global::Gtk.Label();
			this.GtkLabel20.HeightRequest = 32;
			this.GtkLabel20.Name = "GtkLabel20";
			this.GtkLabel20.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Agregar entidades</b>");
			this.GtkLabel20.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel20;
			this.vbox1.Add(this.frame4);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame4]));
			w42.Position = 5;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator11 = new global::Gtk.VSeparator();
			this.vseparator11.WidthRequest = 18;
			this.vseparator11.HeightRequest = 64;
			this.vseparator11.Name = "vseparator11";
			this.hbox8.Add(this.vseparator11);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator11]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.ckbConEve = new global::Gtk.CheckButton();
			this.ckbConEve.CanFocus = true;
			this.ckbConEve.Name = "ckbConEve";
			this.ckbConEve.Label = global::Mono.Unix.Catalog.GetString("Configurar eventos");
			this.ckbConEve.DrawIndicator = true;
			this.ckbConEve.UseUnderline = true;
			this.table4.Add(this.ckbConEve);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table4[this.ckbConEve]));
			w44.LeftAttach = ((uint)(1));
			w44.RightAttach = ((uint)(2));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.ckbConHor = new global::Gtk.CheckButton();
			this.ckbConHor.CanFocus = true;
			this.ckbConHor.Name = "ckbConHor";
			this.ckbConHor.Label = global::Mono.Unix.Catalog.GetString("Configurar horarios");
			this.ckbConHor.DrawIndicator = true;
			this.ckbConHor.UseUnderline = true;
			this.table4.Add(this.ckbConHor);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table4[this.ckbConHor]));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.ckbParGen = new global::Gtk.CheckButton();
			this.ckbParGen.CanFocus = true;
			this.ckbParGen.Name = "ckbParGen";
			this.ckbParGen.Label = global::Mono.Unix.Catalog.GetString("Parámetros generales");
			this.ckbParGen.DrawIndicator = true;
			this.ckbParGen.UseUnderline = true;
			this.table4.Add(this.ckbParGen);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table4[this.ckbParGen]));
			w46.TopAttach = ((uint)(1));
			w46.BottomAttach = ((uint)(2));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.ckbResEnt = new global::Gtk.CheckButton();
			this.ckbResEnt.CanFocus = true;
			this.ckbResEnt.Name = "ckbResEnt";
			this.ckbResEnt.Label = global::Mono.Unix.Catalog.GetString("Restauración de entidades");
			this.ckbResEnt.DrawIndicator = true;
			this.ckbResEnt.UseUnderline = true;
			this.table4.Add(this.ckbResEnt);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table4[this.ckbResEnt]));
			w47.TopAttach = ((uint)(1));
			w47.BottomAttach = ((uint)(2));
			w47.LeftAttach = ((uint)(1));
			w47.RightAttach = ((uint)(2));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox8.Add(this.table4);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.table4]));
			w48.Position = 1;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator12 = new global::Gtk.VSeparator();
			this.vseparator12.WidthRequest = 18;
			this.vseparator12.Name = "vseparator12";
			this.hbox8.Add(this.vseparator12);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator12]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.GtkAlignment4.Add(this.hbox8);
			this.frame5.Add(this.GtkAlignment4);
			this.GtkLabel24 = new global::Gtk.Label();
			this.GtkLabel24.HeightRequest = 32;
			this.GtkLabel24.Name = "GtkLabel24";
			this.GtkLabel24.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Funciones administrativas</b>");
			this.GtkLabel24.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel24;
			this.vbox1.Add(this.frame5);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame5]));
			w52.Position = 6;
			w52.Expand = false;
			w52.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonGuardar = new global::Gtk.Button();
			this.buttonGuardar.WidthRequest = 90;
			this.buttonGuardar.HeightRequest = 30;
			this.buttonGuardar.CanFocus = true;
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.UseUnderline = true;
			this.buttonGuardar.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbuttonbox6.Add(this.buttonGuardar);
			global::Gtk.ButtonBox.ButtonBoxChild w53 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonGuardar]));
			w53.Expand = false;
			w53.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w54 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w54.Position = 1;
			w54.Expand = false;
			w54.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w55.Position = 7;
			w55.Expand = false;
			w55.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 596;
			this.DefaultHeight = 473;
			this.Show();
			this.rbPers.Clicked += new global::System.EventHandler(this.OnRbPersClicked);
			this.rbControl.Clicked += new global::System.EventHandler(this.OnRbControlClicked);
			this.buttonGuardar.Clicked += new global::System.EventHandler(this.OnButtonGuardarClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
