using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vehiculo
    {
		private string patente;
		public string Patente
		{
			get { return patente; }
			set { patente = value; }
		}

		private string marca;
		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		private string modelo;
		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		private TipoVehiculo tipovehiculo;
		public TipoVehiculo TipoVehiculo
		{
			get { return tipovehiculo; }
			set { tipovehiculo = value; }
		}

		public Vehiculo()
		{
			TipoVehiculo = new TipoVehiculo();
		}

	}
}
