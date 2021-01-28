CREATE DATABASE  IF NOT EXISTS `zonafranca` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `zonafranca`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: zonafranca
-- ------------------------------------------------------
-- Server version	5.7.27-log

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
-- Table structure for table `artcompra`
--

DROP TABLE IF EXISTS `artcompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artcompra` (
  `compra` int(10) unsigned NOT NULL,
  `cod_articulo` varchar(6) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `total` double(14,2) DEFAULT NULL,
  KEY `compra` (`compra`),
  KEY `cod_articulo` (`cod_articulo`),
  CONSTRAINT `artcompra_ibfk_1` FOREIGN KEY (`compra`) REFERENCES `compra` (`idcompra`),
  CONSTRAINT `artcompra_ibfk_2` FOREIGN KEY (`cod_articulo`) REFERENCES `articulo` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artcompra`
--

LOCK TABLES `artcompra` WRITE;
/*!40000 ALTER TABLE `artcompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `artcompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artfactura`
--

DROP TABLE IF EXISTS `artfactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artfactura` (
  `factura` int(10) unsigned NOT NULL,
  `cod_articulo` varchar(6) NOT NULL,
  `cantidad` int(4) DEFAULT NULL,
  `total` double(14,2) DEFAULT NULL,
  PRIMARY KEY (`factura`,`cod_articulo`),
  KEY `cod_articulo` (`cod_articulo`),
  CONSTRAINT `artfactura_ibfk_1` FOREIGN KEY (`factura`) REFERENCES `factura` (`nro_factura`),
  CONSTRAINT `artfactura_ibfk_2` FOREIGN KEY (`cod_articulo`) REFERENCES `articulo` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artfactura`
--

LOCK TABLES `artfactura` WRITE;
/*!40000 ALTER TABLE `artfactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `artfactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `articulo`
--

DROP TABLE IF EXISTS `articulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `articulo` (
  `codigo` varchar(6) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `costo` double(14,2) DEFAULT NULL,
  `precio` double(14,2) DEFAULT NULL,
  `stock` int(4) DEFAULT NULL,
  `usuario` varchar(20) DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `usuario` (`usuario`),
  CONSTRAINT `articulo_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulo`
--

LOCK TABLES `articulo` WRITE;
/*!40000 ALTER TABLE `articulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `articulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `cedula` varchar(10) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `telefono` varchar(12) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `idcompra` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `rif_proveedor` varchar(15) DEFAULT NULL,
  `fecha_compra` date DEFAULT NULL,
  `monto` double(14,2) DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idcompra`),
  KEY `rif_proveedor` (`rif_proveedor`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`rif_proveedor`) REFERENCES `proveedor` (`rif`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `cedula` varchar(10) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono1` varchar(12) DEFAULT NULL,
  `telefono2` varchar(12) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `fecha_ingreso` date NOT NULL,
  `sueldo` double(14,2) DEFAULT NULL,
  `fecha_salida` date DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('1','del sistema','Administrador',NULL,NULL,NULL,NULL,NULL,'2020-07-16',NULL,NULL,'A');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura` (
  `nro_factura` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) NOT NULL,
  `ced_cliente` varchar(10) DEFAULT NULL,
  `fecha_venta` date DEFAULT NULL,
  `hora_venta` time DEFAULT NULL,
  `monto` double(14,2) DEFAULT NULL,
  `pago_debito` double(14,2) DEFAULT NULL,
  `pago_transferencia` double(14,2) DEFAULT NULL,
  `pago_efectivo` double(14,2) DEFAULT NULL,
  `pago_dolar` double(14,2) DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`nro_factura`),
  KEY `usuario` (`usuario`),
  KEY `ced_cliente` (`ced_cliente`),
  CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`username`),
  CONSTRAINT `factura_ibfk_2` FOREIGN KEY (`ced_cliente`) REFERENCES `cliente` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insumo`
--

DROP TABLE IF EXISTS `insumo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `insumo` (
  `idinsumo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `compra` int(10) unsigned NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `costo` double(14,2) DEFAULT NULL,
  `cantidad` double(5,2) DEFAULT NULL,
  `unidad_medida` enum('unidad','litro','kilogramo') DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idinsumo`),
  KEY `compra` (`compra`),
  CONSTRAINT `insumo_ibfk_1` FOREIGN KEY (`compra`) REFERENCES `compra` (`idcompra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumo`
--

LOCK TABLES `insumo` WRITE;
/*!40000 ALTER TABLE `insumo` DISABLE KEYS */;
/*!40000 ALTER TABLE `insumo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `idproveedor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `rif` varchar(15) DEFAULT NULL,
  `nombre` varchar(40) DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` varchar(12) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idproveedor`),
  UNIQUE KEY `rif` (`rif`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `iduser` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) DEFAULT NULL,
  `cedempleado` varchar(10) DEFAULT NULL,
  `tipo` enum('admin','usuario') DEFAULT NULL,
  `estatus` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`iduser`),
  UNIQUE KEY `username` (`username`),
  KEY `cedempleado` (`cedempleado`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`cedempleado`) REFERENCES `empleado` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'admin','1234','1','admin','A');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-15  9:46:03
