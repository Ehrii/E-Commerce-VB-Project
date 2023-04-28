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
-- Table structure for table `stockhistory`
--

DROP TABLE IF EXISTS `stockhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stockhistory` (
  `History_ID` int NOT NULL AUTO_INCREMENT,
  `Inventory_ID` int NOT NULL,
  `Product_Name` varchar(45) NOT NULL,
  `Total_Stocks` int NOT NULL,
  `Stock_Adjustments` int NOT NULL,
  `Action_Type` varchar(45) NOT NULL,
  `Inventory_Date` datetime NOT NULL,
  PRIMARY KEY (`History_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stockhistory`
--

LOCK TABLES `stockhistory` WRITE;
/*!40000 ALTER TABLE `stockhistory` DISABLE KEYS */;
INSERT INTO `stockhistory` VALUES (5,11402,'Men’s Full Zip Tracksuit Set',15,2,'ADDED STOCKS +(2)','2023-04-26 14:02:58'),(6,11401,'Men’s Long Sleeve Hooded Sweatshirt Set',13,4,'ADDED STOCKS +(4)','2023-04-26 14:21:09'),(8,11400,'Men’s Jogging Tracksuit Set',38,4,'ADDED STOCKS +(4)','2023-04-26 20:21:05'),(9,11400,'Men’s Jogging Tracksuit Set',42,4,'REMOVED STOCKS -(4)','2023-04-26 20:22:33');
/*!40000 ALTER TABLE `stockhistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-28 21:53:51
