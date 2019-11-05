Create database Lan_House;

USE Lan_House;

INSERT INTO Usuario
VALUES ('admin@email.com', '123456');



INSERT INTO Defeito (dataDefeito, observacao, tipoDefeitoId, equipamentoId)
VALUES		('2017-01-03 00:00:00', 'Aparelho não liga, fonte ligada',1,1),
			('2018-01-03 00:00:00', 'O aparelho desliga do nada',2,2),
			('2019-01-03 00:00:00', 'Não da sinal de imagem',3,1),
			('2019-02-03 00:00:00', 'Não conecta a internet',4,3),
			('2016-01-03 00:00:00', 'Fonte não liga',5,2),
			('2018-01-03 00:00:00', 'HD cheio',6,3);

INSERT INTO TipoDefeito VALUES('Não liga'), ('Desligando'), ('Imagem'), ('Internet'), ('Fonte'), ('HD');

INSERT INTO Defeito VALUES('2017-01-03 00:00:00' , 'Aparelho não liga, fonte ligada' ,1, 1) , ('2018-01-03 00:00:00' , 'O aparelho desliga do nada' ,2,2), ('2019-01-03 00:00:00', 'Não da sinal de imagem',1,3), ('2019-02-03 00:00:00',  'Não conecta a internet' ,3, 3), ('2016-01-03 00:00:00', 'Fonte não liga'  ,2, 2), ('2018-01-03 00:00:00' , 'HD cheio' , 3, 1);

Select * FROM Defeito

INSERT INTO Equipamento VALUES('XBOX ONE'), ('PLAYSTATION 4'), ('NINTENDO WII');

INSERT INTO Equipamentos VALUES(1, '1900-01-01 00:00:00'), (2, '1900-01-01 00:00:00'), (3, '2017-01-03 00:00:00');