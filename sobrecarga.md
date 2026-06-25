# Sobrecarga em C#

A sobrecarga (overload) permite que uma mesma classe declare vários membros (métodos, construtores, indexadores ou operadores) com o mesmo nome, desde que cada declaração tenha assinaturas diferentes — isto é, difiram no número, tipo ou ordem dos parâmetros. blog.codigocentral.com

## Regras e pontos essenciais

- A assinatura (nome + parâmetros) distingue os membros sobrecarregados; o tipo de retorno não é suficiente para diferenciar sobrecargas. devsnapratica.blogspot

- Sobrecarregar melhora a legibilidade e permite adaptar chamadas ao contexto sem criar nomes distintos para operações relacionadas. codefinity

- Métodos sobrecarregados devem estar no mesmo escopo (mesma classe ou struct); não se usa sobrecarga para alterar visibilidade entre classes. blog.codigocentral.com

- Construtores, operadores e indexadores também podem ser sobrecarregados seguindo as mesmas regras de assinatura. tomasvasquez.com.br

- Evite sobrecarregar de forma ambígua (assinaturas que o compilador não consegue distinguir) e prefira combinações claras de parâmetros. medium

## Exemplo simples (descrição)

- `public void Print(string s)` — imprime uma string. codefinity

- `public void Print(string s, int times)` — imprime a string N vezes. codefinity

## Diferença de conceito relacionada

Sobrecarga (overload) é diferente de sobrescrita (override): sobrecarga cria múltiplas assinaturas no mesmo tipo; sobrescrita modifica o comportamento de um método da classe base em uma classe derivada. cursos.alura.com

## Definição rápida (duas linhas)

Sobrecarga em C# é permitir múltiplos membros com o mesmo nome, desde que tenham assinaturas diferentes (número/tipo/ordem de parâmetros). devsnapratica.blogspot

O compilador escolhe qual versão chamar com base nos argumentos fornecidos; o tipo de retorno não distingue sobrecargas. blog.codigocentral.com
