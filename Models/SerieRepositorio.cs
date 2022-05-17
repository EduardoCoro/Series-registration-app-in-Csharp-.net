using System;
using System.Collections.Generic;
using Dio.Series.Interface;

namespace Dio.Series
{
   
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private bool Valido { get; set; }
        private List<Serie> listaSerie = new List<Serie>();

        public bool ExisteID(int id)
        {
            Valido = false;
            for (int indice = 0; indice < listaSerie.Count; indice++)
            {
                if(listaSerie[indice].Id == id )
                {
                    Valido = true;
                    break;
                }
                    
            }      
            
            return Valido;            

        }
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id]  = objeto;                  
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();                    
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public System.Collections.Generic.List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {            
            return listaSerie[id];      
        }
    }
}