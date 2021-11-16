-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Sairaalakanta
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Sairaalakanta
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Sairaalakanta` DEFAULT CHARACTER SET utf8 ;
USE `Sairaalakanta` ;

-- -----------------------------------------------------
-- Table `Sairaalakanta`.`nimike`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`nimike` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`nimike` (
  `idnimike` INT NOT NULL AUTO_INCREMENT,
  `nimike` VARCHAR(45) NULL,
  PRIMARY KEY (`idnimike`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`työntekijä`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`työntekijä` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`työntekijä` (
  `idtyöntekijä` INT NOT NULL AUTO_INCREMENT,
  `etunimi` VARCHAR(45) NULL,
  `sukunimi` VARCHAR(45) NULL,
  `puhelin` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtyöntekijä`),
  INDEX `fk_työntekijä_nimike_idx` (`nimike_idnimike` ASC) VISIBLE,
  CONSTRAINT `fk_työntekijä_nimike`
    FOREIGN KEY (`nimike_idnimike`)
    REFERENCES `Sairaalakanta`.`nimike` (`idnimike`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`työvuoro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`työvuoro` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`työvuoro` (
  `idtyövuoro` INT NOT NULL AUTO_INCREMENT,
  `alkaa` DATETIME NULL,
  `loppuu` DATETIME NULL,
  PRIMARY KEY (`idtyövuoro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tehtävä`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`tehtävä` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`tehtävä` (
  `idtehtävä` INT NOT NULL AUTO_INCREMENT,
  `tehtävä` VARCHAR(45) NULL,
  `paikka` VARCHAR(45) NULL,
  `nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtehtävä`),
  INDEX `fk_tehtävä_nimike1_idx` (`nimike_idnimike` ASC) VISIBLE,
  CONSTRAINT `fk_tehtävä_nimike1`
    FOREIGN KEY (`nimike_idnimike`)
    REFERENCES `Sairaalakanta`.`nimike` (`idnimike`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tarve`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`tarve` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`tarve` (
  `työvuoro_idtyövuoro` INT NOT NULL,
  `tehtävä_idtehtävä` INT NOT NULL,
  `määrä` INT NULL,
  PRIMARY KEY (`työvuoro_idtyövuoro`, `tehtävä_idtehtävä`),
  INDEX `fk_työvuoro_has_tehtävä_tehtävä1_idx` (`tehtävä_idtehtävä` ASC) VISIBLE,
  INDEX `fk_työvuoro_has_tehtävä_työvuoro1_idx` (`työvuoro_idtyövuoro` ASC) VISIBLE,
  CONSTRAINT `fk_työvuoro_has_tehtävä_työvuoro1`
    FOREIGN KEY (`työvuoro_idtyövuoro`)
    REFERENCES `Sairaalakanta`.`työvuoro` (`idtyövuoro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_työvuoro_has_tehtävä_tehtävä1`
    FOREIGN KEY (`tehtävä_idtehtävä`)
    REFERENCES `Sairaalakanta`.`tehtävä` (`idtehtävä`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`kiinnitys`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`kiinnitys` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`kiinnitys` (
  `työntekijä_idtyöntekijä` INT NOT NULL,
  `tarve_työvuoro_idtyövuoro` INT NOT NULL,
  `tarve_tehtävä_idtehtävä` INT NOT NULL,
  INDEX `fk_kiinnitys_tarve1_idx` (`tarve_työvuoro_idtyövuoro` ASC, `tarve_tehtävä_idtehtävä` ASC) VISIBLE,
  INDEX `fk_kiinnitys_työntekijä1_idx` (`työntekijä_idtyöntekijä` ASC) VISIBLE,
  CONSTRAINT `fk_kiinnitys_tarve1`
    FOREIGN KEY (`tarve_työvuoro_idtyövuoro` , `tarve_tehtävä_idtehtävä`)
    REFERENCES `Sairaalakanta`.`tarve` (`työvuoro_idtyövuoro` , `tehtävä_idtehtävä`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_kiinnitys_työntekijä1`
    FOREIGN KEY (`työntekijä_idtyöntekijä`)
    REFERENCES `Sairaalakanta`.`työntekijä` (`idtyöntekijä`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO nimike (nimike)
VALUE
('Yleislääkäri'),
('Kirurgi'),
('Sairaanhoitaja'),
('Erikoislääkäri'),
('Anestesialääkäri'),
('Anestesiahoitaja'), 
('Ortopedi'),
('Lähihoitaja'),
('Röntgenhoitaja'),
('Fysioterapeutti');

INSERT INTO työntekijä(etunimi, sukunimi, puhelin, email, nimike_idnimike)
VALUES
( 'Laura', 'Mattila', '0505273578', 'lauram@gmail.com', 1),
('Terhi', 'Järvinen', '0405023687', 'jarvinenterhi@hotmail.com', 2),
( 'Emma', 'Porilainen', '0507777555', 'emmapori@gmail.com', 3),
( 'Ville', 'Vihuri', '0406668899', 'vihurinen@luukku.fi', 4);