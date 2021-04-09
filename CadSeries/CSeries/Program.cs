using System;
using System.Collections.Generic;
using CSeries.Classes;

namespace CSeries
{
    class Program
    {
      static SerieRepositorio repositorio = new SerieRepositorio();
      static Series ser;
        static void Main(string[] args){
        string entrada="";

        while(!entrada.Equals("x")){
           Console.WriteLine("");
           Console.WriteLine("Digite a opção:");
           Console.WriteLine("(1) Para cadastrar série.");
           Console.WriteLine("(2) Para consultar lista de séries.");
           Console.WriteLine("(3) Para atualizar série.");
           Console.WriteLine("(4) Para indisponibilizar série.");
           Console.WriteLine("(5) Para consultar série por id.");
           Console.WriteLine("(x) Para sair.");
           Console.WriteLine("");
           entrada = Console.ReadLine();
           switch(entrada){
           case "1":
           cadastrar();
           break;
       
           case "2":
         
           listarTodas();
           break;

           case "3":
           atualizar();
           break;

           case "4":
          indispor();
           break;

           case "5":
          consultarPorId();

           break;


           case "x":
           break;
           
           }
    }        static void cadastrar(){ 
             Console.WriteLine("");
             Console.WriteLine("Digite o nome da série");
             string nome = Console.ReadLine();
             Console.WriteLine("Digite a categoria");
             Console.WriteLine("(1) Ação ");
             Console.WriteLine("(2) Corrida ");
             Console.WriteLine("(3) Comedia ");
             Console.WriteLine("(3) Comedia ");
             Console.WriteLine("(4) Drama ");
             Console.WriteLine("(5) Esporte ");
             Console.WriteLine("(6) Ficção ");
             Console.WriteLine("(7) Musical ");
             Console.WriteLine("");

             int categoria =int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o ano de lançamento.");
             int ano =int. Parse(Console.ReadLine());
             Console.WriteLine("Digite a descrição da série.");
             string descricao= Console.ReadLine();
             
              ser = new Series(id:repositorio.ProximoId(),categoria:(Categorias)categoria,nome:nome,ano:ano,descricao:descricao);
             repositorio.insere(ser);
             Console.WriteLine("Serie cadastrada com sucesso.");
}
             static void listarTodas(){
             var lista =repositorio.Lista();

             foreach( var listaTodas in lista  ){
             Console.WriteLine("{0}- {1}- {2}",listaTodas.retornaId(),listaTodas.retornaNome(),listaTodas.retornaCategoria());
  }
   }
              static void indispor(){
              Console.WriteLine("Digite o id que deseja indispor.");
              int categoriaExcluir = int.Parse(Console.ReadLine());
              repositorio.indisporSerie(categoriaExcluir);
}         
              
              
              static void consultarPorId(){
              Console.WriteLine("Digite o id que deseja consultar.");
              int retornoPorId=int.Parse(Console.ReadLine());
              Console.WriteLine(repositorio.RetornaPorId(retornoPorId));
}
              static void atualizar(){
              Console.WriteLine("Digite o id que deseja atualizar.");
              int atualizarId=int.Parse(Console.ReadLine());
              Console.WriteLine("Digite o nome da série");
              string nome = Console.ReadLine();
               Console.WriteLine("Digite a categoria");
              int categoria =int.Parse(Console.ReadLine());
              Console.WriteLine("Digite o ano de lançamento.");
              int ano =int. Parse(Console.ReadLine());
              Console.WriteLine("Digite a descrição da série.");
              string descricao= Console.ReadLine();
              Series atualizarSer = new Series(id:atualizarId,categoria:(Categorias)categoria,nome:nome,ano:ano,descricao:descricao);
              repositorio.atualizarSerie(atualizarId,atualizarSer );
              Console.WriteLine("Nova serie cadastrada com sucesso.");
}             Console.WriteLine("");
        }
}
}
