CREATE OR REPLACE DATABASE mascotas CHARACTER SET UTF8MB4 COLLATE 'utf8mb4_spanish_ci';

CREATE TABLE IF NOT EXISTS mascota (
	id int PRIMARY KEY AUTO_INCREMENT, 
	tipo varchar(50),
	razo VARCHAR(100),
	descripcion VARCHAR(200),
 	alimentacion VARCHAR(150),
 	disponibilidad boolean);

