
#créer la BDD
CREATE SCHEMA `uaa9_24-25` ;

#créer la table User
CREATE TABLE `uaa9_24-25`.`user` (
  `UserID` INT NOT NULL AUTO_INCREMENT,
  `UserNom` VARCHAR(255) NOT NULL,
  `UserPrenom` VARCHAR(45) NOT NULL,
  `UserMail` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`UserID`));
