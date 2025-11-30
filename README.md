# Sistema_GestionFacturacion

Aplicación Windows Forms (target: .NET Framework 4.7.2) para gestión de facturación: pedidos, detalles de pedido, facturación, productos, categorías, descuentos, empleados, cargos, usuarios y roles.

Resumen rápido
- Punto de entrada: `Program.cs` — la aplicación inicia con `Login`.
- Toda la lógica de acceso a base de datos desde la UI debe usar la clase `ConsultasSQL`.
- Las contraseñas se gestionan con PBKDF2 (hash + salt + iteraciones).

Requisitos (para contribuir)
- Visual Studio 2022
- .NET Framework 4.7.2 workload instalado
- Microsoft SQL Server (LocalDB, Express o instancia)
- Configurar la cadena de conexión en `App.config` con la clave `ConexionDB`

Ejemplo `App.config`:



(Hacer backup antes en entornos productivos).

Reglas obligatorias para acceso a BD
- Usar únicamente `ConsultasSQL` desde los formularios / UI para operaciones CRUD.
  - Métodos disponibles: `Buscar`, `Guardar`, `update`, `Eliminar`, `EjecutarConsulta`, `EjecutarComando`.
- Para consultas parametrizadas o columnas binarias (`VARBINARY`) crea un `SqlCommand`, añade parámetros y llama `consulta.EjecutarComando(cmd)`.
- No crear `SqlConnection` / `SqlCommand` directamente en event handlers (btn_Click) en la UI.
- No modificar `Clases\Conexion.cs` salvo que entiendas el impacto global.

Contraseñas seguras
- Guardar contraseñas con PBKDF2: columnas `Clave VARBINARY(...)`, `Sal VARBINARY(...)`, `Iteraciones INT`.
- Siempre usar parámetros (`SqlDbType.VarBinary`) al insertar/actualizar hashes.
- En login: leer `Clave` y `Sal` como `byte[]` y verificar con PBKDF2.

DataGridView y columnas binarias
- Nunca mostrar columnas `Clave`, `Sal` o similares en `DataGridView`.
- Excluir esas columnas en el SELECT o eliminar columnas del `DataTable` antes de asignar `dgv.DataSource`.


Buenas prácticas de implementación
- Validar entrada en la UI y delegar consultas a `ConsultasSQL`.
- Evitar concatenación de SQL con valores directos; usar siempre parámetros cuando sea posible.
- En actualizaciones usar el Id (PK) en el `WHERE`.
- Usar soft-delete (`Estado` = `Activo`/`Inactivo`) en tablas maestras.

Roles y permisos en la UI
- El login devuelve `Rol` (p. ej. `Administrador`, `Empleado`).
- `FormMenu` recibe `(id, rol, nombre, apellido)` y actualiza `lblUsuario` con:
  - `Bienvenido {nombre} {apellido}, {rol}`
- `FormMenu` habilita/deshabilita botones según rol:
  - Administrador: accesos a todos los formularios (Pedidos, DetallesPedidos, Facturas, Cargos, Empleados, Productos, Categorias, Descuento, Usuarios, Roles).
  - Empleado: accesos limitados (por ejemplo: Pedidos, DetallesPedidos, Facturas).
- Evitar abrir duplicados: usar `AbrirFormHijo(Form child)`/chequear `Application.OpenForms`.

Cómo ejecutar la solución localmente
1. Clonar repositorio y abrir solución en Visual Studio 2022.
2. Actualizar `App.config` > `connectionStrings` > `ConexionDB`, dependiendo de tu integración en visual y Gestor de base de Datos.
3. Ejecutar scripts SQL en la base de datos (entorno de pruebas).
4. Compilar y ejecutar (F5). La app inicia en `Login` (ver `Program.cs`).

Pruebas básicas después de levantar el sistema
- Crear roles (`Administrador`, `Empleado`) si no existen.
- Crear usuario administrador (UI o script).
- Iniciar sesión como admin: `FormMenu` debe habilitar botones de administrador.
- Iniciar sesión como empleado: verificar botones restringidos.
- Probar CRUD de productos/categorías/descuentos; crear pedido y factura.

Flujo de trabajo Git / Pull Requests
- Rama por tarea: `feature/<short-desc>` o `bugfix/<id>-<short>`.
- Commits claros: `feat(users): add password hashing when creating user`
- Flujo:
  - `git checkout -b feature/mi-tarea`
  - `git add . && git commit -m "Caracteristica: ..."`
  - `git push origin feature/mi-tarea`
  - Abrir PR en GitHub con descripción y pasos para probar.
- En el PR incluir: qué se cambió y por qué, scripts SQL (si aplica), pasos para probar localmente.

Notas de mantenimiento
- Centralizar cambios en `ConsultasSQL` para logging o transacciones.
- Considerar cifrar la cadena de conexión en `App.config` para seguridad extra.

Contacto / revisión de código
- Al abrir PR etiqueta a los revisores y añade checklist: scripts DB ejecutados, pruebas locales, formularios afectados.

Colocar este `README.md` en la raíz del repositorio y mantenerlo actualizado cuando cambien esquema o patrones de acceso a BD.