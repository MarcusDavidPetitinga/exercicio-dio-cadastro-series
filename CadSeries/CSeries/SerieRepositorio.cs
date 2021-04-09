using System;
using System.Collections.Generic;
using CSeries.Classes;
using CSeries.interfaces;

namespace CSeries
{
    public class SerieRepositorio : Repositorio<Series>
    {
        
        private List<Series>listaDeSeries=new List<Series>();       
     public void atualizarSerie(int id, Series ser)
        {
       listaDeSeries[id]=ser;
        }

        public void indisporSerie(int id)
        {
        listaDeSeries[id].SerieIndisponibilizada();
        Console.WriteLine("Serie indisponibilizada com sucesso.");
        }

        public void insere(Series ser)
        {
         listaDeSeries.Add(ser);
        }

        public List<Series> Lista()
        {
            return listaDeSeries;
        }

        public int ProximoId()
        {
           return listaDeSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaDeSeries[id];
        }
    }
}