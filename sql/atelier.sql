create DATABASE atelier;
USE atelier;


CREATE USER 'atelier'@'localhost' IDENTIFIED BY 'motdepasse';
GRANT ALL PRIVILEGES ON `atelier`.* TO 'atelier'@'localhost';
FLUSH PRIVILEGES;

-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 27 mai 2026 à 17:24
-- Version du serveur : 8.4.7
-- Version de PHP : 8.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelier`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(7, '2026-03-06 00:58:43', '2027-01-28 21:39:10', 2),
(8, '2026-02-22 14:14:58', '2026-01-19 11:48:33', 1),
(8, '2026-04-09 20:10:33', '2026-06-12 05:34:44', 2),
(5, '2025-06-29 06:43:15', '2025-11-12 13:37:10', 3),
(9, '2027-01-05 19:20:29', '2026-05-22 04:01:42', 3),
(7, '2026-04-06 11:10:19', '2027-05-31 16:14:29', 1),
(2, '2026-07-19 03:48:36', '2027-05-31 20:44:08', 4),
(3, '2027-04-17 11:52:52', '2026-02-06 14:40:10', 1),
(3, '2025-10-24 10:39:51', '2025-09-18 10:48:21', 2),
(3, '2025-08-27 23:05:38', '2025-12-19 05:54:34', 4),
(4, '2026-03-01 04:33:14', '2025-09-22 13:55:05', 2),
(7, '2027-01-02 19:59:06', '2026-06-06 06:28:28', 3),
(1, '2026-01-14 16:29:37', '2026-04-29 09:23:18', 1),
(3, '2027-04-14 05:15:02', '2025-08-08 10:50:35', 2),
(8, '2025-05-28 23:30:16', '2025-09-18 20:25:43', 2),
(2, '2026-08-17 22:12:45', '2025-09-11 21:25:04', 4),
(2, '2026-10-25 11:04:23', '2026-05-16 06:57:35', 4),
(10, '2026-06-12 23:51:42', '2025-06-23 06:40:07', 4),
(10, '2027-04-24 18:10:47', '2026-05-05 10:04:35', 1),
(9, '2026-02-18 04:39:03', '2026-06-06 01:40:10', 4),
(8, '2026-08-17 11:20:50', '2026-11-29 03:09:58', 2),
(2, '2026-10-19 11:06:47', '2026-07-29 07:51:09', 2),
(3, '2027-02-07 06:51:39', '2027-02-24 20:35:49', 3),
(8, '2026-07-15 07:48:21', '2026-07-26 09:37:57', 2),
(6, '2026-02-19 16:23:21', '2026-05-20 23:39:48', 2),
(1, '2026-07-21 13:20:46', '2027-04-28 08:36:24', 1),
(5, '2025-08-09 03:21:49', '2026-06-18 08:08:14', 3),
(6, '2026-02-05 12:40:11', '2026-10-10 06:00:35', 3),
(6, '2026-02-11 15:54:04', '2026-05-16 19:28:35', 3),
(4, '2027-03-17 04:24:31', '2026-06-23 08:38:49', 3),
(7, '2026-05-05 01:47:47', '2026-09-12 17:48:50', 2),
(7, '2026-11-02 18:51:55', '2025-10-04 14:53:07', 2),
(10, '2026-10-13 07:31:23', '2026-06-25 02:30:16', 3),
(2, '2026-08-18 15:53:04', '2026-09-11 18:55:54', 2),
(2, '2025-07-11 19:00:25', '2025-08-07 08:13:32', 2),
(1, '2027-04-29 20:15:46', '2026-10-21 09:15:57', 2),
(10, '2027-02-16 06:36:40', '2025-06-06 04:10:15', 3),
(8, '2025-10-11 02:31:19', '2026-06-26 22:06:50', 3),
(9, '2027-02-17 22:43:57', '2025-07-19 18:49:44', 4),
(6, '2026-01-14 09:25:39', '2026-06-14 06:03:37', 3),
(9, '2026-11-19 02:39:03', '2026-09-12 03:41:27', 3),
(9, '2027-02-20 18:24:21', '2026-10-16 00:26:32', 2),
(8, '2026-10-07 21:29:33', '2025-08-18 17:40:52', 2),
(8, '2027-01-06 19:44:33', '2025-11-23 05:07:51', 3),
(8, '2025-10-05 13:46:39', '2026-11-13 13:58:23', 3),
(7, '2025-12-03 03:31:43', '2027-02-13 09:57:33', 3),
(3, '2026-03-27 10:45:58', '2026-03-31 17:12:36', 2),
(9, '2025-08-11 04:53:11', '2026-11-28 02:26:23', 4),
(10, '2026-11-28 11:21:13', '2027-04-18 21:27:53', 4),
(1, '2025-11-06 00:15:50', '2026-01-22 13:46:51', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Summer', 'Valdez', '0652116957', 'lobortis.tellus@icloud.ca', 2),
(2, 'Tamara', 'Owens', '0662658188', 'purus.gravida@google.net', 2),
(3, 'Dorian', 'Dawson', '0659387454', 'eu.erat@google.org', 3),
(4, 'Evan', 'Keller', '0662723748', 'curabitur.ut@protonmail.couk', 3),
(5, 'Briar', 'Hopper', '0698872877', 'integer.sem.elit@outlook.com', 2),
(6, 'Caesar', 'Glover', '0642588182', 'aliquam.vulputate@aol.com', 2),
(7, 'Ahmed', 'Fulton', '0667627188', 'orci.tincidunt@aol.net', 2),
(8, 'Cally', 'Floyd', '0682448567', 'consectetuer.euismod.est@hotmail.edu', 1),
(9, 'Rhea', 'Ortega', '0634386227', 'nec.diam.duis@protonmail.com', 3),
(10, 'Josiah', 'Avery', '0644212881', 'nisi.aenean.eget@protonmail.edu', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('antoine', 'e9b71991b7f947a3467fff8aeb5f6944a34cb9c5f9ab9e605411dd3655190c6c');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
