CREATE TABLE `Orders` (
	`id` int NOT NULL AUTO_INCREMENT,
	`client_name` varchar(30) NOT NULL,
	`status` int NOT NULL,
	`payment_status` bool NOT NULL,
	`tech_name` varchar(100) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Status` (
	`id_status` int NOT NULL AUTO_INCREMENT,
	`status` varchar(30) NOT NULL,
	PRIMARY KEY (`id_status`)
);

CREATE TABLE `Users` (
	`id_user` int NOT NULL AUTO_INCREMENT,
	`role` int NOT NULL,
	`name` varchar(30) NOT NULL,
	`login` varchar(30) NOT NULL,
	`password` varchar(120) NOT NULL,
	PRIMARY KEY (`id_user`)
);

CREATE TABLE `Roles` (
	`id_role` int NOT NULL AUTO_INCREMENT,
	`role` varchar(20) NOT NULL,
	PRIMARY KEY (`id_role`)
);

ALTER TABLE `Orders` ADD CONSTRAINT `Orders_fk0` FOREIGN KEY (`status`) REFERENCES `Status`(`id_status`);

ALTER TABLE `Users` ADD CONSTRAINT `Users_fk0` FOREIGN KEY (`role`) REFERENCES `Roles`(`id_role`);

