using System.Collections.Generic;

namespace CSeries.interfaces
{
    public interface Repositorio<T>
    {  
        List<T> Lista();
        T RetornaPorId(int id);
        void insere(T Ser);
        void indisporSerie(int id);
        void atualizarSerie(int id, T ser);
        int  ProximoId();
       
    }
}