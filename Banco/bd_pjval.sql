DROP DATABASE IF EXISTS bd_pjval;
CREATE DATABASE bd_pjval;
USE bd_pjval;


CREATE TABLE login (
 id INT AUTO_INCREMENT PRIMARY KEY,
 usuario varchar(20) NOT NULL UNIQUE,
 senha varchar(10) NOT NULL
 );


CREATE TABLE produtos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(30) NOT NULL UNIQUE,
  estoque INT,
  valor DECIMAL(10,2) NOT NULL
);

CREATE TABLE clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(80) NOT NULL,
  contato VARCHAR(80) UNIQUE,
  data_de_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
  saldo_devedor DECIMAL(10,2) DEFAULT 0
);

CREATE TABLE pedidos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT,
  data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,

  FOREIGN KEY (cliente_id)
  REFERENCES clientes(id)
  ON DELETE CASCADE
  ON UPDATE CASCADE
);

CREATE TABLE itens_pedido (
  id INT AUTO_INCREMENT PRIMARY KEY,
  pedido_id INT,
  produto_id INT,
  quantidade INT,

  FOREIGN KEY (pedido_id)
  REFERENCES pedidos(id)
  ON DELETE CASCADE,

  FOREIGN KEY (produto_id)
  REFERENCES produtos(id)
);

INSERT INTO login (usuario, senha) VALUES
('adm',1234);

INSERT INTO clientes (nome, contato) VALUES
('João Silva','11980000001'),
('Maria Souza','maria.souza@gmail.com'),
('Carlos Oliveira','11980000002'),
('Ana Costa','ana.costa@yahoo.com'),
('Pedro Rocha','11980000003'),
('Lucas Alves','lucas.alves@hotmail.com'),
('Juliana Martins','11980000004'),
('Rafael Gomes','rafael.gomes@gmail.com'),
('Fernanda Ribeiro','11980000005'),
('Bruno Carvalho','bruno.carvalho@gmail.com'),

('Patrícia Dias','11980000006'),
('Ricardo Nunes','ricardo.nunes@gmail.com'),
('Camila Teixeira','11980000007'),
('Felipe Barbosa','felipe.barbosa@yahoo.com'),
('Larissa Araujo','11980000008'),
('Gustavo Freitas','gustavo.freitas@gmail.com'),
('Aline Melo','11980000009'),
('Eduardo Pinto','eduardo.pinto@hotmail.com'),
('Mariana Lopes','11980000010'),
('Thiago Castro','thiago.castro@gmail.com'),

('Roberta Moreira','11980000011'),
('Daniel Cardoso','daniel.cardoso@gmail.com'),
('Beatriz Fernandes','11980000012'),
('Vinicius Correia','vinicius.correia@yahoo.com'),
('Paula Monteiro','11980000013'),
('Andre Duarte','andre.duarte@gmail.com'),
('Tatiane Mendes','11980000014'),
('Leonardo Farias','leonardo.farias@gmail.com'),
('Renata Coelho','11980000015'),
('Diego Pacheco','diego.pacheco@hotmail.com'),

('Vanessa Moraes','11980000016'),
('Igor Batista','igor.batista@gmail.com'),
('Simone Rezende','11980000017'),
('Marcelo Tavares','marcelo.tavares@yahoo.com'),
('Sabrina Cunha','11980000018'),
('Fabio Peixoto','fabio.peixoto@gmail.com'),
('Carla Neves','11980000019'),
('Rodrigo Antunes','rodrigo.antunes@gmail.com'),
('Priscila Braga','11980000020'),
('Alexandre Paiva','alexandre.paiva@hotmail.com'),

('Julio Cesar','11980000021'),
('Daniele Rocha','daniele.rocha@gmail.com'),
('Claudio Rezende','11980000022'),
('Natalia Duarte','natalia.duarte@yahoo.com'),
('Leandro Borges','11980000023'),
('Bianca Furtado','bianca.furtado@gmail.com'),
('Hugo Santana','11980000024'),
('Kelly Ramos','kelly.ramos@gmail.com'),
('Victor Aguiar','11980000025'),
('Paulo Henrique','paulo.henrique@hotmail.com'),

('Renan Lopes','11980000026'),
('Caroline Pires','caroline.pires@gmail.com'),
('Matheus Andrade','11980000027'),
('Jessica Barros','jessica.barros@yahoo.com'),
('Gabriel Ferreira','11980000028'),
('Leticia Cardoso','leticia.cardoso@gmail.com'),
('Vitor Mendes','11980000029'),
('Amanda Vieira','amanda.vieira@gmail.com'),
('Bruna Castro','11980000030'),
('Caio Duarte','caio.duarte@hotmail.com'),

('Douglas Nascimento','11980000031'),
('Elaine Freire','elaine.freire@gmail.com'),
('Fernando Moraes','11980000032'),
('Giovana Batista','giovana.batista@yahoo.com'),
('Heitor Carvalho','11980000033'),
('Isabela Teixeira','isabela.teixeira@gmail.com'),
('Jonathan Araujo','11980000034'),
('Karen Souza','karen.souza@gmail.com'),
('Luiz Felipe','11980000035'),
('Monique Lopes','monique.lopes@hotmail.com'),

('Nicolas Farias','11980000036'),
('Otavio Mendes','otavio.mendes@gmail.com'),
('Priscila Duarte','11980000037'),
('Rafaela Pinto','rafaela.pinto@yahoo.com'),
('Samuel Ribeiro','11980000038'),
('Talita Neves','talita.neves@gmail.com'),
('Ueslei Rocha','11980000039'),
('Vanessa Teixeira','vanessa.teixeira@gmail.com'),
('William Costa','11980000040'),
('Yasmin Martins','yasmin.martins@hotmail.com'),

('Zuleica Ramos','11980000041'),
('Adriano Barbosa','adriano.barbosa@gmail.com'),
('Brenda Freitas','11980000042'),
('Cesar Almeida','cesar.almeida@yahoo.com'),
('Denise Pacheco','11980000043'),
('Elias Moreira','elias.moreira@gmail.com'),
('Flavia Duarte','11980000044'),
('Gilberto Antunes','gilberto.antunes@gmail.com'),
('Helena Castro','11980000045'),
('Ivan Gomes','ivan.gomes@hotmail.com');

INSERT INTO produtos (nome, estoque, valor) VALUES
('Brigadeiro Tradicional', 100, 2.50),
('Brigadeiro Gourmet', 80, 3.50),
('Beijinho', 90, 2.50),
('Cajuzinho', 70, 2.80),
('Trufa de Chocolate', 60, 4.00),
('Trufa de Maracujá', 60, 4.00),
('Trufa de Morango', 60, 4.00),
('Pão de Mel', 50, 5.50),
('Brownie Tradicional', 40, 6.00),
('Brownie com Nutella', 35, 7.50),

('Bolo de Chocolate (fatia)', 30, 6.50),
('Bolo de Cenoura (fatia)', 30, 6.00),
('Bolo de Fubá (fatia)', 25, 5.50),
('Bolo de Laranja (fatia)', 25, 5.50),
('Bolo de Chocolate com Recheio', 20, 7.50),
('Mini Bolo no Pote', 40, 8.00),
('Bolo no Pote de Chocolate', 40, 9.00),
('Bolo no Pote de Morango', 40, 9.00),
('Bolo no Pote de Leite Ninho', 35, 10.00),
('Bolo no Pote de Prestígio', 35, 10.00),

('Cookie Tradicional', 50, 4.00),
('Cookie com Gotas de Chocolate', 50, 4.50),
('Cookie Recheado', 40, 6.00),
('Donut de Chocolate', 30, 5.50),
('Donut de Doce de Leite', 30, 5.50),
('Sonho de Creme', 25, 6.00),
('Sonho de Doce de Leite', 25, 6.00),
('Torta de Limão (fatia)', 20, 7.00),
('Torta de Chocolate (fatia)', 20, 7.50),
('Torta de Morango (fatia)', 20, 7.50),

('Pudim (fatia)', 20, 6.50),
('Mousse de Chocolate', 30, 5.50),
('Mousse de Maracujá', 30, 5.50),
('Geladinho Gourmet', 60, 3.50),
('Geladinho de Chocolate', 60, 3.00),
('Geladinho de Morango', 60, 3.00),
('Geladinho de Leite Ninho', 50, 4.00),
('Churros Simples', 40, 5.00),
('Churros Recheado', 40, 6.50),
('Mini Churros (porção)', 30, 7.00);

-- Pedidos clientes comprando
INSERT INTO pedidos (cliente_id) VALUES
(1),(5),(10),(3),(8),(15),(20),(2),(7),(12),
(25),(30),(4),(6),(9),(11),(13),(14),(16),(18);

-- Itens dos pedidos

INSERT INTO itens_pedido (pedido_id, produto_id, quantidade) VALUES
-- Pedido 1 (cliente 1)
(1,1,4),(1,9,1),

-- Pedido 2
(2,2,6),(2,8,2),

-- Pedido 3
(3,10,2),(3,1,3),

-- Pedido 4
(4,3,5),

-- Pedido 5
(5,17,2),(5,18,1),

-- Pedido 6
(6,19,2),(6,5,3),

-- Pedido 7
(7,21,4),(7,22,2),

-- Pedido 8
(8,24,2),

-- Pedido 9
(9,25,3),(9,1,2),

-- Pedido 10
(10,28,1),(10,29,2),

-- Pedido 11
(11,30,2),

-- Pedido 12
(12,31,2),(12,32,1),

-- Pedido 13
(13,33,3),

-- Pedido 14
(14,34,5),

-- Pedido 15
(15,35,4),(15,36,2),

-- Pedido 16
(16,37,3),

-- Pedido 17
(17,38,2),(17,39,1),

-- Pedido 18
(18,40,2),

-- Pedido 19
(19,6,4),(19,7,2),

-- Pedido 20
(20,9,2),(20,10,1);


