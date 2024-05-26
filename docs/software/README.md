# Реалізація інформаційного та програмного забезпечення

## SQL-скрипт для створення та початкового наповнення бази даних
```

-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema schema
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `schema` ;

-- -----------------------------------------------------
-- Schema schema
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `schema` DEFAULT CHARACTER SET utf8 ;
USE `schema` ;

-- -----------------------------------------------------
-- Table `schema`.`Project`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Project` (
  `idProject` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(256) NOT NULL,
  PRIMARY KEY (`idProject`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Team`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Team` (
  `idTeam` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(256) NULL,
  `Project_id` INT NOT NULL,
  PRIMARY KEY (`idTeam`),
  INDEX `Project_id_idx` (`Project_id` ASC) VISIBLE,
  CONSTRAINT `Project_id`
    FOREIGN KEY (`Project_id`)
    REFERENCES `schema`.`Project` (`idProject`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Role` (
  `idRole` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(256) NOT NULL,
  PRIMARY KEY (`idRole`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`User` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `photo` VARCHAR(256) NULL,
  `is_banned` TINYINT NOT NULL,
  PRIMARY KEY (`idUser`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Collaborators`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Collaborators` (
  `idCollaborators` INT NOT NULL AUTO_INCREMENT,
  `Role_id` INT NOT NULL,
  `User_id` INT NOT NULL,
  `Team_id` INT NOT NULL,
  PRIMARY KEY (`idCollaborators`),
  INDEX `Team_id_idx` (`Team_id` ASC) VISIBLE,
  INDEX `Role_id_idx` (`Role_id` ASC) VISIBLE,
  INDEX `User_id_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `Team_id`
    FOREIGN KEY (`Team_id`)
    REFERENCES `schema`.`Team` (`idTeam`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Role_id`
    FOREIGN KEY (`Role_id`)
    REFERENCES `schema`.`Role` (`idRole`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `User_id`
    FOREIGN KEY (`User_id`)
    REFERENCES `schema`.`User` (`idUser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Permission`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Permission` (
  `idPermission` INT NOT NULL AUTO_INCREMENT,
  `action` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idPermission`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Grant`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Grant` (
  `Role_id` INT NOT NULL,
  `Permission_id` INT NOT NULL,
  PRIMARY KEY (`Role_id`, `Permission_id`),
  INDEX `Permission_id_idx` (`Permission_id` ASC) VISIBLE,
  CONSTRAINT `Grant_Role_id`
    FOREIGN KEY (`Role_id`)
    REFERENCES `schema`.`Role` (`idRole`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Permission_id`
    FOREIGN KEY (`Permission_id`)
    REFERENCES `schema`.`Permission` (`idPermission`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Task`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Task` (
  `idTask` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(256) NULL,
  `deadline` DATETIME NULL,
  `creation_date` DATETIME NOT NULL,
  PRIMARY KEY (`idTask`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Assignment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Assignment` (
  `idAssignment` INT NOT NULL AUTO_INCREMENT,
  `date_time` DATETIME NULL,
  `Collaborator_id` INT NOT NULL,
  `Task_id` INT NOT NULL,
  PRIMARY KEY (`idAssignment`),
  INDEX `Collaborator_id_idx` (`Collaborator_id` ASC) VISIBLE,
  INDEX `Task_id_idx` (`Task_id` ASC) VISIBLE,
  CONSTRAINT `Collaborator_id`
    FOREIGN KEY (`Collaborator_id`)
    REFERENCES `schema`.`Collaborators` (`idCollaborators`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Task_id`
    FOREIGN KEY (`Task_id`)
    REFERENCES `schema`.`Task` (`idTask`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Action`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Action` (
  `Task_id` INT NOT NULL,
  `Assignment_id` INT NOT NULL,
  `Collaborator_id` INT NOT NULL,
  `date_time` DATETIME NULL,
  PRIMARY KEY (`Collaborator_id`, `Assignment_id`, `Task_id`),
  INDEX `Assignment_id_idx` (`Assignment_id` ASC) VISIBLE,
  INDEX `Collaborator_id_idx` (`Collaborator_id` ASC) VISIBLE,
  INDEX `Task_id_idx` (`Task_id` ASC) VISIBLE,
  CONSTRAINT `Action_Task_id`
    FOREIGN KEY (`Task_id`)
    REFERENCES `schema`.`Task` (`idTask`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Assignment_id`
    FOREIGN KEY (`Assignment_id`)
    REFERENCES `schema`.`Assignment` (`idAssignment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Action_Collaborator_id`
    FOREIGN KEY (`Collaborator_id`)
    REFERENCES `schema`.`Collaborators` (`idCollaborators`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Tag`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Tag` (
  `idTag` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(256) NULL,
  PRIMARY KEY (`idTag`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `schema`.`Label`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `schema`.`Label` (
  `Task_id` INT NOT NULL,
  `Tag_id` INT NOT NULL,
  PRIMARY KEY (`Task_id`, `Tag_id`),
  INDEX `Tag_id_idx` (`Tag_id` ASC) VISIBLE,
  CONSTRAINT `Label_Task_id`
    FOREIGN KEY (`Task_id`)
    REFERENCES `schema`.`Task` (`idTask`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Tag_id`
    FOREIGN KEY (`Tag_id`)
    REFERENCES `schema`.`Tag` (`idTag`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;








-- Початок транзакції
START TRANSACTION;

-- Додавання даних в таблицю `schema`.`Permission`
INSERT INTO `schema`.`Permission` (`action`)
VALUES
    -- collaborator
    ('EditUser'),
    ('CreateTask'),
    ('EditTask'),
    ('DeleteTask'),
    ('FilterTask'),
    ('CommentTask'),
    -- teamlead
    ('CreateProject'),
    ('DeleteProject'),
    ('CreateSprint'),
    ('FinishSprint'),
    ('AddMember'),
    ('DeleteMember'),
    -- admin
    ('UserSupport'),
    ('BanUser'),
    ('UnBanUser');


-- Додавання даних в таблицю `schema`.`Role`
INSERT INTO `schema`.`Role` (`name`, `description`)
VALUES
    ('Administrator', 'Administrator role'),
    ('Team-lead', 'Team-lead role'),
    ('Collaborator', 'Developer role');

-- Додавання даних в таблицю `schema`.`Grant`
INSERT INTO `schema`.`Grant` (`Role_id`, `Permission_id`)
VALUES
    (1, 1),
    (1, 2),
    (1, 3),
    (1, 4),
    (1, 5),
    (1, 6),
    (1, 7),
    (1, 8),
    (1, 9),
    (1, 10),
    (1, 11),
    (1, 12),
    (1, 13),
    (1, 14),
    (1, 15),

    (2, 1),
    (2, 2),
    (2, 3),
    (2, 4),
    (2, 5),
    (2, 6),
    (2, 7),
    (2, 8),
    (2, 9),
    (2, 10),
    (2, 11),
    (2, 12),

    (3, 1),
    (3, 2),
    (3, 3),
    (3, 4),
    (3, 5),
    (3, 6);


-- Додавання даних в таблицю `schema`.`Project`
INSERT INTO `schema`.`Project` (`name`, `description`)
VALUES
    ('Project 1', 'Description for Project 1'),
    ('Project 2', 'Description for Project 2');

-- Додавання даних в таблицю `schema`.`Team`
INSERT INTO `schema`.`Team` (`idTeam`, `name`, `description`, `Project_id`)
VALUES
    (1, 'Team 1', 'description1', 1),
    (2, 'Team 2', 'description2', 2);

-- Додавання даних в таблицю `schema`.`User`
INSERT INTO `schema`.`User` (`name`, `email`, `password`, `photo`, `is_banned`)
VALUES
    ('User1', 'user1@example.com', 'password1', 'link.com/photo', 0),
    ('User2', 'user2@example.com', 'password2', 'link.com/photo', 0);

-- Додавання даних в таблицю `schema`.`Collaborators`
INSERT INTO `schema`.`Collaborators` (`Role_id`, `User_id`, `Team_id`)
VALUES
    (1, 1, 1),  -- Admin User 1 in Team 1
    (2, 2, 2);  -- Manager User 2 in Team 2



-- Додавання даних в таблицю `schema`.`Task`
INSERT INTO `schema`.`Task` (`name`, `description`, `deadline`, `creation_date`)
VALUES
    ('Task 1', 'Description for Task 1', '2023-10-31 12:00:00', NOW()),
    ('Task 2', 'Description for Task 2', '2023-11-15 14:30:00', NOW()),
    ('Task 3', 'Description for Task 3', '2023-11-20 10:00:00', NOW());

-- Додавання тестових даних в таблицю `schema.Assignment`
INSERT INTO `schema`.`Assignment` (`date_time`, `Collaborator_id`, `Task_id`)
VALUES
    ('2023-10-18 11:30:00', 1, 1),
    ('2023-10-19 14:15:00', 2, 2),
    ('2023-10-20 09:45:00', 1, 3);


COMMIT;


```
- RESTfull сервіс для управління даними
