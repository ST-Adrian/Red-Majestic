# Governance - Red Majestic

## 1. Propósito

Este documento define las reglas de trabajo para el desarrollo del proyecto Red Majestic.

El proyecto consiste en una aplicación de consola desarrollada en C# con .NET 10 como prueba de concepto académica.

El objetivo de esta gobernanza es mantener un proceso de desarrollo simple, trazable y consistente utilizando GitHub, Git y herramientas de inteligencia artificial.

---

## 2. Fuente de verdad

GitHub será la fuente de verdad del proyecto.

La información del proyecto se distribuirá de la siguiente manera:

- `README.md`: descripción general del proyecto.
- `docs/REQUIREMENTS.md`: requerimientos proporcionados para el proyecto.
- `docs/GOVERNANCE.md`: reglas de trabajo y desarrollo.
- `AGENTS.md`: instrucciones generales para agentes de inteligencia artificial.
- `.github/copilot-instructions.md`: instrucciones específicas para GitHub Copilot.
- GitHub Issues: tareas de desarrollo.
- Pull Requests: revisión e integración de cambios.

Los agentes de inteligencia artificial no deben inventar, modificar ni eliminar requerimientos.

---

## 3. Prioridad de los requerimientos

Los requerimientos académicos tienen prioridad sobre alternativas de implementación consideradas mejores prácticas.

Si un requerimiento exige específicamente una estructura, tipo de dato o mecanismo del lenguaje, deberá respetarse.

Ejemplos:

- Si se solicita `float`, no debe reemplazarse por `decimal`.
- Si se solicita `switch`, debe utilizarse `switch`.
- Si se solicita `while`, no debe reemplazarse por `for` o `foreach`.
- Si se solicita un vector, no debe reemplazarse por una lista.
- Si se solicita `List<float>`, debe utilizarse ese tipo.
- Si se solicita `Dictionary<int, float>`, debe utilizarse ese tipo.

La finalidad académica del proyecto tiene prioridad sobre refactorizaciones que alteren estas decisiones.

---

## 4. Ambigüedades

Si existe una contradicción o ambigüedad en los requerimientos, no deberá resolverse silenciosamente mediante una suposición.

La decisión deberá:

1. identificarse;
2. documentarse;
3. utilizar la interpretación más consistente con los requerimientos técnicos;
4. evitar modificar comportamiento no solicitado.

Para los identificadores de tarjetas se utilizarán los valores establecidos explícitamente en los requerimientos técnicos:

- Visa: `4407`
- Mastercard: `3890`
- Diners Club: `7401`

---

## 5. Flujo de desarrollo

Todo cambio funcional deberá originarse en una GitHub Issue.

El flujo esperado es:

1. Crear o seleccionar una Issue.
2. Crear una branch asociada a la Issue.
3. Implementar únicamente el alcance indicado.
4. Revisar y ejecutar la aplicación.
5. Crear un Pull Request.
6. Revisar los cambios.
7. Integrar el Pull Request en `main`.

No se desarrollarán nuevas funcionalidades directamente sobre `main`.

---

## 6. Branches

La branch `main` representa la versión estable del proyecto.

Las funcionalidades se desarrollarán en branches independientes.

Formato recomendado:

`feat/<descripcion>`

Ejemplos:

- `feat/main-menu`
- `feat/card-validation`
- `feat/visa-transactions`
- `feat/mastercard-transactions`
- `feat/diners-transactions`

Las correcciones podrán utilizar:

`fix/<descripcion>`

---

## 7. Issues

Cada Issue debe representar una tarea concreta y verificable.

Siempre que sea posible deberá indicar:

- requerimiento o requerimientos relacionados;
- objetivo;
- comportamiento esperado;
- restricciones técnicas;
- criterios de aceptación.

Una Issue no debe ampliar el alcance definido por los requerimientos originales.

---

## 8. Pull Requests

Todo cambio funcional deberá integrarse mediante Pull Request.

Cada Pull Request deberá:

- indicar qué Issue resuelve;
- describir brevemente los cambios realizados;
- indicar los requerimientos afectados;
- confirmar que el proyecto compila;
- confirmar que el comportamiento fue verificado.

El Pull Request debe contener solamente cambios relacionados con la tarea correspondiente.

---

## 9. Uso de inteligencia artificial

Las herramientas de inteligencia artificial actúan como asistentes de desarrollo.

La IA puede:

- analizar una Issue;
- proponer una implementación;
- escribir código;
- explicar código;
- detectar errores;
- realizar correcciones solicitadas.

La IA no puede:

- modificar los requerimientos por iniciativa propia;
- agregar funcionalidades no solicitadas;
- cambiar tecnologías del proyecto;
- introducir librerías innecesarias;
- reemplazar estructuras exigidas por los requerimientos;
- realizar refactorizaciones fuera del alcance de una Issue;
- modificar la gobernanza sin autorización.

Las decisiones finales corresponden al desarrollador.

---

## 10. Simplicidad

El proyecto debe mantenerse acorde con el alcance académico de una aplicación de consola.

Se evitarán salvo requerimiento explícito:

- arquitecturas por capas innecesarias;
- patrones de diseño innecesarios;
- dependencias externas;
- frameworks adicionales;
- abstracciones que no aporten al cumplimiento de los requerimientos;
- sobreingeniería.

El código debe ser comprensible y justificable por el estudiante.

---

## 11. Criterio de finalización

Una tarea se considera terminada cuando:

- cumple los requerimientos asociados;
- respeta las estructuras exigidas;
- el proyecto compila correctamente;
- el comportamiento esperado fue comprobado;
- no incorpora cambios fuera de alcance;
- el Pull Request fue revisado y aprobado.