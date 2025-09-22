using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string descripcion;
		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private int valor;
		public int Valor
		{
			get { return valor; }
			set { valor = value; }
		}


	}
}
