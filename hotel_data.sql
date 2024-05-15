-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 03 fév. 2023 à 12:29
-- Version du serveur :  5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `hotel_data`
--

-- --------------------------------------------------------

--
-- Structure de la table `category`
--

DROP TABLE IF EXISTS `category`;
CREATE TABLE IF NOT EXISTS `category` (
  `CategoryId` int(10) NOT NULL,
  `label` varchar(20) NOT NULL,
  `Price` varchar(10) NOT NULL,
  PRIMARY KEY (`CategoryId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `category`
--

INSERT INTO `category` (`CategoryId`, `label`, `Price`) VALUES
(1, 'Single', '1000'),
(2, 'Double', '2000'),
(3, 'Suite', '5000');

-- --------------------------------------------------------

--
-- Structure de la table `guest`
--

DROP TABLE IF EXISTS `guest`;
CREATE TABLE IF NOT EXISTS `guest` (
  `GuestId` varchar(20) NOT NULL,
  `GuestFirstName` varchar(10) NOT NULL,
  `GuestLastName` varchar(10) NOT NULL,
  `GuestPhone` varchar(15) NOT NULL,
  `GuestCity` varchar(20) NOT NULL,
  PRIMARY KEY (`GuestId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `guest`
--

INSERT INTO `guest` (`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES
('EE890102', 'mouad', 'aniba', '2000155', 'maroc');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `RecervId` int(10) NOT NULL AUTO_INCREMENT,
  `GuestId` varchar(20) NOT NULL,
  `RoomNo` varchar(10) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL,
  PRIMARY KEY (`RecervId`),
  UNIQUE KEY `GuestId_2` (`GuestId`),
  KEY `GuestId` (`GuestId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `room`
--

DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `RoomId` int(5) NOT NULL,
  `RoomType` int(5) NOT NULL,
  `RoomPhone` varchar(15) NOT NULL,
  `RoomStatus` varchar(10) NOT NULL,
  PRIMARY KEY (`RoomId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `room`
--

INSERT INTO `room` (`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES
(102, 2, '2001', 'Free');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`GuestId`) REFERENCES `guest` (`GuestId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
