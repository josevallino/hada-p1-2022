Jose Vallino García

PRÁCTICA 1: USO DE GIT

Pregunta 1:
indica el último commit a recuperar

Pregunta 2: 
se ha modificado el índice, cambia el compromiso al que apunta la cabeza de la rama actualmente.

Pregunta 3:
- git revert: toma un commit específico y crea un nuevo commit con el contenido del commit
especificado.

- git reset:  Un reset es una operación que toma un commit específico y restablece el historial
para que coincida con el estado del repositorio en ese commit específico.

Pregunta 4:
- git merge mantiene a salvo la historia de la rama secundaria, ya que crea un nuevo commit 
  que une ambas ramas sin "eliminarlas", creando un nuevo punto de continuación que tiene 2
  historias por detrás.
- git rebase no mantiene a salvo la historia de la rama secundaria, sino que reescribe la 
  historia de la rama principal integrando los commits de la rama secundaria en la rama
  principal, no crea un commit de unión adicional, sino que cambia el HEAD al última commit
  que ubica.  
