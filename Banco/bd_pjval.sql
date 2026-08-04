DROP DATABASE IF EXISTS bd_pjval;
CREATE DATABASE bd_pjval;
USE bd_pjval;

	CREATE TABLE cadastro_temp (
		id INT AUTO_INCREMENT PRIMARY KEY,
		email VARCHAR(250) NOT NULL,
		reset_code VARCHAR(10) NOT NULL,
		reset_expiration DATETIME NOT NULL,
		reset_last_sent DATETIME NOT NULL
	);
    
    CREATE TABLE cadastro_tempN (
		id INT AUTO_INCREMENT PRIMARY KEY,
		email VARCHAR(250) NOT NULL,
		reset_code VARCHAR(10) NOT NULL,
		reset_expiration DATETIME NOT NULL,
		reset_last_sent DATETIME NOT NULL
	);

-- Tabela de login preparada para SHA256
CREATE TABLE login (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(20) NOT NULL UNIQUE,
    senha CHAR(64) NOT NULL,
    email VARCHAR(250) NOT NULL UNIQUE
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
    data_de_cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE pedidos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT NOT NULL,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP,
    status_pagamento VARCHAR(20) DEFAULT 'Pendente',
    FOREIGN KEY (cliente_id) REFERENCES clientes(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (produto_id) REFERENCES produtos(id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- 70 clientes
INSERT INTO clientes (nome, contato) VALUES
-- Personagens de filmes
('Harry Potter','harry@hogwarts.com'),
('Hermione Granger','11987654321'),
('Ron Weasley','ron@hogwarts.com'),
('Tony Stark','11912345678'),
('Bruce Wayne','bruce@wayne.com'),
('Clark Kent','11922220001'),
('Peter Parker','peter@spiderman.com'),
('Darth Vader','11944440002'),
('Luke Skywalker','luke@rebellion.com'),
('Leia Organa','11966660003'),
('Yoda','yoda@jedi.com'),
('Shrek','11988880004'),
('Fiona','fiona@swamp.com'),
('Donkey','11900001005'),
('Neo','neo@matrix.com'),
('Morpheus','11933330006'),
('Trinity','trinity@matrix.com'),
('John Wick','11955550007'),
('Walter White','walter@heisenberg.com'),
('Jesse Pinkman','11977770008'),

-- Artistas brasileiros
('Anitta','anitta@email.com'),
('Ivete Sangalo','11999990009'),
('Luan Santana','luan@email.com'),
('Zezé Di Camargo','11911110010'),
('Luciano Huck','huck@email.com'),
('Xuxa Meneghel','11933330011'),
('Roberto Carlos','rcarlos@email.com'),
('Caetano Veloso','11955550012'),
('Gilberto Gil','gil@email.com'),
('Chico Buarque','11977770013'),
('Marília Mendonça','marilia@email.com'),
('Gusttavo Lima','11988880014'),
('Michel Teló','michel@email.com'),
('Paula Fernandes','11900001015'),
('Sandy','sandy@email.com'),
('Junior Lima','11922220016'),
('Fábio Porchat','porchat@email.com'),
('Whindersson Nunes','11944440017'),
('Tirullipa','tirullipa@email.com'),
('Zeca Pagodinho','11966660018'),

-- Jogadores da Seleção
('Alisson Becker','alisson@cbf.com'),
('Ederson Moraes','11933330019'),
('Endrick','endrick@palmeiras.com'),
('Vinícius Júnior','vinijr@realmadrid.com'),
('Neymar Jr','11988880020'),
('Casemiro','casemiro@manutd.com'),
('Lucas Paquetá','11922220021'),
('Douglas Santos','douglas@zenit.com'),
('Gabriel Magalhães','gabriel@arsenal.com'),
('Marquinhos','marquinhos@psg.com'),

-- Personagens de jogos
('Mario','mario@nintendo.com'),
('Luigi','luigi@nintendo.com'),
('Princess Peach','peach@nintendo.com'),
('Bowser','11911110022'),
('Yoshi','yoshi@nintendo.com'),
('Donkey Kong','11933330023'),
('Link','link@hyrule.com'),
('Zelda','11955550024'),
('Ganondorf','11977770025'),
('Sonic','sonic@sega.com'),
('Tails','tails@sega.com'),
('Knuckles','11988880026'),
('Shadow','shadow@sega.com'),
('Lara Croft','lara@tombraider.com'),
('Master Chief','chief@halo.com'),
('Kratos','kratos@godofwar.com'),
('Atreus','atreus@godofwar.com'),
('Geralt de Rívia','geralt@witcher.com'),
('Ciri','ciri@witcher.com'),
('Pikachu','pikachu@pokemon.com');
 



-- 20 produtos típicos de confeitaria
INSERT INTO produtos (nome, valor) VALUES
('Bolo de Chocolate', 35.00),
('Bolo de Cenoura com Cobertura', 28.00),
('Torta de Limão', 32.00),
('Torta Holandesa', 40.00),
('Cheesecake de Frutas Vermelhas', 45.00),
('Pudim de Leite', 20.00),
('Brigadeiro Gourmet', 3.50),
('Beijinho', 3.00),
('Coxinha', 6.00),
('Empada de Frango', 5.50),
('Quindim', 4.50),
('Sonho com Creme', 7.00),
('Donut com Cobertura', 8.00),
('Macaron', 5.00),
('Cupcake de Baunilha', 6.50),
('Brownie de Chocolate', 9.00),
('Palha Italiana', 6.00),
('Pastel de Nata', 7.50),
('Croissant', 6.00),
('Éclair de Chocolate', 8.50);


DELIMITER $$

CREATE PROCEDURE gerar_pedidos_aleatorios()
BEGIN
    DECLARE i INT DEFAULT 1;
    DECLARE cliente INT;
    DECLARE produto INT;
    DECLARE qtd INT;
    DECLARE preco DECIMAL(10,2);
    DECLARE total DECIMAL(10,2);
    DECLARE status VARCHAR(20);

    WHILE i <= 150 DO
        -- Cliente aleatório entre 1 e 70
        SET cliente = FLOOR(1 + (RAND() * 70));
        -- Produto aleatório entre 1 e 20
        SET produto = FLOOR(1 + (RAND() * 20));
        -- Quantidade aleatória entre 1 e 5
        SET qtd = FLOOR(1 + (RAND() * 5));

        -- Pega preço do produto
        SELECT valor INTO preco FROM produtos WHERE id = produto;

        -- Calcula valor total
        SET total = preco * qtd;

        -- Define status aleatório
        IF RAND() < 0.5 THEN
            SET status = 'Pago';
        ELSE
            SET status = 'Pendente';
        END IF;

        -- Insere pedido
        INSERT INTO pedidos (cliente_id, produto_id, quantidade, valor_total, status_pagamento)
        VALUES (cliente, produto, qtd, total, status);

        SET i = i + 1;
    END WHILE;
END$$

DELIMITER ;

-- Executa procedure para gerar os 150 pedidos
CALL gerar_pedidos_aleatorios();
