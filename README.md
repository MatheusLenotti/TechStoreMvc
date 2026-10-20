1- Classe Categoria (Model): Definir a estrutura dos dados (propriedades Id, Nome, etc.).

2- CategoriasController: Receber a requisição HTTP, processar a lógica e acionar a View com os dados.

3- @model como lista: Permitir que a View receba e exiba múltiplos objetos de uma só vez.

4- foreach: Percorrer a lista de dados e gerar o código HTML para cada item dinamicamente.

5- Pasta Views/Categoria (no singular): Causará erro de "View não encontrada", pois o ASP.NET exige o mesmo nome do Controller (Categorias).

6- Ao acessar /categorias, a requisição GET é encaminhada à action Index de CategoriasController. Ela cria a lista e chama View(categorias). O MVC localiza Index.cshtml, que percorre a lista e produz a resposta HTML.