SELECT * FROM Alumnos 
--where apellido in ('Armstrong', 'Rios') and nombre like '%a%'
--order by curso DESC, apellido ASC

DELETE FROM Alumnos WHERE legajo in 
(SELECT legajo FROM Alumnos where apellido in ('Armstrong', 'Rios'))

INSERT INTO Alumnos(legajo, nombre, apellido, curso)
(SELECT 1, nombre, 'Rios', curso FROM Alumnos where apellido like 'ra%')

UPDATE Alumnos SET curso = 2 WHERE legajo = 
(SELECT legajo FROM alumnos where legajo < 10)

SELECT min(legajo) from Alumnos

SELECT AVG(curso) from Alumnos

SELECT SUM(curso) from Alumnos

SELECT curso, nombre from Alumnos GROUP BY curso, nombre
having nombre like 'a%'

SELECT A.legajo AS ID, A.nombre, A.apellido, C.nombre, P.nombre, P.apellido
from Alumnos A INNER JOIN Cursos C on A.curso = C.id
	INNER JOIN Profesores P ON C.profesor = P.legajo



