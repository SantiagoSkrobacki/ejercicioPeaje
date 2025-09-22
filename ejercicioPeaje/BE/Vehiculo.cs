using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vehiculo
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
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



	}
}
