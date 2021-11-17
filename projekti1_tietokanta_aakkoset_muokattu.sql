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
-- Table `Sairaalakanta`.`tyontekija`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`tyontekija` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`tyontekija` (
  `idtyontekija` INT NOT NULL AUTO_INCREMENT,
  `etunimi` VARCHAR(45) NULL,
  `sukunimi` VARCHAR(45) NULL,
  `puhelin` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtyontekija`),
  INDEX `fk_työntekijä_nimike_idx` (`nimike_idnimike` ASC) VISIBLE,
  CONSTRAINT `fk_työntekijä_nimike`
    FOREIGN KEY (`nimike_idnimike`)
    REFERENCES `Sairaalakanta`.`nimike` (`idnimike`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tyovuoro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`tyovuoro` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`tyovuoro` (
  `idtyovuoro` INT NOT NULL AUTO_INCREMENT,
  `alkaa` DATETIME NULL,
  `loppuu` DATETIME NULL,
  PRIMARY KEY (`idtyovuoro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tehtava`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`tehtava` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`tehtava` (
  `idtehtava` INT NOT NULL AUTO_INCREMENT,
  `tehtava` VARCHAR(45) NULL,
  `paikka` VARCHAR(45) NULL,
  `nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtehtava`),
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
  `tyovuoro_idtyovuoro` INT NOT NULL,
  `tehtava_idtehtava` INT NOT NULL,
  `maara` INT NULL,
  PRIMARY KEY (`tyovuoro_idtyovuoro`, `tehtava_idtehtava`),
  INDEX `fk_työvuoro_has_tehtävä_tehtävä1_idx` (`tehtava_idtehtava` ASC) VISIBLE,
  INDEX `fk_työvuoro_has_tehtävä_työvuoro1_idx` (`tyovuoro_idtyovuoro` ASC) VISIBLE,
  CONSTRAINT `fk_työvuoro_has_tehtävä_työvuoro1`
    FOREIGN KEY (`tyovuoro_idtyovuoro`)
    REFERENCES `Sairaalakanta`.`tyovuoro` (`idtyovuoro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_työvuoro_has_tehtävä_tehtävä1`
    FOREIGN KEY (`tehtava_idtehtava`)
    REFERENCES `Sairaalakanta`.`tehtava` (`idtehtava`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`kiinnitys`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`kiinnitys` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`kiinnitys` (
  `tyontekija_idtyontekija` INT NOT NULL,
  `tarve_tyovuoro_idtyovuoro` INT NOT NULL,
  `tarve_tehtava_idtehtava` INT NOT NULL,
  INDEX `fk_kiinnitys_tarve1_idx` (`tarve_tyovuoro_idtyovuoro` ASC, `tarve_tehtava_idtehtava` ASC) VISIBLE,
  INDEX `fk_kiinnitys_työntekijä1_idx` (`tyontekija_idtyontekija` ASC) VISIBLE,
  CONSTRAINT `fk_kiinnitys_tarve1`
    FOREIGN KEY (`tarve_tyovuoro_idtyovuoro` , `tarve_tehtava_idtehtava`)
    REFERENCES `Sairaalakanta`.`tarve` (`tyovuoro_idtyovuoro` , `tehtava_idtehtava`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_kiinnitys_työntekijä1`
    FOREIGN KEY (`tyontekija_idtyontekija`)
    REFERENCES `Sairaalakanta`.`tyontekija` (`idtyontekija`)
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

INSERT INTO tyontekija(etunimi, sukunimi, puhelin, email, nimike_idnimike)
VALUES
( 'Laura', 'Mattila', '0505273578', 'lauram@gmail.com', 1),
('Terhi', 'Järvinen', '0405023687', 'jarvinenterhi@hotmail.com', 2),
( 'Emma', 'Porilainen', '0507777555', 'emmapori@gmail.com', 3),
( 'Ville', 'Vihuri', '0406668899', 'vihurinen@luukku.fi', 4),
('Minna', 'Muikku', '0404234234', 'muikku.minna@hotmail.com', 1),
('Henri', 'Heinonen', '0456745378', 'henri.heinonn@gmailmail.com', 3),
('Hanna', 'Kirjavainen', '0552424241', 'hansu76@hotmail.com', 3),
('Pauli', 'Kalalahti', '0402232346', 'pauli.kalalahti@luukku.com', 3),
('Raija', 'Lehtonen', '0407706044', 'raija.lehtonen@hotmail.com', 1),
('Paavo', 'Maijala', '0502211665', 'paukku.maijala@gmail.com', 1),
('Ninni', 'Maijala', '0506523452', 'maijala.ninni@gmail.com', 5),
('Jorma', 'Kirves', '0445326511', 'joppe65@gmail.com', 9),
('Heikki', 'Näsä', '0506254526', 'hessu.naesae@hotmail.com', 10),
('Emma', 'Koskelo', '0445446522', 'emma.koskelo@gmail.com', 7),
('Kalle', 'Vilpas', '0552654788', 'kale@gmail.com', 6),
('Kaija', 'Papu', '05014265489', 'papu.kaija@gmail.com', 8),
('Henrik', 'Berg', '0405013665', 'henrik01@gmail.com', 4),
('Will', 'Yard', '6522145554', 'will.yard@gmail.com', 2),
('Kalevi', 'Ankka', '0405043562', 'kale.ankka@gmail.com', 3);

INSERT INTO tehtava(tehtava, paikka, nimike_idnimike)
values
('vastaanotto SH', 'Osasto A', 3),
('vastaanotto LK', 'Osasto A', 1),
('vastaanotto FT', 'Osasto A', 10),
('lääkärinkierto', 'Osasto B', 1),
('sairaanhoitajankierto', 'Osasto B', 3),
('leikkaus', 'Osasto B', 2),
('leikkaus', 'Osasto B', 3),
('leikkaus', 'Osasto B', 5),
('leikkaus', 'Osasto B', 6);

INSERT INTO tyovuoro(alkaa, loppuu)
values
('2021-11-17 06:00', '2021-11-17 14:00'),
('2021-11-17 14:00', '2021-11-17 22:00'),
('2021-11-17 22:00', '2021-11-18 06:00');

INSERT INTO tarve(tyovuoro_idtyovuoro, tehtava_idtehtava, maara)
values
(1, 1, 1),
(1, 2, 1),
(1, 4, 1),
(1, 5, 1),
(2, 1, 1),
(2, 2, 1),
(2, 4, 1),
(2, 5, 1),
(3, 1, 1),
(3, 2, 1),
(3, 4, 1),
(3, 5, 1),
(1, 6, 1);

INSERT INTO kiinnitys(tyontekija_idtyontekija, tarve_tyovuoro_idtyovuoro, tarve_tehtava_idtehtava)
values
(3, 1, 1),
(1, 1, 2),
(5, 2, 4),
(6, 2, 5),
(9, 3, 4),
(7, 3, 5);

