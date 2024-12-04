-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: midtermprojectdb
-- ------------------------------------------------------
-- Server version	5.6.51-log

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
-- Table structure for table `buy`
--

DROP TABLE IF EXISTS `buy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `buy` (
  `BUY_NUM` int(11) NOT NULL AUTO_INCREMENT,
  `BUY_ID` varchar(50) DEFAULT NULL,
  `ITEM_NUM` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL,
  `BUY_QTY` int(11) DEFAULT NULL,
  `BUY_DISCOUNT` varchar(50) DEFAULT NULL,
  `BUY_PRICE` varchar(50) DEFAULT NULL,
  `BUY_TPRICE` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`BUY_NUM`),
  KEY `ID` (`ID`),
  KEY `ITEM_NUM` (`ITEM_NUM`),
  CONSTRAINT `buy_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `buy_ibfk_2` FOREIGN KEY (`ITEM_NUM`) REFERENCES `item` (`ITEM_NUM`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buy`
--

LOCK TABLES `buy` WRITE;
/*!40000 ALTER TABLE `buy` DISABLE KEYS */;
/*!40000 ALTER TABLE `buy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UID` varchar(50) DEFAULT NULL,
  `FNAME` varchar(50) DEFAULT NULL,
  `MNAME` varchar(50) DEFAULT NULL,
  `LNAME` varchar(50) DEFAULT NULL,
  `ADDRESS` varchar(80) DEFAULT NULL,
  `EMAIL` varchar(80) DEFAULT NULL,
  `CP` varchar(11) DEFAULT NULL,
  `PICTURE` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'CUS-2023-1','Maricar','Carreon','Aydalla','Purok 7, Matanag Legazpi City','carreonmaricar@gmail.com','09484838438','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_52_Pro.jpg'),(2,'CUS-2023-2','ANTHONY','DADO','DAEN','BURAGUIS','BURAGUIS LEGAZPI CITY','09238283282','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_58_Pro.jpg'),(3,'CUS-2023-3','Maricar','Carreon','Aydalla','Buraguis','angthonasd','09323823828','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_58_Pro.jpg'),(6,'CUS-2023-4','JohnDave','Dado','Daen','Buraguis Legazpi City','anthony@gmail.com','09328288328','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_39_Pro.jpg'),(7,'CUS-2023-7','Cleo','D','Daen','Matanag','cloe@gmail.com','09323888328','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_39_Pro.jpg'),(8,'CUS-2023-8','Waffle','D','Daen','Matanag','waffle@gmail.com','09328382838','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_58_Pro.jpg'),(9,'CUS-2023-9','Marco','D','Daen','Buraguis','marco@gmail,com','09232838283','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_58_Pro.jpg');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `ITEM_NUM` int(11) NOT NULL AUTO_INCREMENT,
  `ITEM_ID` varchar(30) DEFAULT NULL,
  `ITEM_NAME` varchar(40) DEFAULT NULL,
  `ITEM_PRICE` decimal(10,0) DEFAULT NULL,
  `ITEM_DESCRIPTION` text,
  `ITEM_PIC` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ITEM_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'ITEM-1-2023','System Unit',30000,'Intel i5,256 SSD','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_56_Pro.jpg'),(2,'ITEM-2-2023','PRINTER',12000,'BROTHER','C:;Users;carre;OneDrive;Pictures;Camera Roll;brother.jpg'),(3,'ITEM-3-2023','PRINTER',8000,'CANON','C:;Users;carre;OneDrive;Pictures;Camera Roll;canon.jpg'),(4,'ITEM-4-2023','Computer System',10000,'Intel i3, SSD 256','C:;Users;carre;OneDrive;Pictures;Camera Roll;WIN_20230923_14_22_56_Pro.jpg'),(5,'ITEM-5-2023','PRINTER',6000,'EPSON','C:;Users;carre;OneDrive;Pictures;Camera Roll;epson.jpg');
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-07 19:11:32
