DROP DATABASE IF EXISTS bd_pjval;
CREATE DATABASE bd_pjval;
USE bd_pjval;


CREATE TABLE login (
 id INT AUTO_INCREMENT PRIMARY KEY,
 usuario varchar(20) NOT NULL UNIQUE,
 senha varchar(10) NOT NULL,
 cpf varchar(11) NOT NULL UNIQUE
 );


CREATE TABLE produtos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(80) NOT NULL UNIQUE,
  valor DECIMAL(10,2) NOT NULL
);

CREATE TABLE clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(120) NOT NULL UNIQUE,
  contato VARCHAR(80) NOT NULL UNIQUE,
  data_de_cadastro DATE DEFAULT (CURRENT_DATE)
);

CREATE TABLE pedidos (

    id INT AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    produto_id INT NOT NULL,
    
    quantidade INT NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,
    status_pagamento VARCHAR(20) DEFAULT 'Pendente',

    FOREIGN KEY (cliente_id)
    REFERENCES clientes(id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,

    FOREIGN KEY (produto_id)
    REFERENCES produtos(id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

INSERT INTO login (usuario, senha,cpf) VALUES
   ('adm',1234,12345678900);

INSERT INTO clientes (nome, contato) VALUES

   ('João Silva', '11980000001'),
   ('Maria Souza', '11980000002'),
   ('Carlos Oliveira', '11980000003'),
   ('Ana Costa', '11980000004'),
   ('Pedro Rocha', '11980000005'),
   ('Fernanda Lima', '11980000006'),
   ('Lucas Martins', '11980000007'),
   ('Juliana Alves', '11980000008'),
   ('Rafael Gomes', '11980000009'),
   ('Camila Freitas', '11980000010');

INSERT INTO produtos (nome, valor) VALUES

   ('Brigadeiro Gourmet', 3.50),
   ('Brownie', 7.00),
   ('Pão de Mel', 5.50),
   ('Bolo no Pote', 9.00),
   ('Cookie Recheado', 6.00),
   ('Trufa de Chocolate', 4.00),
   ('Donut', 5.50),
   ('Mini Churros', 7.00),
   ('Torta de Limão', 8.50),
   ('Geladinho Gourmet', 4.50);

INSERT INTO pedidos (cliente_id, produto_id, quantidade, valor_total, status_pagamento) VALUES

   (1, 1, 5, 17.50, 'Pago'),
   (2, 2, 2, 14.00, 'Pendente'),
   (3, 4, 3, 27.00, 'Pago'),
   (4, 3, 4, 22.00, 'Pendente'),
   (5, 5, 6, 36.00, 'Pago'),
   (6, 6, 10, 40.00, 'Pendente'),
   (7, 7, 2, 11.00, 'Pago'),
   (8, 8, 1, 7.00, 'Pago'),
   (9, 9, 2, 17.00, 'Pendente'),
   (10, 10, 8, 36.00, 'Pago'),
   (1, 2, 1, 7.00, 'Pendente'),
   (2, 3, 2, 11.00, 'Pago'),
   (3, 1, 12, 42.00, 'Pago'),
   (4, 5, 3, 18.00, 'Pendente'),
   (5, 4, 2, 18.00, 'Pago'),
   (6, 9, 1, 8.50, 'Pendente'),
   (7, 10, 5, 22.50, 'Pago'),
   (8, 6, 4, 16.00, 'Pago'),
   (9, 7, 3, 16.50, 'Pendente'),
   (10, 8, 2, 14.00, 'Pago');