#!/bin/bash
# Script de ejemplo para crear rama feature/caso1 y hacer >=3 commits (ejecutar en el repo local)

# 1. Crear rama y cambiar
git checkout -b feature/caso1

# 2. Commit 1: agregar modelo y repositorio
git add Models Data Examen2.csproj Program.cs
git commit -m "feat(caso1): agregar modelo Reservation y repositorio en memoria"

# 3. Commit 2: agregar controlador y vistas
git add Controllers Views
git commit -m "feat(caso1): agregar ReservationsController y vistas Create/Index"

# 4. Commit 3: ajustes y validaciones
git add .
git commit -m "fix(caso1): validaciones adicionales y diagrama"

# 5. Subir rama
git push -u origin feature/caso1

echo "Rama feature/caso1 creada y cambios empujados (si tienes permisos y remoto configurado)."
