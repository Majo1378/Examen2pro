# Examen2 - Gestión de Reservas (Laboratorios de Cómputo)

Este proyecto es una implementación mínima de la aplicación solicitada para el caso "Gestión de Reservas - Laboratorios de Cómputo".

## Qué incluye
- Proyecto ASP.NET Core MVC (.NET 8) con modelos, repositorio en memoria, controlador y vistas Create/Index.
- Validaciones con DataAnnotations y validaciones manuales en el repositorio (fecha, horas, código único, solapamientos).
- Diagrama de flujo en `diagrams/gestion_reservas_flowchart.drawio.xml`.
- Script de comandos Git para crear la rama `feature/caso1` y hacer ≥3 commits (`git_commands.sh`).

## Instrucciones rápidas (local)
1. Clona el repositorio remoto en tu máquina:

```bash
git clone https://github.com/Majo1378/Examen2.git
cd Examen2
```

2. Copia los archivos entregados en la carpeta del repo o reemplaza el contenido.

3. Crear la rama del caso y hacer commits (ejemplo):

```bash
# crea y cámbiate a la rama
git checkout -b feature/caso1

# 1) Agregar modelo y repositorio
git add Models Data Examen2.csproj Program.cs
git commit -m "feat(caso1): agregar modelo Reservation y repositorio en memoria"

# 2) Agregar controlador y vistas
git add Controllers Views
git commit -m "feat(caso1): agregar ReservationsController y vistas Create/Index"

# 3) Ajustes y validaciones manuales
git add .
git commit -m "fix(caso1): validaciones adicionales (fecha, horas, código único, solapamientos)"

# subir rama
git push -u origin feature/caso1
```

> Asegúrate de tener configurado tu usuario de Git (`git config user.name` y `git config user.email`) si es necesario.

## Diagrama
El archivo `diagrams/gestion_reservas_flowchart.drawio.xml` contiene el diagrama en formato importable en diagrams.net.

## Notas
- El repositorio en memoria es `Singleton` para mantener los datos durante la ejecución.
- Este proyecto es funcional como plantilla; puede necesitar adaptaciones según tu entorno (Visual Studio/CLI) y soporte para validación cliente (unobtrusive) si lo deseas.
