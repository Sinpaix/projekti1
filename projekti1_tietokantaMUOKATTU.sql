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
-- Table `Sairaalakanta`.`Nimike`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Nimike` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Nimike` (
  `idnimike` INT NOT NULL AUTO_INCREMENT,
  `nimike` VARCHAR(45) NULL,
  PRIMARY KEY (`idnimike`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`Tyontekija`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Tyontekija` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Tyontekija` (
  `idtyontekija` INT NOT NULL AUTO_INCREMENT,
  `etunimi` VARCHAR(45) NULL,
  `sukunimi` VARCHAR(45) NULL,
  `puhelin` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `Nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtyontekija`),
  INDEX `fk_tyontekija_nimike_idx` (`Nimike_idnimike` ASC) VISIBLE,
  CONSTRAINT `fk_tyontekija_nimike`
    FOREIGN KEY (`Nimike_idnimike`)
    REFERENCES `Sairaalakanta`.`Nimike` (`idnimike`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`Tyovuoro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Tyovuoro` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Tyovuoro` (
  `idtyovuoro` INT NOT NULL AUTO_INCREMENT,
  `alkaa` DATETIME NULL,
  `loppuu` DATETIME NULL,
  PRIMARY KEY (`idtyovuoro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tehtävä`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Tehtava` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Tehtava` (
  `idtehtava` INT NOT NULL AUTO_INCREMENT,
  `tehtava` VARCHAR(45) NULL,
  `paikka` VARCHAR(45) NULL,
  `Nimike_idnimike` INT NOT NULL,
  PRIMARY KEY (`idtehtava`),
  INDEX `fk_tehtava_nimike1_idx` (`Nimike_idnimike` ASC) VISIBLE,
  CONSTRAINT `fk_tehtava_nimike1`
    FOREIGN KEY (`Nimike_idnimike`)
    REFERENCES `Sairaalakanta`.`Nimike` (`idnimike`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`tarve`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Tarve` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Tarve` (
  `Tyovuoro_idtyovuoro` INT NOT NULL,
  `Tehtava_idtehtava` INT NOT NULL,
  `maara` INT NULL,
  PRIMARY KEY (`Tyovuoro_idtyovuoro`, `Tehtava_idtehtava`),
  INDEX `fk_tyovuoro_has_tehtava_tehtava1_idx` (`Tehtava_idtehtava` ASC) VISIBLE,
  INDEX `fk_tyovuoro_has_tehtava_tyovuoro1_idx` (`Tyovuoro_idtyovuoro` ASC) VISIBLE,
  CONSTRAINT `fk_työvuoro_has_Tehtava_tyovuoro1`
    FOREIGN KEY (`Tyovuoro_idtyovuoro`)
    REFERENCES `Sairaalakanta`.`Tyovuoro` (`idtyovuoro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tyovuoro_has_tehtava_tehtava1`
    FOREIGN KEY (`Tehtava_idtehtava`)
    REFERENCES `Sairaalakanta`.`Tehtava` (`idtehtava`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Sairaalakanta`.`Kiinnitys`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Sairaalakanta`.`Kiinnitys` ;

CREATE TABLE IF NOT EXISTS `Sairaalakanta`.`Kiinnitys` (
  `Tyontekija_idtyontekija` INT NOT NULL,
  `Tarve_Tyovuoro_idtyovuoro` INT NOT NULL,
  `Tarve_Tehtava_idtehtava` INT NOT NULL,
  INDEX `fk_kiinnitys_tarve1_idx` (`Tarve_Tyovuoro_idtyovuoro` ASC, `Tarve_Tehtava_idtehtava` ASC) VISIBLE,
  INDEX `fk_kiinnitys_tyontekija1_idx` (`Tyontekija_idtyontekija` ASC) VISIBLE,
  CONSTRAINT `fk_kiinnitys_tarve1`
    FOREIGN KEY (`Tarve_Tyovuoro_idtyovuoro` , `Tarve_Tehtava_idtehtava`)
    REFERENCES `Sairaalakanta`.`Tarve` (`Tyovuoro_idtyovuoro` , `Tehtava_idtehtava`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_kiinnitys_tyontekija1`
    FOREIGN KEY (`Tyontekija_idtyontekija`)
    REFERENCES `Sairaalakanta`.`Tyontekija` (`idtyontekija`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO Nimike (nimike)
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

INSERT INTO Tyontekija(etunimi, sukunimi, puhelin, email, Nimike_idnimike)
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

INSERT INTO Tehtava(tehtava, paikka, Nimike_idnimike)
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

INSERT INTO Tyovuoro(alkaa, loppuu)
values
('2021-11-17 06:00', '2021-11-17 14:00'),
('2021-11-17 14:00', '2021-11-17 22:00'),
('2021-11-17 22:00', '2021-11-18 06:00');

INSERT INTO Tarve(Tyovuoro_idtyovuoro, Tehtava_idtehtava, maara)
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

INSERT INTO Kiinnitys(Tyontekija_idtyontekija, Tarve_Tyovuoro_idtyovuoro, Tarve_Tehtava_idtehtava)
values
(3, 1, 1),
(1, 1, 2),
(5, 2, 4),
(6, 2, 5),
(9, 3, 4),
(7, 3, 5);
