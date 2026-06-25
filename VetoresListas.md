# Vetores e Listas em C#

## Vetores (Arrays)

Vetores são estruturas de dados que armazenam vários valores do mesmo tipo em posições consecutivas da memória.

O tamanho do vetor é fixo após sua criação.

### Criando um vetor

```csharp
int[] numeros = new int[5];
```

### Inicializando com valores

```csharp
int[] numeros = { 10, 20, 30, 40, 50 };
```

### Acessando elementos

```csharp
Console.WriteLine(numeros[0]); // 10
Console.WriteLine(numeros[2]); // 30
```

### Alterando elementos

```csharp
numeros[1] = 99;
```

### Percorrendo com for

```csharp
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

### Percorrendo com foreach

```csharp
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
```

### Propriedades importantes

| Propriedade | Descrição |
|------------|------------|
| `Length` | Quantidade de elementos do vetor |

---

## Listas (List<T>)

Listas são coleções dinâmicas que podem crescer ou diminuir durante a execução do programa.

Para utilizá-las é necessário importar:

```csharp
using System.Collections.Generic;
```

### Criando uma lista

```csharp
List<int> numeros = new List<int>();
```

### Inicializando com valores

```csharp
List<int> numeros = new List<int>()
{
    10,
    20,
    30
};
```

### Adicionando elementos

```csharp
numeros.Add(40);
numeros.Add(50);
```

### Removendo elementos

```csharp
numeros.Remove(20);
```

### Removendo por índice

```csharp
numeros.RemoveAt(0);
```

### Inserindo em uma posição

```csharp
numeros.Insert(1, 100);
```

### Verificando se existe um valor

```csharp
bool existe = numeros.Contains(30);
```

### Acessando elementos

```csharp
Console.WriteLine(numeros[0]);
```

### Percorrendo com for

```csharp
for (int i = 0; i < numeros.Count; i++)
{
    Console.WriteLine(numeros[i]);
}
```

### Percorrendo com foreach

```csharp
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
```

### Propriedades importantes

| Propriedade | Descrição |
|------------|------------|
| `Count` | Quantidade de elementos da lista |

---

## Diferenças entre Vetor e Lista

| Característica | Vetor (Array) | Lista (List<T>) |
|---------------|---------------|-----------------|
| Tamanho | Fixo | Dinâmico |
| Adicionar elementos | Não | Sim |
| Remover elementos | Não | Sim |
| Performance | Mais rápida | Leve sobrecarga |
| Flexibilidade | Menor | Maior |

---

## Quando usar?

### Use Vetor quando:

- O tamanho é conhecido.
- Os dados não mudarão com frequência.
- Deseja máximo desempenho.

### Use Lista quando:

- O tamanho pode variar.
- Será necessário adicionar ou remover elementos.
- Deseja mais flexibilidade.

---

## Resumo

| Estrutura | Característica Principal |
|------------|--------------------------|
| `Array` | Tamanho fixo |
| `List<T>` | Tamanho dinâmico |
| `Length` | Quantidade de elementos do vetor |
| `Count` | Quantidade de elementos da lista |
| `Add()` | Adiciona elemento na lista |
| `Remove()` | Remove elemento da lista |
| `Insert()` | Insere elemento em uma posição |
| `Contains()` | Verifica se um valor existe |
