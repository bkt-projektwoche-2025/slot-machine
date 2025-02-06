-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 06. Feb 2025 um 12:24
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `slot-maschine`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `game`
--

CREATE TABLE `game` (
  `ID` int(11) NOT NULL,
  `user_ID` int(11) NOT NULL,
  `coins` int(11) NOT NULL,
  `slot_1` int(11) NOT NULL,
  `slot _2` int(11) NOT NULL,
  `slot _3` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `session`
--

CREATE TABLE `session` (
  `token` varchar(55) NOT NULL,
  `user_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Vorname` varchar(30) NOT NULL,
  `Mail` varchar(50) NOT NULL,
  `Passwort` varchar(256) NOT NULL,
  `Geburtsdatum` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `user`
--

INSERT INTO `user` (`ID`, `Name`, `Vorname`, `Mail`, `Passwort`, `Geburtsdatum`) VALUES
(1, 'Wehn', 'Axel', 'wehnaxel@gmail.com', '$2a$11$zZn/DKaOLh0EpEU4TYYozOnIXE2WkIUzUk9mw3sY4yCCl7BZt9Dbe', '1997-08-30');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
