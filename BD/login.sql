create database login2
 use login2

 CREATE TABLE Usuario(
Usuario VARCHAR(25) PRIMARY KEY NOT NULL,
CONTRASEÑA VARCHAR(25),
ROLL VARCHAR(25)
)

INSERT USUARIO VALUES
('fer@gmail.com','1234','Administrador')
INSERT USUARIO VALUES
('jose@gmail.com','12346','usuario')
INSERT USUARIO VALUES
('sergio@gmail.com','12347','secretario')

CREATE TABLE ADMINISTRADOR
(ID INT NOT NULL PRIMARY KEY,
USUARIO VARCHAR(25),
CONTRASEÑA VARCHAR(25),
ROL VARCHAR(25))

INSERT ADMINISTRADOR VALUES
('01', 'jose@gmail.com', 12345, 'administrador')
INSERT ADMINISTRADOR VALUES
('02', 'jared@gmail.com', 123456, 'cliente')
INSERT ADMINISTRADOR VALUES
('03', 'sergio@gmail.com', 123457, 'secretario')
INSERT ADMINISTRADOR VALUES
('04', 'sebas@gmail.com', 123458, 'administrador')

select * from ADMINISTRADOR

