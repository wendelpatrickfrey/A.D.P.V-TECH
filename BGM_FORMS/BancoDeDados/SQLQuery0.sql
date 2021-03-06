-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb`;	

-- -----------------------------------------------------
-- Table `mydb`.`TERCEIRO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`TERCEIRO` (
  `idTERCEIRO` INT NOT NULL AUTO_INCREMENT,
  `STATUS` BIT(1) NULL,
  `NOME` VARCHAR(50) NULL,
  `CPF` VARCHAR(11) NULL,
  `CNPJ` VARCHAR(14) NULL,
  `CNH` VARCHAR(11) NULL,
  `RENAVAM` VARCHAR(12) NULL,
  `EMAIL` VARCHAR(45) NULL,
  `TELEFONE` VARCHAR(45) NULL,
  `CEP` VARCHAR(45) NULL,
  PRIMARY KEY (`idTERCEIRO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`DOCUMENTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`DOCUMENTO` (
  `idDOCUMENTO` INT NOT NULL AUTO_INCREMENT,
  `NUMERO` VARCHAR(30) NOT NULL,
  `DATA` INT(8) NOT NULL,
  PRIMARY KEY (`idDOCUMENTO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PARCELAS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`PARCELAS` (
  `idPARCELAS` INT NOT NULL AUTO_INCREMENT,
  `QUANTIDADE` VARCHAR(45) NULL,
  `DATAINICIO` VARCHAR(45) NULL,
  `DATAVENCIMENTO` VARCHAR(45) NULL,
  `VALOR` VARCHAR(45) NULL,
  PRIMARY KEY (`idPARCELAS`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`COMPLEMENTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`COMPLEMENTO` (
  `idCOMPLEMENTO` INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idCOMPLEMENTO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ACORDO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ACORDO` (
  `idACORDO` INT NOT NULL AUTO_INCREMENT,
  `DATA` VARCHAR(45) NULL,
  `COMISSAO` DOUBLE NULL,
  `PARCELAS_idPARCELAS` INT NULL,
  `COMPLEMENTO_idCOMPLEMENTO` INT NULL,
  PRIMARY KEY (`idACORDO`),
  INDEX `fk_ACORDO_PARCELAS1_idx` (`PARCELAS_idPARCELAS` ASC) VISIBLE,
  INDEX `fk_ACORDO_COMPLEMENTO1_idx` (`COMPLEMENTO_idCOMPLEMENTO` ASC) VISIBLE,
  CONSTRAINT `fk_ACORDO_PARCELAS1`
    FOREIGN KEY (`PARCELAS_idPARCELAS`)
    REFERENCES `mydb`.`PARCELAS` (`idPARCELAS`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ACORDO_COMPLEMENTO1`
    FOREIGN KEY (`COMPLEMENTO_idCOMPLEMENTO`)
    REFERENCES `mydb`.`COMPLEMENTO` (`idCOMPLEMENTO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`AJUIZADO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`AJUIZADO` (
  `idAJUIZADO` INT NOT NULL AUTO_INCREMENT,
  `DATAINICIO` VARCHAR(8) NULL,
  `DATAFIM` VARCHAR(8) NULL,
  `ANALISTA` VARCHAR(50) NULL,
  `COMISAO` DOUBLE NULL,
  PRIMARY KEY (`idAJUIZADO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`OCORRENCIA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`OCORRENCIA` (
  `idOCORRENCIA` INT NOT NULL AUTO_INCREMENT,
  `NUMERO` VARCHAR(30) NOT NULL,
  `DATA` VARCHAR(8) NOT NULL,
  `VALOR` DOUBLE NOT NULL,
  `TERCEIRO_idTERCEIRO` INT NULL, 
  `DOCUMENTO_idDOCUMENTO` INT NULL,
  `DESCRICAO_idDESCRICAO` INT NULL,
  `ACORDO_idACORDO` INT NULL,
  `AJUIZADO_idAJUIZADO` INT NULL,
  PRIMARY KEY (`idOCORRENCIA`),
  INDEX `fk_OCORRENCIA_TERCEIRO_idx` (`TERCEIRO_idTERCEIRO` ASC) VISIBLE,
  INDEX `fk_OCORRENCIA_DOCUMENTO1_idx` (`DOCUMENTO_idDOCUMENTO` ASC) VISIBLE,
  INDEX `fk_OCORRENCIA_ACORDO1_idx` (`ACORDO_idACORDO` ASC) VISIBLE,
  INDEX `fk_OCORRENCIA_AJUIZADO1_idx` (`AJUIZADO_idAJUIZADO` ASC) VISIBLE,
  CONSTRAINT `fk_OCORRENCIA_TERCEIRO`
    FOREIGN KEY (`TERCEIRO_idTERCEIRO`)
    REFERENCES `mydb`.`TERCEIRO` (`idTERCEIRO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OCORRENCIA_DOCUMENTO1`
    FOREIGN KEY (`DOCUMENTO_idDOCUMENTO`)
    REFERENCES `mydb`.`DOCUMENTO` (`idDOCUMENTO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OCORRENCIA_ACORDO1`
    FOREIGN KEY (`ACORDO_idACORDO`)
    REFERENCES `mydb`.`ACORDO` (`idACORDO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OCORRENCIA_AJUIZADO1`
    FOREIGN KEY (`AJUIZADO_idAJUIZADO`)
    REFERENCES `mydb`.`AJUIZADO` (`idAJUIZADO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
