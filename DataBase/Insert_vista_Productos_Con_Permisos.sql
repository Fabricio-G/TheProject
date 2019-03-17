USE [System_1]
GO
SET IDENTITY_INSERT [dbo].[Vista] ON 

INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (11, N'Producto', N'Gestion de productos')
GO
SET IDENTITY_INSERT [dbo].[Vista] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (22, N'Listado productos', N'Index', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (23, N'Crear productos', N'Create', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (24, N'Editar productos', N'Edit', 11)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (25, N'Eliminar productos', N'Delete', 11)
GO
SET IDENTITY_INSERT [dbo].[Permiso] OFF

GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 22)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 23)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 24)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 25)

