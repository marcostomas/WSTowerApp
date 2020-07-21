USE WSTower
GO

INSERT INTO TipoUsuario(Titulo) VALUES
('Admnistrador'),('Comum');
GO

INSERT INTO Usuario(NomeUsuario,Email,Senha,Telefone,idTipoUsuario) VALUES
('Douglas','Douglas@gmail.com','123123','40028922',1),
('Andre','Andre@gmail.com','123123','1243234234',2),
('Marcos','Marcos@gmail.com','123123','70070074534',2),
('Thiago','Thiago@gmail.com','123123','1312342422',2);
GO

INSERT INTO Estadio(NomeEstadio,Endereco) VALUES 
('Estádio Cícero Pompeu de Toledo','Praça Roberto Gomes Pedrosa, 1 - Morumbi, São Paulo - SP, 05653-070'),
('Allianz Parque','Av. Francisco Matarazzo, 1705 - Água Branca, São Paulo - SP, 05001-200'),
('Estádio Jornalista Mário Filho','Av. Pres. Castelo Branco, Portão 3 - Maracanã, Rio de Janeiro - RJ, 20271-130'),
('Mané Garrincha','SRPN - Asa Norte, Brasília - DF, 70070-701');
GO

INSERT INTO Times(Nome) VALUES
('São Paulo'),('Palmeiras'),('Corinthans'),('Santos'),('Flamengo'),('Ituano'),('Gremio'),('Fluminence'),('Vasco'),('Chapecoense'),('Portuguesa');
GO

INSERT INTO TipoParticipacao(TituloParticipacao) VALUES
('Transmissão Ao Vivo'),('Para Assitir no local'),('Para participar');
GO

INSERT INTO TipoEvento(NomeTipoEvento) VALUES
('Futebol'),('E-Sports'),('Show');
GO

select * from Estadio
select * from Usuario
select * from TipoUsuario
select * from TipoEvento
select * from TipoParticipacao
select * from Times