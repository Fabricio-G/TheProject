
SET IDENTITY_INSERT [dbo].[Vista] ON 

GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (1, N'Perfil', N'Gestión de perfiles')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (6, N'Usuario', N'Gestión de usuarios')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (7, N'Parametro', N'Gestión de parámetros')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (8, N'Auditoria', N'Gestión de audotría')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (9, N'Marca', N'Gestion de marcas')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (10, N'Categoria', N'Gestion de categorias')
GO
INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (11, N'Empleados', N'Gestion de empleados')
GO
SET IDENTITY_INSERT [dbo].[Vista] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (3, N'Listado de usuarios', N'Index', 6)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (4, N'Crear usuario', N'Create', 6)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (5, N'Editar usuario', N'Edit', 6)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (6, N'Eliminar usuario', N'Delete', 6)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (7, N'Listado de perfiles', N'Index', 1)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (8, N'Crear perfil', N'Create', 1)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (9, N'Editar perfil', N'Edit', 1)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (10, N'Eliminar perfil', N'Delete', 1)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (11, N'Ver parámetros', N'Index', 7)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (12, N'Editar parámetro', N'Edit', 7)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (13, N'Ver auditoría', N'Index', 8)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (14, N'Ver marca', N'Index', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (15, N'Crear marca', N'Create', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (16, N'Editar marca', N'Edit', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (17, N'Eliminar marca', N'Delete', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (18, N'Listado categorias', N'Index', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (19, N'Crear categoria', N'Create', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (20, N'Editar Categoria', N'Edit', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (21, N'Eliminar Categoria', N'Delete', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (22, N'Listado empleado', N'Index', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (23, N'Crear empleado', N'Create', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (24, N'Editar empleado', N'Edit', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (27, N'Eliminar empleado', N'Delete', 11)
GO
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

GO
INSERT [dbo].[Rol] ([RolId], [Codigo], [Nombre]) VALUES (1, N'ADM', N'Administrador')
GO
INSERT [dbo].[Rol] ([RolId], [Codigo], [Nombre]) VALUES (2, NULL, N'Test')
GO
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 3)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 4)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 5)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 6)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 7)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 8)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 9)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 10)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 11)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 12)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 13)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 14)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 15)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 16)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 17)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 18)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 19)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 20)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 21)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 22)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 23)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 24)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 27)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 3)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 5)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 13)
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

GO
INSERT [dbo].[Usuario] ([UsuarioId], [Apellido], [Contrasena], [ContrasenaActualizada], [Email], [Habilitado], [Nombre], [TSCreado], [TSEliminado], [TSModificado]) VALUES (2, N'Gatica', N'vNfmOJQYQTEL4XmHsWpSIw==', 1, N'damian13.fg@gmail.com', 1, N'Fabricio', CAST(0x070000000000F83E0B AS DateTime2), NULL, CAST(0x07D20AA3EDA4613F0B AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[UsuarioRol] ([RolId], [UsuarioId]) VALUES (1, 2)
GO
SET IDENTITY_INSERT [dbo].[Parametro] ON 

GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (1, N'General', N'AppTitle', N'Nombre de la app', N'Sistema Ventas')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (2, N'Mail', N'TiempoExpiracionTokenMail', N'Tiempo en minutos de expiración del token del email.', N'60')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (3, N'Path', N'UrlFrontend', N'Url del directorio donde se encuentran las imagenes', N'definir')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (4, N'General', N'BaseUrlBackend', N'Url backend', N'http://localhost:51249/')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (6, N'Mails', N'Servidor', N'Servidor de donde saldrán los mails', N'smtp.gmail.com')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (7, N'Mails', N'Puerto', N'Indica el puerto del servidor de correo', N'25')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (9, N'Mails', N'Usuario', N'Indica el usuario de la cuenta', N'emailparatest.system@gmail.com')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (10, N'Mails', N'Contraseña', N'Indica contraseña de la cuenta', N'123456789+a')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (11, N'Mails', N'RemitenteNombre', N'Indica el from(quien envía el mail)', N'test@test.com')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (12, N'Path', N'PathMailing', N'Indica la ruta de la plantilla .html del mail', N'C:\Users\fabricio.gatica\Documents\System\System.BackEnd\wwwroot\mailing')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (28, N'Mails', N'MetodoEnvio', N'Forma de envio', N'Mailgun')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (29, N'Mails', N'Remitente', N'Indica el remitente ', N'test@test.com')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (30, N'Mail', N'EnableSsl', N'Indica si se va a usar enable', N'1')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (1001, N'Mail', N'MailSoporte', N'Mail soporte de System', N'system@system.com')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (1002, N'Key', N'MailGunApiKey', N'Key para la api de mailgun', N'a2286cabbc9925fb744a1e8ddfe44a00-52cbfb43-be443208')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (1003, N'Dominio', N'MailGunDominio', N'Dominio para la api de mailgun', N'sandbox0b005a61b6fa4f85a2e803de056b6886.mailgun.org')
GO
INSERT [dbo].[Parametro] ([ParametroId], [Categoria], [Clave], [Descripcion], [Valor]) VALUES (1004, N'Path', N'UrlApiMailgun', N'Url api de mailgun', N'https://api.mailgun.net/v3')
GO
SET IDENTITY_INSERT [dbo].[Parametro] OFF
GO
--SET IDENTITY_INSERT [dbo].[UsuarioToken] ON 

--GO
--INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (1, CAST(0x077FA0D9AE9AF83E0B AS DateTime2), N'7d3d9ea2-18e7-42f5-b0fc-f6fccfb169fb', 0, 2)
--GO
--INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (2, CAST(0x072FF29B20A9073F0B AS DateTime2), N'58311fcd-abe4-4a58-bd9c-f3f881c97707', 0, 2)
--GO
--INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (3, CAST(0x075600383AB2073F0B AS DateTime2), N'402c4c8e-0428-4544-a184-ac617a91a164', 0, 2)
--GO
--SET IDENTITY_INSERT [dbo].[UsuarioToken] OFF
--GO
