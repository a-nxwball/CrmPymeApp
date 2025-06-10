# Configuración de Protección de Ramas

## Recomendaciones para GitHub

### 1. Proteger la rama `main`:
- Ve a Settings > Branches
- Agrega una regla para `main`
- Activa las siguientes opciones:
  - ✅ Require a pull request before merging
  - ✅ Require status checks to pass before merging
  - ✅ Require branches to be up to date before merging
  - ✅ Require linear history
  - ✅ Include administrators

### 2. Configurar Status Checks:
- Require branches to be up to date before merging
- Require status checks to pass before merging

### 3. Configurar Review Requirements:
- Require pull request reviews before merging
- Require review from code owners
- Dismiss stale PR approvals when new commits are pushed

### 4. Configurar Restrictions:
- Restrict pushes that create files larger than 100 MB
- Restrict pushes that create files with certain extensions

## Workflow Recomendado

1. **Crear rama feature**: `git checkout -b feature/nueva-funcionalidad`
2. **Desarrollar cambios**: Hacer commits con mensajes descriptivos
3. **Crear Pull Request**: Con descripción detallada usando la plantilla
4. **Review automático**: GitHub Actions ejecuta tests
5. **Review manual**: Revisar código y aprobar
6. **Merge**: Solo después de aprobación

## Configuración de Code Owners

Crear archivo `.github/CODEOWNERS`:
```
# Estos usuarios serán solicitados para review automáticamente
* @a-nxwball

# Archivos específicos
*.md @a-nxwball
.github/ @a-nxwball 