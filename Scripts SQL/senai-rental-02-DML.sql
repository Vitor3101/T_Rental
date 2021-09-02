USE T_Rental_Vitor

INSERT INTO EMPRESA(NomeEmpresa) VALUES ('Rental')

INSERT INTO MARCA(NomeMarca) VALUES ('GM'),('Fiat'),('Hyundai')

INSERT INTO MODELO(NomeModelo, idMarca) VALUES ('Celta',1),('Punto',2),('HB20',3),('Creta',1)

INSERT INTO VEICULO(idModelo, idEmpresa) VALUES (1,1),(3,1),(1,1),(2,1),(4,1)

INSERT INTO CLIENTE(Nome, Sobrenome, CPF) VALUES ('Vitor','Luiz',01234567890)

INSERT INTO ALUGUEL(idCliente, idVeiculo) VALUES (1,2)