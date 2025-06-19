

---

#  Trabalho Final — Arquitetura de Software: Sistema de Pedidos

##  Alunas

* Eunice de Borba
* Katleen Mendes
* Maria Laura Jeronimo
* Vitória Viana

---

##  Propósito do Sistema

Desenvolver o **back-end de uma loja virtual de sapatos infantis**, com funcionalidades como:

* Cadastro e gerenciamento de produtos
* Controle de pedidos
* Gerenciamento de dados dos clientes

Utilizando **arquitetura de microsserviços** com as seguintes tecnologias:

* NET
* SQLite
* API RESTful

---

##  Usuários do Sistema

* **Clientes**: podem visualizar e realizar pedidos de produtos.
* **Administradores**: responsáveis pelo cadastro e gerenciamento de produtos e pedidos.

---

##  Requisitos Funcionais

| Código   | Descrição                                                                         |
| -------- | --------------------------------------------------------------------------------- |
| **R1** | O sistema deve permitir o **cadastro de produtos** (sapatinhos).                  |
| **R2** | O sistema deve permitir o **cadastro de clientes**.                               |
| **R3** | O sistema deve permitir o **registro de pedidos** por parte dos clientes.         |
| **R4** | O sistema deve permitir **buscar dados de um produto** (nome, tamanho, estoque).  |
| **R5** | O sistema deve permitir **buscar dados de um cliente**.                           |
| **R6** | O sistema deve **atualizar o estoque** do produto após a realização de um pedido. |

---

##  Arquitetura de Microsserviços

###  Microsserviço 1: Catálogo de Produtos

**Função:** Gerenciar os produtos disponíveis para venda.

**Endpoints:**

* `GET /produtos/{id}` — Buscar produto por ID
* `GET /produtos` — Listar todos os produtos
* `POST /produtos` — Cadastrar novo produto

---

###  Microsserviço 2: Cadastro de Clientes

**Função:** Gerenciar os dados dos clientes da loja.

**Endpoints:**

* `GET /clientes/{id}` — Buscar cliente por ID

---

###  Microsserviço 3: Pedidos

**Função:** Registrar e gerenciar os pedidos dos clientes.

**Funcionalidades:**

* Registrar pedido
* Integrar com o MS de Clientes para buscar dados do cliente
* Integrar com o MS de Produtos para buscar dados do produto
* Atualizar o estoque do produto após confirmação do pedido

**Endpoints:**

* `POST /pedidos` — Criar novo pedido
* `GET /pedidos/{id}` — Buscar pedido por ID

---

##  Integração entre Microsserviços

| Integração           | Descrição                                        |
| -------------------- | ------------------------------------------------ |
| **Pedido → Cliente** | Buscar dados do cliente no momento do pedido     |
| **Pedido → Produto** | Buscar dados do produto (nome, tamanho, estoque) |
| **Pedido → Produto** | Atualizar o estoque do produto após o pedido     |

---

