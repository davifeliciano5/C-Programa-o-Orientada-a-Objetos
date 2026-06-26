# Anotações
## statics
# 📌 Guia Rápido: Instância vs. Static em C#

A diferença fundamental entre usar `new` e usar `static` resume-se a como e onde os valores são guardados na memória do computador, e se eles precisam ser individuais ou compartilhados.

## 1. Memória de Instância (`new`)

**Palavra-chave:** Individualidade *(Cada um com a sua pasta na memória).*

Quando você usa o `new`, você cria uma cópia isolada (um objeto) na memória. Os dados de um objeto não afetam o outro.

**Quando usar:** Quando a classe precisa "lembrar" de informações que mudam de objeto para objeto.

**Exemplos reais:** ContaBancaria (o saldo do João é diferente do saldo da Maria), Usuario, Produto.

**Como se usa:**

```csharp
Conta joao = new Conta();
joao.Saldo = 100; // Saldo guardado na "gaveta" do João
```

## 2. Memória Estática (`static`)

**Palavra-chave:** Compartilhamento *(Uma única gaveta global para o sistema inteiro).*

Quando você usa `static`, o C# não cria uma caixa nova na memória ao usar a classe. Existe apenas um único espaço criado assim que o programa inicia.

**Quando usar:** Para funções utilitárias, ferramentas de cálculo puro (que recebem dados, processam e devolvem o resultado sem precisar "lembrar" de nada depois) ou configurações globais.

**Exemplos reais:** `Math.Sqrt()` (calcular raiz quadrada), conversores de moedas, validadores de CPF.

**Como se usa:**

```csharp
// Não usa 'new'. Chama direto pelo nome da Classe.
double resultado = Calculadora.Somar(5, 10);
```

## ⚠️ A Regra de Ouro do Acesso

**Dentro de um método `static` ➡️ Só entra `static`:** Um método estático não sabe qual objeto está rodando, então ele não pode acessar variáveis normais de instância diretamente (a menos que você passe o objeto como parâmetro).

**Dentro de um método Normal ➡️ Pode tudo:** Um método de instância consegue ler tanto as suas próprias variáveis quanto as variáveis estáticas da classe.

## 🎯 Resumo do Resumo

**Precisa guardar e isolar dados? ➡️ Use `new` (Instância).**

**significa que um membro pertence à classe e não a uma instância da classe. Por isso, ele pode ser acessado sem criar um objeto com new.
Diferente dos membros de instância, que cada objeto possui sua própria cópia, os membros static possuem uma única cópia compartilhada por todos os objetos da classe durante a execução da aplicação.
Utilizamos static quando o comportamento ou dado não depende do estado de um objeto específico.**

**É só uma fórmula matemática ou função utilitária? ➡️ Use `static`.**
