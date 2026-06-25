# params, ref, out, boxing e unboxing em C#

## params

Permite passar uma quantidade variável de argumentos para um método.

```csharp
static int Somar(params int[] numeros)
{
    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    return soma;
}

Console.WriteLine(Somar(10, 20, 30));
```

### Regras

- Deve ser o último parâmetro do método.
- Só pode existir um `params` por método.
- Internamente é tratado como um array.

---

## ref

Permite passar uma variável por referência.

Qualquer alteração feita dentro do método afeta a variável original.

```csharp
static void Dobrar(ref int numero)
{
    numero *= 2;
}

int valor = 10;

Dobrar(ref valor);

Console.WriteLine(valor); // 20
```

### Regras

- A variável deve estar inicializada antes da chamada.
- É obrigatório usar `ref` tanto na declaração quanto na chamada.

---

## out

Também passa por referência, mas é usado para retornar valores pelo método.

```csharp
static void Dividir(int a, int b, out int resultado)
{
    resultado = a / b;
}

Dividir(10, 2, out int valor);

Console.WriteLine(valor);
```

### Regras

- A variável não precisa estar inicializada antes da chamada.
- O método é obrigado a atribuir um valor ao parâmetro `out`.
- É obrigatório usar `out` na declaração e na chamada.

---

## Boxing

Conversão de um tipo de valor para um tipo de referência (`object`).

```csharp
int numero = 10;

object obj = numero; // Boxing
```

### O que acontece?

1. O valor é copiado.
2. Uma nova instância é criada na heap.
3. O valor é armazenado dentro do objeto.

---

## Unboxing

Conversão de um objeto (`object`) de volta para um tipo de valor.

```csharp
object obj = 10;

int numero = (int)obj; // Unboxing
```

### O que acontece?

1. O CLR verifica se o objeto contém o tipo esperado.
2. O valor é extraído.
3. O valor é copiado para uma variável do tipo correspondente.

---

## Diferença entre Boxing e Unboxing

### Boxing

```csharp
int numero = 10;
object obj = numero;
```

- Valor → Objeto
- Cria alocação na heap
- Possui custo de desempenho

### Unboxing

```csharp
object obj = 10;
int numero = (int)obj;
```

- Objeto → Valor
- Requer cast explícito
- Possui custo de desempenho

---

## Resumo

| Recurso | Função |
|----------|----------|
| `params` | Permite quantidade variável de argumentos |
| `ref` | Passa variável por referência |
| `out` | Retorna valores através de parâmetros |
| `boxing` | Converte tipo de valor para `object` |
| `unboxing` | Converte `object` para tipo de valor |
