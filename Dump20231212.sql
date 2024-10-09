-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: fitnessgym
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `como_conocio`
--

DROP TABLE IF EXISTS `como_conocio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `como_conocio` (
  `id_como_conocio` int NOT NULL AUTO_INCREMENT,
  `detalle_como_conocio` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_como_conocio`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `como_conocio`
--

LOCK TABLES `como_conocio` WRITE;
/*!40000 ALTER TABLE `como_conocio` DISABLE KEYS */;
INSERT INTO `como_conocio` VALUES (1,'Redes Socioales/Web'),(2,'Por algún conocido'),(3,'Ninguna de las Anteriores');
/*!40000 ALTER TABLE `como_conocio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `condi_ejercicio`
--

DROP TABLE IF EXISTS `condi_ejercicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `condi_ejercicio` (
  `id_condiciones_fisicas` int NOT NULL,
  `id_ejercicio` int NOT NULL,
  KEY `id_condiciones_fisicas_idx` (`id_condiciones_fisicas`),
  KEY `id_ejercicio_idx` (`id_ejercicio`),
  CONSTRAINT `fk_id_ejercicio` FOREIGN KEY (`id_ejercicio`) REFERENCES `ejercicios` (`id_ejercicio`) ON DELETE CASCADE,
  CONSTRAINT `id_condiciones_fisi` FOREIGN KEY (`id_condiciones_fisicas`) REFERENCES `condiciones_fisicas` (`id_condiciones_fisicas`),
  CONSTRAINT `id_ejercicio` FOREIGN KEY (`id_ejercicio`) REFERENCES `ejercicios` (`id_ejercicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `condi_ejercicio`
--

LOCK TABLES `condi_ejercicio` WRITE;
/*!40000 ALTER TABLE `condi_ejercicio` DISABLE KEYS */;
INSERT INTO `condi_ejercicio` VALUES (2,24),(3,24),(7,25);
/*!40000 ALTER TABLE `condi_ejercicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `condiciones_fisicas`
--

DROP TABLE IF EXISTS `condiciones_fisicas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `condiciones_fisicas` (
  `id_condiciones_fisicas` int NOT NULL AUTO_INCREMENT,
  `descripcion_condicion` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_condiciones_fisicas`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `condiciones_fisicas`
--

LOCK TABLES `condiciones_fisicas` WRITE;
/*!40000 ALTER TABLE `condiciones_fisicas` DISABLE KEYS */;
INSERT INTO `condiciones_fisicas` VALUES (1,'Enfermedades cardiovasculares'),(2,'Enfermedades respiratorias'),(3,'Edad Avanzada'),(4,'Peso Corporal Elevado'),(5,'Lesiones en la Columna'),(6,'Lesiones Musculares'),(7,'Lesiones Muscular Pecho');
/*!40000 ALTER TABLE `condiciones_fisicas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `coste`
--

DROP TABLE IF EXISTS `coste`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coste` (
  `id_coste` int NOT NULL AUTO_INCREMENT,
  `id_suscripcion` int NOT NULL,
  `detalle_frecuencia` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `costo_mensual` int NOT NULL,
  PRIMARY KEY (`id_coste`),
  KEY `id_suscripcion_idx` (`id_suscripcion`),
  CONSTRAINT `id_suscripcion` FOREIGN KEY (`id_suscripcion`) REFERENCES `suscripcion` (`id_suscripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coste`
--

LOCK TABLES `coste` WRITE;
/*!40000 ALTER TABLE `coste` DISABLE KEYS */;
INSERT INTO `coste` VALUES (3,2,'3 veces por semana',4500),(5,1,'5 veces por semana',5000),(6,1,'2 veces por semana',2000),(8,3,'3 veces por semana',7000);
/*!40000 ALTER TABLE `coste` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ejercicios`
--

DROP TABLE IF EXISTS `ejercicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ejercicios` (
  `id_ejercicio` int NOT NULL AUTO_INCREMENT,
  `nombre_ejercicio` varchar(200) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id_ejercicio`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ejercicios`
--

LOCK TABLES `ejercicios` WRITE;
/*!40000 ALTER TABLE `ejercicios` DISABLE KEYS */;
INSERT INTO `ejercicios` VALUES (24,'Vuelos Laterales'),(25,'Press Banca');
/*!40000 ALTER TABLE `ejercicios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `id_empleado` int NOT NULL AUTO_INCREMENT,
  `nombre_user` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `password_user` varchar(200) COLLATE utf8mb4_general_ci NOT NULL,
  `id_rol` int NOT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `id_roles_idx` (`id_rol`),
  CONSTRAINT `id_roles` FOREIGN KEY (`id_rol`) REFERENCES `roles` (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'rut','rut',2),(2,'papa','papa',1);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genero` (
  `id_genero` int NOT NULL AUTO_INCREMENT,
  `detalle_genero` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES (1,'Masculino'),(2,'Femenino');
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_suscripcion`
--

DROP TABLE IF EXISTS `historial_suscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historial_suscripcion` (
  `id_historial_suscripcion` int NOT NULL AUTO_INCREMENT,
  `id_users` int NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_fin` date NOT NULL,
  `id_empleado` int NOT NULL,
  `id_coste` int NOT NULL,
  PRIMARY KEY (`id_historial_suscripcion`),
  KEY `id_users_idx` (`id_users`),
  KEY `id_empleados_idx` (`id_empleado`),
  KEY `id_coste_idx` (`id_coste`),
  CONSTRAINT `id_costee` FOREIGN KEY (`id_coste`) REFERENCES `coste` (`id_coste`),
  CONSTRAINT `id_empleados` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`),
  CONSTRAINT `id_users` FOREIGN KEY (`id_users`) REFERENCES `users` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_suscripcion`
--

LOCK TABLES `historial_suscripcion` WRITE;
/*!40000 ALTER TABLE `historial_suscripcion` DISABLE KEYS */;
INSERT INTO `historial_suscripcion` VALUES (11,38,'2023-12-09','2024-01-09',1,5),(13,40,'2023-12-09','2024-01-09',1,5),(14,41,'2023-12-09','2024-01-09',1,5),(15,41,'2023-12-09','2024-01-09',1,5);
/*!40000 ALTER TABLE `historial_suscripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `id_proveedores` int NOT NULL AUTO_INCREMENT,
  `Razon_Social` varchar(45) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Direccion` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Telefono` int NOT NULL,
  `Email` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_proveedores`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id_rol` int NOT NULL AUTO_INCREMENT,
  `rol` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Usuario Común');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rutina_ejercicios`
--

DROP TABLE IF EXISTS `rutina_ejercicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rutina_ejercicios` (
  `id_rutina` int NOT NULL,
  `id_ejercicio` int NOT NULL,
  `series` int DEFAULT NULL,
  `repeticiones` int DEFAULT NULL,
  KEY `id_rutina` (`id_rutina`),
  KEY `id_ejercicio` (`id_ejercicio`),
  CONSTRAINT `rutina_ejercicios_ibfk_1` FOREIGN KEY (`id_rutina`) REFERENCES `rutinas` (`id_rutina`),
  CONSTRAINT `rutina_ejercicios_ibfk_2` FOREIGN KEY (`id_ejercicio`) REFERENCES `ejercicios` (`id_ejercicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rutina_ejercicios`
--

LOCK TABLES `rutina_ejercicios` WRITE;
/*!40000 ALTER TABLE `rutina_ejercicios` DISABLE KEYS */;
INSERT INTO `rutina_ejercicios` VALUES (11,25,2,4),(12,25,12,4),(13,24,1,12);
/*!40000 ALTER TABLE `rutina_ejercicios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rutinas`
--

DROP TABLE IF EXISTS `rutinas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rutinas` (
  `id_rutina` int NOT NULL AUTO_INCREMENT,
  `nombre_rutina` varchar(200) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_rutina`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rutinas`
--

LOCK TABLES `rutinas` WRITE;
/*!40000 ALTER TABLE `rutinas` DISABLE KEYS */;
INSERT INTO `rutinas` VALUES (1,'Rutina_1'),(2,'Rutina_2'),(3,'Dami'),(5,'Vuelos'),(7,'Martes'),(8,'Miercoles'),(9,'Tren Superior'),(11,'Tren Superior'),(12,'Espalda'),(13,'Tren Inferior'),(14,'TrenSuperior'),(15,'Espalda');
/*!40000 ALTER TABLE `rutinas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscripcion`
--

DROP TABLE IF EXISTS `suscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suscripcion` (
  `id_suscripcion` int NOT NULL AUTO_INCREMENT,
  `nombre_suscripcion` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_suscripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscripcion`
--

LOCK TABLES `suscripcion` WRITE;
/*!40000 ALTER TABLE `suscripcion` DISABLE KEYS */;
INSERT INTO `suscripcion` VALUES (1,'Musculacion'),(2,'HipertrofiaCardio'),(3,'personalizada');
/*!40000 ALTER TABLE `suscripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscripcion_rutina`
--

DROP TABLE IF EXISTS `suscripcion_rutina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suscripcion_rutina` (
  `id_suscripcion` int NOT NULL,
  `id_rutina` int NOT NULL,
  KEY `suscripcion_rutina_ibfk_1` (`id_suscripcion`),
  KEY `suscripcion_rutina_ibfk_2` (`id_rutina`),
  CONSTRAINT `suscripcion_rutina_ibfk_1` FOREIGN KEY (`id_suscripcion`) REFERENCES `suscripcion` (`id_suscripcion`),
  CONSTRAINT `suscripcion_rutina_ibfk_2` FOREIGN KEY (`id_rutina`) REFERENCES `rutinas` (`id_rutina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscripcion_rutina`
--

LOCK TABLES `suscripcion_rutina` WRITE;
/*!40000 ALTER TABLE `suscripcion_rutina` DISABLE KEYS */;
INSERT INTO `suscripcion_rutina` VALUES (1,11),(1,12),(2,13),(2,14),(3,15);
/*!40000 ALTER TABLE `suscripcion_rutina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_condi`
--

DROP TABLE IF EXISTS `user_condi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_condi` (
  `id_user` int NOT NULL,
  `id_condiciones_fisicas` int DEFAULT NULL,
  KEY `id_user_idx` (`id_user`),
  KEY `id_condiciones_fisicas_idx` (`id_condiciones_fisicas`),
  CONSTRAINT `id_condiciones_fisicas` FOREIGN KEY (`id_condiciones_fisicas`) REFERENCES `condiciones_fisicas` (`id_condiciones_fisicas`),
  CONSTRAINT `id_user` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_condi`
--

LOCK TABLES `user_condi` WRITE;
/*!40000 ALTER TABLE `user_condi` DISABLE KEYS */;
INSERT INTO `user_condi` VALUES (31,2),(31,3),(32,2),(38,2),(38,3),(40,7),(41,7);
/*!40000 ALTER TABLE `user_condi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `apellido` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(200) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `DNI` varchar(400) COLLATE utf8mb4_general_ci NOT NULL,
  `telefono` varchar(400) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `direccion` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `id_como_conocio` int DEFAULT NULL,
  `id_genero` int NOT NULL,
  `id_suscripcion_actual` int NOT NULL,
  `imagen` varbinary(30000) DEFAULT NULL,
  PRIMARY KEY (`id_user`),
  KEY `id_genero_idx` (`id_genero`),
  KEY `id_como_conocio_idx` (`id_como_conocio`),
  KEY `id_suscripcion_actual_idx` (`id_suscripcion_actual`),
  CONSTRAINT `id_como_conocio` FOREIGN KEY (`id_como_conocio`) REFERENCES `como_conocio` (`id_como_conocio`),
  CONSTRAINT `id_genero` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`),
  CONSTRAINT `id_suscripcion_actual` FOREIGN KEY (`id_suscripcion_actual`) REFERENCES `suscripcion` (`id_suscripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (31,'Ruben Omar','Acuña','ruben@gmail.com','2023-12-07','44681264','3764245046','Ramon Diaz',1,1,1,NULL),(32,'Kevin','Aliendro','rgtfvbfgf','2023-12-08','6565456','76545654','htgrfdvfgb',1,1,1,NULL),(38,'Ma','nano','ghdhsbf','2023-12-09','45446625','542532','eghteegr',1,1,1,NULL),(40,'ruti','ni','uihiuhihiih','2023-12-09','89776666','7688787','ggygyhu',1,1,1,NULL),(41,'lus','benito','jiuhiuhiuh','2023-12-09','78786868','9779787','uihuih',2,2,1,NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-12 17:26:24
