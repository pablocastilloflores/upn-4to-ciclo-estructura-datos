# MesaTech - Sistema de Gestión de Tickets

Proyecto desarrollado en la Semana 1 del curso de Estructura de Datos, como parte del 4to ciclo en la Universidad Privada del Norte.

## 📖 Descripción

Aplicación de escritorio (Windows Forms) que simula un sistema de gestión de tickets de soporte para una empresa. El proyecto implementa una **lista enlazada** como estructura de datos principal para almacenar y gestionar los tickets, en lugar de usar colecciones nativas de .NET, con el objetivo de reforzar los conceptos fundamentales de estructuras de datos.

## ⚙️ Funcionalidades

- Registro de nuevos tickets
- Validación de datos de los tickets
- Gestión de tickets mediante lista enlazada (inserción, recorrido, búsqueda)

## 🛠️ Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET (Windows Forms)
- **Estructura de datos:** Lista enlazada (implementación propia)

## 📁 Estructura del código

- `Form1.cs` / `Form1.Designer.cs` — Interfaz gráfica principal
- `Nodo.cs` — Definición del nodo de la lista enlazada
- `ListaEnlazadaTickets.cs` — Implementación de la lista enlazada
- `Ticket.cs` — Modelo de datos del ticket
- `TicketValidador.cs` — Lógica de validación de tickets

## ▶️ Cómo ejecutarlo

1. Clona el repositorio
2. Abre `MesaTechGestionTickets.Lab1.sln` en Visual Studio
3. Ejecuta el proyecto (F5)

## 💡 Aprendizajes

Este laboratorio permitió reforzar la implementación manual de una lista enlazada, entendiendo su funcionamiento interno (nodos, referencias, recorrido) en lugar de depender de estructuras ya construidas del lenguaje.
