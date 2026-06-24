# Encapsulamento em C#: resumo breve

Encapsulamento é o princípio da programação orientada a objetos que protege o estado interno de um objeto controlando acesso a seus dados por meio de membros (propriedades e métodos) públicos, privados ou com níveis de acesso intermediários. Ele promove coesão e ocultação de implementação, forçando uso de interfaces estáveis (getters/setters, propriedades) e reduzindo acoplamento entre componentes.

## Regras e pontos essenciais

- Use níveis de acesso (private, protected, internal, public) para expor apenas o necessário; dados sensíveis devem ser private.

- Propriedades (auto-implemented ou com lógica em get/set) permitem validar valores, disparar eventos ou manter invariantes ao atribuir ou ler campos.

- Métodos públicos compõem a API do objeto; a lógica interna fica escondida, o que facilita refatoração sem quebrar consumidores.

- Encapsulamento melhora segurança, testabilidade e manutenção, porque mudanças internas não afetam código que usa o objeto.

- Combine encapsulamento com imutabilidade quando apropriado (readonly, propriedades somente leitura) para simplificar invariantes e concorrência.

## Exemplo curto (descrição)

- Campo privado: `private int age;` com propriedade pública controlada: `public int Age { get => age; set { if (value >= 0) age = value; } }`.

## Diferença relacionada

Encapsulamento não é o mesmo que abstração; encapsulamento controla acesso e protege estado, enquanto abstração foca em representar apenas os aspectos relevantes de um objeto.

## Definição rápida (duas linhas) — leitura rápida

Encapsulamento em C# é proteger o estado interno de um objeto usando níveis de acesso e propriedades para controlar leitura/escrita.

Isso garante controle sobre invariantes e reduz acoplamento, melhorando manutenção e segurança.
