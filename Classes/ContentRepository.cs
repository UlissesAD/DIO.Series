using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class ContentRepository : IRepositorio<Content>
	{
        private List<Content> listaContent = new List<Content>();
		public void Atualiza(int id, Content objeto)
		{
			listaContent[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaContent[id].Excluir();
		}

		public void Insere(Content objeto)
		{
			listaContent.Add(objeto);
		}

		public List<Content> Lista()
		{
			return listaContent;
		}

		public int ProximoId()
		{
			return listaContent.Count;
		}

		public Content RetornaPorId(int id)
		{
			return listaContent[id];
		}
	}
}