-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 04, 2024 at 07:50 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `categorie_id` char(3) NOT NULL COMMENT 'รหัสหมวดหมู่',
  `categorie_name` varchar(20) DEFAULT NULL COMMENT 'ชื่อหมวดหมู่'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`categorie_id`, `categorie_name`) VALUES
('001', 'ชา'),
('002', 'กาแฟ'),
('003', 'นม'),
('004', 'ผลไม้');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` char(5) NOT NULL COMMENT 'รหัสพนักงาน',
  `employee_username` varchar(20) DEFAULT NULL COMMENT 'ชื่อผู้ใช้',
  `employee_password` varchar(20) DEFAULT NULL COMMENT 'รหัสผ่านพนักงาน',
  `employee_fname` varchar(20) DEFAULT NULL COMMENT 'ชื่อพนักงาน',
  `employee_lname` varchar(20) DEFAULT NULL COMMENT 'สกุลพนักงาน',
  `employee_level` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `employee_username`, `employee_password`, `employee_fname`, `employee_lname`, `employee_level`) VALUES
('00001', 'svp', 'tp', 'สุวพิชญ์', 'ตาเปี้ย', '1'),
('00003', 'ar', 'trpk', 'อริญชย์', 'ตีระพิพัฒนกุล', '2'),
('0002', 'sps', 'pts', 'สุุภัสสร', 'พฤฒิสาร ', '2'),
('11111', 'dick', '852369', 'หัสนัย', 'หม้อยา', '2'),
('98745', 'mut', '12345', 'เสถียรพงษ์', 'แซ่แจ้น', '2'),
('99999', 'Pootanet', '0612161312', 'ภูธเนศ', 'รำเภย', '1');

-- --------------------------------------------------------

--
-- Table structure for table `orderdetail`
--

CREATE TABLE `orderdetail` (
  `order_id` bigint(5) DEFAULT NULL COMMENT 'รหัสออเดอร์',
  `orderdetail_quantity` bigint(20) NOT NULL COMMENT 'จำนวนสินค้า',
  `level_id` char(5) DEFAULT NULL COMMENT 'รหัสระดับความหวาน',
  `product_id` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `orderdetail`
--

INSERT INTO `orderdetail` (`order_id`, `orderdetail_quantity`, `level_id`, `product_id`) VALUES
(29, 1, '00001', '002'),
(30, 1, '00001', '002'),
(31, 1, '00001', '001'),
(32, 1, '00001', '002'),
(32, 1, '00001', '004'),
(33, 1, '00001', '004'),
(33, 2, '00001', '001'),
(34, 1, '00001', '002'),
(34, 1, '00001', '004'),
(34, 1, '00001', '001'),
(35, 1, '00001', '002');

-- --------------------------------------------------------

--
-- Table structure for table `orderlevel`
--

CREATE TABLE `orderlevel` (
  `level_id` char(5) NOT NULL COMMENT 'รหัสระดับความหวาน',
  `orderlevel_level` varchar(20) DEFAULT NULL COMMENT 'ระดับความหวาน'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `orderlevel`
--

INSERT INTO `orderlevel` (`level_id`, `orderlevel_level`) VALUES
('00001', 'หวานปกติ'),
('00002', 'หวานมาก'),
('00003', 'หวานน้อย');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_dete` datetime NOT NULL COMMENT 'วันที่',
  `employee_id` char(5) DEFAULT NULL COMMENT 'รหัสพนักงาน',
  `promotion_id` char(5) DEFAULT NULL COMMENT 'รหัสโปรโมชั่น',
  `order_id` bigint(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_dete`, `employee_id`, `promotion_id`, `order_id`) VALUES
('2024-03-26 17:02:28', '99999', '0', 29),
('2024-03-26 17:03:08', '99999', '0', 30),
('2024-03-26 17:04:40', '99999', '0', 31),
('2024-03-26 17:47:16', '99999', '00002', 32),
('2024-04-01 23:11:02', '99999', '0', 33),
('2024-04-04 01:13:00', '99999', '0', 34),
('2024-04-04 01:19:12', '99999', '0', 35),
('2024-04-04 01:28:51', '99999', '0', 36);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` char(5) NOT NULL COMMENT 'รหัสสินค้า',
  `product_name` varchar(20) DEFAULT NULL COMMENT 'ชื่อสินค้า',
  `product_detail` text NOT NULL COMMENT 'รายละเอียดสินค้า',
  `product_price` float DEFAULT NULL COMMENT 'ราคาสินค้า',
  `categorie_id` char(3) DEFAULT NULL COMMENT 'รหัสหมวกหมู่',
  `product_status` char(1) DEFAULT NULL COMMENT 'สถานะสินค้า',
  `product_img` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `product_detail`, `product_price`, `categorie_id`, `product_status`, `product_img`) VALUES
('001', 'ชาไทย', 'test', 30, '001', 'O', '4_20240320_004623.png'),
('002', 'กาแฟ', 'test ', 35, '002', 'O', '5_20240319_231440.png'),
('003', 'น้ำส้ม', 'test', 30, '004', 'C', '30_20240320_004603.png'),
('004', 'ชาเขียว', 'test', 200, '001', 'O', '12_20240320_001150.png'),
('005', 'น้ำกระท่อม', '', 90, '004', 'O', '30_20240320_003755.png'),
('006', 'ddd', 'ddd', 99, '001', 'O', '3_20240320_003926.png'),
('007', 'น้ำเปล่า0', '-', 20, '004', 'O', '18_20240323_130333.png');

-- --------------------------------------------------------

--
-- Table structure for table `promotions`
--

CREATE TABLE `promotions` (
  `promotion_id` char(5) NOT NULL COMMENT 'รหัสโปรโมชั่น',
  `promotion_discount` float DEFAULT NULL COMMENT 'ส่วนลด',
  `pomotion_detail` varchar(20) DEFAULT NULL COMMENT 'รายละเอียดส่วนลด',
  `promotion_dete_start` date DEFAULT NULL COMMENT 'วันที่เริ่มส่วนลด',
  `promotion_dete_end` date DEFAULT NULL COMMENT 'วันหมดส่วนลด'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_thai_520_w2;

--
-- Dumping data for table `promotions`
--

INSERT INTO `promotions` (`promotion_id`, `promotion_discount`, `pomotion_detail`, `promotion_dete_start`, `promotion_dete_end`) VALUES
('0', 0, '0', '2024-03-01', '2024-03-01'),
('00001', 200, 'dave', '2024-03-14', '2024-03-14'),
('00002', 80, 'ซื้อทั้งวัน ก็ไม่หมด', '2024-03-15', '2024-03-30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`categorie_id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD KEY `order_id` (`order_id`,`level_id`,`product_id`),
  ADD KEY `level_id` (`level_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `orderlevel`
--
ALTER TABLE `orderlevel`
  ADD PRIMARY KEY (`level_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `orders_employee_FK` (`employee_id`),
  ADD KEY `orders_Promotion_FK` (`promotion_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `products_categoriesFK` (`categorie_id`);

--
-- Indexes for table `promotions`
--
ALTER TABLE `promotions`
  ADD PRIMARY KEY (`promotion_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` bigint(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD CONSTRAINT `orderdetail_ibfk_1` FOREIGN KEY (`level_id`) REFERENCES `orderlevel` (`level_id`),
  ADD CONSTRAINT `orderdetail_ibfk_3` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`),
  ADD CONSTRAINT `orderdetail_ibfk_4` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_Promotion_FK` FOREIGN KEY (`promotion_id`) REFERENCES `promotions` (`promotion_id`),
  ADD CONSTRAINT `orders_employee_FK` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_categoriesFK` FOREIGN KEY (`categorie_id`) REFERENCES `categories` (`categorie_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
