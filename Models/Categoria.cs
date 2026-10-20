using System;

namespace TechStoreMvc.Models;

public class Categoria
{
    // Passo 01 - Criar as Models
    // Atributos

    public int Id {get; set;} // Get para obter um id = Identificador
                             // Set para definir um novo valor, atualizar e etc...
    public string Nome {get; set;}
    public string Descricao {get; set;}
    public bool Ativa {get; set;}

    // Método Construtor - Define valores iniciais desses atributos acima!

    public Categoria (
        int id,
        string nome,
        string descricao,
        bool ativa
    )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Ativa = ativa;
    }

}
