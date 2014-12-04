-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-12-2014 a las 00:31:26
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `elvirasgym`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencias`
--

CREATE TABLE IF NOT EXISTS `asistencias` (
`id` int(4) NOT NULL,
  `clientes_id` int(4) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `asistencias`
--

INSERT INTO `asistencias` (`id`, `clientes_id`, `fecha`) VALUES
(1, 1, '2014-11-28'),
(2, 8, '2014-11-28'),
(13, 10, '2014-11-28'),
(14, 11, '2014-11-28');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clases`
--

CREATE TABLE IF NOT EXISTS `clases` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `clases`
--

INSERT INTO `clases` (`id`, `nombre`) VALUES
(1, 'Zumba'),
(2, 'Spinning');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
`id` int(11) NOT NULL,
  `DNI` int(4) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido_paterno` varchar(45) NOT NULL,
  `apellido_materno` varchar(45) NOT NULL,
  `foto` varchar(45) NOT NULL,
  `activo` int(11) NOT NULL,
  `grupo_id` int(11) NOT NULL,
  `pagos_id` int(11) NOT NULL,
  `descuentos_id` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `DNI`, `nombre`, `apellido_paterno`, `apellido_materno`, `foto`, `activo`, `grupo_id`, `pagos_id`, `descuentos_id`) VALUES
(1, 1001, 'Cliente', 'General', 'Venta', 'pendiente', 0, 1, 1, 1),
(8, 1002, 'Cynthia', 'Rodriguez', 'Jimenez', 'pendiente', 0, 1, 2, 1),
(9, 1003, 'Leticia', 'Ibarra', 'Gomez', 'pendiente', 0, 1, 3, 1),
(10, 1004, 'Monica de Jesus', 'Fregoso', 'Osuna', 'pendiente', 0, 1, 1, 1),
(11, 1005, 'Efrain', 'Jazo', 'Guevara', 'foto1005.jpg', 0, 1, 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes_pagos`
--

CREATE TABLE IF NOT EXISTS `clientes_pagos` (
`id` int(11) NOT NULL,
  `pagos_id` int(11) NOT NULL,
  `clientes_id` int(11) NOT NULL,
  `fecha_anterior` date NOT NULL,
  `fecha_corte` date NOT NULL,
  `fecha_pago` date NOT NULL,
  `pago` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `descuentos`
--

CREATE TABLE IF NOT EXISTS `descuentos` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descuento` double NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `descuentos`
--

INSERT INTO `descuentos` (`id`, `nombre`, `descuento`) VALUES
(1, '0%', 0),
(2, '10%', 0.1),
(3, '20%', 0.2),
(4, '30%', 0.3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos`
--

CREATE TABLE IF NOT EXISTS `grupos` (
`id` int(11) NOT NULL,
  `duracion` varchar(10) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `horario` varchar(20) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `instructores_id` int(11) NOT NULL,
  `clases_id` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `grupos`
--

INSERT INTO `grupos` (`id`, `duracion`, `descripcion`, `horario`, `fecha_inicio`, `instructores_id`, `clases_id`) VALUES
(1, '0 hrs', 'nada', 'nada', '2014-11-21', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos_detalles`
--

CREATE TABLE IF NOT EXISTS `grupos_detalles` (
`id` int(11) NOT NULL,
  `grupo_id` int(11) NOT NULL,
  `clientes_id` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `instructores`
--

CREATE TABLE IF NOT EXISTS `instructores` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `sexo` enum('Masculino','Femenino') NOT NULL,
  `edad` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `instructores`
--

INSERT INTO `instructores` (`id`, `nombre`, `apellidos`, `sexo`, `edad`) VALUES
(1, 'Jesus', 'Fregoso Osuna', 'Masculino', 21),
(2, 'Eligio', 'Arreola Torres', 'Masculino', 20),
(3, 'Orlando', 'Aguilera', 'Masculino', 20);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE IF NOT EXISTS `pagos` (
`id` int(11) NOT NULL,
  `tipo` enum('Diario','Semanal','Mensual') DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id`, `tipo`) VALUES
(1, 'Diario'),
(2, 'Semanal'),
(3, 'Mensual');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE IF NOT EXISTS `productos` (
`id` int(11) NOT NULL,
  `DNI` int(4) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` double NOT NULL,
  `foto` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `DNI`, `nombre`, `descripcion`, `cantidad`, `precio`, `foto`) VALUES
(1, 2001, 'Proteinas', 'Ganar musculo', 20, 350, ''),
(2, 2002, 'Chocomilk', 'Malteada para ganar energia', 50, 25, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `usuario` varchar(15) NOT NULL,
  `contrasenia` varchar(15) NOT NULL,
  `activo` int(11) NOT NULL,
  `tipo` enum('Admin','Empleado') NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `apellidos`, `usuario`, `contrasenia`, `activo`, `tipo`) VALUES
(1, 'Efrain', 'Jazo Guevara', 'Admin', '12345', 0, 'Admin'),
(2, 'Eligio', 'Arreola Torres', 'earreola', '123', 0, 'Admin'),
(3, 'Jesus', 'Fregoso Osuna', 'eloso', '123', 0, 'Admin'),
(4, 'Ricardo', 'Osuna Castillo', 'riki', '123', 0, 'Empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE IF NOT EXISTS `ventas` (
`id` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `total` double NOT NULL,
  `usuarios_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalles`
--

CREATE TABLE IF NOT EXISTS `ventas_detalles` (
`id` int(11) NOT NULL,
  `precio` double NOT NULL,
  `productos_id` int(11) NOT NULL,
  `venta_id` int(11) NOT NULL,
  `descuentos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asistencias`
--
ALTER TABLE `asistencias`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `clases`
--
ALTER TABLE `clases`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Clientes_Grupo1_idx` (`grupo_id`), ADD KEY `fk_Clientes_Pagos1_idx` (`pagos_id`), ADD KEY `fk_Clientes_Descuentos1_idx` (`descuentos_id`);

--
-- Indices de la tabla `clientes_pagos`
--
ALTER TABLE `clientes_pagos`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Clientes_pagos_Pagos1_idx` (`pagos_id`), ADD KEY `fk_Clientes_pagos_Clientes1_idx` (`clientes_id`);

--
-- Indices de la tabla `descuentos`
--
ALTER TABLE `descuentos`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `grupos`
--
ALTER TABLE `grupos`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Grupo_Instructores1_idx` (`instructores_id`), ADD KEY `fk_Grupo_Clases1_idx` (`clases_id`);

--
-- Indices de la tabla `grupos_detalles`
--
ALTER TABLE `grupos_detalles`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Grupo_detalle_Grupo1_idx` (`grupo_id`);

--
-- Indices de la tabla `instructores`
--
ALTER TABLE `instructores`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Venta_Usuarios1_idx` (`usuarios_id`);

--
-- Indices de la tabla `ventas_detalles`
--
ALTER TABLE `ventas_detalles`
 ADD PRIMARY KEY (`id`), ADD KEY `fk_Venta_detalle_Productos1_idx` (`productos_id`), ADD KEY `fk_Venta_detalle_Venta1_idx` (`venta_id`), ADD KEY `fk_Ventas_detalles_Descuentos1_idx` (`descuentos_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asistencias`
--
ALTER TABLE `asistencias`
MODIFY `id` int(4) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT de la tabla `clases`
--
ALTER TABLE `clases`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `clientes_pagos`
--
ALTER TABLE `clientes_pagos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `descuentos`
--
ALTER TABLE `descuentos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `grupos`
--
ALTER TABLE `grupos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `grupos_detalles`
--
ALTER TABLE `grupos_detalles`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `instructores`
--
ALTER TABLE `instructores`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `ventas_detalles`
--
ALTER TABLE `ventas_detalles`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
ADD CONSTRAINT `fk_Clientes_Descuentos1` FOREIGN KEY (`descuentos_id`) REFERENCES `descuentos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Clientes_Grupo1` FOREIGN KEY (`grupo_id`) REFERENCES `grupos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Clientes_Pagos1` FOREIGN KEY (`pagos_id`) REFERENCES `pagos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `clientes_pagos`
--
ALTER TABLE `clientes_pagos`
ADD CONSTRAINT `fk_Clientes_pagos_Clientes1` FOREIGN KEY (`clientes_id`) REFERENCES `clientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Clientes_pagos_Pagos1` FOREIGN KEY (`pagos_id`) REFERENCES `pagos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `grupos`
--
ALTER TABLE `grupos`
ADD CONSTRAINT `fk_Grupo_Clases1` FOREIGN KEY (`clases_id`) REFERENCES `clases` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Grupo_Instructores1` FOREIGN KEY (`instructores_id`) REFERENCES `instructores` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `grupos_detalles`
--
ALTER TABLE `grupos_detalles`
ADD CONSTRAINT `fk_Grupo_detalle_Grupo1` FOREIGN KEY (`grupo_id`) REFERENCES `grupos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
ADD CONSTRAINT `fk_Venta_Usuarios1` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `ventas_detalles`
--
ALTER TABLE `ventas_detalles`
ADD CONSTRAINT `fk_Venta_detalle_Productos1` FOREIGN KEY (`productos_id`) REFERENCES `productos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Venta_detalle_Venta1` FOREIGN KEY (`venta_id`) REFERENCES `ventas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `fk_Ventas_detalles_Descuentos1` FOREIGN KEY (`descuentos_id`) REFERENCES `descuentos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
