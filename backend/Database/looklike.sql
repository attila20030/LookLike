-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Ápr 24. 20:36
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `looklike`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `booking`
--

CREATE TABLE `booking` (
  `idopontID` int(11) NOT NULL,
  `date_of_reservation` date DEFAULT NULL,
  `date` date DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `userID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `booking`
--

INSERT INTO `booking` (`idopontID`, `date_of_reservation`, `date`, `status`, `userID`) VALUES
(1, '2025-04-03', '2025-04-05', 'Foglalt', 1),
(2, '2025-04-05', '2025-04-07', 'Foglalt', 2),
(3, '2025-04-04', '2025-04-06', 'Foglalt', 3);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `category`
--

CREATE TABLE `category` (
  `categoryID` int(11) NOT NULL,
  `category_name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `category`
--

INSERT INTO `category` (`categoryID`, `category_name`) VALUES
(1, 'Fodrász'),
(2, 'Masszázs'),
(3, 'Manikűr'),
(4, 'Piercer'),
(5, 'Tattoo Artist'),
(6, 'Nail Artist');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `service`
--

CREATE TABLE `service` (
  `serviceID` int(11) NOT NULL,
  `userID` int(11) DEFAULT NULL,
  `rating` int(11) DEFAULT NULL,
  `text` text DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `booking_date` date DEFAULT NULL,
  `date_of_reservation` date DEFAULT NULL,
  `service_providerID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `service`
--

INSERT INTO `service` (`serviceID`, `userID`, `rating`, `text`, `price`, `booking_date`, `date_of_reservation`, `service_providerID`) VALUES
(1, 1, 5, 'Nagyon profi fodrász, elégedett vagyok!', 8500.00, '2025-04-01', '2025-04-03', 1),
(2, 2, 4, 'Kellemes masszázs, újra jövök!', 12000.00, '2025-04-02', '2025-04-05', 2),
(3, 3, 5, 'Szuper körmös, gyors és precíz!', 6000.00, '2025-04-01', '2025-04-04', 3);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `service_provider`
--

CREATE TABLE `service_provider` (
  `service_providerID` int(11) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `qualification_level` varchar(100) DEFAULT NULL,
  `userName` varchar(100) DEFAULT NULL,
  `short_text` text DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `categoryID` int(11) DEFAULT NULL,
  `idopontID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `service_provider`
--

INSERT INTO `service_provider` (`service_providerID`, `email`, `qualification_level`, `userName`, `short_text`, `password`, `categoryID`, `idopontID`) VALUES
(1, 'ETOlly@email.org', 'mesterfodrász', 'hairdresser1', 'Modern stílus, színezés, vágás', 'cut123', 1, 1),
(2, 'SaSanna@email.org', 'mesterfodrász', 'hairdresser2', 'Modern stílus, színezés, vágás', 'cut1', 1, 1),
(3, 'BALI@email.org', 'mesterfodrász', 'hairdresser3', 'Modern stílus, színezés, vágás', 'cut126', 1, 1),
(4, 'KiTTyCat@email.org', 'mesterfodrász', 'hairdresser4', 'Modern stílus, színezés, vágás', 'cut15', 1, 1),
(5, 'Brade.Din@email.org', 'mesterfodrász', 'hairdresser5', 'Modern stílus, színezés, vágás', 'cut14', 1, 1),
(6, 'BFerretKip@email.org', 'Piercer', 'Piercer1', 'Modern stílus, színezés, vágás', 'cut11', 4, 1),
(7, 'Johnn.Lie99@email.org', 'Piercer', 'Piercer2', 'Modern stílus, színezés, vágás', 'cut12', 4, 1),
(8, 'JennyDa@email.org', 'Piercer', 'Piercer3', 'Modern stílus, színezés, vágás', 'cut13', 4, 1),
(9, 'ScottishBoy98@email.org', 'Piercer', 'Piercer4', 'Modern stílus, színezés, vágás', 'cut14', 4, 1),
(10, 'MariAyla@email.org', 'Piercer', 'Piercer5', 'Modern stílus, színezés, vágás', 'cut15', 4, 1),
(11, 'BriarJaxton@email.org', 'Tattoo Artist', 'TattooArtist1', 'Modern stílus, színezés, vágás', 'cut15', 5, 1),
(12, 'MariAyla@email.org', 'Tattoo Artist', 'TattooArtist2', 'Modern stílus, színezés, vágás', 'cut15', 5, 1),
(13, 'MariAyla@email.org', 'Tattoo Artist', 'TattooArtist3', 'Modern stílus, színezés, vágás', 'cut15', 5, 1),
(14, 'MariAyla@email.org', 'Tattoo Artist', 'TattooArtist4', 'Modern stílus, színezés, vágás', 'cut15', 5, 1),
(15, 'MariAyla@email.org', 'Tattoo Artist', 'TattooArtist5', 'Modern stílus, színezés, vágás', 'cut15', 5, 1),
(16, 'HeyNi@email.org', 'Nail Artist', 'Nail Artist1', 'Modern stílus, színezés, vágás', 'cut15', 6, 1),
(17, 'NoYa@email.org', 'Nail Artist', 'Nail Artist2', 'Modern stílus, színezés, vágás', 'cut15', 6, 1),
(18, 'LotusinTheLake@email.org', 'Nail Artist', 'Nail Artist3', 'Modern stílus, színezés, vágás', 'cut15', 6, 1),
(19, 'Mel.Cel.sa@email.org', 'Nail Artist', 'Nail Artist4', 'Modern stílus, színezés, vágás', 'cut15', 6, 1),
(20, 'Finle76@email.org', 'Nail Artist', 'Nail Artist5', 'Modern stílus, színezés, vágás', 'cut15', 6, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `userName` varchar(100) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `role` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`userID`, `email`, `password`, `userName`, `name`, `role`) VALUES
(1, 'anna@example.com', 'pass123', 'annax', 'Anna Kovács', 1),
(2, 'bela@example.com', 'secret456', 'belab', 'Béla Nagy', 0),
(3, 'cili@example.com', 'mypassword', 'cili123', 'Cili Horváth', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`idopontID`),
  ADD KEY `userID` (`userID`);

--
-- A tábla indexei `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryID`);

--
-- A tábla indexei `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`serviceID`),
  ADD KEY `userID` (`userID`),
  ADD KEY `service_providerID` (`service_providerID`);

--
-- A tábla indexei `service_provider`
--
ALTER TABLE `service_provider`
  ADD PRIMARY KEY (`service_providerID`),
  ADD KEY `categoryID` (`categoryID`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `booking`
--
ALTER TABLE `booking`
  MODIFY `idopontID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `category`
--
ALTER TABLE `category`
  MODIFY `categoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `service`
--
ALTER TABLE `service`
  MODIFY `serviceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `service_provider`
--
ALTER TABLE `service_provider`
  MODIFY `service_providerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Megkötések a táblához `service`
--
ALTER TABLE `service`
  ADD CONSTRAINT `service_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`),
  ADD CONSTRAINT `service_ibfk_2` FOREIGN KEY (`service_providerID`) REFERENCES `service_provider` (`service_providerID`);

--
-- Megkötések a táblához `service_provider`
--
ALTER TABLE `service_provider`
  ADD CONSTRAINT `service_provider_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `category` (`categoryID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
