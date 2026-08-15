# Projeto Valquíria

Sistema desktop para **gestão de pedidos, clientes, produtos e controle financeiro de encomendas**, desenvolvido em **C# com Windows Forms e MySQL**.

O projeto foi desenvolvido originalmente em um contexto acadêmico durante o curso de **Programador de Sistemas**, tendo como objetivo atender às necessidades de gestão de encomendas de doces e salgados de um comércio.

---

## 📌 Visão Geral

O **Projeto Valquíria** é uma aplicação desktop desenvolvida para centralizar e simplificar o gerenciamento de pedidos e vendas.

O sistema permite cadastrar clientes e produtos, registrar pedidos, acompanhar pagamentos e visualizar informações gerais por meio de um painel administrativo.

Além das funcionalidades de negócio, o projeto conta com recursos de autenticação, recuperação de credenciais, validações de dados, tratamento de exceções e registro de erros.

---

## 🎯 Objetivos

* Centralizar o gerenciamento de clientes, produtos e pedidos.
* Facilitar o controle de encomendas.
* Automatizar o cálculo dos valores dos pedidos.
* Permitir o acompanhamento de pagamentos pendentes.
* Disponibilizar autenticação e recuperação de acesso.
* Aplicar conceitos de programação orientada a objetos, banco de dados e desenvolvimento de aplicações desktop.
* Desenvolver uma solução prática para uma necessidade real de negócio.

---

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET Framework**
* **Windows Forms**
* **MySQL**
* **MySQL Workbench**
* **SMTP / Gmail** para envio de códigos de autenticação
* **Git / GitHub**

---

# ⚙️ Requisitos do Sistema

## Hardware e Software

| Requisito           | Especificação           |
| ------------------- | ----------------------- |
| Sistema Operacional | Windows 10 ou superior  |
| Plataforma          | .NET Framework          |
| Banco de Dados      | MySQL Server            |
| E-mail              | Serviço SMTP compatível |
| Interface           | Windows Forms           |

---

# ✨ Funcionalidades

## 👤 Gestão de Usuários

* Login por e-mail e senha.
* Cadastro inicial de usuário.
* Validação de e-mail.
* Recuperação de senha.
* Alteração de e-mail.
* Geração de códigos temporários de verificação.
* Controle de tempo para reenvio de códigos.
* Armazenamento de senhas utilizando hash SHA-256.

## 👥 Gestão de Clientes

* Cadastro de clientes.
* Edição de informações.
* Consulta de clientes.
* Validação de telefone e e-mail.
* Registro da data de cadastro.

## 📦 Gestão de Produtos

* Cadastro de produtos.
* Edição de produtos.
* Consulta do catálogo.
* Definição de preços.
* Validação de nomes duplicados.
* Edição de múltiplos registros.

## 🧾 Gestão de Pedidos

* Registro de pedidos.
* Associação entre clientes e produtos.
* Cálculo automático do valor total.
* Controle de quantidade.
* Definição da data do pedido.
* Controle do status de pagamento.
* Edição e exclusão de registros.
* Identificação de pagamentos pendentes.

## 📊 Dashboard

O painel principal apresenta uma visão geral das operações do sistema, incluindo:

* Pedidos pendentes.
* Quantidade de produtos cadastrados.
* Quantidade de clientes.
* Valor acumulado de pagamentos pendentes.
* Lista de clientes com pagamentos pendentes.
* Data e hora em tempo real.

---

# 🏗️ Arquitetura de Módulos

O sistema está dividido em módulos de acordo com suas principais responsabilidades.

## 🔐 Módulo de Autenticação e Segurança

### `frmLogin`

Tela responsável pelo acesso ao sistema.

**Principais funcionalidades:**

* Validação de login e senha.
* Conversão da senha para hash SHA-256.
* Consulta das credenciais no banco de dados.
* Controle da sessão ativa.
* Redirecionamento para o painel principal.
* Exibição/ocultação da senha.
* Acesso à recuperação de senha e cadastro de usuário.
* Verificação da conexão com o banco de dados.

---

### `frmCadastrarLogin`

Responsável pelo cadastro inicial de usuários.

**Principais funcionalidades:**

* Validação do endereço de e-mail.
* Geração de código aleatório de 6 dígitos.
* Validade de 10 minutos para o código.
* Armazenamento temporário do código.
* Controle de reenvio com intervalo de 2 minutos.
* Geração de hash SHA-256 para a senha.
* Efetivação do cadastro após validação do código.

---

### `frmEsqueciSenha`

Responsável pela recuperação das credenciais.

**Principais funcionalidades:**

* Verificação da existência do e-mail cadastrado.
* Envio de código de recuperação.
* Contagem regressiva para reenvio.
* Validação do código dentro do período de validade.
* Atualização das credenciais no banco de dados.

---

### `frmAtualizarEmail`

Responsável pela alteração do e-mail associado ao usuário.

**Principais funcionalidades:**

* Validação do e-mail atual.
* Validação do novo e-mail.
* Envio de códigos independentes de confirmação.
* Controle de reenvio dos códigos.
* Prevenção de cadastro de e-mails duplicados.
* Tratamento do erro MySQL `1062`.

---

# 💼 Módulo de Operações

## `frmHome`

Painel principal e dashboard do sistema.

**Principais funcionalidades:**

* Exibição de data e hora em tempo real.
* Consulta de pagamentos pendentes.
* Destaque visual para valores devedores acima de R$ 99,00.
* Exibição de estatísticas gerais.
* Navegação para os demais módulos.
* Encerramento seguro da aplicação.

---

## `frmProdutos`

Gerenciador do catálogo de produtos.

**Principais funcionalidades:**

* Exibição dos produtos em `DataGridView`.
* Formatação monetária em padrão brasileiro.
* Cadastro e edição de produtos.
* Limitação do nome a 80 caracteres.
* Prevenção de nomes duplicados.
* Validação de valores positivos.
* Limite de R$ 999,00 por produto.
* Edição de múltiplos registros.

---

## `frmClientes`

Gerenciador da base de clientes.

**Principais funcionalidades:**

* Cadastro de clientes.
* Edição de informações.
* Consulta de clientes.
* Nomes com até 120 caracteres.
* Validação de telefone.
* Validação de e-mail.
* Exibição da data de cadastro.
* Identificação do dia da semana correspondente à data de cadastro.

---

## `frmPedidos`

Gerenciador de pedidos e encomendas.

**Principais funcionalidades:**

* Seleção de clientes e produtos.
* Preenchimento automático de informações.
* Cálculo automático do valor total.
* Limite de R$ 1.500,00 por pedido.
* Controle de quantidade de até 999 unidades.
* Alteração do status entre **Pago** e **Pendente**.
* Edição de datas, quantidades e itens.
* Exclusão de pedidos.
* Validação da existência de clientes e produtos no banco de dados.

---

# 🔒 Segurança

O sistema possui mecanismos básicos de segurança para proteção das credenciais e validação dos usuários.

### Hash de Senhas

As senhas não são armazenadas diretamente no banco de dados. Antes da gravação, são convertidas utilizando **SHA-256**.

### Verificação por E-mail

Algumas operações utilizam códigos temporários enviados por e-mail para confirmar a identidade do usuário.

Os códigos possuem prazo de validade e controle de reenvio.

### Validação de Credenciais

Em caso de credenciais inválidas, o sistema apresenta uma mensagem genérica ao usuário, evitando expor informações desnecessárias sobre a existência ou não de determinados usuários.

> **Observação:** o projeto possui finalidade acadêmica e demonstrativa. As práticas de segurança implementadas não devem ser consideradas suficientes, isoladamente, para um sistema de produção de alta criticidade.

---

# 🛡️ Tratamento de Erros

O sistema possui tratamento de exceções para diferentes situações.

| Situação                     | Comportamento                                      |
| ---------------------------- | -------------------------------------------------- |
| Campos obrigatórios vazios   | Destaque visual e mensagem de alerta               |
| Credenciais inválidas        | Mensagem genérica ao usuário                       |
| Falha na conexão com o banco | Mensagem informativa e encerramento seguro da tela |
| Falha no envio de e-mail     | Interceptação da exceção e aviso ao usuário        |
| Registro duplicado           | Tratamento de erros do MySQL, incluindo `1062`     |
| Exceções inesperadas         | Registro técnico em arquivo de log                 |

Os erros inesperados são registrados no arquivo:

```text
erros.log
```

O registro contém informações técnicas utilizadas para auxiliar na identificação e correção de problemas.

---

# ⚡ Performance e Usabilidade

O projeto possui algumas implementações voltadas à experiência do usuário e à eficiência das consultas.

### Debounce nas pesquisas

As caixas de pesquisa utilizam um mecanismo de **debounce de 500 ms**, evitando a execução excessiva de consultas ao banco enquanto o usuário está digitando.

### Interface

A interface utiliza componentes padronizados e uma classe utilitária denominada `UIHelper` para auxiliar na aplicação da identidade visual dos formulários e controles.

---

# 🗄️ Banco de Dados

O sistema utiliza **MySQL** para armazenamento das informações.

Entre os principais dados gerenciados estão:

* Usuários;
* Clientes;
* Produtos;
* Pedidos;
* Dados temporários utilizados nos processos de autenticação.

O projeto contém o script do banco de dados para auxiliar na configuração do ambiente de desenvolvimento.

---

# 📂 Estrutura Geral

Uma representação simplificada dos principais componentes do sistema:

```text
Projeto Valquíria/
│
├── Forms/
│   ├── frmLogin
│   ├── frmCadastrarLogin
│   ├── frmEsqueciSenha
│   ├── frmAtualizarEmail
│   ├── frmHome
│   ├── frmProdutos
│   ├── frmClientes
│   └── frmPedidos
│
├── Classes/
│   └── UIHelper
│
├── BD/
│   └── bd_pjval.sql
│
├── erros.log
│
└── ...
```

> A estrutura acima representa a organização conceitual do projeto. Os nomes e diretórios podem variar de acordo com a versão do código presente no repositório.

---

# 🎓 Contexto Acadêmico

O **Projeto Valquíria** foi desenvolvido como parte de um projeto acadêmico durante o curso de **Programador de Sistemas**.

A proposta consistiu no desenvolvimento de uma solução computacional baseada em uma necessidade real de negócio, permitindo aplicar na prática conceitos de:

* Lógica de programação;
* Programação em C#;
* Programação Orientada a Objetos;
* Desenvolvimento de aplicações Windows Forms;
* Banco de dados relacionais;
* SQL;
* Validação de dados;
* Autenticação;
* Tratamento de exceções;
* Integração com serviços de e-mail;
* Controle de versão com Git.

O projeto também serviu como oportunidade para trabalhar com requisitos de software e transformar necessidades de um usuário em funcionalidades de um sistema.

---

# 🚀 Execução do Projeto

Para executar o projeto em ambiente de desenvolvimento, é necessário possuir:

1. Windows 10 ou superior;
2. Visual Studio compatível com o projeto;
3. .NET Framework utilizado pela aplicação;
4. MySQL Server;
5. Banco de dados configurado a partir do script SQL;
6. Configuração das credenciais de conexão com o banco;
7. Configuração do serviço SMTP utilizado para envio de e-mails.

> **Importante:** credenciais de banco de dados, senhas de e-mail e outras informações sensíveis não devem ser armazenadas diretamente no repositório.

---

# 📄 Licença

Este projeto é disponibilizado para fins de **estudo, demonstração e portfólio**, conforme os termos definidos no arquivo [`LICENSE`](LICENSE).

---

# 👨‍💻 Sobre o Projeto

**Projeto Valquíria**
Sistema desktop de gestão de pedidos e vendas.

Desenvolvido em contexto acadêmico utilizando **C#, Windows Forms e MySQL**.
