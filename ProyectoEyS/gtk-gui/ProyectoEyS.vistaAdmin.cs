
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class vistaAdmin
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action MenAction;

		private global::Gtk.Action ReportesAction;

		private global::Gtk.Action AyudaAction;

		private global::Gtk.Action AadirEntidadAction;

		private global::Gtk.Action ListarTrabajadoresAction;

		private global::Gtk.Action ParmetrosGeneralesAction;

		private global::Gtk.Action CerrarSesinAction;

		private global::Gtk.Action VistaPersonalizadaDeReportesAction;

		private global::Gtk.Action GenerarReporteGeneralAction;

		private global::Gtk.Action InstructivoAction;

		private global::Gtk.Action ReportarUnProblemaAction;

		private global::Gtk.Action AcercaDeAction;

		private global::Gtk.Action EstablecerEventoAction;

		private global::Gtk.Action ListarEntidadesAction;

		private global::Gtk.Action ListarEntidadesAction1;

		private global::Gtk.Action ParmetrosGeneralesAction1;

		private global::Gtk.Action CerrarSesinAction1;

		private global::Gtk.Action ParametrosGeneralesAction;

		private global::Gtk.Action MenAction1;

		private global::Gtk.Action ReportesAction1;

		private global::Gtk.Action AyudaAction1;

		private global::Gtk.Action AadirEntidadAction1;

		private global::Gtk.Action ListarEntidadesAction2;

		private global::Gtk.Action ParamGenButt;

		private global::Gtk.Action VistaPersonalizadaAction;

		private global::Gtk.Action ReportePersonalizadoAction;

		private global::Gtk.Action ReporteGeneralAction;

		private global::Gtk.Action InstructivoAction1;

		private global::Gtk.Action ReportarUnProblemaAction1;

		private global::Gtk.Action AcercaDeAction1;

		private global::Gtk.Action CerrarSesinAction2;

		private global::Gtk.Action AadirAction1;

		private global::Gtk.Action ListarAction;

		private global::Gtk.Action DepartamentoAdd;

		private global::Gtk.Action CargoAdd;

		private global::Gtk.Action EmpleadoAdd;

		private global::Gtk.Action DepartamentosAction;

		private global::Gtk.Action CargosAction;

		private global::Gtk.Action EmpleadosAction;

		private global::Gtk.Action SeguridadAction;

		private global::Gtk.Action CredencialesAction;

		private global::Gtk.Action CrearUsuarioAction;

		private global::Gtk.Action AdministrarUsuarioAction;

		private global::Gtk.Action RestauracinAction;

		private global::Gtk.Action DepartamentoAction;

		private global::Gtk.Action CargoAction1;

		private global::Gtk.Action EmpleadoAction;

		private global::Gtk.Action PermisosAction;

		private global::Gtk.Action AadirAction;

		private global::Gtk.Action RolAction;

		private global::Gtk.Action UsuarioAction;

		private global::Gtk.Action AdministrarAction;

		private global::Gtk.Action RolAction1;

		private global::Gtk.Action UsuarioAction1;

		private global::Gtk.Action RestaurarAction;

		private global::Gtk.Action restaurarDept;

		private global::Gtk.Action restaurarCargo;

		private global::Gtk.Action restaurarEmp;

		private global::Gtk.Action restaurarUser;

		private global::Gtk.Action OpcionesDeRolAction;

		private global::Gtk.Action ListarAction1;

		private global::Gtk.Action RolAction2;

		private global::Gtk.Action ListarAction2;

		private global::Gtk.Action RolAction3;

		private global::Gtk.Action UsuarioAction3;

		private global::Gtk.VBox vbox7;

		private global::Gtk.MenuBar menubar3;

		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox13;

		private global::Gtk.DrawingArea drawingarea1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow6;

		private global::Gtk.Label labelHora;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.Calendar calendar3;

		private global::Gtk.ScrolledWindow GtkScrolledWindow3;

		private global::Gtk.TextView tvEvento;

		private global::Gtk.VBox vbox12;

		private global::Gtk.ScrolledWindow GtkScrolledWindow5;

		private global::Gtk.Label label18;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvwEmpleado;

		private global::Gtk.VBox vbox14;

		private global::Gtk.HBox hbox3;

		private global::Gtk.VBox vbox16;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gtk.Label labelCargo;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.Label labelEmp;

		private global::Gtk.Image image1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.vistaAdmin
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.MenAction = new global::Gtk.Action("MenAction", global::Mono.Unix.Catalog.GetString("Menú"), null, null);
			this.MenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Menú");
			w1.Add(this.MenAction, null);
			this.ReportesAction = new global::Gtk.Action("ReportesAction", global::Mono.Unix.Catalog.GetString("Reportes"), null, null);
			this.ReportesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Reportes");
			w1.Add(this.ReportesAction, null);
			this.AyudaAction = new global::Gtk.Action("AyudaAction", global::Mono.Unix.Catalog.GetString("Ayuda"), null, null);
			this.AyudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ayuda");
			w1.Add(this.AyudaAction, null);
			this.AadirEntidadAction = new global::Gtk.Action("AadirEntidadAction", global::Mono.Unix.Catalog.GetString("Añadir entidad"), null, null);
			this.AadirEntidadAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Añadir entidad");
			w1.Add(this.AadirEntidadAction, null);
			this.ListarTrabajadoresAction = new global::Gtk.Action("ListarTrabajadoresAction", global::Mono.Unix.Catalog.GetString("Listar trabajadores"), null, null);
			this.ListarTrabajadoresAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar trabajadores");
			w1.Add(this.ListarTrabajadoresAction, null);
			this.ParmetrosGeneralesAction = new global::Gtk.Action("ParmetrosGeneralesAction", global::Mono.Unix.Catalog.GetString("Parámetros generales"), null, null);
			this.ParmetrosGeneralesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Parámetros generales");
			w1.Add(this.ParmetrosGeneralesAction, null);
			this.CerrarSesinAction = new global::Gtk.Action("CerrarSesinAction", global::Mono.Unix.Catalog.GetString("Cerrar sesión"), null, null);
			this.CerrarSesinAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cerrar sesión");
			w1.Add(this.CerrarSesinAction, null);
			this.VistaPersonalizadaDeReportesAction = new global::Gtk.Action("VistaPersonalizadaDeReportesAction", global::Mono.Unix.Catalog.GetString("Vista personalizada de reportes"), null, null);
			this.VistaPersonalizadaDeReportesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Vista personalizada de reportes");
			w1.Add(this.VistaPersonalizadaDeReportesAction, null);
			this.GenerarReporteGeneralAction = new global::Gtk.Action("GenerarReporteGeneralAction", global::Mono.Unix.Catalog.GetString("Generar reporte general"), null, null);
			this.GenerarReporteGeneralAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Generar reporte general");
			w1.Add(this.GenerarReporteGeneralAction, null);
			this.InstructivoAction = new global::Gtk.Action("InstructivoAction", global::Mono.Unix.Catalog.GetString("Instructivo"), null, null);
			this.InstructivoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Instructivo");
			w1.Add(this.InstructivoAction, null);
			this.ReportarUnProblemaAction = new global::Gtk.Action("ReportarUnProblemaAction", global::Mono.Unix.Catalog.GetString("Reportar un problema"), null, null);
			this.ReportarUnProblemaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Reportar un problema");
			w1.Add(this.ReportarUnProblemaAction, null);
			this.AcercaDeAction = new global::Gtk.Action("AcercaDeAction", global::Mono.Unix.Catalog.GetString("Acerca de "), null, null);
			this.AcercaDeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Acerca de ");
			w1.Add(this.AcercaDeAction, null);
			this.EstablecerEventoAction = new global::Gtk.Action("EstablecerEventoAction", global::Mono.Unix.Catalog.GetString("Establecer Evento"), null, null);
			this.EstablecerEventoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Establecer Evento");
			w1.Add(this.EstablecerEventoAction, null);
			this.ListarEntidadesAction = new global::Gtk.Action("ListarEntidadesAction", global::Mono.Unix.Catalog.GetString("Listar entidades"), null, null);
			this.ListarEntidadesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar entidades");
			w1.Add(this.ListarEntidadesAction, null);
			this.ListarEntidadesAction1 = new global::Gtk.Action("ListarEntidadesAction1", global::Mono.Unix.Catalog.GetString("Listar entidades"), null, null);
			this.ListarEntidadesAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar entidades");
			w1.Add(this.ListarEntidadesAction1, null);
			this.ParmetrosGeneralesAction1 = new global::Gtk.Action("ParmetrosGeneralesAction1", global::Mono.Unix.Catalog.GetString("Parámetros generales"), null, null);
			this.ParmetrosGeneralesAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Parámetros generales");
			w1.Add(this.ParmetrosGeneralesAction1, null);
			this.CerrarSesinAction1 = new global::Gtk.Action("CerrarSesinAction1", global::Mono.Unix.Catalog.GetString("Cerrar sesión"), null, null);
			this.CerrarSesinAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Cerrar sesión");
			w1.Add(this.CerrarSesinAction1, null);
			this.ParametrosGeneralesAction = new global::Gtk.Action("ParametrosGeneralesAction", global::Mono.Unix.Catalog.GetString("Parametros generales"), null, null);
			this.ParametrosGeneralesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Parametros generales");
			w1.Add(this.ParametrosGeneralesAction, null);
			this.MenAction1 = new global::Gtk.Action("MenAction1", global::Mono.Unix.Catalog.GetString("Menú"), null, null);
			this.MenAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Menú");
			w1.Add(this.MenAction1, null);
			this.ReportesAction1 = new global::Gtk.Action("ReportesAction1", global::Mono.Unix.Catalog.GetString("Reportes"), null, null);
			this.ReportesAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Reportes");
			w1.Add(this.ReportesAction1, null);
			this.AyudaAction1 = new global::Gtk.Action("AyudaAction1", global::Mono.Unix.Catalog.GetString("Ayuda"), null, null);
			this.AyudaAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Ayuda");
			w1.Add(this.AyudaAction1, null);
			this.AadirEntidadAction1 = new global::Gtk.Action("AadirEntidadAction1", global::Mono.Unix.Catalog.GetString("Añadir entidad"), null, null);
			this.AadirEntidadAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Añadir entidad");
			w1.Add(this.AadirEntidadAction1, null);
			this.ListarEntidadesAction2 = new global::Gtk.Action("ListarEntidadesAction2", global::Mono.Unix.Catalog.GetString("Listar entidades"), null, null);
			this.ListarEntidadesAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar entidades");
			w1.Add(this.ListarEntidadesAction2, null);
			this.ParamGenButt = new global::Gtk.Action("ParamGenButt", global::Mono.Unix.Catalog.GetString("Parámetros generales"), null, null);
			this.ParamGenButt.ShortLabel = global::Mono.Unix.Catalog.GetString("Parámetros generales");
			w1.Add(this.ParamGenButt, null);
			this.VistaPersonalizadaAction = new global::Gtk.Action("VistaPersonalizadaAction", global::Mono.Unix.Catalog.GetString("Vista personalizada"), null, null);
			this.VistaPersonalizadaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Vista personalizada");
			w1.Add(this.VistaPersonalizadaAction, null);
			this.ReportePersonalizadoAction = new global::Gtk.Action("ReportePersonalizadoAction", global::Mono.Unix.Catalog.GetString("Reporte personalizado"), null, null);
			this.ReportePersonalizadoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Reporte personalizado");
			w1.Add(this.ReportePersonalizadoAction, null);
			this.ReporteGeneralAction = new global::Gtk.Action("ReporteGeneralAction", global::Mono.Unix.Catalog.GetString("Reporte general"), null, null);
			this.ReporteGeneralAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Reporte general");
			w1.Add(this.ReporteGeneralAction, null);
			this.InstructivoAction1 = new global::Gtk.Action("InstructivoAction1", global::Mono.Unix.Catalog.GetString("Instructivo"), null, null);
			this.InstructivoAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Instructivo");
			w1.Add(this.InstructivoAction1, null);
			this.ReportarUnProblemaAction1 = new global::Gtk.Action("ReportarUnProblemaAction1", global::Mono.Unix.Catalog.GetString("Reportar un problema"), null, null);
			this.ReportarUnProblemaAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Reportar un problema");
			w1.Add(this.ReportarUnProblemaAction1, null);
			this.AcercaDeAction1 = new global::Gtk.Action("AcercaDeAction1", global::Mono.Unix.Catalog.GetString("Acerca de"), null, null);
			this.AcercaDeAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Acerca de");
			w1.Add(this.AcercaDeAction1, null);
			this.CerrarSesinAction2 = new global::Gtk.Action("CerrarSesinAction2", global::Mono.Unix.Catalog.GetString("Cerrar Sesión"), null, null);
			this.CerrarSesinAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Cerrar Sesión");
			w1.Add(this.CerrarSesinAction2, null);
			this.AadirAction1 = new global::Gtk.Action("AadirAction1", global::Mono.Unix.Catalog.GetString("Añadir"), null, null);
			this.AadirAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Añadir entidad");
			w1.Add(this.AadirAction1, null);
			this.ListarAction = new global::Gtk.Action("ListarAction", global::Mono.Unix.Catalog.GetString("Listar"), null, null);
			this.ListarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar entidad");
			w1.Add(this.ListarAction, null);
			this.DepartamentoAdd = new global::Gtk.Action("DepartamentoAdd", global::Mono.Unix.Catalog.GetString("Departamento"), null, null);
			this.DepartamentoAdd.ShortLabel = global::Mono.Unix.Catalog.GetString("Departamento");
			w1.Add(this.DepartamentoAdd, null);
			this.CargoAdd = new global::Gtk.Action("CargoAdd", global::Mono.Unix.Catalog.GetString("Cargo"), null, null);
			this.CargoAdd.ShortLabel = global::Mono.Unix.Catalog.GetString("Cargo");
			w1.Add(this.CargoAdd, null);
			this.EmpleadoAdd = new global::Gtk.Action("EmpleadoAdd", global::Mono.Unix.Catalog.GetString("Empleado"), null, null);
			this.EmpleadoAdd.ShortLabel = global::Mono.Unix.Catalog.GetString("Empleado");
			w1.Add(this.EmpleadoAdd, null);
			this.DepartamentosAction = new global::Gtk.Action("DepartamentosAction", global::Mono.Unix.Catalog.GetString("Departamentos"), null, null);
			this.DepartamentosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Departamento");
			w1.Add(this.DepartamentosAction, null);
			this.CargosAction = new global::Gtk.Action("CargosAction", global::Mono.Unix.Catalog.GetString("Cargos"), null, null);
			this.CargosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cargo");
			w1.Add(this.CargosAction, null);
			this.EmpleadosAction = new global::Gtk.Action("EmpleadosAction", global::Mono.Unix.Catalog.GetString("Empleados"), null, null);
			this.EmpleadosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Empleado");
			w1.Add(this.EmpleadosAction, null);
			this.SeguridadAction = new global::Gtk.Action("SeguridadAction", global::Mono.Unix.Catalog.GetString("Seguridad"), null, null);
			this.SeguridadAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Seguridad");
			w1.Add(this.SeguridadAction, null);
			this.CredencialesAction = new global::Gtk.Action("CredencialesAction", global::Mono.Unix.Catalog.GetString("Credenciales"), null, null);
			this.CredencialesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Credenciales");
			w1.Add(this.CredencialesAction, null);
			this.CrearUsuarioAction = new global::Gtk.Action("CrearUsuarioAction", global::Mono.Unix.Catalog.GetString("Crear usuario"), null, null);
			this.CrearUsuarioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Crear usuario");
			w1.Add(this.CrearUsuarioAction, null);
			this.AdministrarUsuarioAction = new global::Gtk.Action("AdministrarUsuarioAction", global::Mono.Unix.Catalog.GetString("Administrar usuario"), null, null);
			this.AdministrarUsuarioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Administrar usuario");
			w1.Add(this.AdministrarUsuarioAction, null);
			this.RestauracinAction = new global::Gtk.Action("RestauracinAction", global::Mono.Unix.Catalog.GetString("Restauración"), null, null);
			this.RestauracinAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Restauración");
			w1.Add(this.RestauracinAction, null);
			this.DepartamentoAction = new global::Gtk.Action("DepartamentoAction", global::Mono.Unix.Catalog.GetString("Departamento"), null, null);
			this.DepartamentoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Departamento");
			w1.Add(this.DepartamentoAction, null);
			this.CargoAction1 = new global::Gtk.Action("CargoAction1", global::Mono.Unix.Catalog.GetString("Cargo"), null, null);
			this.CargoAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Cargo");
			w1.Add(this.CargoAction1, null);
			this.EmpleadoAction = new global::Gtk.Action("EmpleadoAction", global::Mono.Unix.Catalog.GetString("Empleado"), null, null);
			this.EmpleadoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Empleado");
			w1.Add(this.EmpleadoAction, null);
			this.PermisosAction = new global::Gtk.Action("PermisosAction", global::Mono.Unix.Catalog.GetString("Permisos"), null, null);
			this.PermisosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Permisos");
			w1.Add(this.PermisosAction, null);
			this.AadirAction = new global::Gtk.Action("AadirAction", global::Mono.Unix.Catalog.GetString("Añadir"), null, null);
			this.AadirAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Añadir");
			w1.Add(this.AadirAction, null);
			this.RolAction = new global::Gtk.Action("RolAction", global::Mono.Unix.Catalog.GetString("Rol"), null, null);
			this.RolAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Rol");
			w1.Add(this.RolAction, null);
			this.UsuarioAction = new global::Gtk.Action("UsuarioAction", global::Mono.Unix.Catalog.GetString("Usuario"), null, null);
			this.UsuarioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuario");
			w1.Add(this.UsuarioAction, null);
			this.AdministrarAction = new global::Gtk.Action("AdministrarAction", global::Mono.Unix.Catalog.GetString("Administrar"), null, null);
			this.AdministrarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Administrar");
			w1.Add(this.AdministrarAction, null);
			this.RolAction1 = new global::Gtk.Action("RolAction1", global::Mono.Unix.Catalog.GetString("Rol"), null, null);
			this.RolAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Rol");
			w1.Add(this.RolAction1, null);
			this.UsuarioAction1 = new global::Gtk.Action("UsuarioAction1", global::Mono.Unix.Catalog.GetString("Usuario"), null, null);
			this.UsuarioAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuario");
			w1.Add(this.UsuarioAction1, null);
			this.RestaurarAction = new global::Gtk.Action("RestaurarAction", global::Mono.Unix.Catalog.GetString("Restaurar"), null, null);
			this.RestaurarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Restaurar");
			w1.Add(this.RestaurarAction, null);
			this.restaurarDept = new global::Gtk.Action("restaurarDept", global::Mono.Unix.Catalog.GetString("Departamento"), null, null);
			this.restaurarDept.ShortLabel = global::Mono.Unix.Catalog.GetString("Departamento");
			w1.Add(this.restaurarDept, null);
			this.restaurarCargo = new global::Gtk.Action("restaurarCargo", global::Mono.Unix.Catalog.GetString("Cargo"), null, null);
			this.restaurarCargo.ShortLabel = global::Mono.Unix.Catalog.GetString("Cargo");
			w1.Add(this.restaurarCargo, null);
			this.restaurarEmp = new global::Gtk.Action("restaurarEmp", global::Mono.Unix.Catalog.GetString("Empleado"), null, null);
			this.restaurarEmp.ShortLabel = global::Mono.Unix.Catalog.GetString("Empleado");
			w1.Add(this.restaurarEmp, null);
			this.restaurarUser = new global::Gtk.Action("restaurarUser", global::Mono.Unix.Catalog.GetString("Usuario"), null, null);
			this.restaurarUser.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuario");
			w1.Add(this.restaurarUser, null);
			this.OpcionesDeRolAction = new global::Gtk.Action("OpcionesDeRolAction", global::Mono.Unix.Catalog.GetString("Opciones de rol"), null, null);
			this.OpcionesDeRolAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Permisos");
			w1.Add(this.OpcionesDeRolAction, null);
			this.ListarAction1 = new global::Gtk.Action("ListarAction1", global::Mono.Unix.Catalog.GetString("Listar"), null, null);
			this.ListarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar");
			w1.Add(this.ListarAction1, null);
			this.RolAction2 = new global::Gtk.Action("RolAction2", global::Mono.Unix.Catalog.GetString("Rol"), null, null);
			this.RolAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Rol");
			w1.Add(this.RolAction2, null);
			this.ListarAction2 = new global::Gtk.Action("ListarAction2", global::Mono.Unix.Catalog.GetString("Listar"), null, null);
			this.ListarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Listar");
			w1.Add(this.ListarAction2, null);
			this.RolAction3 = new global::Gtk.Action("RolAction3", global::Mono.Unix.Catalog.GetString("Rol"), null, null);
			this.RolAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Rol");
			w1.Add(this.RolAction3, null);
			this.UsuarioAction3 = new global::Gtk.Action("UsuarioAction3", global::Mono.Unix.Catalog.GetString("Usuario"), null, null);
			this.UsuarioAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuario");
			w1.Add(this.UsuarioAction3, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.WidthRequest = 1024;
			this.HeightRequest = 584;
			this.Name = "ProyectoEyS.vistaAdmin";
			this.Title = global::Mono.Unix.Catalog.GetString("vistaAdmin");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProyectoEyS.vistaAdmin.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar3\'><menu name=\'MenAction1\' action=\'MenAction1\'><menu na" +
					"me=\'AadirAction1\' action=\'AadirAction1\'><menuitem name=\'DepartamentoAdd\' action=" +
					"\'DepartamentoAdd\'/><menuitem name=\'CargoAdd\' action=\'CargoAdd\'/><menuitem name=\'" +
					"EmpleadoAdd\' action=\'EmpleadoAdd\'/></menu><menu name=\'ListarAction\' action=\'List" +
					"arAction\'><menuitem name=\'DepartamentosAction\' action=\'DepartamentosAction\'/><me" +
					"nuitem name=\'CargosAction\' action=\'CargosAction\'/><menuitem name=\'EmpleadosActio" +
					"n\' action=\'EmpleadosAction\'/></menu><separator/><menuitem name=\'ParamGenButt\' ac" +
					"tion=\'ParamGenButt\'/><menuitem name=\'CerrarSesinAction2\' action=\'CerrarSesinActi" +
					"on2\'/></menu><menu name=\'ReportesAction1\' action=\'ReportesAction1\'><menuitem nam" +
					"e=\'VistaPersonalizadaAction\' action=\'VistaPersonalizadaAction\'/><menuitem name=\'" +
					"ReportePersonalizadoAction\' action=\'ReportePersonalizadoAction\'/><menuitem name=" +
					"\'ReporteGeneralAction\' action=\'ReporteGeneralAction\'/></menu><menu name=\'Segurid" +
					"adAction\' action=\'SeguridadAction\'><menu name=\'AadirAction\' action=\'AadirAction\'" +
					"><menuitem name=\'RolAction\' action=\'RolAction\'/><menuitem name=\'UsuarioAction\' a" +
					"ction=\'UsuarioAction\'/></menu><menu name=\'ListarAction2\' action=\'ListarAction2\'>" +
					"<menuitem name=\'RolAction3\' action=\'RolAction3\'/><menuitem name=\'UsuarioAction3\'" +
					" action=\'UsuarioAction3\'/></menu><separator/><menu name=\'RestaurarAction\' action" +
					"=\'RestaurarAction\'><menuitem name=\'restaurarDept\' action=\'restaurarDept\'/><menui" +
					"tem name=\'restaurarCargo\' action=\'restaurarCargo\'/><menuitem name=\'restaurarEmp\'" +
					" action=\'restaurarEmp\'/><menuitem name=\'restaurarUser\' action=\'restaurarUser\'/><" +
					"/menu></menu><menu name=\'AyudaAction1\' action=\'AyudaAction1\'><menuitem name=\'Ins" +
					"tructivoAction1\' action=\'InstructivoAction1\'/><menuitem name=\'ReportarUnProblema" +
					"Action1\' action=\'ReportarUnProblemaAction1\'/><menuitem name=\'AcercaDeAction1\' ac" +
					"tion=\'AcercaDeAction1\'/></menu></menubar></ui>");
			this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar3")));
			this.menubar3.Name = "menubar3";
			this.vbox7.Add(this.menubar3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.menubar3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.WidthRequest = 275;
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.drawingarea1 = new global::Gtk.DrawingArea();
			this.drawingarea1.HeightRequest = 275;
			this.drawingarea1.Name = "drawingarea1";
			this.vbox13.Add(this.drawingarea1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.drawingarea1]));
			w3.Position = 0;
			w3.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.GtkScrolledWindow6 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow6.HeightRequest = 32;
			this.GtkScrolledWindow6.Name = "GtkScrolledWindow6";
			this.GtkScrolledWindow6.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow6.Gtk.Container+ContainerChild
			global::Gtk.Viewport w4 = new global::Gtk.Viewport();
			w4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport5.Gtk.Container+ContainerChild
			this.labelHora = new global::Gtk.Label();
			this.labelHora.HeightRequest = 25;
			this.labelHora.Name = "labelHora";
			this.labelHora.LabelProp = global::Mono.Unix.Catalog.GetString("HH:MM:SS");
			this.labelHora.UseUnderline = true;
			w4.Add(this.labelHora);
			this.GtkScrolledWindow6.Add(w4);
			this.vbox13.Add(this.GtkScrolledWindow6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.GtkScrolledWindow6]));
			w7.Position = 1;
			w7.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.WidthRequest = 268;
			this.scrolledwindow2.HeightRequest = 180;
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w8 = new global::Gtk.Viewport();
			w8.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport2.Gtk.Container+ContainerChild
			this.calendar3 = new global::Gtk.Calendar();
			this.calendar3.CanFocus = true;
			this.calendar3.Name = "calendar3";
			this.calendar3.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			w8.Add(this.calendar3);
			this.scrolledwindow2.Add(w8);
			this.vbox13.Add(this.scrolledwindow2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.scrolledwindow2]));
			w11.Position = 2;
			w11.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow3.BorderWidth = ((uint)(10));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.tvEvento = new global::Gtk.TextView();
			this.tvEvento.Sensitive = false;
			this.tvEvento.CanFocus = true;
			this.tvEvento.Name = "tvEvento";
			this.tvEvento.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow3.Add(this.tvEvento);
			this.vbox13.Add(this.GtkScrolledWindow3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.GtkScrolledWindow3]));
			w13.Position = 3;
			this.hbox2.Add(this.vbox13);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox13]));
			w14.Position = 0;
			w14.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.WidthRequest = 766;
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.GtkScrolledWindow5 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow5.WidthRequest = 0;
			this.GtkScrolledWindow5.HeightRequest = 48;
			this.GtkScrolledWindow5.Name = "GtkScrolledWindow5";
			this.GtkScrolledWindow5.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow5.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow5.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow5.Gtk.Container+ContainerChild
			global::Gtk.Viewport w15 = new global::Gtk.Viewport();
			w15.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport4.Gtk.Container+ContainerChild
			this.label18 = new global::Gtk.Label();
			this.label18.HeightRequest = 1;
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Entradas:");
			w15.Add(this.label18);
			this.GtkScrolledWindow5.Add(w15);
			this.vbox12.Add(this.GtkScrolledWindow5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.GtkScrolledWindow5]));
			w18.Position = 0;
			w18.Expand = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvwEmpleado = new global::Gtk.TreeView();
			this.trvwEmpleado.WidthRequest = 1000;
			this.trvwEmpleado.CanFocus = true;
			this.trvwEmpleado.Name = "trvwEmpleado";
			this.GtkScrolledWindow.Add(this.trvwEmpleado);
			this.vbox12.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.GtkScrolledWindow]));
			w20.Position = 1;
			// Container child vbox12.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			// Container child vbox16.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w21 = new global::Gtk.Viewport();
			w21.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.labelCargo = new global::Gtk.Label();
			this.labelCargo.Name = "labelCargo";
			this.labelCargo.Xalign = 1F;
			this.labelCargo.LabelProp = global::Mono.Unix.Catalog.GetString("CARGO");
			this.labelCargo.UseUnderline = true;
			w21.Add(this.labelCargo);
			this.GtkScrolledWindow2.Add(w21);
			this.vbox16.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.GtkScrolledWindow2]));
			w24.Position = 0;
			// Container child vbox16.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w25 = new global::Gtk.Viewport();
			w25.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.labelEmp = new global::Gtk.Label();
			this.labelEmp.Name = "labelEmp";
			this.labelEmp.Xalign = 1F;
			this.labelEmp.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.labelEmp.UseUnderline = true;
			this.labelEmp.Justify = ((global::Gtk.Justification)(2));
			w25.Add(this.labelEmp);
			this.GtkScrolledWindow1.Add(w25);
			this.vbox16.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.GtkScrolledWindow1]));
			w28.PackType = ((global::Gtk.PackType)(1));
			w28.Position = 1;
			this.hbox3.Add(this.vbox16);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox16]));
			w29.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("ProyectoEyS.Texturas.userActive.png");
			this.hbox3.Add(this.image1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.image1]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox14.Add(this.hbox3);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox3]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			this.vbox12.Add(this.vbox14);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox14]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			this.hbox2.Add(this.vbox12);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox12]));
			w33.Position = 1;
			this.vbox7.Add(this.hbox2);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox2]));
			w34.Position = 1;
			this.Add(this.vbox7);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1120;
			this.DefaultHeight = 693;
			this.Show();
			this.ParamGenButt.Activated += new global::System.EventHandler(this.OnParamGenButtActivated);
			this.CerrarSesinAction2.Activated += new global::System.EventHandler(this.OnCerrarSesinAction2Activated);
				this.DepartamentoAdd.Activated += new global::System.EventHandler(this.OnDepartamentoAddActivated);
			this.CargoAdd.Activated += new global::System.EventHandler(this.OnCargoAddActivated);
			this.EmpleadoAdd.Activated += new global::System.EventHandler(this.OnEmpleadoAddActivated);
			this.DepartamentosAction.Activated += new global::System.EventHandler(this.OnDepartamentoAction1Activated);
			this.CargosAction.Activated += new global::System.EventHandler(this.OnCargoListarActivated);
			this.EmpleadosAction.Activated += new global::System.EventHandler(this.OnEmpleadoListarActivated);
			this.RolAction.Activated += new global::System.EventHandler(this.OnRolActionActivated);
			this.UsuarioAction.Activated += new global::System.EventHandler(this.OnUsuarioActionActivated);
			this.restaurarDept.Activated += new global::System.EventHandler(this.OnRestaurarDeptActivated);
			this.restaurarCargo.Activated += new global::System.EventHandler(this.OnRestaurarCargoActivated);
			this.restaurarEmp.Activated += new global::System.EventHandler(this.OnRestaurarEmpActivated);
			this.restaurarUser.Activated += new global::System.EventHandler(this.OnRestaurarUserActivated);
			this.OpcionesDeRolAction.Activated += new global::System.EventHandler(this.OnPermisosAction1Activated);
			this.RolAction3.Activated += new global::System.EventHandler(this.OnRolAction3Activated);
			this.UsuarioAction3.Activated += new global::System.EventHandler(this.OnUsuarioAction3Activated);
		}
	}
}
