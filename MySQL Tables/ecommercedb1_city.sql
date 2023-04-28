-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: ecommercedb1
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `city` (
  `City_ID` int NOT NULL AUTO_INCREMENT,
  `Region_ID` int NOT NULL,
  `City_Name` varchar(45) NOT NULL,
  PRIMARY KEY (`City_ID`),
  KEY `Fk_region_id_idx` (`Region_ID`),
  CONSTRAINT `Fk_region_id` FOREIGN KEY (`Region_ID`) REFERENCES `region` (`Region_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=143 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,1001,'Batac City'),(2,1001,'Laog City'),(3,1001,'Candon City'),(4,1001,'Vigan City'),(5,1001,'San Fernando City'),(6,1001,'Alaminos city'),(7,1001,'Dagupan City'),(8,1001,'San Carlos City'),(9,1001,'Uradaneta City'),(10,1002,'Tuguegerao City'),(11,1002,'Cauyan City'),(12,1002,'Ilagan City'),(13,1002,'Santiago City'),(14,1003,'Balanga City'),(15,1003,'Malolos City'),(16,1003,'Meycauyan City'),(17,1003,'San Jose Del Monte City'),(18,1003,'Cabanatuan City'),(19,1003,'Gapan City'),(20,1003,'Muñoz City'),(21,1003,'Palayan City '),(22,1003,'Angeles City'),(23,1003,'Mabalacat City'),(24,1003,'San Fernando City'),(25,1003,'Tarlac City'),(26,1003,'Olangapo City'),(27,1003,'San Jose City'),(28,1004,'Batangas City'),(29,1004,'Lipa City'),(30,1004,'Tanuan City'),(31,1004,'Bacoor City'),(32,1004,'Dasmariñas City'),(33,1004,'Imus City'),(34,1004,'Tagaytay City'),(35,1004,'Trece Martires City'),(36,1004,'Biñan City'),(37,1004,'Cabuyao City'),(38,1004,'San Pablo City'),(39,1004,'Santa Rosa City'),(40,1004,'Lucena City'),(41,1004,'Tayabas City'),(42,1004,'Antipolo City'),(43,1004,'Calamba City'),(44,1005,'Calapan City'),(45,1005,'Puerto Princesa City'),(46,1006,'Legazpi City'),(47,1006,'Ligao City'),(48,1006,'Tabaco City'),(49,1006,'Iriga City'),(50,1006,'Naga City'),(51,1006,'Masbate City'),(52,1006,'Sorsogon City'),(53,1007,'Roxas City'),(54,1007,'Iloilo City'),(55,1007,'Passi City'),(56,1007,'Bacolod City'),(57,1007,'Bago City'),(58,1007,'Cadiz City'),(59,1007,'Escalante City'),(60,1007,'Himamaylan City'),(61,1007,'Kabankalan City'),(62,1007,'La Carlota City'),(63,1007,'Sagay City'),(64,1007,'San Carlos Ciy'),(65,1007,'Silay City'),(66,1007,'Sipalay City'),(67,1007,'Talisay City'),(68,1007,'Victorias City'),(69,1008,'Tagbiliran City'),(70,1008,'Bogo City'),(71,1008,'Carcar City'),(72,1008,'Cebu City'),(73,1008,'Danao City'),(74,1008,'Lapu-Lapu City'),(75,1008,'Mandaue City'),(76,1008,'Naga  City'),(77,1008,'Talisay City'),(78,1008,'Bais City'),(79,1008,'Bayawan City'),(80,1008,'Canlaon City'),(81,1008,'Dumaguete City'),(82,1008,'Guihulngan City'),(83,1008,'Tanjay City'),(84,1008,'Toledo City'),(85,1009,'Borongan City'),(86,1009,'Baybay City '),(87,1009,'Ormoc City'),(88,1009,'Tacloban City'),(89,1009,'Calbayog City'),(90,1009,'Catbalogan City'),(91,1009,'Massin City'),(92,1010,'Isabela City'),(93,1010,'Dapitan City'),(94,1010,'Dipolog City'),(95,1010,'Pagadian City'),(96,1010,'Zamboanga City'),(97,1011,'Malaybalay City'),(98,1011,'Valencia City'),(99,1011,'Iligan City'),(100,1011,'Oroquieta City'),(101,1011,'Ozamiz City'),(102,1011,'Tangub City'),(103,1011,'Cagayan De Oro City'),(104,1011,'El Salvador City'),(105,1011,'Gingoog City'),(106,1012,'Panabo City'),(107,1012,'Samal City'),(108,1012,'Tagum City'),(109,1012,'Davao City'),(110,1012,'Digos City'),(111,1012,'Mati City'),(112,1013,'Kidapawan City'),(113,1013,'Cotabato City'),(114,1013,'General Santos City'),(115,1013,'Koronadal City'),(116,1013,'Tacurong City'),(117,1014,'Butuan City'),(118,1014,'Cabadbaran City'),(119,1014,'Bayugan City'),(120,1014,'Surigao City'),(121,1014,'Bislig City'),(122,1014,'Tandag City'),(123,1015,'Caloocan City'),(124,1015,'Las Piñas City'),(125,1015,'Makati City'),(126,1015,'Malabon City'),(127,1015,'Mandaluyong City'),(128,1015,'Manila City'),(129,1015,'Marikina City'),(130,1015,'Muntinlupa City'),(131,1015,'Navotas City'),(132,1015,'Parañaque City'),(133,1015,'Pasay City'),(134,1015,'Pasig City'),(135,1015,'Quezon City'),(136,1015,'San Juan City'),(137,1015,'Taguig City'),(138,1015,'Valenzuela City'),(139,1016,'Baguio Cirt'),(140,1016,'Tabuk City'),(141,1017,'Lamitan City'),(142,1017,'Marawi City');
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-28 21:53:44
