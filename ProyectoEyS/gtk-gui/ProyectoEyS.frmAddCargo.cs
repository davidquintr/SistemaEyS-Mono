
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmAddCargo
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label labelTitulo;

		private global::Gtk.HBox hbox11;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table3;

		private global::Gtk.ComboBoxEntry cbxEDep;

		private global::Gtk.Entry entryID;

		private global::Gtk.Entry entryNombre;

		private global::Gtk.Label label11;

		private global::Gtk.Label label15;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.ScrolledWindow scroller;

		private global::Gtk.TextView textvDesc;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonEliminar;

		private global::Gtk.Button buttonHorario;

		private global::Gtk.Button buttonAdmin;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmAddCargo
			this.WidthRequest = 455;
			this.Name = "ProyectoEyS.frmAddCargo";
			this.Title = global::Mono.Unix.Catalog.GetString("frmAddCargo");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmAddCargo.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelTitulo = new global::Gtk.Label();
			this.labelTitulo.HeightRequest = 35;
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Xalign = 0.03F;
			this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Agregar cargo");
			this.vbox2.Add(this.labelTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelTitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.Name = "vseparator3";
			this.hbox11.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.cbxEDep = global::Gtk.ComboBoxEntry.NewText();
			this.cbxEDep.WidthRequest = 226;
			this.cbxEDep.HeightRequest = 30;
			this.cbxEDep.Name = "cbxEDep";
			this.table3.Add(this.cbxEDep);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.cbxEDep]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryID = new global::Gtk.Entry();
			this.entryID.HeightRequest = 30;
			this.entryID.CanFocus = true;
			this.entryID.Name = "entryID";
			this.entryID.IsEditable = false;
			this.entryID.InvisibleChar = '•';
			this.table3.Add(this.entryID);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.entryID]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryNombre = new global::Gtk.Entry();
			this.entryNombre.HeightRequest = 30;
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '•';
			this.table3.Add(this.entryNombre);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.entryNombre]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.WidthRequest = 175;
			this.label11.HeightRequest = 30;
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Departamento:");
			this.table3.Add(this.label11);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label11]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label();
			this.label15.WidthRequest = 175;
			this.label15.HeightRequest = 28;
			this.label15.Name = "label15";
			this.label15.Xalign = 0F;
			this.label15.Yalign = 0.1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Descripción:");
			this.table3.Add(this.label15);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3[this.label15]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 175;
			this.label4.HeightRequest = 30;
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table3.Add(this.label4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 175;
			this.label5.HeightRequest = 30;
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.scroller = new global::Gtk.ScrolledWindow();
			this.scroller.Name = "scroller";
			this.scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scroller.Gtk.Container+ContainerChild
			this.textvDesc = new global::Gtk.TextView();
			this.textvDesc.HeightRequest = 70;
			this.textvDesc.CanFocus = true;
			this.textvDesc.Name = "textvDesc";
			this.textvDesc.WrapMode = ((global::Gtk.WrapMode)(3));
			this.scroller.Add(this.textvDesc);
			this.table3.Add(this.scroller);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.scroller]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox11.Add(this.table3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.table3]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox11.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vseparator2]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox2.Add(this.hbox11);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox11]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonEliminar = new global::Gtk.Button();
			this.buttonEliminar.CanFocus = true;
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.UseUnderline = true;
			this.buttonEliminar.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.hbuttonbox6.Add(this.buttonEliminar);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonEliminar]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonHorario = new global::Gtk.Button();
			this.buttonHorario.CanFocus = true;
			this.buttonHorario.Name = "buttonHorario";
			this.buttonHorario.UseUnderline = true;
			this.buttonHorario.Label = global::Mono.Unix.Catalog.GetString("Horarios");
			this.hbuttonbox6.Add(this.buttonHorario);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonHorario]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdmin = new global::Gtk.Button();
			this.buttonAdmin.WidthRequest = 90;
			this.buttonAdmin.HeightRequest = 30;
			this.buttonAdmin.CanFocus = true;
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.UseUnderline = true;
			this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbuttonbox6.Add(this.buttonAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox2.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbuttonbox6]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 455;
			this.DefaultHeight = 290;
			this.Show();
			this.buttonEliminar.Clicked += new global::System.EventHandler(this.OnButtonEliminarClicked);
			this.buttonHorario.Clicked += new global::System.EventHandler(this.OnButtonHorarioClicked);
			this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonAdminClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
