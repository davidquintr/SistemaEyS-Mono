using System;
namespace ProyectoEyS {
    public partial class frmAcercaDe : Gtk.Window {
        public frmAcercaDe() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            Pango.FontDescription txt = new Pango.FontDescription() {
                Stretch = Pango.Stretch.UltraExpanded,
                Size = Convert.ToInt32(35 * Pango.Scale.PangoScale),
                Family = "sans serif",
            };

            Pango.FontDescription txt2 = new Pango.FontDescription() {
                Stretch = Pango.Stretch.UltraExpanded,
                Size = Convert.ToInt32(15 * Pango.Scale.PangoScale),
                Family = "sans serif",
            };

            label3.ModifyFont(txt);
            label4.ModifyFont(txt2);

        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }
    }
}
