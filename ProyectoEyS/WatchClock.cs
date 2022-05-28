using System;
using Cairo;

namespace ProyectoEyS
{
    public class WatchClock
    {

        public Antialias universalAntiA = Antialias.Default;

        int Width = 0;
        int Height = 0;

        public void ObtenerDimensiones(int ancho, int alto)
        {
            Width = ancho;
            Height = alto;
        }

        public void DrawRing(Gdk.Window drawingArea)
        {
            int clockAmount = 0;
            double rotateAmount = 0;

            while (clockAmount < 12)//cantidad de veces que se dibujan las lineas
            {
                Cairo.Context ring = Gdk.CairoHelper.Create(drawingArea);

                PointD point1, point2;
                point1 = new PointD(75, 0);
                point2 = new PointD(85, 0);

                ring.Antialias = universalAntiA;
                ring.Translate(Width, Height);
                ring.Rotate(rotateAmount);//Rotacion por cada linea
                ring.LineWidth = 5; //Ancho de cada linea
                ring.MoveTo(point1);
                ring.LineTo(point2);
                ring.LineCap = LineCap.Round;


                ring.SetSourceColor(new Cairo.Color(0.95, 0.95, 0.95)); //color blanco de las lineas
                ring.Stroke();

                ring.GetTarget().Dispose();
                ring.Dispose();

                clockAmount++;
                rotateAmount += (Math.PI * 2) / 12; //Calculo de la rotacion por cada linea de hora

            }// fin del while
        }//fin del metodo


        public void HourLine(Gdk.Window drawingArea)
        {
            Cairo.Context ring = Gdk.CairoHelper.Create(drawingArea);

            PointD point1, point2;
            point1 = new PointD(0, 0);
            point2 = new PointD(0, -60);

            ring.Antialias = universalAntiA;
            ring.Translate(Width, Height);
            ring.Rotate(CalculateHourRadians()); // Calculo de la rotacion del aguja
            ring.LineWidth = 8;
            ring.MoveTo(point1);
            ring.LineTo(point2);
            ring.LineCap = LineCap.Round;


            ring.SetSourceColor(new Cairo.Color(0.5, 0.1, 0.1));
            ring.Stroke();

            ring.GetTarget().Dispose();
            ring.Dispose();

        }//fin del metodo

        public void MinuteLine(Gdk.Window drawingArea)
        {
            Cairo.Context ring = Gdk.CairoHelper.Create(drawingArea);

            PointD point1, point2;
            point1 = new PointD(0, 0);
            point2 = new PointD(0, -70);

            ring.Antialias = universalAntiA;
            ring.Translate(Width, Height);
            ring.Rotate(CalculateMinuteRadians()); // Calculo de la rotacion del aguja
            ring.LineWidth = 4;
            ring.MoveTo(point1);
            ring.LineTo(point2);
            ring.LineCap = LineCap.Round;


            ring.SetSourceColor(new Cairo.Color(0.95, 0.95, 0.95));
            ring.Stroke();

            ring.GetTarget().Dispose();
            ring.Dispose();
        }

        public void SecondsLine(Gdk.Window drawingArea)
        {
            Cairo.Context ring = Gdk.CairoHelper.Create(drawingArea);

            PointD point1, point2;
            point1 = new PointD(0, 0);
            point2 = new PointD(0, -80);

            ring.Antialias = universalAntiA;
            ring.Translate(Width, Height);
            ring.Rotate(CalculateSecondsRadians()); // Calculo de la rotacion del aguja
            ring.LineWidth = 4;
            ring.MoveTo(point1);
            ring.LineTo(point2);
            ring.LineCap = LineCap.Round;


            ring.SetSourceColor(new Cairo.Color(0.95, 0.95, 0.95));
            ring.Stroke();

            ring.GetTarget().Dispose();
            ring.Dispose();
        }

        //Calculamos la rotacion de la aguja de horas
        double CalculateHourRadians()
        {
            double radian = Math.PI * 2;
            int minutes;

            if (DateTime.Now.Hour > 12)
                minutes = (DateTime.Now.Hour - 12) * 60 + (DateTime.Now.Minute);
            else
                minutes = DateTime.Now.Hour * 60 + (DateTime.Now.Minute);

            radian = radian * (0.001388889 * (double)minutes);
            return radian;
        }//fin del metodo

        double CalculateMinuteRadians()
        {
            double radian = Math.PI * 2;

            radian = radian * (0.016666667 * DateTime.Now.Minute);
            return radian;
        }//fin del metodo

        double CalculateSecondsRadians()
        {
            double radian = Math.PI * 2;

            radian = radian * (0.016666667 * DateTime.Now.Second);
            return radian;
        }
    }
}
