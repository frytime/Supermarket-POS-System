-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: logindb
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `baskets`
--

DROP TABLE IF EXISTS `baskets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `baskets` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `productID` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `basketFK_idx` (`productID`),
  CONSTRAINT `basketFK` FOREIGN KEY (`productID`) REFERENCES `products` (`productsID`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baskets`
--

LOCK TABLES `baskets` WRITE;
/*!40000 ALTER TABLE `baskets` DISABLE KEYS */;
INSERT INTO `baskets` VALUES (37,1,5),(38,2,3);
/*!40000 ALTER TABLE `baskets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `idcustomers` int NOT NULL,
  `customerName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idcustomers`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Nasri'),(2,'Sam'),(3,'Samantha'),(4,'Eggeggyegg');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employeesID` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(255) DEFAULT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `job` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `IDuser` int DEFAULT NULL,
  PRIMARY KEY (`employeesID`),
  KEY `FK_employeeID_idx` (`IDuser`),
  CONSTRAINT `FK_employeeID` FOREIGN KEY (`IDuser`) REFERENCES `users` (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (2,'jeff','smith','jeff street\r\njeff city','jeff','jeffkingsley@gmail.com',6),(3,NULL,NULL,NULL,NULL,NULL,6),(4,NULL,NULL,NULL,NULL,NULL,7),(5,NULL,NULL,NULL,NULL,NULL,2),(6,NULL,NULL,NULL,NULL,NULL,3),(7,NULL,NULL,NULL,NULL,NULL,1),(8,NULL,NULL,NULL,NULL,NULL,4),(9,NULL,NULL,NULL,NULL,NULL,5),(10,NULL,NULL,NULL,NULL,NULL,8),(11,NULL,NULL,NULL,NULL,NULL,9),(12,NULL,NULL,NULL,NULL,NULL,10),(13,NULL,NULL,NULL,NULL,NULL,11);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `licences`
--

DROP TABLE IF EXISTS `licences`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `licences` (
  `idlicences` int NOT NULL,
  `LicenceType` varchar(45) DEFAULT NULL,
  `licenceNumber` int DEFAULT NULL,
  `startDate` varchar(255) DEFAULT NULL,
  `expiryDate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idlicences`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `licences`
--

LOCK TABLES `licences` WRITE;
/*!40000 ALTER TABLE `licences` DISABLE KEYS */;
INSERT INTO `licences` VALUES (1,'BASIC',60175460,'02/23','02/23'),(2,'System.Windows.Forms.TextBox, Text: PREMIUM',52552174,'02/23','02/23');
/*!40000 ALTER TABLE `licences` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderproductlink`
--

DROP TABLE IF EXISTS `orderproductlink`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderproductlink` (
  `id` int NOT NULL AUTO_INCREMENT,
  `orderID` int DEFAULT NULL,
  `productID` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `ordersforeign_idx` (`orderID`),
  KEY `productsforeign_idx` (`productID`),
  CONSTRAINT `ordersforeign` FOREIGN KEY (`orderID`) REFERENCES `orders` (`idorders`),
  CONSTRAINT `productsforeign` FOREIGN KEY (`productID`) REFERENCES `products` (`productsID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproductlink`
--

LOCK TABLES `orderproductlink` WRITE;
/*!40000 ALTER TABLE `orderproductlink` DISABLE KEYS */;
INSERT INTO `orderproductlink` VALUES (20,1,1,5),(22,2,1,7),(23,3,1,7),(24,3,2,5),(25,10,1,5),(26,10,2,3);
/*!40000 ALTER TABLE `orderproductlink` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `idorders` int NOT NULL,
  `totalamount` double DEFAULT NULL,
  `date` varchar(255) DEFAULT NULL,
  `customerID` int DEFAULT NULL,
  PRIMARY KEY (`idorders`),
  KEY `SaleFK_idx` (`idorders`),
  KEY `ordersforeign_idx` (`customerID`),
  CONSTRAINT `customerforeign` FOREIGN KEY (`customerID`) REFERENCES `customers` (`idcustomers`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,10.36,'23/02/2023 18:01:39',1),(2,21.76,'25/02/2023 09:51:25',2),(3,37.3,'25/02/2023 09:52:45',3),(10,24.86,'11/03/2023 13:56:11',4);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `productsID` int NOT NULL,
  `productName` varchar(255) DEFAULT NULL,
  `price` decimal(6,2) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `stock` int DEFAULT NULL,
  `barcode` int NOT NULL,
  `supplerID` int NOT NULL,
  PRIMARY KEY (`productsID`),
  KEY `foreignSupp_idx` (`supplerID`),
  CONSTRAINT `prodForeign` FOREIGN KEY (`supplerID`) REFERENCES `suppliers` (`idsuppliers`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Crisps',3.00,'Cheese Flavour',26,84873986,1),(2,'Chedder',3.00,'Nice Flavour',10,84873986,1),(3,'Toy Car',15.00,'Red-Black Ferrari Car',75,14709516,1);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `idsuppliers` int NOT NULL,
  `firstName` varchar(45) DEFAULT NULL,
  `lastName` varchar(45) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `company` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `telephoneNum` int DEFAULT NULL,
  `licenceID` int DEFAULT NULL,
  PRIMARY KEY (`idsuppliers`),
  KEY `licenceForeign_idx` (`licenceID`),
  CONSTRAINT `licenceForeign` FOREIGN KEY (`licenceID`) REFERENCES `licences` (`idlicences`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Nasri','Ibrahim','Bristol City','Nasri Ltd','nasri@gmail.com',991,1);
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `userID` int NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `salt` varchar(255) NOT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','ARzNz0Oh48DXi4srIiBzbZ8ECK4=','YGDqxwCeEtAFUywIEDG52w=='),(2,'nasri','239+3agIxdhV4W1qCJTS4evUhEI=','7lPW+vXnOEjJpzQbMXWyWA=='),(3,'nathan','8rigGn+aVHBfTEsirwStpwQAdZU=','+DnCjG+y3MseHsmtVl6DaA=='),(4,'test123','K+vUB9nrNuDGw9k82/i6haWowfw=','rDZNs1bwuha9c76jPPob+w=='),(5,'test45','IjeJWebpRtPjQyS8obEt7wAaPo8=','G/DMlp4HiIhl/zW1lknurg=='),(6,'has','mFo5xCf7KVi3HA4PQkUC9yftSU0=','Ay6Bt7Sd2aFoajgb7hpyAQ=='),(7,'Jeff','I2qeBos/rp7G9YCkS+6AMT53b4s=','bstUZ4iJZspilKJKAfLIng=='),(8,'tester','dPcp4sssE338jUvzj1nPLEFbwJc=','BfAIxuhr9Jron5Z7ciJWZg=='),(9,'hello','PhzobAM9yIgfCUBdNXtjfn6TPNI=','K4Zz+p9qj1iDOYpj5Jl7LA=='),(10,'eggyeggegg','pxRwtHuReZcCfoTgbH11jREoOcE=','UXU63WmZv+LNaFETcBqqUw=='),(11,'mytest','ZWMjWghmAkVl+3uY9ooaSQDmZvU=','tjniiqNg7fbp7Viog2swHQ==');
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

-- Dump completed on 2023-03-15 22:08:30
