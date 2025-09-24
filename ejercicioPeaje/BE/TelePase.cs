using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TelePase
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private TimeSpan hora;
		public TimeSpan Hora
		{
			get { return hora; }
			set { hora = value; }
		}

		private Vehiculo vehiculo;
		public Vehiculo Vehiculo
		{
			get { return vehiculo; }
			set { vehiculo = value; }
		}

		private int importe;
		public int Importe
		{
			get { return importe; }
			set { importe = value; }
		}


		public TelePase()
		{
			Vehiculo = new Vehiculo(); 
		}

	}
}
