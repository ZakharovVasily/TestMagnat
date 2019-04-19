-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Апр 20 2019 г., 01:28
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `magnat_nk`
--

-- --------------------------------------------------------

--
-- Структура таблицы `advertising_sources`
--

CREATE TABLE IF NOT EXISTS `advertising_sources` (
  `id_advertising` int(11) NOT NULL AUTO_INCREMENT,
  `advertising_name` varchar(100) NOT NULL,
  PRIMARY KEY (`id_advertising`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Дамп данных таблицы `advertising_sources`
--

INSERT INTO `advertising_sources` (`id_advertising`, `advertising_name`) VALUES
(1, 'Листовки'),
(6, 'Газета "Таштагольский курьер"'),
(7, 'Газета "Кузнецкий рабочий"'),
(8, 'Сайт'),
(9, '2Гис'),
(10, 'Офис'),
(11, 'Рекомендации'),
(12, 'Повторный заказ');

-- --------------------------------------------------------

--
-- Структура таблицы `brand`
--

CREATE TABLE IF NOT EXISTS `brand` (
  `brand` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `id_category` int(11) NOT NULL AUTO_INCREMENT,
  `name_category` varchar(50) NOT NULL,
  `head_node` varchar(50) NOT NULL,
  `level` int(11) NOT NULL,
  PRIMARY KEY (`id_category`),
  KEY `id_category` (`id_category`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Дамп данных таблицы `category`
--

INSERT INTO `category` (`id_category`, `name_category`, `head_node`, `level`) VALUES
(1, 'Первая', '', 1),
(2, 'Вторая', '', 1),
(3, '1-1', 'Первая', 0),
(4, '1-2', 'Первая', 0),
(5, '1-3', 'Первая', 0),
(6, '2-1', 'Вторая', 0),
(7, '2-2', 'Вторая', 0),
(8, '1-2-1', '1-2', 0),
(9, '1-2-2', '1-2', 0),
(10, '2-2-2', '2-2', 0),
(11, '2-1-2', '2-1', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `clients_base`
--

CREATE TABLE IF NOT EXISTS `clients_base` (
  `id_client` int(11) NOT NULL AUTO_INCREMENT,
  `surname` varchar(60) NOT NULL,
  `name` varchar(60) NOT NULL,
  `lastname` varchar(60) NOT NULL,
  `city` varchar(60) NOT NULL,
  `adress` varchar(250) NOT NULL,
  `phone_number` varchar(12) NOT NULL,
  `email` varchar(50) NOT NULL,
  `series_passport` int(11) NOT NULL,
  `number_passport` int(11) NOT NULL,
  `date_issue` varchar(20) NOT NULL,
  `issued_by` varchar(250) NOT NULL,
  `registratoin` varchar(250) NOT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `config`
--

CREATE TABLE IF NOT EXISTS `config` (
  `name_config` varchar(50) NOT NULL,
  `message_users` varchar(250) NOT NULL,
  `access` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `config`
--

INSERT INTO `config` (`name_config`, `message_users`, `access`) VALUES
('config_programm', 'На сервере идут плановые технические работы. До 18:00 по местному времени.', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `empl_base`
--

CREATE TABLE IF NOT EXISTS `empl_base` (
  `id_emplusers` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `id_position` int(11) NOT NULL,
  PRIMARY KEY (`id_emplusers`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `empl_base`
--

INSERT INTO `empl_base` (`id_emplusers`, `user_name`, `password`, `surname`, `name`, `lastname`, `id_position`) VALUES
(1, 'q', 'q', 'we', 'we', 'we', 1),
(2, 'w', 'w', 'sdf2', 'sdf', 'sdfe', 2),
(3, 'r', 'r', 'r', 'r', 'r', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `froze_base`
--

CREATE TABLE IF NOT EXISTS `froze_base` (
  `id_froze` int(11) NOT NULL AUTO_INCREMENT,
  `time` int(11) NOT NULL,
  `date` varchar(10) NOT NULL,
  `city` varchar(100) NOT NULL,
  `street` varchar(100) NOT NULL,
  `house_number` int(11) NOT NULL,
  `apartment` int(11) NOT NULL,
  `phone_number` varchar(12) NOT NULL,
  `coment` varchar(500) NOT NULL,
  `advertising_source` int(11) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `check_order` tinyint(1) NOT NULL DEFAULT '0',
  `check_was` tinyint(1) NOT NULL DEFAULT '0',
  `check_contract` tinyint(1) NOT NULL DEFAULT '0',
  `id_gager` varchar(20) NOT NULL,
  `way` int(11) NOT NULL,
  `create` varchar(100) NOT NULL,
  `changer` varchar(100) NOT NULL,
  PRIMARY KEY (`id_froze`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `froze_base`
--

INSERT INTO `froze_base` (`id_froze`, `time`, `date`, `city`, `street`, `house_number`, `apartment`, `phone_number`, `coment`, `advertising_source`, `brand`, `check_order`, `check_was`, `check_contract`, `id_gager`, `way`, `create`, `changer`) VALUES
(1, 2, '18.04.2019', 'sdf', 'sdf', 25, 2, '89562542245', 'sdffe', 2, 'dsfe', 0, 0, 0, '2', 1, 'asddw', ''),
(2, 4, '26.03.2019', 'sdf', 'sdf', 25, 2, '89562542245', 'sdffe', 2, 'dsfe', 0, 0, 0, '2', 1, 'asddw', ''),
(3, 5, '26.03.2019', 'tre', 'fgh', 12, 52, '89562542245', 'cvbfd', 3, 'dvbfd', 0, 0, 0, '3', 1, 'dfgrg', ''),
(4, 0, '19.04.2019', 'dsfdsf', 'sdf', 213, 0, 'df', 'sdf', 0, '', 0, 0, 0, '2', 0, 'we we 19.04.2019 23:22', '');

-- --------------------------------------------------------

--
-- Структура таблицы `id_product`
--

CREATE TABLE IF NOT EXISTS `id_product` (
  `id_product` int(11) NOT NULL AUTO_INCREMENT,
  `name_product` varchar(50) NOT NULL,
  `count` int(11) NOT NULL,
  `price` float NOT NULL,
  `summa` float NOT NULL,
  `id_order` int(11) NOT NULL,
  PRIMARY KEY (`id_product`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `installment_plan`
--

CREATE TABLE IF NOT EXISTS `installment_plan` (
  `id_install_plan` int(11) NOT NULL AUTO_INCREMENT,
  `number_month` int(11) NOT NULL,
  `date_pay` varchar(11) NOT NULL,
  `summa` float NOT NULL,
  `paid` float NOT NULL,
  `check_pay` tinyint(1) NOT NULL,
  `id_order` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  PRIMARY KEY (`id_install_plan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `id_order` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(50) NOT NULL,
  `installation` varchar(50) NOT NULL,
  `id_client` int(11) NOT NULL,
  `id_sold` int(11) NOT NULL,
  `summa_price` float NOT NULL,
  `summa_installation` float NOT NULL,
  `type_pay` int(11) NOT NULL,
  `summa_paid` float NOT NULL,
  `create_empl` int(11) NOT NULL,
  `prepayment` float NOT NULL,
  `prepaid` float NOT NULL,
  `comments` varchar(500) NOT NULL,
  `check_pause` tinyint(1) NOT NULL,
  `debt` float NOT NULL,
  `check_finish` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_order`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `position`
--

CREATE TABLE IF NOT EXISTS `position` (
  `id_position` int(11) NOT NULL AUTO_INCREMENT,
  `name_position` varchar(50) NOT NULL,
  `add_froze` tinyint(1) NOT NULL,
  `edit_froze` tinyint(1) NOT NULL,
  `comment_froze` tinyint(1) NOT NULL,
  `add_order` tinyint(1) NOT NULL,
  `edit_order` tinyint(1) NOT NULL,
  `mark_froze` tinyint(1) NOT NULL,
  `comment_order` tinyint(1) NOT NULL,
  `pausestart_order` tinyint(1) NOT NULL,
  `finish_order` tinyint(1) NOT NULL,
  `see_payment` tinyint(1) NOT NULL,
  `add_prepayment` tinyint(1) NOT NULL,
  `see_client` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_position`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `position`
--

INSERT INTO `position` (`id_position`, `name_position`, `add_froze`, `edit_froze`, `comment_froze`, `add_order`, `edit_order`, `mark_froze`, `comment_order`, `pausestart_order`, `finish_order`, `see_payment`, `add_prepayment`, `see_client`) VALUES
(1, 'Директор', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(2, 'Менеджер', 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1),
(3, 'Замерщик', 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
