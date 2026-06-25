# Garbage Collector e Escopo Local em C#

## Garbage Collector (GC)

O Garbage Collector (GC) é o sistema responsável por gerenciar automaticamente a memória em C#. Seu objetivo é identificar objetos que não estão mais sendo utilizados pelo programa e liberar a memória ocupada por eles.

### Principais características

- Evita a necessidade de liberar memória manualmente.
- Reduz vazamentos de memória.
- Executa automaticamente quando necessário.
- Atua principalmente sobre objetos alocados no heap.

### Como funciona

1. Um objeto é criado no heap.
2. Enquanto existir uma referência apontando para ele, o objeto permanece na memória.
3. Quando nenhuma referência acessível aponta mais para o objeto, ele se torna elegível para coleta.
4. O Garbage Collector remove o objeto e libera a memória utilizada.

### Exemplo

```csharp
Pessoa pessoa = new Pessoa();

// A referência é removida
pessoa = null;

// O objeto poderá ser coletado pelo GC futuramente.
```

## Escopo Local

Escopo local é a região do código onde uma variável pode ser acessada. Variáveis declaradas dentro de um método, bloco condicional ou laço existem apenas dentro desse contexto.

### Principais características

- A variável só pode ser utilizada dentro do bloco em que foi declarada.
- Após o término do bloco, a variável deixa de existir.
- Ajuda a organizar o código e evitar conflitos de nomes.

### Exemplo

```csharp
void Exemplo()
{
    int numero = 10;

    if (numero > 0)
    {
        string mensagem = "Positivo";
    }

    // mensagem não pode ser acessada aqui
}
```

## Relação entre Escopo Local e Garbage Collector

Quando uma variável local sai de escopo, ela deixa de ser acessível pelo código. Se essa variável era a última referência para um objeto no heap, esse objeto poderá ser coletado futuramente pelo Garbage Collector.

```csharp
void CriarObjeto()
{
    Pessoa pessoa = new Pessoa();
}

// Ao sair do método, a variável pessoa deixa de existir.
// Se não houver outras referências para o objeto,
// ele poderá ser removido pelo Garbage Collector.
```

## Resumo

- O Garbage Collector libera automaticamente objetos que não são mais utilizados.
- Objetos são coletados quando não existem referências acessíveis para eles.
- Variáveis locais existem apenas dentro do bloco onde foram declaradas.
- Quando uma variável local sai de escopo, ela deixa de referenciar objetos.
- Objetos sem referências tornam-se candidatos à coleta de lixo.
