CREATE DATABASE  IF NOT EXISTS `BDSistemaEyS` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `BDSistemaEyS`;
-- MySQL dump 10.13  Distrib 8.0.25, for Linux (x86_64)
--
-- Host: localhost    Database: BDSistemaEyS
-- ------------------------------------------------------
-- Server version	8.0.29-0ubuntu0.22.04.2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `Vw_Cargo`
--

DROP TABLE IF EXISTS `Vw_Cargo`;
/*!50001 DROP VIEW IF EXISTS `Vw_Cargo`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Cargo` AS SELECT 
 1 AS `id`,
 1 AS `nombre`,
 1 AS `departamento`,
 1 AS `descripcion`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Departamento`
--

DROP TABLE IF EXISTS `Vw_Departamento`;
/*!50001 DROP VIEW IF EXISTS `Vw_Departamento`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Departamento` AS SELECT 
 1 AS `id`,
 1 AS `nombre`,
 1 AS `ext`,
 1 AS `email`,
 1 AS `descripcion`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Empleado`
--

DROP TABLE IF EXISTS `Vw_Empleado`;
/*!50001 DROP VIEW IF EXISTS `Vw_Empleado`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Empleado` AS SELECT 
 1 AS `id`,
 1 AS `usuario`,
 1 AS `nombres`,
 1 AS `apellidos`,
 1 AS `sexo`,
 1 AS `cedula`,
 1 AS `departamento`,
 1 AS `cargo`,
 1 AS `emailCorporativo`,
 1 AS `emailPersonal`,
 1 AS `fechaNac`,
 1 AS `fechaIngreso`,
 1 AS `activo`,
 1 AS `telefono`,
 1 AS `observacion`,
 1 AS `direccion`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Evento`
--

DROP TABLE IF EXISTS `Vw_Evento`;
/*!50001 DROP VIEW IF EXISTS `Vw_Evento`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Evento` AS SELECT 
 1 AS `ID`,
 1 AS `Fecha Inicio`,
 1 AS `Fecha Fin`,
 1 AS `Razon`,
 1 AS `Descripcion`,
 1 AS `Nombres`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_OpcRol`
--

DROP TABLE IF EXISTS `Vw_OpcRol`;
/*!50001 DROP VIEW IF EXISTS `Vw_OpcRol`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_OpcRol` AS SELECT 
 1 AS `IdOpcRol`,
 1 AS `Activo`,
 1 AS `Nombre`,
 1 AS `idrol`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Registro`
--

DROP TABLE IF EXISTS `Vw_Registro`;
/*!50001 DROP VIEW IF EXISTS `Vw_Registro`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Registro` AS SELECT 
 1 AS `id`,
 1 AS `hEntrada`,
 1 AS `hSalida`,
 1 AS `hAlmuerzoIn`,
 1 AS `hAlmuerzoOut`,
 1 AS `usuario`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Rol`
--

DROP TABLE IF EXISTS `Vw_Rol`;
/*!50001 DROP VIEW IF EXISTS `Vw_Rol`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Rol` AS SELECT 
 1 AS `id`,
 1 AS `nombre`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_Usuario`
--

DROP TABLE IF EXISTS `Vw_Usuario`;
/*!50001 DROP VIEW IF EXISTS `Vw_Usuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_Usuario` AS SELECT 
 1 AS `id`,
 1 AS `username`,
 1 AS `clave`,
 1 AS `empleado`,
 1 AS `rol`,
 1 AS `estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `Vw_inSesion`
--

DROP TABLE IF EXISTS `Vw_inSesion`;
/*!50001 DROP VIEW IF EXISTS `Vw_inSesion`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `Vw_inSesion` AS SELECT 
 1 AS `nombres`,
 1 AS `apellidos`,
 1 AS `cedula`,
 1 AS `departamento`,
 1 AS `cargo`,
 1 AS `Fecha`,
 1 AS `hora entrada`,
 1 AS `hora salida`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tbl_Cargo`
--

DROP TABLE IF EXISTS `tbl_Cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Cargo` (
  `idCargo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `descripcion` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `estado` int NOT NULL,
  `idDepartamento` int NOT NULL,
  PRIMARY KEY (`idCargo`),
  UNIQUE KEY `idCargo_UNIQUE` (`idCargo`),
  KEY `Reftbl_Departamento16` (`idDepartamento`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Cargo`
--

LOCK TABLES `tbl_Cargo` WRITE;
/*!40000 ALTER TABLE `tbl_Cargo` DISABLE KEYS */;
INSERT INTO `tbl_Cargo` VALUES (1,'Analista de Negocio','Analiza los negocios',2,2),(2,'Experto en Soporte','Experto en soporte pues que mas',2,2),(3,'CEO','omg, CEO',2,1),(4,'Gerente de PPC','Despedimos a todos por falta de fondos.',2,3),(5,'Analista Programador','',2,2),(6,'Operador de Sistemas','Despedimos a todos por falta de fondos.',2,2),(7,'Operador de Netbeans','hace nada',2,2),(8,'Adorno','No sé qué es lo que hace uno de marketing, perdón.',2,3),(9,'Presidente de la República','Puesto exclusivo para Daniel Ortega Saavedra',2,3),(10,'Operador de Redes','',2,2),(11,'Analista de Sistemas','perrito',1,2),(12,'Content Manager','Despedimos a todos por falta de fondos.',2,3),(13,'Gerente de Marca','Despedimos a todos por falta de fondos.',2,3),(14,'Especialista en SEO','Despedimos a todos por falta de fondos.',2,3),(15,'Consultor','',2,2),(16,'Secretaría','',1,4);
/*!40000 ALTER TABLE `tbl_Cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Config`
--

DROP TABLE IF EXISTS `tbl_Config`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Config` (
  `idConfig` int NOT NULL AUTO_INCREMENT,
  `nombreEmpresa` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `hAlmuerzoIn` datetime NOT NULL,
  `hAlmuerzoOut` datetime NOT NULL,
  `tiempoGracia` int NOT NULL,
  `emailEmpresa` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`idConfig`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Config`
--

LOCK TABLES `tbl_Config` WRITE;
/*!40000 ALTER TABLE `tbl_Config` DISABLE KEYS */;
INSERT INTO `tbl_Config` VALUES (1,'Tiendita SA','2001-09-11 13:00:00','2001-09-11 12:00:00',15,'@teamf.com.ni');
/*!40000 ALTER TABLE `tbl_Config` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Departamento`
--

DROP TABLE IF EXISTS `tbl_Departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Departamento` (
  `idDepartamento` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(60) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `ext` varchar(10) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `email` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `descripcion` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `estado` int NOT NULL,
  PRIMARY KEY (`idDepartamento`),
  UNIQUE KEY `idDepartamento_UNIQUE` (`idDepartamento`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Departamento`
--

LOCK TABLES `tbl_Departamento` WRITE;
/*!40000 ALTER TABLE `tbl_Departamento` DISABLE KEYS */;
INSERT INTO `tbl_Departamento` VALUES (1,'RRHH','616','rrh@teamf.com.ni','Coolaboradores del control de empleados.',2),(2,'Sistemas','838','sistemas@teamf.com.ni','Administración del software',2),(3,'Marketing','1610','marketing@teamf.com.ni','Administración de Redes Sociales',1),(4,'Dirección General','910','directgen@teamf.com.ni','',1);
/*!40000 ALTER TABLE `tbl_Departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Empleado`
--

DROP TABLE IF EXISTS `tbl_Empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Empleado` (
  `idEmpleado` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(14) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `primerNombre` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `segundoNombre` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `primerApellido` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `segundoApellido` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `observacion` varchar(100) DEFAULT NULL,
  `telefono` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `emailPersonal` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `emailCorporativo` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `sexo` bit(1) NOT NULL,
  `estadoActividad` bit(1) NOT NULL,
  `estado` int NOT NULL,
  `fechaNac` datetime NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  `fechaAgregado` datetime DEFAULT NULL,
  `idCargo` int NOT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idEmpleado`),
  UNIQUE KEY `cedula_UNIQUE` (`cedula`),
  UNIQUE KEY `idEmpleado_UNIQUE` (`idEmpleado`),
  UNIQUE KEY `emailCorporativo_UNIQUE` (`emailCorporativo`),
  KEY `Reftbl_Usuario57` (`idUsuario`),
  KEY `Reftbl_Cargo31` (`idCargo`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Empleado`
--

LOCK TABLES `tbl_Empleado` WRITE;
/*!40000 ALTER TABLE `tbl_Empleado` DISABLE KEYS */;
INSERT INTO `tbl_Empleado` VALUES (1,'0012405041023S','Erick','Oswaldo          ','Gonzalez','Gallegos','Managua, Colonia Máximo Jerez','','87402508','erickgonz@gmail.com','erickgonz@teamf.com.ni',_binary '',_binary '\0',2,'2004-05-24 00:00:00','2020-04-23 00:00:00','2022-05-20 00:00:00',1,1),(2,'0011901011009G','Armando','Alexander','Meza','López','Managua, Américas 2','','77665604','amezal@gmail.com','armando@teamf.com.ni',_binary '',_binary '\0',2,'2001-01-19 00:00:00','2021-05-19 00:00:00','2022-05-21 00:00:00',5,7),(3,'0011904041016S','David',' ','Quintanilla','Ruiz','Managua, Camilo Ortega','','77488103','davidquint@gmail.com','davidquint@teamf.com.ni',_binary '',_binary '\0',2,'2004-04-19 00:00:00','2022-04-01 00:00:00','2022-05-24 00:00:00',11,3),(4,'0010808041004S','David','Sebastián','Parrales','Ponce','Carazo, El Rosario','','81841231','davidponce@gmail.com','davidponce@teamf.com.ni',_binary '',_binary '\0',1,'2004-08-08 00:00:00','2022-05-25 00:00:00','2022-05-25 00:00:00',2,4),(5,'0012405221004S','Mabel','Aryeris  ','García','Hernández','Ciudad Sandino','','83249712','mabelgarcia@gmail.com','mabelgarcia@empresa.com.ni',_binary '\0',_binary '\0',2,'2004-05-24 00:00:00','2022-05-24 00:00:00','2022-05-24 00:00:00',12,6),(6,'0011807031040S','Riuske','Mateo ','Nishime','Robleto','Carretera a Masaya','Hay que tener cuidad con los animales domésticos(se los come).','77369964','riuskenishime@gmail.com','riuskenishime@teamf.com.ni',_binary '',_binary '\0',2,'2022-05-03 00:00:00','2022-05-24 00:00:00','2022-05-24 00:00:00',15,5),(7,'1230807181016S','Juan','Daniel ','Gaturron','Treminio','Managua, Camilo Ortega','','77488103','juandaga@gmail.com','juandaga@teamf.com.ni',_binary '',_binary '\0',2,'2022-05-03 00:00:00','2022-05-10 00:00:00','2022-05-28 00:00:00',5,9),(8,'0011904041017S','Elsner','','González','Ortega','','es GOD','86769679','elsnergod@gmail.com','elsnergod@teamf.com.ni',_binary '',_binary '\0',2,'2022-06-07 00:00:00','2022-05-18 00:00:00','2022-05-28 00:00:00',3,8),(9,'1232104521003J','Armando','José ','López','López','Desconocida','¿Por qué usaron el campo de observación? ya no se usa...','','armandol@gmail.com','armandol@teamf.com.ni',_binary '',_binary '\0',2,'2022-05-03 00:00:00','2022-05-12 00:00:00','2022-05-29 00:00:00',3,12),(10,'0011807031008G','Ernesto','','Román','Luna','','','77908074','eroman@gmail.com','eroman@teamf.com.ni',_binary '',_binary '\0',2,'2022-05-06 00:00:00','2022-05-25 00:00:00','2022-05-30 00:00:00',7,0);
/*!40000 ALTER TABLE `tbl_Empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Evento`
--

DROP TABLE IF EXISTS `tbl_Evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Evento` (
  `idEvento` int NOT NULL AUTO_INCREMENT,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime NOT NULL,
  `razon` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `descripcion` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `estado` int NOT NULL,
  `idEmpleado` int NOT NULL,
  PRIMARY KEY (`idEvento`),
  UNIQUE KEY `idEvento_UNIQUE` (`idEvento`),
  KEY `Reftbl_Empleado51` (`idEmpleado`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Evento`
--

LOCK TABLES `tbl_Evento` WRITE;
/*!40000 ALTER TABLE `tbl_Evento` DISABLE KEYS */;
INSERT INTO `tbl_Evento` VALUES (1,'2022-05-28 00:00:00','2022-07-20 00:00:00','Enfermedad','Al estimado le dió una buena gripe.',1,1);
/*!40000 ALTER TABLE `tbl_Evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Horario`
--

DROP TABLE IF EXISTS `tbl_Horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Horario` (
  `idHorario` int NOT NULL AUTO_INCREMENT,
  `horarioIn` datetime NOT NULL,
  `horarioOut` datetime NOT NULL,
  `tipoHorario` int NOT NULL,
  `activo` bit(1) NOT NULL,
  `idCargo` int NOT NULL,
  PRIMARY KEY (`idHorario`),
  UNIQUE KEY `idHorario_UNIQUE` (`idHorario`),
  KEY `Reftbl_Cargo40` (`idCargo`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Horario`
--

LOCK TABLES `tbl_Horario` WRITE;
/*!40000 ALTER TABLE `tbl_Horario` DISABLE KEYS */;
INSERT INTO `tbl_Horario` VALUES (1,'2001-01-01 08:00:00','2001-09-01 12:03:00',1,_binary '',4),(2,'2001-01-01 08:00:00','2001-01-01 17:00:00',2,_binary '',4),(3,'2001-01-01 00:00:00','2001-01-01 01:01:00',0,_binary '',4),(4,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',0),(5,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',0),(6,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '',0),(7,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',0),(8,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',0),(9,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '',0),(10,'2001-09-11 10:05:00','2001-09-11 20:03:00',1,_binary '',10),(11,'2001-09-11 11:03:00','2001-09-11 14:06:00',2,_binary '',10),(12,'2001-09-11 12:03:00','2001-09-11 14:02:00',3,_binary '',10),(13,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',11),(14,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',11),(15,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '\0',11),(16,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',12),(17,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',12),(18,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '\0',12),(19,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '\0',13),(20,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',13),(21,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '\0',13),(22,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '\0',14),(23,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '\0',14),(24,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '',14),(25,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',15),(26,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',15),(27,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '',15),(28,'2001-09-11 06:00:00','2001-09-11 17:00:00',1,_binary '',16),(29,'2001-09-11 08:00:00','2001-09-11 12:00:00',2,_binary '',16),(30,'2001-09-11 08:00:00','2001-09-11 12:00:00',3,_binary '\0',16);
/*!40000 ALTER TABLE `tbl_Horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_OpcRol`
--

DROP TABLE IF EXISTS `tbl_OpcRol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_OpcRol` (
  `idOpcRol` int NOT NULL AUTO_INCREMENT,
  `activo` bit(1) NOT NULL,
  `idOpcion` int NOT NULL,
  `idRol` int NOT NULL,
  PRIMARY KEY (`idOpcRol`),
  UNIQUE KEY `idOpcRol_UNIQUE` (`idOpcRol`),
  KEY `Reftbl_Opcion53` (`idOpcion`),
  KEY `Reftbl_Rol58` (`idRol`)
) ENGINE=MyISAM AUTO_INCREMENT=96 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_OpcRol`
--

LOCK TABLES `tbl_OpcRol` WRITE;
/*!40000 ALTER TABLE `tbl_OpcRol` DISABLE KEYS */;
INSERT INTO `tbl_OpcRol` VALUES (1,_binary '\0',1,2),(2,_binary '\0',2,2),(3,_binary '\0',3,2),(4,_binary '\0',4,2),(5,_binary '\0',5,2),(6,_binary '',6,2),(7,_binary '',7,2),(8,_binary '',8,2),(9,_binary '',9,2),(10,_binary '',10,2),(11,_binary '\0',11,2),(12,_binary '\0',12,2),(13,_binary '\0',13,2),(14,_binary '\0',14,2),(15,_binary '\0',15,2),(16,_binary '\0',16,2),(17,_binary '\0',17,2),(18,_binary '\0',18,2),(19,_binary '\0',19,2),(20,_binary '\0',1,3),(21,_binary '\0',2,3),(22,_binary '\0',3,3),(23,_binary '\0',4,3),(24,_binary '\0',5,3),(25,_binary '\0',6,3),(26,_binary '\0',7,3),(27,_binary '\0',8,3),(28,_binary '\0',9,3),(29,_binary '\0',10,3),(30,_binary '\0',11,3),(31,_binary '\0',12,3),(32,_binary '\0',13,3),(33,_binary '\0',14,3),(34,_binary '\0',15,3),(35,_binary '\0',16,3),(36,_binary '\0',17,3),(37,_binary '\0',18,3),(38,_binary '\0',19,3),(76,_binary '',19,1),(75,_binary '',18,1),(74,_binary '',17,1),(73,_binary '\0',16,1),(72,_binary '\0',15,1),(71,_binary '',14,1),(70,_binary '',13,1),(69,_binary '',12,1),(68,_binary '',11,1),(67,_binary '',10,1),(66,_binary '',9,1),(65,_binary '',8,1),(64,_binary '',7,1),(63,_binary '\0',6,1),(62,_binary '\0',5,1),(61,_binary '\0',4,1),(60,_binary '\0',3,1),(59,_binary '',2,1),(58,_binary '\0',1,1),(77,_binary '',1,4),(78,_binary '',2,4),(79,_binary '',3,4),(80,_binary '',4,4),(81,_binary '',5,4),(82,_binary '',6,4),(83,_binary '',7,4),(84,_binary '',8,4),(85,_binary '',9,4),(86,_binary '',10,4),(87,_binary '',11,4),(88,_binary '',12,4),(89,_binary '',13,4),(90,_binary '',14,4),(91,_binary '',15,4),(92,_binary '',16,4),(93,_binary '',17,4),(94,_binary '',18,4),(95,_binary '',19,4);
/*!40000 ALTER TABLE `tbl_OpcRol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Opcion`
--

DROP TABLE IF EXISTS `tbl_Opcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Opcion` (
  `idOpcion` int NOT NULL AUTO_INCREMENT,
  `formulario` varchar(80) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`idOpcion`),
  UNIQUE KEY `idOpcion_UNIQUE` (`idOpcion`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Opcion`
--

LOCK TABLES `tbl_Opcion` WRITE;
/*!40000 ALTER TABLE `tbl_Opcion` DISABLE KEYS */;
INSERT INTO `tbl_Opcion` VALUES (1,'Administrar Empleado'),(2,'Administrar Cargo'),(3,'Administrar Departamento'),(4,'Administrar Usuario'),(5,'Administrar Rol'),(6,'Listar Empleados'),(7,'Listar Cargos'),(8,'Listar Departamentos'),(9,'Listar Usuarios'),(10,'Listar Roles'),(11,'Agregar Empleado'),(12,'Agregar Cargo'),(13,'Agregar Departamento'),(14,'Agregar Usuario'),(15,'Agregar Rol'),(16,'Configurar Horarios'),(17,'Configurar Eventos'),(18,'Parámetros Generales'),(19,'Restauración de Entidades');
/*!40000 ALTER TABLE `tbl_Opcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Registro`
--

DROP TABLE IF EXISTS `tbl_Registro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Registro` (
  `idRegistro` int NOT NULL AUTO_INCREMENT,
  `horaEntrada` datetime DEFAULT NULL,
  `horaSalida` datetime DEFAULT NULL,
  `horaAlmuerzoIn` datetime DEFAULT NULL,
  `horaAlmuerzoOut` datetime DEFAULT NULL,
  `idEmpleado` int NOT NULL,
  PRIMARY KEY (`idRegistro`),
  UNIQUE KEY `idRegstro_UNIQUE` (`idRegistro`),
  KEY `Reftbl_Empleado36` (`idEmpleado`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Registro`
--

LOCK TABLES `tbl_Registro` WRITE;
/*!40000 ALTER TABLE `tbl_Registro` DISABLE KEYS */;
INSERT INTO `tbl_Registro` VALUES (1,NULL,'2022-05-23 10:00:00','2022-05-23 10:00:00','2022-05-23 10:00:00',1),(2,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(3,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(4,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(5,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(6,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(7,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(8,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(9,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(10,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(11,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(12,'2022-05-01 10:00:00',NULL,NULL,NULL,1),(13,'2022-05-24 10:00:00','2022-05-24 22:37:15',NULL,NULL,1),(14,'2022-05-23 10:00:00',NULL,NULL,NULL,1),(15,'2022-05-23 10:00:00',NULL,NULL,NULL,1),(16,'2022-05-23 10:00:00',NULL,NULL,NULL,1),(17,'2022-05-23 10:00:00',NULL,NULL,NULL,1),(18,'2022-05-23 10:00:00',NULL,NULL,NULL,1),(19,'0001-01-01 00:00:00',NULL,NULL,NULL,3),(20,'2022-05-24 22:28:22','2022-05-24 22:36:02',NULL,NULL,3),(21,'2022-05-25 22:38:54','2022-05-25 22:39:51',NULL,NULL,3),(22,'2022-05-25 23:13:04','2022-05-25 23:18:02','2022-05-25 23:15:38','2022-05-25 23:13:09',4),(23,'2022-05-24 23:19:10','2022-05-24 23:19:32','2022-05-24 23:19:25','2022-05-24 23:19:19',4),(24,'2022-05-24 23:31:47',NULL,'2022-05-24 23:32:29','2022-05-24 23:32:20',5),(25,'2022-05-24 23:34:23','2022-05-24 23:38:44','2022-05-24 23:38:27','2022-05-24 23:34:28',6),(26,'2022-05-25 13:27:01','2022-05-25 13:36:51','2022-05-25 13:36:24','2022-05-25 13:36:09',2),(27,'2022-05-25 16:12:26','2022-05-25 16:12:36','2022-05-25 16:12:34','2022-05-25 16:12:32',1),(28,'2022-05-28 15:46:59','2022-05-28 16:40:41',NULL,NULL,3),(29,'2022-05-29 13:29:19','2022-05-29 20:17:36',NULL,NULL,3),(30,'2022-05-29 14:11:54',NULL,NULL,NULL,1),(31,'2022-05-29 14:12:08','2022-05-29 20:21:22',NULL,NULL,6),(32,'2022-05-29 14:13:18','2022-05-29 20:16:50',NULL,NULL,4),(33,'2022-05-30 00:58:43','2022-05-30 12:13:33','2022-05-30 12:09:20','2022-05-30 12:05:19',3),(34,'2022-05-30 12:18:31','2022-05-30 12:18:52','2022-05-30 12:18:48','2022-05-30 12:18:42',6),(35,'2022-05-30 01:34:03','2022-05-30 13:25:00',NULL,NULL,2),(36,'2022-05-30 02:52:36','2022-05-30 13:24:48','2022-05-30 13:24:20','2022-05-30 12:24:04',5);
/*!40000 ALTER TABLE `tbl_Registro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Rol`
--

DROP TABLE IF EXISTS `tbl_Rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Rol` (
  `idRol` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `estado` int NOT NULL,
  PRIMARY KEY (`idRol`),
  UNIQUE KEY `idRol_UNIQUE` (`idRol`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Rol`
--

LOCK TABLES `tbl_Rol` WRITE;
/*!40000 ALTER TABLE `tbl_Rol` DISABLE KEYS */;
INSERT INTO `tbl_Rol` VALUES (1,'Administrador',0),(2,'Vigilante',1),(3,'Común',0),(4,'Admin Supremo',0),(5,'Aparte',1);
/*!40000 ALTER TABLE `tbl_Rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_Usuario`
--

DROP TABLE IF EXISTS `tbl_Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_Usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `username` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8_general_ci NOT NULL,
  `estado` int NOT NULL,
  `idRol` int NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `idUsuario_UNIQUE` (`idUsuario`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  KEY `Reftbl_Rol56` (`idRol`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_Usuario`
--

LOCK TABLES `tbl_Usuario` WRITE;
/*!40000 ALTER TABLE `tbl_Usuario` DISABLE KEYS */;
INSERT INTO `tbl_Usuario` VALUES (1,'eros','900',2,4),(2,'poncka','123',3,4),(3,'davidquint','1984',2,4),(4,'davidponce','123',2,4),(5,'riuskenishime','1234',2,1),(6,'mabelgarcia','1234',2,3),(7,'amezal','123',2,3),(9,'juandagaturron','1984',2,3),(8,'elsnergod','1739',2,4),(10,'ernestoluna','asies',3,1),(11,'yiziyizark','gatito',3,1),(12,'armandol','1984',2,3),(13,'leocorea','123',3,1),(14,'peterparker','123',3,1),(15,'eroman','1234',3,5),(16,'erozzz','1234',3,5),(17,'testing','1234',3,5),(18,'chinaso','1234',3,5);
/*!40000 ALTER TABLE `tbl_Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `Vw_Cargo`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Cargo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Cargo` AS select `car`.`idCargo` AS `id`,`car`.`nombre` AS `nombre`,`dep`.`nombre` AS `departamento`,`car`.`descripcion` AS `descripcion`,`car`.`estado` AS `estado` from (`tbl_Cargo` `car` left join `tbl_Departamento` `dep` on((`car`.`idDepartamento` = `dep`.`idDepartamento`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Departamento`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Departamento`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Departamento` AS select `dep`.`idDepartamento` AS `id`,`dep`.`nombre` AS `nombre`,`dep`.`ext` AS `ext`,`dep`.`email` AS `email`,`dep`.`descripcion` AS `descripcion`,`dep`.`estado` AS `estado` from `tbl_Departamento` `dep` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Empleado`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Empleado`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Empleado` AS select `emp`.`idEmpleado` AS `id`,`usr`.`username` AS `usuario`,concat(`emp`.`primerNombre`,' ',`emp`.`segundoNombre`) AS `nombres`,concat(`emp`.`primerApellido`,' ',`emp`.`segundoApellido`) AS `apellidos`,(case when (`emp`.`sexo` = 1) then 'Masculino' else 'Femenino' end) AS `sexo`,`emp`.`cedula` AS `cedula`,`dep`.`nombre` AS `departamento`,`car`.`nombre` AS `cargo`,`emp`.`emailCorporativo` AS `emailCorporativo`,`emp`.`emailPersonal` AS `emailPersonal`,`emp`.`fechaNac` AS `fechaNac`,`emp`.`fechaIngreso` AS `fechaIngreso`,(case when (`emp`.`estadoActividad` = 1) then 'Si' else 'No' end) AS `activo`,`emp`.`telefono` AS `telefono`,`emp`.`observacion` AS `observacion`,`emp`.`direccion` AS `direccion`,`emp`.`estado` AS `estado` from (((`tbl_Empleado` `emp` join `tbl_Cargo` `car` on((`emp`.`idCargo` = `car`.`idCargo`))) join `tbl_Departamento` `dep` on((`car`.`idDepartamento` = `dep`.`idDepartamento`))) left join `tbl_Usuario` `usr` on((`emp`.`idUsuario` = `usr`.`idUsuario`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Evento`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Evento`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Evento` AS select `even`.`idEvento` AS `ID`,`even`.`fechaInicio` AS `Fecha Inicio`,`even`.`fechaFin` AS `Fecha Fin`,`even`.`razon` AS `Razon`,`even`.`descripcion` AS `Descripcion`,concat(`emp`.`primerNombre`,' ',`emp`.`primerApellido`,' - ',`emp`.`cedula`) AS `Nombres` from (`tbl_Evento` `even` left join `tbl_Empleado` `emp` on((`even`.`idEmpleado` = `emp`.`idEmpleado`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_OpcRol`
--

/*!50001 DROP VIEW IF EXISTS `Vw_OpcRol`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_OpcRol` AS select `tbl_OpcRol`.`idOpcRol` AS `IdOpcRol`,`tbl_OpcRol`.`activo` AS `Activo`,`tbl_Opcion`.`formulario` AS `Nombre`,`tbl_OpcRol`.`idRol` AS `idrol` from (`tbl_OpcRol` join `tbl_Opcion` on((`tbl_OpcRol`.`idOpcion` = `tbl_Opcion`.`idOpcion`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Registro`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Registro`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Registro` AS select `reg`.`idRegistro` AS `id`,`reg`.`horaEntrada` AS `hEntrada`,`reg`.`horaSalida` AS `hSalida`,`reg`.`horaAlmuerzoIn` AS `hAlmuerzoIn`,`reg`.`horaAlmuerzoOut` AS `hAlmuerzoOut`,`usr`.`username` AS `usuario` from ((`tbl_Registro` `reg` join `tbl_Empleado` `emp` on((`emp`.`idEmpleado` = `reg`.`idEmpleado`))) join `tbl_Usuario` `usr` on((`usr`.`idUsuario` = `emp`.`idUsuario`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Rol`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Rol`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Rol` AS select `rol`.`idRol` AS `id`,`rol`.`nombre` AS `nombre`,`rol`.`estado` AS `estado` from `tbl_Rol` `rol` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_Usuario`
--

/*!50001 DROP VIEW IF EXISTS `Vw_Usuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_Usuario` AS select `usr`.`idUsuario` AS `id`,`usr`.`username` AS `username`,`usr`.`password` AS `clave`,concat(`emp`.`primerNombre`,' ',`emp`.`primerApellido`,' - ',`emp`.`cedula`) AS `empleado`,`rol`.`nombre` AS `rol`,`usr`.`estado` AS `estado` from ((`tbl_Usuario` `usr` left join `tbl_Empleado` `emp` on((`usr`.`idUsuario` = `emp`.`idUsuario`))) join `tbl_Rol` `rol` on((`usr`.`idRol` = `rol`.`idRol`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `Vw_inSesion`
--

/*!50001 DROP VIEW IF EXISTS `Vw_inSesion`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `Vw_inSesion` AS select `Vw_Empleado`.`nombres` AS `nombres`,`Vw_Empleado`.`apellidos` AS `apellidos`,`Vw_Empleado`.`cedula` AS `cedula`,`Vw_Empleado`.`departamento` AS `departamento`,`Vw_Empleado`.`cargo` AS `cargo`,date_format(`tbl_Registro`.`horaEntrada`,'%Y-%c-%d') AS `Fecha`,date_format(`tbl_Registro`.`horaEntrada`,'%H:%i:%S') AS `hora entrada`,date_format(`tbl_Registro`.`horaSalida`,'%H:%i:%S') AS `hora salida` from (`Vw_Empleado` left join `tbl_Registro` on((`Vw_Empleado`.`id` = `tbl_Registro`.`idEmpleado`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-30 18:29:36
