USE [DListDB]
GO
SET IDENTITY_INSERT [dbo].[ContactInfos] ON 

INSERT [dbo].[ContactInfos] ([Id], [Title], [ReceptPhone], [ComplantPhone], [SupportPhone]) VALUES (1, N'Sascs', N'51511515', N'5156', N'254')
SET IDENTITY_INSERT [dbo].[ContactInfos] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'21e42c85-b0f2-44ec-973f-88a8e66bd706', N'rauf_p222@gmail.com', N'RAUF_P222@GMAIL.COM', N'rauf_p222@gmail.com', N'RAUF_P222@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEB+1poh5PpVyt8zX2PoSFK8vuU6RzjHRiy6RT4Zc5vq4NFOuWpW/3sZmKzN1Y5hSRw==', N'A3Q4NVX4Q4XV5CJVX36MJL2ISQEOJ45W', N'43ab1a93-9b57-4555-90eb-c2ff2718a861', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[AboutUs] ON 

INSERT [dbo].[AboutUs] ([Id], [Image], [Icon], [Title], [Content], [Link], [CreatedDate]) VALUES (3, N'68b2bcb1-b279-418e-969b-e8df6cd0fb6a-20220104164222-bw-1.jpg', NULL, N'About Us sCAAVDC', N'GVEGERBVFVRGEERVBSRVRWG', NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AboutUs] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (5, N'gjvugvguv', N'gvgvgv', N'About')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [BgImage], [ShortInfo], [Address], [Phone], [Email]) VALUES (1, N'1', N'1', N'1', N'1', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
