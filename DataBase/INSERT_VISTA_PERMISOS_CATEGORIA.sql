USE [System_1]
GO
SET IDENTITY_INSERT [dbo].[Vista] ON 

INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (10, N'Categoria', N'Gestion de categorias')
GO
SET IDENTITY_INSERT [dbo].[Vista] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (18, N'Listado categorias', N'Index', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (19, N'Crear categoria', N'Create', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (20, N'Editar Categoria', N'Edit', 10)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (21, N'Eliminar Categoria', N'Delete', 10)
GO
SET IDENTITY_INSERT [dbo].[Permiso] OFF

GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 18)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 19)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 20)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 21)

