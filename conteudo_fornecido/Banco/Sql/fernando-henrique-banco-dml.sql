
bulk insert Tipos_Equipamentos from 'E:\Projetos_Internos\Senai\Saep_Pratico\Treinamento-1\csv\tipo_equipamento.csv' with (fieldterminator = ',', rowterminator = '\n', firstrow = 1, codepage = 'acp')

bulk insert Tipos_Defeitos from 'E:\Projetos_Internos\Senai\Saep_Pratico\Treinamento-1\csv\defeito.csv' with (fieldterminator = ',', rowterminator = '\n', firstrow = 1, codepage = 'acp')

bulk insert Equipamentos from 'E:\Projetos_Internos\Senai\Saep_Pratico\Treinamento-1\csv\equipamento.csv' with (fieldterminator = ',', ROWTERMINATOR = '0x0a', firstrow = 1, codepage = 'acp')

bulk insert Registros_Defeitos from 'E:\Projetos_Internos\Senai\Saep_Pratico\Treinamento-1\csv\registro_defeito.csv' with (fieldterminator = ',', ROWTERMINATOR = '0x0a', firstrow = 1, codepage = 'acp')

insert into Usuarios values('admin@email.com', '123456')
