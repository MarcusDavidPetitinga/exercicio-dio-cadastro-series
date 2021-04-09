using System;

namespace CSeries.Classes
{
    public class Series:ClasseBase
    {

private Categorias categoria{get; set;} 
private string nome {get; set;}
private int ano {get; set;}
private string descricao {get; set;}
private bool indisponivel{get; set;}
 public Series(int id, Categorias categoria, string nome, int ano, string descricao)
        {  
            this.id=id;
            this.categoria = categoria;
            this.nome = nome;
            this.ano = ano;
            this.descricao = descricao;
            this.indisponivel=false;
        }

    

        public override string ToString()
        {string retorno="";
        retorno+= "Id: "+ this.id +Environment.NewLine;
        retorno+= "Categoria: "+ this.categoria +Environment.NewLine;
        retorno+= "Nome: "+ this.nome +Environment.NewLine;
        retorno+= "Ano: "+ this.ano +Environment.NewLine;
        retorno+= "Descrição: "+ this.descricao +Environment.NewLine;
        retorno+= "Indisponível:"+ this.indisponivel+Environment.NewLine;
        return retorno;
        }

public string retornaNome(){
    return this.nome;
}

public int retornaId(){
    return this.id;
}

public Categorias retornaCategoria(){
    return this.categoria;
}

public void SerieIndisponibilizada(){

  this.indisponivel=true;
}



        
    }
}