CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `AspNetRoles` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoles` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUsers` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_AspNetUsers` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Etiquetas` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Etiquetas` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Libros` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Titulo` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Autor` longtext CHARACTER SET utf8mb4 NULL,
    `Editorial` longtext CHARACTER SET utf8mb4 NULL,
    `Ano` int NULL,
    `Precio` decimal(65,30) NULL,
    `ISBN` longtext CHARACTER SET utf8mb4 NULL,
    `Sinopsis` longtext CHARACTER SET utf8mb4 NULL,
    `Imagen` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Libros` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Posts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Cita` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Categoria` longtext CHARACTER SET utf8mb4 NULL,
    `Titulo` longtext CHARACTER SET utf8mb4 NULL,
    `Autor` longtext CHARACTER SET utf8mb4 NULL,
    `Imagen` longtext CHARACTER SET utf8mb4 NULL,
    `Texto` longtext CHARACTER SET utf8mb4 NULL,
    `Puntuacion` int NOT NULL,
    CONSTRAINT `PK_Posts` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Redes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Enlace` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Redes` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Tarjetas` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Titulo` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Descripcion` longtext CHARACTER SET utf8mb4 NULL,
    `Imagen` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Tarjetas` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderDisplayName` longtext CHARACTER SET utf8mb4 NULL,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `EtiquetasLibros` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IdEtiqueta` int NOT NULL,
    `IdLibro` int NOT NULL,
    CONSTRAINT `PK_EtiquetasLibros` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_EtiquetasLibros_Etiquetas_IdEtiqueta` FOREIGN KEY (`IdEtiqueta`) REFERENCES `Etiquetas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_EtiquetasLibros_Libros_IdLibro` FOREIGN KEY (`IdLibro`) REFERENCES `Libros` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Comentarios` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IdPost` int NOT NULL,
    `IdUsuario` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Texto` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Comentarios` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Comentarios_AspNetUsers_IdUsuario` FOREIGN KEY (`IdUsuario`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Comentarios_Posts_IdPost` FOREIGN KEY (`IdPost`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `EtiquetasPosts` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IdEtiqueta` int NOT NULL,
    `IdPost` int NOT NULL,
    CONSTRAINT `PK_EtiquetasPosts` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_EtiquetasPosts_Etiquetas_IdEtiqueta` FOREIGN KEY (`IdEtiqueta`) REFERENCES `Etiquetas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_EtiquetasPosts_Posts_IdPost` FOREIGN KEY (`IdPost`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE TABLE `Puntuaciones` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IdUsuario` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `IdPost` int NOT NULL,
    `Puntos` int NOT NULL,
    `PostId` int NOT NULL,
    CONSTRAINT `PK_Puntuaciones` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Puntuaciones_AspNetUsers_IdUsuario` FOREIGN KEY (`IdUsuario`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Puntuaciones_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `Posts` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

CREATE INDEX `IX_Comentarios_IdPost` ON `Comentarios` (`IdPost`);

CREATE INDEX `IX_Comentarios_IdUsuario` ON `Comentarios` (`IdUsuario`);

CREATE INDEX `IX_EtiquetasLibros_IdEtiqueta` ON `EtiquetasLibros` (`IdEtiqueta`);

CREATE INDEX `IX_EtiquetasLibros_IdLibro` ON `EtiquetasLibros` (`IdLibro`);

CREATE INDEX `IX_EtiquetasPosts_IdEtiqueta` ON `EtiquetasPosts` (`IdEtiqueta`);

CREATE INDEX `IX_EtiquetasPosts_IdPost` ON `EtiquetasPosts` (`IdPost`);

CREATE INDEX `IX_Puntuaciones_IdUsuario` ON `Puntuaciones` (`IdUsuario`);

CREATE INDEX `IX_Puntuaciones_PostId` ON `Puntuaciones` (`PostId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20240401153329_Inicial', '8.0.3');

COMMIT;


