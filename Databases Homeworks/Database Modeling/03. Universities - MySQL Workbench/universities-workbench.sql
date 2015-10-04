-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema universities
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema universities
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `universities` DEFAULT CHARACTER SET utf8 ;
USE `universities` ;

-- -----------------------------------------------------
-- Table `universities`.`courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`courses` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `DepartmentId` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`faculties` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(200) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`departments` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(200) NOT NULL COMMENT '',
  `FacultyId` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  INDEX `FK_Departments_Faculties` (`FacultyId` ASC)  COMMENT '',
  CONSTRAINT `FK_Departments_Faculties`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `universities`.`faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`professors` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `FirstName` VARCHAR(100) NOT NULL COMMENT '',
  `LastName` VARCHAR(100) NOT NULL COMMENT '',
  `DepartmentId` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`departments_professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`departments_professors` (
  `DepartmentId` INT(11) NOT NULL COMMENT '',
  `ProfessorId` INT(11) NOT NULL COMMENT '',
  INDEX `FK_Departments_Professors_Departments` (`DepartmentId` ASC)  COMMENT '',
  INDEX `FK_Departments_Professors_Professors` (`ProfessorId` ASC)  COMMENT '',
  PRIMARY KEY (`DepartmentId`, `ProfessorId`)  COMMENT '',
  CONSTRAINT `FK_Departments_Professors_Departments`
    FOREIGN KEY (`DepartmentId`)
    REFERENCES `universities`.`departments` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Departments_Professors_Professors`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `universities`.`professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`professors_courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`professors_courses` (
  `ProfessorId` INT(11) NOT NULL COMMENT '',
  `CourseId` INT(11) NOT NULL COMMENT '',
  INDEX `FK_Professors_Courses_Courses` (`CourseId` ASC)  COMMENT '',
  INDEX `FK_Professors_Courses_Professors` (`ProfessorId` ASC)  COMMENT '',
  PRIMARY KEY (`ProfessorId`, `CourseId`)  COMMENT '',
  CONSTRAINT `FK_Professors_Courses_Courses`
    FOREIGN KEY (`CourseId`)
    REFERENCES `universities`.`courses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Professors_Courses_Professors`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `universities`.`professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`titles` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(200) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`professors_titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`professors_titles` (
  `ProfessorId` INT(11) NOT NULL COMMENT '',
  `TitleId` INT(11) NOT NULL COMMENT '',
  INDEX `FK_Professors_Titles_Professors` (`ProfessorId` ASC)  COMMENT '',
  INDEX `FK_Professors_Titles_Titles` (`TitleId` ASC)  COMMENT '',
  PRIMARY KEY (`TitleId`, `ProfessorId`)  COMMENT '',
  CONSTRAINT `FK_Professors_Titles_Professors`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `universities`.`professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Professors_Titles_Titles`
    FOREIGN KEY (`TitleId`)
    REFERENCES `universities`.`titles` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`students` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `FirstName` VARCHAR(100) NOT NULL COMMENT '',
  `LastName` VARCHAR(100) NOT NULL COMMENT '',
  `FacultyId` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  INDEX `FK_Students_Faculties` (`FacultyId` ASC)  COMMENT '',
  CONSTRAINT `FK_Students_Faculties`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `universities`.`faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`students_courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`students_courses` (
  `StudentId` INT(11) NOT NULL COMMENT '',
  `CourseId` INT(11) NOT NULL COMMENT '',
  INDEX `FK_Students_Courses_Courses` (`CourseId` ASC)  COMMENT '',
  INDEX `FK_Students_Courses_Students` (`StudentId` ASC)  COMMENT '',
  PRIMARY KEY (`StudentId`, `CourseId`)  COMMENT '',
  CONSTRAINT `FK_Students_Courses_Courses`
    FOREIGN KEY (`CourseId`)
    REFERENCES `universities`.`courses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Students_Courses_Students`
    FOREIGN KEY (`StudentId`)
    REFERENCES `universities`.`students` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `universities`.`sysdiagrams`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `universities`.`sysdiagrams` (
  `name` VARCHAR(160) NOT NULL COMMENT '',
  `principal_id` INT(11) NOT NULL COMMENT '',
  `diagram_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `version` INT(11) NULL DEFAULT NULL COMMENT '',
  `definition` LONGBLOB NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`diagram_id`)  COMMENT '',
  UNIQUE INDEX `UK_principal_name` (`principal_id` ASC, `name` ASC)  COMMENT '')
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
