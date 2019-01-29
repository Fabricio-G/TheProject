USE [System_1]
GO
SET IDENTITY_INSERT [dbo].[Vista] ON 

INSERT [dbo].[Vista] ([VistaId], [Descripcion], [Nombre]) VALUES (9, N'Marca', N'Gestion de marcas')
GO
SET IDENTITY_INSERT [dbo].[Vista] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (14, N'Ver marca', N'Index', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (15, N'Crear marca', N'Create', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (16, N'Editar marca', N'Edit', 9)
GO
INSERT [dbo].[Permiso] ([PermisoId], [Descripcion], [Funcionalidad], [VistaId]) VALUES (17, N'Eliminar marca', N'Delete', 9)
GO
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 14)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 15)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 16)
GO
INSERT [dbo].[RolPermiso] ([RolId], [PermisoId]) VALUES (1, 17)
GO
