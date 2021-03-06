USE [System_1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoria](
	[AuditoriaId] [int] IDENTITY(1,1) NOT NULL,
	[Action] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Entity] [nvarchar](max) NULL,
	[EntityId] [nvarchar](max) NULL,
	[Habilitado] [bit] NOT NULL,
	[TSCreate] [datetime2](7) NULL,
	[TSEliminado] [datetime2](7) NULL,
	[TSModificado] [datetime2](7) NULL,
	[TransactionId] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Auditoria] PRIMARY KEY CLUSTERED 
(
	[AuditoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametro](
	[ParametroId] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [nvarchar](max) NULL,
	[Clave] [nvarchar](max) NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Valor] [nvarchar](max) NULL,
 CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED 
(
	[ParametroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[PermisoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Funcionalidad] [nvarchar](max) NULL,
	[VistaId] [int] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[PermisoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[BreveDescripcion] [nvarchar](max) NULL,
	[Cantidad] [int] NOT NULL,
	[Categoria] [nvarchar](max) NULL,
	[Codigo] [int] NOT NULL,
	[Estado] [nvarchar](max) NULL,
	[Imagen] [nvarchar](max) NULL,
	[Marca] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Precio] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RolPermiso]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolPermiso](
	[RolId] [int] NOT NULL,
	[PermisoId] [int] NOT NULL,
 CONSTRAINT [PK_RolPermiso] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC,
	[PermisoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](max) NULL,
	[Contrasena] [nvarchar](max) NULL,
	[ContrasenaActualizada] [bit] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Habilitado] [bit] NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[TSCreado] [datetime2](7) NOT NULL,
	[TSEliminado] [datetime2](7) NULL,
	[TSModificado] [datetime2](7) NULL,
	[Token] [nvarchar](max) NULL,
	[TokenExpiration] [datetime2](7) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioRol]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioRol](
	[RolId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioRol] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC,
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioToken]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioToken](
	[UsuarioTokenId] [int] IDENTITY(1,1) NOT NULL,
	[FechaExpiracion] [datetime2](7) NOT NULL,
	[Token] [nvarchar](max) NULL,
	[Usado] [bit] NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioToken] PRIMARY KEY CLUSTERED 
(
	[UsuarioTokenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vista]    Script Date: 07/12/2018 9:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vista](
	[VistaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Vista] PRIMARY KEY CLUSTERED 
(
	[VistaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181119174725_AddNewColumInUsuario', N'2.0.1-rtm-125')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181204220934_InsertTableProducto', N'2.0.1-rtm-125')
GO
SET IDENTITY_INSERT [dbo].[Auditoria] ON 

GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (1, N'Insert', CAST(0x074EE62A6292F83E0B AS DateTime2), N'Nuevo registro en la tabla UsuarioToken', N'UsuarioToken', NULL, 1, CAST(0x07AEC9356292F83E0B AS DateTime2), NULL, NULL, N'ba2a6b27-e24c-4c82-a6c9-342de55ac74e', N'fabricio.gatica', N'{
  "UsuarioTokenId": 1,
  "Token": "7d3d9ea2-18e7-42f5-b0fc-f6fccfb169fb",
  "UsuarioId": 2,
  "Usado": false,
  "FechaExpiracion": "2018-11-19T18:27:15.8461567-03:00"
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (2, N'Insert', CAST(0x07F311F71A93F83E0B AS DateTime2), N'Nuevo registro en la tabla Rol', N'Rol', NULL, 1, CAST(0x071599F71A93F83E0B AS DateTime2), NULL, NULL, N'ced31ede-d1f0-4cba-b62e-a2950c6c4634', N'fabricio.gatica', N'{
  "RolId": 2,
  "Nombre": "Test",
  "Codigo": null
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (3, N'Insert', CAST(0x07F311F71A93F83E0B AS DateTime2), N'Nuevo registro en la tabla RolPermiso', N'RolPermiso', NULL, 1, CAST(0x0742FAF71A93F83E0B AS DateTime2), NULL, NULL, N'ced31ede-d1f0-4cba-b62e-a2950c6c4634', N'fabricio.gatica', N'{
  "PermisoId": 3,
  "RolId": 2
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (4, N'Insert', CAST(0x07F311F71A93F83E0B AS DateTime2), N'Nuevo registro en la tabla RolPermiso', N'RolPermiso', NULL, 1, CAST(0x078CFFF71A93F83E0B AS DateTime2), NULL, NULL, N'ced31ede-d1f0-4cba-b62e-a2950c6c4634', N'fabricio.gatica', N'{
  "PermisoId": 5,
  "RolId": 2
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (5, N'Insert', CAST(0x07F311F71A93F83E0B AS DateTime2), N'Nuevo registro en la tabla RolPermiso', N'RolPermiso', NULL, 1, CAST(0x07C503F81A93F83E0B AS DateTime2), NULL, NULL, N'ced31ede-d1f0-4cba-b62e-a2950c6c4634', N'fabricio.gatica', N'{
  "PermisoId": 13,
  "RolId": 2
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (6, N'Insert', CAST(0x0707AE3C2693F83E0B AS DateTime2), N'Nuevo registro en la tabla UsuarioRol', N'UsuarioRol', NULL, 1, CAST(0x07621A3D2693F83E0B AS DateTime2), NULL, NULL, N'f23dd40e-1487-4e27-8654-caa1deef363b', N'fabricio.gatica', N'{
  "UsuarioId": 2,
  "RolId": 2
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (7, N'Delete', CAST(0x0707AE3C2693F83E0B AS DateTime2), N'Registro eliminado de la tabla UsuarioRol', N'UsuarioRol', NULL, 1, CAST(0x0701803D2693F83E0B AS DateTime2), NULL, NULL, N'f23dd40e-1487-4e27-8654-caa1deef363b', N'fabricio.gatica', N'{"UsuarioId":2,"RolId":1}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (8, N'Insert', CAST(0x077320DF4193F83E0B AS DateTime2), N'Nuevo registro en la tabla UsuarioRol', N'UsuarioRol', NULL, 1, CAST(0x07C829DF4193F83E0B AS DateTime2), NULL, NULL, N'11ba17df-6b14-4117-885d-8a9c3d5f84bc', N'fabricio.gatica', N'{
  "UsuarioId": 2,
  "RolId": 1
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (9, N'Delete', CAST(0x077320DF4193F83E0B AS DateTime2), N'Registro eliminado de la tabla UsuarioRol', N'UsuarioRol', NULL, 1, CAST(0x07C22FDF4193F83E0B AS DateTime2), NULL, NULL, N'11ba17df-6b14-4117-885d-8a9c3d5f84bc', N'fabricio.gatica', N'{"UsuarioId":2,"RolId":2}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (1002, N'Insert', CAST(0x07DA3FE4C2A0073F0B AS DateTime2), N'Nuevo registro en la tabla UsuarioToken', N'UsuarioToken', NULL, 1, CAST(0x07A405F8C2A0073F0B AS DateTime2), NULL, NULL, N'75b21e2e-700d-4b26-9277-364ed1f0015a', N'fabricio.gatica', N'{
  "UsuarioTokenId": 2,
  "Token": "58311fcd-abe4-4a58-bd9c-f3f881c97707",
  "UsuarioId": 2,
  "Usado": false,
  "FechaExpiracion": "2018-12-04T20:10:39.6564015-03:00"
}')
GO
INSERT [dbo].[Auditoria] ([AuditoriaId], [Action], [Date], [Descripcion], [Entity], [EntityId], [Habilitado], [TSCreate], [TSEliminado], [TSModificado], [TransactionId], [UserName], [Value]) VALUES (1003, N'Insert', CAST(0x07E31A9EDAA9073F0B AS DateTime2), N'Nuevo registro en la tabla UsuarioToken', N'UsuarioToken', NULL, 1, CAST(0x07DD14A9DAA9073F0B AS DateTime2), NULL, NULL, N'08ca150a-7e6d-4e66-bb85-34eda8e50de9', N'fabricio.gatica', N'{
  "UsuarioTokenId": 3,
  "Token": "402c4c8e-0428-4544-a184-ac617a91a164",
  "UsuarioId": 2,
  "Usado": false,
  "FechaExpiracion": "2018-12-04T21:15:48.0927318-03:00"
}')
GO
SET IDENTITY_INSERT [dbo].[Auditoria] OFF
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
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 3)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 5)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (2, 13)
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

GO
INSERT [dbo].[Usuario] ([UsuarioId], [Apellido], [Contrasena], [ContrasenaActualizada], [Email], [Habilitado], [Nombre], [TSCreado], [TSEliminado], [TSModificado], [Token], [TokenExpiration]) VALUES (2, N'Gatica', N'vNfmOJQYQTEL4XmHsWpSIw==', 1, N'damian13.fg@gmail.com', 1, N'Fabricio', CAST(0x070000000000F83E0B AS DateTime2), NULL, CAST(0x07948ADB4193F83E0B AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[UsuarioRol] ([RolId], [UsuarioId]) VALUES (1, 2)
GO
SET IDENTITY_INSERT [dbo].[UsuarioToken] ON 

GO
INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (1, CAST(0x077FA0D9AE9AF83E0B AS DateTime2), N'7d3d9ea2-18e7-42f5-b0fc-f6fccfb169fb', 0, 2)
GO
INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (2, CAST(0x072FF29B20A9073F0B AS DateTime2), N'58311fcd-abe4-4a58-bd9c-f3f881c97707', 0, 2)
GO
INSERT [dbo].[UsuarioToken] ([UsuarioTokenId], [FechaExpiracion], [Token], [Usado], [UsuarioId]) VALUES (3, CAST(0x075600383AB2073F0B AS DateTime2), N'402c4c8e-0428-4544-a184-ac617a91a164', 0, 2)
GO
SET IDENTITY_INSERT [dbo].[UsuarioToken] OFF
GO
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
SET IDENTITY_INSERT [dbo].[Vista] OFF
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Vista_VistaId] FOREIGN KEY([VistaId])
REFERENCES [dbo].[Vista] ([VistaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_Vista_VistaId]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK_RolPermiso_Permiso_PermisoId] FOREIGN KEY([PermisoId])
REFERENCES [dbo].[Permiso] ([PermisoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK_RolPermiso_Permiso_PermisoId]
GO
ALTER TABLE [dbo].[RolPermiso]  WITH CHECK ADD  CONSTRAINT [FK_RolPermiso_Rol_RolId] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolPermiso] CHECK CONSTRAINT [FK_RolPermiso_Rol_RolId]
GO
ALTER TABLE [dbo].[UsuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioRol_Rol_RolId] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioRol] CHECK CONSTRAINT [FK_UsuarioRol_Rol_RolId]
GO
ALTER TABLE [dbo].[UsuarioRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioRol_Usuario_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioRol] CHECK CONSTRAINT [FK_UsuarioRol_Usuario_UsuarioId]
GO
