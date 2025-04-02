
#créer la BDD
CREATE SCHEMA `uaa9_24-25` ;

#créer la table User
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `UserNom` varchar(255) NOT NULL,
  `UserPrenom` varchar(255) NOT NULL,
  `UserMail` varchar(255) NOT NULL,
  `UserPassword` varchar(255) NOT NULL,
  `UserLogin` varchar(255) NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `idx_UserPrenom` (`UserPrenom`)
)

#création de la table Projet
CREATE TABLE `projet` (
  `ProjetID` int NOT NULL AUTO_INCREMENT,
  `ProjetTitle` varchar(45) DEFAULT NULL,
  `ProjetDescription` varchar(500) DEFAULT NULL,
  `projetDateStart` date DEFAULT NULL,
  `projetDateEnd` date DEFAULT NULL,
  `projetMaker` int DEFAULT NULL,
  PRIMARY KEY (`ProjetID`),
  UNIQUE KEY `ProjetID_UNIQUE` (`ProjetID`),
  KEY `UserID_idx` (`projetMaker`)
)


#création de la table de jointure userProjet de façon à ce que si il faut, on peut suprimer des éléments plus facilement
CREATE TABLE `userprojet` (
  `userProjetID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `ProjetID` int NOT NULL,
  `ProjetMakerName` varchar(45) NOT NULL,
  PRIMARY KEY (`userProjetID`),
  UNIQUE KEY `userProjetID_UNIQUE` (`userProjetID`),
  KEY `UserID` (`UserID`),
  KEY `projetMakerID` (`ProjetID`),
  KEY `ProjetMakerID_idx` (`ProjetMakerName`),
  CONSTRAINT `ProjetID` FOREIGN KEY (`ProjetID`) REFERENCES `projet` (`ProjetID`),
  CONSTRAINT `UserID` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`)
)

#création de la table categorie qui aura un lien avec la table projet
CREATE TABLE `categorie` (
  `categorieID` int NOT NULL AUTO_INCREMENT,
  `categorieNom` varchar(45) DEFAULT NULL,
  `categoriePosition` int DEFAULT NULL,
  `ProjetID` int NOT NULL,
  PRIMARY KEY (`categorieID`),
  KEY `FK_ProjetID` (`ProjetID`),
  CONSTRAINT `FK_ProjetID` FOREIGN KEY (`ProjetID`) REFERENCES `projet` (`ProjetID`)
)

#création de la table carte qui aura un lien avec la table categorie
CREATE TABLE `carte` (
  `carteID` int NOT NULL AUTO_INCREMENT,
  `carteNom` varchar(45) DEFAULT NULL,
  `carteDescription` varchar(45) DEFAULT NULL,
  `carteDateDebut` date DEFAULT NULL,
  `carteDateFin` date DEFAULT NULL,
  `categorieID` int NOT NULL,
  PRIMARY KEY (`carteID`),
  KEY `FK_categorieID` (`categorieID`),
  CONSTRAINT `FK_categorieID` FOREIGN KEY (`categorieID`) REFERENCES `categorie` (`categorieID`)
)