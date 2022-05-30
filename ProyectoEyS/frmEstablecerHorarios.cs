using System;
using System.Collections.Generic;
using Entidades;
using Gtk;
using Negocio;

namespace ProyectoEyS {
    public partial class frmEstablecerHorarios : Gtk.Window {

        private List<Tbl_Horario> listHor = new List<Tbl_Horario>();

        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        private frmAddCargo callAddCargo;
        public frmAddCargo CallAddCargo { get => callAddCargo; set => callAddCargo = value; }

        public frmEstablecerHorarios() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            Title = "Restauración de Entidades";
            checkbutton1.Active = false;
            checkbutton3.Active = false;
            checkbutton2.Active = false;
            RecargarSpinB();
        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        public void CambiarModo(List<Tbl_Horario> listHor) { // Para editar
            label1.Text = "Editar horarios";
            this.listHor = listHor;
            OrdenarDatos();
            RecargarSpinB();
        }

        public void OrdenarDatos() {
            for (int i = 0; i < listHor.Count; i++) {

                switch (listHor[i].TipoHor) {
                    case 1:
                        if (listHor[i].Activo)
                            checkbutton1.Active = true;
                        spHoraIR1.Value = listHor[i].HorarioIn.Hour;
                        spHoraFR1.Value = listHor[i].HorarioIn.Minute;

                        spHoraIR2.Value = listHor[i].HorarioOut.Hour;
                        spHoraFR2.Value = listHor[i].HorarioOut.Minute;
                        break;
                    case 2:
                        if (listHor[i].Activo)
                            checkbutton2.Active = true;
                        spHoraIS1.Value = listHor[i].HorarioIn.Hour;
                        spHoraFS1.Value = listHor[i].HorarioIn.Minute;

                        spHoraIS2.Value = listHor[i].HorarioOut.Hour;
                        spHoraFS2.Value = listHor[i].HorarioOut.Minute;
                        break;
                    case 3:
                        if (listHor[i].Activo)
                            checkbutton3.Active = true;
                        spHoraID1.Value = listHor[i].HorarioIn.Hour;
                        spHoraFD1.Value = listHor[i].HorarioIn.Minute;

                        spHoraID2.Value = listHor[i].HorarioOut.Hour;
                        spHoraFD2.Value = listHor[i].HorarioOut.Minute;
                        break;
                }
            }
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnButtonGuardarClicked(object sender, EventArgs e) {
            ConvertirHorarios();
            int conteo = 0;
            for (int i = 0; i < listHor.Count; i++) {
                if (listHor[i].HorarioIn == listHor[i].HorarioOut) {
                    CuadroMensaje("Los horarios de entrada y salida no pueden ser los mismos", MessageType.Info, ButtonsType.Ok);
                    return;
                }
                if (listHor[i].HorarioIn > listHor[i].HorarioOut) {
                    CuadroMensaje("Los horarios de entrada no puede ser mayor al horario de salida", MessageType.Info, ButtonsType.Ok);
                    return;
                }
                if (listHor[i].Activo == true)
                    conteo++;
            }

            if (conteo == 0) {
                CuadroMensaje("Se tiene que tener al menos un horario", MessageType.Info, ButtonsType.Ok);
                return;
            }

            if (CuadroMensaje("¿Deseas guardar los horarios?", MessageType.Question, ButtonsType.YesNo)) {
                CuadroMensaje("Se han actualizado los horarios", MessageType.Info, ButtonsType.Ok);
                callAddCargo.EstablecerHorarios(listHor);
                this.Destroy();
            }
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }

        protected void OnCheckbutton3Toggled(object sender, EventArgs e) {
            RecargarSpinB();
        }

        protected void OnCheckbutton2Toggled(object sender, EventArgs e) {
            RecargarSpinB();
        }

        protected void OnCheckbutton1Toggled(object sender, EventArgs e) {
            RecargarSpinB();
        }

        private void ConvertirHorarios() {
            listHor.Clear();
            Tbl_Horario horario = new Tbl_Horario();
            string formarHorario;

            formarHorario = "2001-09-11 " + spHoraIR1.Text + ":" + spHoraFR1.Text + ":" + "00";
            horario.HorarioIn = DateTime.Parse(formarHorario);
            formarHorario = "2001-09-11 " + spHoraIR2.Text + ":" + spHoraFR2.Text + ":" + "00";
            horario.HorarioOut = DateTime.Parse(formarHorario);
            horario.TipoHor = 1;// Significa que es regular
            horario.Activo = checkbutton1.Active;
            listHor.Add(horario); // Se agrega el horario regular

            horario = new Tbl_Horario();
            formarHorario = "2001-09-11 " + spHoraIS1.Text + ":" + spHoraFS1.Text + ":" + "00";
            horario.HorarioIn = DateTime.Parse(formarHorario);
            formarHorario = "2001-09-11 " + spHoraIS2.Text + ":" + spHoraFS2.Text + ":" + "00";
            horario.HorarioOut = DateTime.Parse(formarHorario);
            horario.TipoHor = 2;// Significa que es sabático cariño
            horario.Activo = checkbutton2.Active;
            listHor.Add(horario); // Se agrega el horario sabatino

            horario = new Tbl_Horario();
            formarHorario = "2001-09-11 " + spHoraID1.Text + ":" + spHoraFD1.Text + ":" + "00";
            horario.HorarioIn = DateTime.Parse(formarHorario);
            formarHorario = "2001-09-11 " + spHoraID2.Text + ":" + spHoraFD2.Text + ":" + "00";
            horario.HorarioOut = DateTime.Parse(formarHorario);
            horario.TipoHor = 3;// Significa que es domingo
            horario.Activo = checkbutton3.Active;
            listHor.Add(horario); // Se agrega el horario sabatino
        }

        private void RecargarSpinB() {
            if (!checkbutton1.Active) {
                spHoraIR1.Sensitive = false;
                spHoraIR2.Sensitive = false;

                spHoraFR1.Sensitive = false;
                spHoraFR2.Sensitive = false;
            } else {
                spHoraIR1.Sensitive = true;
                spHoraIR2.Sensitive = true;

                spHoraFR1.Sensitive = true;
                spHoraFR2.Sensitive = true;
            }

            if (!checkbutton2.Active) {
                spHoraIS1.Sensitive = false;
                spHoraIS2.Sensitive = false;

                spHoraFS1.Sensitive = false;
                spHoraFS2.Sensitive = false;
            } else {
                spHoraIS1.Sensitive = true;
                spHoraIS2.Sensitive = true;

                spHoraFS1.Sensitive = true;
                spHoraFS2.Sensitive = true;
            }

            if (!checkbutton3.Active) {
                spHoraID1.Sensitive = false;
                spHoraID2.Sensitive = false;

                spHoraFD1.Sensitive = false;
                spHoraFD2.Sensitive = false;
            } else {
                spHoraID1.Sensitive = true;
                spHoraID2.Sensitive = true;

                spHoraFD1.Sensitive = true;
                spHoraFD2.Sensitive = true;
            }
        }
    }
}
