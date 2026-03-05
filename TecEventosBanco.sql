-- Criação do banco de dados
DROP SCHEMA IF EXISTS TecEventos;
CREATE DATABASE IF NOT EXISTS TecEventos;
USE TecEventos;

-- 1. Tabela de Endereços
CREATE TABLE enderecos (
    id INT NOT NULL AUTO_INCREMENT,
    rua VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    bairro VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);

-- 2. Tabela de Usuários
CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(20),
    endereco_id INT,
    PRIMARY KEY (id),
    FOREIGN KEY (endereco_id) REFERENCES enderecos(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 3. Tabela de Regras
CREATE TABLE regras (
    id INT NOT NULL AUTO_INCREMENT,
    descricao TEXT NOT NULL,
    PRIMARY KEY (id)
);

-- 4. Tabela de Políticas
CREATE TABLE politicas (
    id INT NOT NULL AUTO_INCREMENT,
    descricao TEXT NOT NULL,
    PRIMARY KEY (id)
);

-- 5. Tabela de Chácaras
CREATE TABLE chacara (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    endereco_id INT,
    regras_id INT,
    politicas_id INT,
    PRIMARY KEY (id),
    FOREIGN KEY (endereco_id) REFERENCES enderecos(id),
    FOREIGN KEY (regras_id) REFERENCES regras(id),
    FOREIGN KEY (politicas_id) REFERENCES politicas(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 6. Tabela de Valores de Diárias
CREATE TABLE valores_diarias (
    id INT NOT NULL AUTO_INCREMENT,
    valor DECIMAL(10, 2) NOT NULL,
    dia_semana VARCHAR(20) NOT NULL,
    PRIMARY KEY (id)
);

-- 7. Tabela de Associação entre Chácaras e Valores de Diárias
CREATE TABLE chacaras_valores_diarias (
    id INT NOT NULL AUTO_INCREMENT,
    chacara_id INT,
    valor_diaria_id INT,
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    FOREIGN KEY (valor_diaria_id) REFERENCES valores_diarias(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE,
    PRIMARY KEY (id),
    UNIQUE INDEX idx_chacaras_valores_diarias (chacara_id, valor_diaria_id)
);

-- 8. Tabela de Datas Comemorativas
CREATE TABLE datas_comemorativas (
    id INT NOT NULL AUTO_INCREMENT,
    descricao VARCHAR(100),
    valor_promocional_id INT,
    data_comemorativa DATE NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (valor_promocional_id) REFERENCES valores_diarias(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 9. Tabela de Administração (Login)
CREATE TABLE Adm (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INT,
    senha VARCHAR(255) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 10. Tabela de Agendamentos
CREATE TABLE agendamento (
    id INT NOT NULL AUTO_INCREMENT,
    entrada_data DATE NOT NULL,
    saida_data DATE NOT NULL,
    usuario_id INT,
    chacara_id INT,
    valor_agendamento DECIMAL(10, 2) NOT NULL,
    status ENUM('Confirmada', 'Pendente', 'Cancelada'),
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE,
    UNIQUE INDEX idx_agendamento (chacara_id, entrada_data)
    
);

-- 11. Tabela de Controle de Pagamentos
CREATE TABLE controle_pagamentos (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INT,
    chacara_id INT,
    agendamento_id INT,
    valor_pago DECIMAL(10, 2) NOT NULL,
    data_pagamento DATE NOT NULL,
    metodo_pagamento ENUM('PIX', 'Depósito Bancário', 'Cartão Débito', 'Cartão Crédito'),
    status_pagamento ENUM('Pago', 'Pendente', 'Cancelado'),
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id),
    FOREIGN KEY (agendamento_id) REFERENCES agendamento(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 12. Tabela de Disponibilidade
CREATE TABLE disponibilidade (
    id INT NOT NULL AUTO_INCREMENT,
    chacara_id INT,
    data DATE NOT NULL,
    disponivel BOOLEAN NOT NULL DEFAULT TRUE,
    PRIMARY KEY (id),
    FOREIGN KEY (chacara_id) REFERENCES chacara(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE,
    UNIQUE INDEX idx_disponibilidade (chacara_id, data)
);

-- 13. Tabela de Contratos
CREATE TABLE contratos (
    id INT NOT NULL AUTO_INCREMENT,
    agendamento_id INT,
    data_criacao DATE NOT NULL,
    detalhes TEXT NOT NULL,
    assinatura_cliente BOOLEAN NOT NULL DEFAULT FALSE,
    assinatura_proprietario BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (id),
    FOREIGN KEY (agendamento_id) REFERENCES agendamento(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 14. Tabela de Registros de Login
CREATE TABLE LoginRegistro (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    login_datetime DATETIME,
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- 15. Tabela de Registros de Logout
CREATE TABLE LogoutRegistro (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    logout_datetime DATETIME,
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- Inserindo dados na tabela de Endereços
INSERT INTO enderecos (rua, numero, bairro) VALUES 
('Rua Barão de Jaguara', '100', 'Centro'),
('Rua Dr. Quirino', '200', 'Centro'),
('Rua Conceição', '300', 'Cambuí'),
('Rua Emília Paiva Meira', '400', 'Taquaral'),
('Rua José de Alencar', '500', 'Vila Itapura'),
('Avenida Moraes Salles', '600', 'Bosque'),
('Rua Dr. Guilherme da Silva', '700', 'Cambuí'),
('Rua Irmã Serafina', '800', 'Centro'),
('Rua Maria Monteiro', '900', 'Cambuí'),
('Rua Antonio Cesarino', '1000', 'Vila Industrial');


-- Inserindo dados na tabela de Usuários
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'TecEventos', 'teceventos@admin.com', '19998887766', id FROM enderecos WHERE rua = 'Rua Barão de Jaguara';
SELECT 'João Silva', 'joao.silva@example.com', '19998887766', id FROM enderecos WHERE rua = 'Rua Barão de Jaguara';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Maria Oliveira', 'maria.oliveira@example.com', '19997776655', id FROM enderecos WHERE rua = 'Rua Dr. Quirino';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Carlos Pereira', 'carlos.pereira@example.com', '19996665544', id FROM enderecos WHERE rua = 'Rua Conceição';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Ana Souza', 'ana.souza@example.com', '19995554433', id FROM enderecos WHERE rua = 'Rua Emília Paiva Meira';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Pedro Lima', 'pedro.lima@example.com', '19994443322', id FROM enderecos WHERE rua = 'Rua José de Alencar';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Julia Santos', 'julia.santos@example.com', '19993332211', id FROM enderecos WHERE rua = 'Avenida Moraes Salles';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Roberto Costa', 'roberto.costa@example.com', '19992221100', id FROM enderecos WHERE rua = 'Rua Dr. Guilherme da Silva';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Fernanda Almeida', 'fernanda.almeida@example.com', '19991110099', id FROM enderecos WHERE rua = 'Rua Irmã Serafina';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Lucas Martins', 'lucas.martins@example.com', '19990000999', id FROM enderecos WHERE rua = 'Rua Maria Monteiro';
INSERT INTO usuarios (nome, email, telefone, endereco_id) 
SELECT 'Paula Fernandes', 'paula.fernandes@example.com', '19998889988', id FROM enderecos WHERE rua = 'Rua Antonio Cesarino';

-- Inserindo dados na tabela de Regras
INSERT INTO regras (descricao) VALUES 
('Não é permitido música alta após as 22h'),
('É obrigatório o uso de máscaras nas áreas comuns'),
('Proibido fumar dentro das instalações'),
('Animais de estimação são permitidos mediante aviso prévio'),
('Uso da piscina permitido até as 20h'),
('Somente hóspedes registrados podem pernoitar nas dependências'),
('Manter a limpeza dos espaços comuns'),
('É proibido levar toalhas das acomodações'),
('Solicitar autorização para eventos com mais de 10 pessoas'),
('Não é permitido churrasco nas varandas dos apartamentos');


-- Inserindo dados na tabela de Políticas
INSERT INTO politicas (descricao) VALUES 
('Check-in a partir das 14h e check-out até as 12h'),
('Cancelamento gratuito até 48h antes do check-in'),
('Taxa de 50% do valor total em caso de cancelamento tardio'),
('Pagamento de caução no valor de R$500,00 no check-in'),
('Política de privacidade para tratamento de dados pessoais'),
('Reservas confirmadas somente mediante pagamento antecipado de 50% do valor'),
('Proibido estender a estadia sem prévia autorização'),
('Reembolso de 100% em caso de problemas técnicos que não possam ser resolvidos'),
('É necessário documento de identificação para o check-in'),
('Reservas para menores de idade somente acompanhados pelos pais ou responsáveis');


-- Inserindo dados na tabela de Chácaras
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Bela Vista', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Barão de Jaguara' AND r.id = 1 AND p.id = 1;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Paraíso', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Dr. Quirino' AND r.id = 2 AND p.id = 2;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Recanto Feliz', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Conceição' AND r.id = 3 AND p.id = 3;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Flor do Campo', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Emília Paiva Meira' AND r.id = 4 AND p.id = 4;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Sol Nascente', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua José de Alencar' AND r.id = 5 AND p.id = 5;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Raio de Luz', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Avenida Moraes Salles' AND r.id = 6 AND p.id = 6;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Horizonte Verde', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Dr. Guilherme da Silva' AND r.id = 7 AND p.id = 7;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Recanto dos Pássaros', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Irmã Serafina' AND r.id = 8 AND p.id = 8;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Beija-Flor', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Maria Monteiro' AND r.id = 9 AND p.id = 9;
INSERT INTO chacara (nome, endereco_id, regras_id, politicas_id) 
SELECT 'Chácara Jardim das Flores', e.id, r.id, p.id 
FROM enderecos e, regras r, politicas p WHERE e.rua = 'Rua Antonio Cesarino' AND r.id = 10 AND p.id = 10;


-- Inserindo dados na tabela de Valores de Diárias
INSERT INTO valores_diarias (valor, dia_semana) VALUES 
(500.00, 'Segunda-feira'),
(550.00, 'Terça-feira'),
(600.00, 'Quarta-feira'),
(650.00, 'Quinta-feira'),
(700.00, 'Sexta-feira'),
(800.00, 'Sábado'),
(750.00, 'Domingo'),
(900.00, 'Sábado'),
(850.00, 'Domingo'),
(5000.00, 'Feriado'),
(1000.00, 'Sábado');


-- Inserindo dados na tabela de Associação entre Chácaras e Valores de Diárias
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Bela Vista' AND v.dia_semana = 'Segunda-feira';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Paraíso' AND v.dia_semana = 'Terça-feira';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Recanto Feliz' AND v.dia_semana = 'Quarta-feira';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Flor do Campo' AND v.dia_semana = 'Quinta-feira';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Sol Nascente' AND v.dia_semana = 'Sexta-feira';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Raio de Luz' AND v.dia_semana = 'Sábado';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Horizonte Verde' AND v.dia_semana = 'Domingo';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Recanto dos Pássaros' AND v.dia_semana = 'Feriado';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Beija-Flor' AND v.dia_semana = 'Véspera de feriado';
INSERT INTO chacaras_valores_diarias (chacara_id, valor_diaria_id)
SELECT c.id, v.id FROM chacara c, valores_diarias v WHERE c.nome = 'Chácara Jardim das Flores' AND v.dia_semana = 'Ano Novo';

-- Inserindo dados na tabela de Datas Comemorativas
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Natal', id, '2024-12-25' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Ano Novo', id, '2024-01-01' FROM valores_diarias WHERE dia_semana = 'Ano Novo';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Carnaval', id, '2024-02-13' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Páscoa', id, '2024-04-01' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Dia do Trabalho', id, '2024-05-01' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Independência do Brasil', id, '2024-09-07' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Finados', id, '2024-11-02' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Proclamação da República', id, '2024-11-15' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Dia das Crianças', id, '2024-10-12' FROM valores_diarias WHERE dia_semana = 'Feriado';
INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
SELECT 'Dia da Consciência Negra', id, '2024-11-20' FROM valores_diarias WHERE dia_semana = 'Feriado';


-- Inserindo dados na tabela de Administração (Login)
INSERT INTO Adm (usuario_id, senha) 
SELECT id, 'admin' FROM usuarios WHERE email = 'teceventos@admin.com';
INSERT INTO Adm (usuario_id, senha) 
SELECT id, '1234' FROM usuarios WHERE email = 'maria.oliveira@example.com';


-- Inserindo dados na tabela de Agendamentos
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-09-01', '2024-09-05', u.id, c.id, 2500.00, 'Confirmada' 
FROM usuarios u, chacara c WHERE u.email = 'joao.silva@example.com' AND c.nome = 'Chácara Bela Vista';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-10-01', '2024-10-05', u.id, c.id, 2700.00, 'Pendente' 
FROM usuarios u, chacara c WHERE u.email = 'maria.oliveira@example.com' AND c.nome = 'Chácara Paraíso';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-11-01', '2024-11-05', u.id, c.id, 3000.00, 'Cancelada' 
FROM usuarios u, chacara c WHERE u.email = 'carlos.pereira@example.com' AND c.nome = 'Chácara Recanto Feliz';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-12-01', '2024-12-05', u.id, c.id, 3200.00, 'Confirmada' 
FROM usuarios u, chacara c WHERE u.email = 'ana.souza@example.com' AND c.nome = 'Chácara Flor do Campo';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-09-10', '2024-09-15', u.id, c.id, 2900.00, 'Pendente' 
FROM usuarios u, chacara c WHERE u.email = 'pedro.lima@example.com' AND c.nome = 'Chácara Sol Nascente';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-08-20', '2024-08-25', u.id, c.id, 3100.00, 'Confirmada' 
FROM usuarios u, chacara c WHERE u.email = 'julia.santos@example.com' AND c.nome = 'Chácara Raio de Luz';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-07-10', '2024-07-15', u.id, c.id, 2600.00, 'Pendente' 
FROM usuarios u, chacara c WHERE u.email = 'roberto.costa@example.com' AND c.nome = 'Chácara Horizonte Verde';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-06-01', '2024-06-05', u.id, c.id, 2800.00, 'Cancelada' 
FROM usuarios u, chacara c WHERE u.email = 'fernanda.almeida@example.com' AND c.nome = 'Chácara Recanto dos Pássaros';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-05-20', '2024-05-25', u.id, c.id, 2700.00, 'Confirmada' 
FROM usuarios u, chacara c WHERE u.email = 'lucas.martins@example.com' AND c.nome = 'Chácara Beija-Flor';
INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status)
SELECT '2024-04-15', '2024-04-20', u.id, c.id, 2900.00, 'Pendente' 
FROM usuarios u, chacara c WHERE u.email = 'paula.fernandes@example.com' AND c.nome = 'Chácara Jardim das Flores';

-- Inserindo dados na tabela de Controle de Pagamentos
INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento)
SELECT u.id, c.id, a.id, 2500.00, '2024-09-01', 'PIX', 'Pago'
FROM usuarios u
JOIN chacara c ON c.nome = 'Chácara Bela Vista'
JOIN agendamento a ON a.usuario_id = u.id AND a.chacara_id = c.id
WHERE u.email = 'joao.silva@example.com';

INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento)
SELECT u.id, c.id, a.id, 2700.00, '2024-10-02', 'Cartão Crédito', 'Pendente'
FROM usuarios u
JOIN chacara c ON c.nome = 'Chácara Paraíso'
JOIN agendamento a ON a.usuario_id = u.id AND a.chacara_id = c.id
WHERE u.email = 'maria.oliveira@example.com';

INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento)
SELECT u.id, c.id, a.id, 3000.00, '2024-11-03', 'Depósito Bancário', 'Cancelado'
FROM usuarios u
JOIN chacara c ON c.nome = 'Chácara Recanto Feliz'
JOIN agendamento a ON a.usuario_id = u.id AND a.chacara_id = c.id
WHERE u.email = 'carlos.pereira@example.com';

INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento)
SELECT u.id, c.id, a.id, 3200.00, '2024-12-04', 'PIX', 'Pago'
FROM usuarios u
JOIN chacara c ON c.nome = 'Chácara Flor do Campo'
JOIN agendamento a ON a.usuario_id = u.id AND a.chacara_id = c.id
WHERE u.email = 'ana.souza@example.com';

INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento)
SELECT u.id, c.id, a.id, 2900.00, '2024-09-11', 'Cartão Débito', 'Pendente'
FROM usuarios u
JOIN chacara c ON c.nome = 'Chácara Sol Nascente'
JOIN agendamento a ON a.usuario_id = u.id AND a.chacara_id = c.id
WHERE u.email = 'pedro.lima@example.com';


-- Inserindo dados na tabela de Disponibilidade
INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-09-01', FALSE FROM chacara WHERE nome = 'Chácara Bela Vista';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-10-02', TRUE FROM chacara WHERE nome = 'Chácara Paraíso';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-11-03', FALSE FROM chacara WHERE nome = 'Chácara Recanto Feliz';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-12-04', TRUE FROM chacara WHERE nome = 'Chácara Flor do Campo';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-09-11', TRUE FROM chacara WHERE nome = 'Chácara Sol Nascente';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-08-20', FALSE FROM chacara WHERE nome = 'Chácara Raio de Luz';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-07-10', TRUE FROM chacara WHERE nome = 'Chácara Horizonte Verde';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-06-01', FALSE FROM chacara WHERE nome = 'Chácara Recanto dos Pássaros';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-05-20', TRUE FROM chacara WHERE nome = 'Chácara Beija-Flor';

INSERT INTO disponibilidade (chacara_id, data, disponivel)
SELECT id, '2024-04-15', FALSE FROM chacara WHERE nome = 'Chácara Jardim das Flores';


-- Inserindo dados na tabela de Contratos
INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario)
SELECT a.id, '2024-09-01', 'Contrato para locação de Chácara Bela Vista.', TRUE, TRUE 
FROM agendamento a
JOIN chacara c ON a.chacara_id = c.id
WHERE c.nome = 'Chácara Bela Vista';

INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario)
SELECT a.id, '2024-10-01', 'Contrato para locação de Chácara Paraíso.', TRUE, FALSE 
FROM agendamento a
JOIN chacara c ON a.chacara_id = c.id
WHERE c.nome = 'Chácara Paraíso';

INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario)
SELECT a.id, '2024-11-01', 'Contrato para locação de Chácara Recanto Feliz.', FALSE, FALSE 
FROM agendamento a
JOIN chacara c ON a.chacara_id = c.id
WHERE c.nome = 'Chácara Recanto Feliz';

INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario)
SELECT a.id, '2024-12-01', 'Contrato para locação de Chácara Flor do Campo.', TRUE, TRUE 
FROM agendamento a
JOIN chacara c ON a.chacara_id = c.id
WHERE c.nome = 'Chácara Flor do Campo';

INSERT INTO contratos (agendamento_id, data_criacao, detalhes, assinatura_cliente, assinatura_proprietario)
SELECT a.id, '2024-09-10', 'Contrato para locação de Chácara Sol Nascente.', TRUE, TRUE 
FROM agendamento a
JOIN chacara c ON a.chacara_id = c.id
WHERE c.nome = 'Chácara Sol Nascente';


-- Inserindo dados na tabela de Registros de Login
INSERT INTO LoginRegistro (usuario_id, login_datetime) VALUES 
((SELECT id FROM usuarios WHERE nome='João Silva'), '2024-08-01 09:00:00');

-- Inserindo dados na tabela de Registros de Logout
INSERT INTO LogoutRegistro (usuario_id, logout_datetime) VALUES 
((SELECT id FROM usuarios WHERE nome='João Silva'), '2024-08-01 17:00:00');

-- Agendamento
SELECT entrada_data as Entrada, saida_data as Saída, u.nome as Cliente, 
                             u.telefone as Telefone, c.nome as Chacara, 
                             a.valor_agendamento as 'Valor Agendamento', 
                             a.status as 'Status Agendamento' 
                             FROM agendamento a
                             JOIN usuarios u ON u.id = a.usuario_id
                             JOIN chacara c ON c.id = a.chacara_id;

-- Selecionando todos os registros das tabelas

SELECT * FROM enderecos;
SELECT * FROM usuarios;
SELECT * FROM regras;
SELECT * FROM politicas;
SELECT * FROM chacara;
SELECT * FROM valores_diarias;
SELECT * FROM chacaras_valores_diarias;
SELECT * FROM datas_comemorativas;	
SELECT * FROM Adm;
SELECT * FROM agendamento;
SELECT * FROM controle_pagamentos;
SELECT * FROM disponibilidade;
SELECT * FROM contratos;
SELECT * FROM LoginRegistro;
SELECT * FROM LogoutRegistro;
