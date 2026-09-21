# AGENTS.md - Red Majestic

## Propósito

Este archivo define las instrucciones generales que deben seguir los agentes de inteligencia artificial que trabajen sobre el repositorio Red Majestic.

El proyecto es una aplicación de consola académica desarrollada en C# con .NET 10.

Los agentes deben priorizar el cumplimiento exacto de los requerimientos académicos por encima de refactorizaciones, abstracciones o mejoras no solicitadas.

---

## 1. Fuente de verdad

Antes de realizar cambios, revisar:

- `docs/REQUIREMENTS.md`
- `docs/GOVERNANCE.md`

Los requerimientos documentados allí tienen prioridad sobre interpretaciones propias del agente.

No modificar requerimientos ni gobernanza salvo que la tarea lo solicite explícitamente.

---

## 2. Alcance de trabajo

Cada tarea debe limitarse al alcance definido por la Issue correspondiente.

No realizar cambios adicionales por iniciativa propia.

No agregar funcionalidades no solicitadas.

No realizar refactorizaciones fuera del alcance de la tarea.

No modificar archivos no relacionados con la Issue salvo que sea necesario para completar correctamente la implementación.

---

## 3. Restricciones académicas

El proyecto evalúa conceptos específicos del lenguaje C#.

Por lo tanto, no reemplazar estructuras o tipos exigidos por alternativas consideradas mejores prácticas.

Deben respetarse especialmente:

- `int` para la opción seleccionada.
- `string` para el número de tarjeta.
- `string` para el identificador.
- `string` para los últimos cuatro dígitos.
- `switch` para la validación general.
- `float[]` para las transacciones Visa.
- `List<float>` para las transacciones Mastercard.
- `Dictionary<int, float>` para las transacciones Diners Club.
- `while` para mostrar transacciones Visa.
- `do-while` para mostrar transacciones Mastercard.
- `foreach` para mostrar transacciones Diners Club.
- `for` para cargar las colecciones de transacciones.

No sustituir estas decisiones por otras estructuras.

---

## 4. Simplicidad

Mantener la implementación simple y acorde al nivel académico del proyecto.

Evitar salvo requerimiento explícito:

- patrones de diseño innecesarios;
- arquitectura por capas;
- interfaces innecesarias;
- clases adicionales sin necesidad;
- librerías externas;
- frameworks adicionales;
- inyección de dependencias;
- abstracciones prematuras;
- sobreingeniería.

El código debe ser fácil de leer, explicar y justificar.

---

## 5. Ambigüedades

Si se detecta una contradicción o ambigüedad en los requerimientos:

1. no inventar una solución silenciosamente;
2. consultar `docs/REQUIREMENTS.md`;
3. consultar `docs/GOVERNANCE.md`;
4. utilizar la interpretación documentada;
5. si sigue existiendo ambigüedad, informarla antes de realizar un cambio que afecte comportamiento.

Para los identificadores se utilizarán:

- Visa: `4407`
- Mastercard: `3890`
- Diners Club: `7401`

---

## 6. Flujo esperado

Antes de implementar:

1. Leer la Issue.
2. Identificar los requerimientos relacionados.
3. Revisar `docs/REQUIREMENTS.md`.
4. Revisar las restricciones aplicables.
5. Modificar únicamente lo necesario.

Después de implementar:

1. comprobar que el proyecto compile;
2. revisar el comportamiento de la funcionalidad;
3. comprobar que se respetaron las estructuras exigidas;
4. informar brevemente qué cambios fueron realizados;
5. indicar cualquier supuesto o limitación detectada.

---

## 7. Código

El código debe:

- utilizar nombres claros;
- mantener una estructura simple;
- evitar duplicación innecesaria;
- respetar las funciones exigidas por los requerimientos;
- evitar comentarios obvios o excesivos;
- evitar código muerto;
- evitar cambios puramente cosméticos fuera del alcance de la tarea.

No cambiar la tecnología del proyecto.

No cambiar la versión de .NET.

---

## 8. Validación

Un agente no debe considerar una tarea terminada únicamente porque el código fue escrito.

Debe comprobar, cuando sea posible:

- que el proyecto compile;
- que la funcionalidad solicitada esté presente;
- que la implementación respete el requerimiento correspondiente;
- que no se hayan introducido cambios fuera de alcance.

Si no puede realizar alguna comprobación, debe indicarlo claramente.

---

## 9. Comportamiento esperado del agente

El agente debe actuar como implementador de una tarea definida, no como propietario del producto.

Debe:

- seguir instrucciones;
- mantener el alcance;
- respetar los requerimientos;
- informar problemas;
- evitar decisiones arquitectónicas no solicitadas.

Las decisiones finales corresponden al desarrollador.

---

## 10. Git y control de versiones

Los agentes pueden ejecutar operaciones Git necesarias para completar una tarea.

Antes de realizar operaciones Git, deben:

1. revisar el estado actual del repositorio;
2. comprobar si existen cambios locales sin commit;
3. evitar sobrescribir o descartar trabajo no relacionado;
4. confirmar que no están trabajando directamente sobre `main`.

Los agentes pueden:

- crear una branch de trabajo;
- cambiar a la branch correspondiente;
- consultar `git status`;
- consultar diferencias con `git diff`;
- agregar archivos al staging;
- crear commits;
- realizar push de la branch de trabajo;
- consultar el historial Git.

Los agentes no deben:

- realizar commits directamente sobre `main`;
- realizar push directo a `main`;
- ejecutar merge hacia `main`;
- utilizar `force push`;
- reescribir el historial;
- eliminar branches remotas sin autorización;
- descartar cambios locales del desarrollador que no formen parte de la tarea.

Cuando una Issue especifique una branch, debe utilizarse esa branch.

Si la Issue no especifica una branch, utilizar:

- `feat/<descripcion>` para funcionalidades;
- `fix/<descripcion>` para correcciones.

Los commits deben ser pequeños, claros y relacionados únicamente con la tarea actual.

Ejemplos:

- `feat: add main menu`
- `feat: implement card validation`
- `feat: add visa transactions`
- `fix: correct invalid option handling`

Antes de finalizar una tarea, el agente debe informar:

- branch utilizada;
- archivos principales modificados;
- commit creado;
- resultado de compilación;
- validaciones realizadas;
- cualquier problema o limitación encontrada.

El agente no debe realizar el merge final hacia `main`.