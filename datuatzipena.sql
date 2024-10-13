-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-10-2024 a las 18:25:14
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.1.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `datuatzipena`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `erabiltzaile`
--

CREATE TABLE `erabiltzaile` (
  `id_erabiltzailea` int(255) NOT NULL,
  `langilea_id` int(255) NOT NULL,
  `erabiltzailea` text NOT NULL,
  `pasahitza` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `erabiltzaile`
--

INSERT INTO `erabiltzaile` (`id_erabiltzailea`, `langilea_id`, `erabiltzailea`, `pasahitza`) VALUES
(13, 19, 'Snigger', 'Trackme123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `langile`
--

CREATE TABLE `langile` (
  `id` int(255) NOT NULL,
  `arduraduna` tinyint(1) DEFAULT NULL,
  `izena` text NOT NULL,
  `contraseña` text NOT NULL,
  `eliminado` bit(1) DEFAULT b'0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `langile`
--

INSERT INTO `langile` (`id`, `arduraduna`, `izena`, `contraseña`, `eliminado`) VALUES
(2, 0, 'Jane Doe', 'mypassword', b'1'),
(17, 0, 'Laura Snachez', 'leakpassword', b'1'),
(18, 0, 'Loan Sanchez', 'loaSanchez', b'1'),
(19, 1, 'Snigger', 'Trackme123', b'0');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `erabiltzaile`
--
ALTER TABLE `erabiltzaile`
  ADD PRIMARY KEY (`id_erabiltzailea`),
  ADD KEY `langilea_id` (`langilea_id`);

--
-- Indices de la tabla `langile`
--
ALTER TABLE `langile`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `erabiltzaile`
--
ALTER TABLE `erabiltzaile`
  MODIFY `id_erabiltzailea` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `langile`
--
ALTER TABLE `langile`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `erabiltzaile`
--
ALTER TABLE `erabiltzaile`
  ADD CONSTRAINT `erabiltzaile_ibfk_1` FOREIGN KEY (`langilea_id`) REFERENCES `langile` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
