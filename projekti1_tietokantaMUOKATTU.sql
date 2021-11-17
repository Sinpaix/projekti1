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

INSERT INTO tehtävä(tehtävä, paikka, nimike_idnimike)
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

INSERT INTO työvuoro(alkaa, loppuu)
values
('2021-11-17 06:00', '2021-11-17 14:00'),
('2021-11-17 14:00', '2021-11-17 22:00'),
('2021-11-17 22:00', '2021-11-18 06:00');

INSERT INTO tarve(työvuoro_idtyövuoro, tehtävä_idtehtävä, määrä)
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

INSERT INTO kiinnitys(työntekijä_idtyöntekijä, tarve_työvuoro_idtyövuoro, tarve_tehtävä_idtehtävä)
values
(3, 1, 1),
(1, 1, 2),
(5, 2, 4),
(6, 2, 5),
(9, 3, 4),
(7, 3, 5);
