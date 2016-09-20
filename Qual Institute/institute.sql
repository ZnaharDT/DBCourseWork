-- MySQL dump 10.13  Distrib 5.5.46, for Win32 (x86)
--
-- Host: localhost    Database: qual institute
-- ------------------------------------------------------
-- Server version	5.5.46

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `groups` (
  `idGroup` int(11) NOT NULL,
  `name` varchar(10) DEFAULT NULL,
  `specId` int(11) NOT NULL,
  `count_of_students` int(4) DEFAULT '0',
  PRIMARY KEY (`idGroup`),
  KEY `specId` (`specId`),
  CONSTRAINT `FK_groups_specialties` FOREIGN KEY (`specId`) REFERENCES `specialties` (`idSpec`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (3,'пт-21',1234,0),(4,'пт-22',1234,0),(5,'са-10',1444,0),(6,'са-11',1444,0),(7,'су-31',1345,0),(8,'су-32',1345,-1);
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marks`
--

DROP TABLE IF EXISTS `marks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marks` (
  `studId` int(11) NOT NULL,
  `subjId` int(11) NOT NULL,
  `mark` int(11) DEFAULT NULL,
  KEY `studId` (`studId`),
  KEY `subjId` (`subjId`),
  CONSTRAINT `marks_ibfk_1` FOREIGN KEY (`studId`) REFERENCES `students` (`idStud`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `marks_ibfk_2` FOREIGN KEY (`subjId`) REFERENCES `subjects` (`idSubject`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marks`
--

LOCK TABLES `marks` WRITE;
/*!40000 ALTER TABLE `marks` DISABLE KEYS */;
INSERT INTO `marks` VALUES (42,41,4),(42,12,3);
/*!40000 ALTER TABLE `marks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedule` (
  `teacherId` int(11) NOT NULL,
  `subjId` int(11) NOT NULL,
  `groupId` int(11) NOT NULL,
  `day` enum('Пон','Вт','Ср','Чт','Пт','Сб') DEFAULT NULL,
  `startTime` time DEFAULT NULL,
  KEY `teacherId` (`teacherId`),
  KEY `subjId` (`subjId`),
  KEY `groupId` (`groupId`),
  CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`teacherId`) REFERENCES `teachers` (`idTeacher`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_ibfk_2` FOREIGN KEY (`subjId`) REFERENCES `subjects` (`idSubject`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_ibfk_3` FOREIGN KEY (`groupId`) REFERENCES `groups` (`idGroup`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` VALUES (4,33,8,'Пт','12:20:00'),(4,32,8,'Пт','14:15:00');
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specialties`
--

DROP TABLE IF EXISTS `specialties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `specialties` (
  `idSpec` int(11) NOT NULL,
  `specName` varchar(50) NOT NULL,
  `studyingTime` int(11) DEFAULT NULL,
  `timesAtYear` int(11) DEFAULT NULL,
  `hasHostel` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idSpec`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialties`
--

LOCK TABLES `specialties` WRITE;
/*!40000 ALTER TABLE `specialties` DISABLE KEYS */;
INSERT INTO `specialties` VALUES (1234,'ОС',2,3,1),(1345,'СУБД',1,2,0),(1444,'САПР',1,4,1);
/*!40000 ALTER TABLE `specialties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `idStud` int(11) NOT NULL,
  `organisation` enum('завод КИАПО г. Киев','УКРНИИинжпроект  г. Львов','Кривбасспроект г. Кривой Рог') DEFAULT NULL,
  `groupId` int(11) NOT NULL,
  PRIMARY KEY (`idStud`),
  KEY `groupId` (`groupId`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`groupId`) REFERENCES `groups` (`idGroup`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (11,'завод КИАПО г. Киев',3),(42,'Кривбасспроект г. Кривой Рог',8);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger add_stu after insert on students for each row
begin
update groups set count_of_students = count_of_students + 1
where idgroup = new.groupid;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger upd_st after update on students for each row
begin
update groups set count_of_students = count_of_students-1
where idgroup = old.groupid;
update groups set count_of_students = count_of_students+1
where idgroup = new.groupid;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger del_stu after delete on students for each row
begin
update groups set count_of_students = count_of_students-1
where idgroup = old.groupid;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subjects` (
  `idSubject` int(11) NOT NULL,
  `subName` varchar(30) DEFAULT NULL,
  `lectHours` float DEFAULT NULL,
  `practHours` float DEFAULT NULL,
  PRIMARY KEY (`idSubject`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (11,'Экономика',15,10),(12,'MS DOS',25,25),(13,'Ассемблер',18,12),(14,'Бейсик',14,22),(21,'САПР',30,25),(31,'ТБД',15,16),(32,'РР СУБД',25,20),(33,'ПС СУБД',20,15),(41,'Паскаль',15,10);
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teachers` (
  `idTeacher` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `qual` enum('Нет','К.т.н.') DEFAULT 'Нет',
  `salary` float NOT NULL,
  PRIMARY KEY (`idTeacher`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Петр','Петров','Нет',5),(2,'Сергей','Сидоров','К.т.н.',6),(3,'Валентина','Михайлова','Нет',5),(4,'Ольга','Шевчук','К.т.н.',6);
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-21  1:08:24
