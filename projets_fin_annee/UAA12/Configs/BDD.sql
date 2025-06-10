CREATE DATABASE  IF NOT EXISTS `solune` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `solune`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: 10.10.51.98    Database: solune
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `carte`
--

DROP TABLE IF EXISTS `carte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carte` (
  `carteID` bigint NOT NULL AUTO_INCREMENT,
  `carteNom` varchar(255) DEFAULT NULL,
  `carteDescription` varchar(255) DEFAULT NULL,
  `categorieID` bigint DEFAULT NULL,
  PRIMARY KEY (`carteID`),
  KEY `FKcategorieID` (`categorieID`),
  CONSTRAINT `FKcategorieID` FOREIGN KEY (`categorieID`) REFERENCES `categorie` (`categorieID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carte`
--

LOCK TABLES `carte` WRITE;
/*!40000 ALTER TABLE `carte` DISABLE KEYS */;
INSERT INTO `carte` VALUES (1,'test1','test1',52),(2,'une tache','ceci est une tache qui est très longue à écrire et courte à faire',52),(3,'test','testest',52);
/*!40000 ALTER TABLE `carte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorie` (
  `categorieID` bigint NOT NULL AUTO_INCREMENT,
  `categorieNom` varchar(255) DEFAULT NULL,
  `categoriePosition` int DEFAULT NULL,
  `projetID` bigint DEFAULT NULL,
  PRIMARY KEY (`categorieID`),
  KEY `FKprojet` (`projetID`),
  CONSTRAINT `FKprojet` FOREIGN KEY (`projetID`) REFERENCES `projet` (`projetID`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorie`
--

LOCK TABLES `categorie` WRITE;
/*!40000 ALTER TABLE `categorie` DISABLE KEYS */;
INSERT INTO `categorie` VALUES (42,'Analyse',2,3),(43,'Archi MVC',1,3),(44,'Cahier des charges',1,4),(45,'test',1,6),(46,'test2',1,6),(52,'dfqq',2,1),(55,'cat2',1,10),(57,'test scroll',2,1),(62,'test',1,6);
/*!40000 ALTER TABLE `categorie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projet`
--

DROP TABLE IF EXISTS `projet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projet` (
  `projetID` bigint NOT NULL AUTO_INCREMENT,
  `projetTitle` varchar(255) DEFAULT NULL,
  `projetDescription` varchar(255) DEFAULT NULL,
  `projetDateStart` date DEFAULT NULL,
  `projetDateEnd` date DEFAULT NULL,
  `projetMaker` bigint DEFAULT NULL,
  PRIMARY KEY (`projetID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projet`
--

LOCK TABLES `projet` WRITE;
/*!40000 ALTER TABLE `projet` DISABLE KEYS */;
INSERT INTO `projet` VALUES (1,'test new db','test',NULL,NULL,1),(2,'démo bb','fdsqfdqsdfqs',NULL,NULL,1),(3,'UAA12','projet personnel',NULL,NULL,3),(4,'UAA9','Apprendre à s\'organiser dans la création d\'un code C#',NULL,NULL,3),(6,'testeur','test les différents trucs\r\n',NULL,NULL,2),(7,'testeur','test les différents trucs\r\n',NULL,NULL,2),(8,'testeur','test',NULL,NULL,2),(9,'tester','test',NULL,NULL,2),(10,'démo arnaud','démo pour le con de la classe (moi)',NULL,NULL,1),(11,'p a supprimer','juste pour essai supp profil',NULL,NULL,4),(12,'p2 a supprimer','juste pour essai supp profil',NULL,NULL,4),(13,'titre','fdedsqfdsq\r\n',NULL,NULL,5);
/*!40000 ALTER TABLE `projet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `userID` bigint NOT NULL AUTO_INCREMENT,
  `userNom` varchar(255) DEFAULT NULL,
  `userPrenom` varchar(255) DEFAULT NULL,
  `userMail` varchar(255) DEFAULT NULL,
  `userPassword` varchar(255) DEFAULT NULL,
  `userLogin` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Solune','Petit','petitsolune01@gmail.com','cosmo','cosmo'),(2,'2','test','test@gmail.com','test','test'),(3,'b','b','b@ici.net','b','b'),(4,'bbb','bbb','bbb@la.net','bbb','bbb'),(5,'testbb','testbb','testbb@gmail.com','testbb','testbb');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userprojet`
--

DROP TABLE IF EXISTS `userprojet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userprojet` (
  `userID` bigint NOT NULL AUTO_INCREMENT,
  `projetID` bigint NOT NULL,
  PRIMARY KEY (`userID`,`projetID`),
  KEY `FKProjetID` (`projetID`),
  CONSTRAINT `FKProjetID` FOREIGN KEY (`projetID`) REFERENCES `projet` (`projetID`),
  CONSTRAINT `FKuserID` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userprojet`
--

LOCK TABLES `userprojet` WRITE;
/*!40000 ALTER TABLE `userprojet` DISABLE KEYS */;
INSERT INTO `userprojet` VALUES (1,1),(1,2),(3,3),(3,4),(2,6),(2,8),(2,9),(1,10),(4,11),(4,12),(5,13);
/*!40000 ALTER TABLE `userprojet` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-04 14:56:51
