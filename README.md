# Desafio-Dio-Construindo-um-Sistema-de-Hospedagem-de-um-Hotel-no-CSharp



## **Projeto Cadastro de Funcionários**

#### **Objetivo:**

 Criar um sistema de cadastro de funcionários usando ASP.NET Core e Entity Framework Core.



#### **Estrutura do Projeto:**

- Controllers:

  - FuncionariosController: Controla as operações CRUD para funcionários.

- Models:

  - Funcionario: Representa um funcionário com propriedades como nome, email e telefone.

- Contexto do Banco de Dados:

  - CadastroFuncionariosContext: Gerencia a conexão com o banco de dados e define o conjunto de entidades.

    

- Páginas Razor:

  - Index: Página inicial que lista todos os funcionários.
  - Create: Página para criar um novo funcionário.
  - Edit: Página para editar um funcionário existente.
  - Delete: Página para deletar um funcionário.



### **Implementação:**



### **Controllers:**

Os controllers definem as ações que podem ser realizadas no sistema. Nosso `FuncionariosController` lida com operações CRUD para funcionários.



#### **Models:**

Os models representam as entidades do nosso sistema. Nosso model `Funcionario` possui propriedades para nome, email e telefone.



#### **Contexto do Banco de Dados:**

O contexto do banco de dados gerencia a conexão com o banco de dados e define o conjunto de entidades. Nosso `CadastroFuncionariosContext` define o conjunto de entidades como `Funcionario`.



#### **Páginas Razor:**

As páginas Razor são usadas para exibir dados e permitir que os usuários interajam com o sistema. Nossas páginas Razor incluem:

- **Index:** Lista todos os funcionários em uma tabela.
- **Create:** Permite que os usuários criem um novo funcionário.
- **Edit:** Permite que os usuários editem um funcionário existente.
- **Delete:** Permite que os usuários excluam um funcionário.



#### **Uso:**

Para usar o sistema, você pode:

1. Criar um novo banco de dados e adicionar a string de conexão no arquivo `appsettings.json`.
2. Executar o projeto.
3. Navegue até a página inicial (`/`) para ver a lista de funcionários.
4. Clique no botão "Novo" para criar um novo funcionário.
5. Preencha o formulário e clique em "Criar" para salvar o novo funcionário.
6. Você pode editar ou excluir funcionários clicando nos botões correspondentes.



### **Conclusão:**

Este projeto fornece um sistema básico de cadastro de funcionários usando ASP.NET Core e Entity Framework Core. Ele demonstra como criar, ler, atualizar e excluir dados em um banco de dados relacional.



## Desafio de projeto

Para este desafio, precisamos usar nosso conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.



## Contexto

<p> Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.</p>

<p> O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.</p>



## Regras e validações

1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

