
#créer la BDD
CREATE SCHEMA `uaa9_24-25` ;

#créer la table User
CREATE TABLE `uaa9_24-25`.`user` (
  `UserID` INT NOT NULL AUTO_INCREMENT,
  `UserNom` VARCHAR(255) NOT NULL,
  `UserPrenom` VARCHAR(255) NOT NULL,
  `UserMail` VARCHAR(255) NOT NULL,
  `UserPassword` VARCHAR(255) NOT NULL,
  `UserLogin` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`UserID`));

#création de la table Projet
CREATE TABLE `uaa9_24-25`.`projet` (
  `ProjetID` INT NOT NULL AUTO_INCREMENT,
  `ProjetMakerID` INT NOT NULL,
  `ProjetTitle` VARCHAR(45) NULL,
  `ProjetDescription` VARCHAR(255) NULL,
  `ProjetDateStart` DATE NULL,
  `ProjetDateEnd` DATE NULL,
  PRIMARY KEY (`ProjetID`),
  UNIQUE INDEX `ProjetID_UNIQUE` (`ProjetID` ASC) VISIBLE);


#création de la table de jointure userProjet de façon à ce que si il faut, on peut suprimer des éléments plus facilement
CREATE TABLE `uaa9_24-25`.`userprojet` (
  `userProjetID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `ProjetID` INT NOT NULL,
  `ProjetMakerID` INT NOT NULL,
  PRIMARY KEY (`userProjetID`),
  UNIQUE INDEX `userProjetID_UNIQUE` (`userProjetID` ASC) VISIBLE,
  CONSTRAINT `UserID`
    FOREIGN KEY (`UserID`)
    REFERENCES `uaa9_24-25`.`user` (`UserID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProjetID`
    FOREIGN KEY (`ProjetID`)
    REFERENCES `uaa9_24-25`.`projet` (`ProjetID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

#création de la table categorie qui aura un lien avec la table projet
CREATE TABLE `uaa9_24-25`.`categorie` (
  `categorieID` INT NOT NULL AUTO_INCREMENT,
  `categorieNom` VARCHAR(45) NULL,
  `categoriePosition` INT NULL,
  `ProjetID` INT NOT NULL,  -- Ajout de la colonne ProjetID
  PRIMARY KEY (`categorieID`),
  CONSTRAINT `FK_ProjetID`  -- Nouveau nom de la contrainte
    FOREIGN KEY (`ProjetID`)  -- Définition de la clé étrangère
    REFERENCES `uaa9_24-25`.`projet` (`ProjetID`)  -- Lien avec la colonne ProjetID de la table projet
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

#création de la table carte qui aura un lien avec la table categorie
CREATE TABLE `uaa9_24-25`.`carte` (
  `carteID` INT NOT NULL AUTO_INCREMENT,  -- Ajout de AUTO_INCREMENT
  `carteNom` VARCHAR(45) NULL,
  `carteDescription` VARCHAR(45) NULL,
  `carteDateDebut` DATE NULL,
  `carteDateFin` DATE NULL,
  `categorieID` INT NOT NULL,  -- Ajout de la colonne categorieID
  PRIMARY KEY (`carteID`),
  CONSTRAINT `FK_categorieID`  -- Nom de la contrainte
    FOREIGN KEY (`categorieID`)  -- Définition de la clé étrangère
    REFERENCES `uaa9_24-25`.`categorie` (`categorieID`)  -- Lien avec la table categorie
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
