CREATE DATABASE Lan_House

USE Lan_House

Create Table Tipos_Equipamentos (
	id int NOT NULL IDENTITY(1,1),
	Nome varchar(100) not null,
	 Primary Key(Id)
)



Create Table Tipos_Defeitos (
	id int NOT NULL IDENTITY(1,1),
	Nome varchar(100) not null,
	 Primary Key(Id)
)



Create Table Equipamentos (
	id int NOT NULL IDENTITY(1,1),
	Tipo_Equipamento_ID int not null,
	Data datetime2 not null,
	 Primary Key(Id),
	FOREIGN KEY (Tipo_Equipamento_ID) REFERENCES Tipos_Equipamentos(ID)
)


Create Table Registros_Defeitos (
	id int NOT NULL IDENTITY(1,1),
	Data_Defeito datetime2 not null,
	Tipo_Equipamento_Id int not null,
	Tipo_Defeito_Id int not null,
	Observacao varchar(250) null
	 Primary Key(Id),
	FOREIGN KEY (Tipo_Equipamento_Id) REFERENCES Tipos_Equipamentos(id),
	FOREIGN KEY (Tipo_Defeito_Id) REFERENCES Tipos_Defeitos(id)
)


Create Table Usuarios (
	id int NOT NULL IDENTITY(1,1),
	Email varchar(100) not null,
	Senha varchar(50) not null,
	Primary Key(Id)
)


select * from usuarios