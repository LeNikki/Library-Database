-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: db_book
-- ------------------------------------------------------
-- Server version	8.0.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `book_table1`
--

DROP TABLE IF EXISTS `book_table1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_table1` (
  `BookID` int NOT NULL AUTO_INCREMENT,
  `ISBN_No` int NOT NULL,
  `Title` varchar(45) DEFAULT NULL,
  `Copyright_Date` varchar(45) DEFAULT NULL,
  `Primary_Author` varchar(45) DEFAULT NULL,
  `Publisher` varchar(45) DEFAULT NULL,
  `Pages` int DEFAULT NULL,
  `Course_No` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_table1`
--

LOCK TABLES `book_table1` WRITE;
/*!40000 ALTER TABLE `book_table1` DISABLE KEYS */;
INSERT INTO `book_table1` VALUES (4,23423423,'title 4','2323','fgfgh','dfghdh',45,'34'),(5,657567,'cngf','6476','fgjfgj','gfgjfgj',6,'565'),(6,13423424,'title 5','2-2-2','author 5','pub 5',98,'47657'),(9,334567676,'titlenanaman','3-4-5','author656','pub767',343,'FUN');
/*!40000 ALTER TABLE `book_table1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `coursebooks`
--

DROP TABLE IF EXISTS `coursebooks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coursebooks` (
  `BookID` int NOT NULL AUTO_INCREMENT,
  `ISBN_No` int NOT NULL,
  `Course_No` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coursebooks`
--

LOCK TABLES `coursebooks` WRITE;
/*!40000 ALTER TABLE `coursebooks` DISABLE KEYS */;
/*!40000 ALTER TABLE `coursebooks` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-14 10:47:26
