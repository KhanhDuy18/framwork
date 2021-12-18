-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8111
-- Generation Time: Dec 17, 2021 at 10:01 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quanlykhoahoc`
--

-- --------------------------------------------------------

--
-- Table structure for table `approle`
--

CREATE TABLE `approle` (
  `Id` varchar(100) NOT NULL,
  `Name` text DEFAULT NULL,
  `NormalizedName` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `Discriminator` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `approle`
--

INSERT INTO `approle` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`, `Discriminator`) VALUES
('0444a10f-bbc4-408e-b805-e535cb3d4a98', 'Xem', 'XEM', '5c0e1523-abb2-49c0-873b-0c3fe46e5b63', 'IdentityRole'),
('166b3f9d-a7f7-4154-8374-30980d66df15', 'NhanVien', 'NHANVIEN', '1f373e74-ad1a-495f-9429-3c6a386ee9dd', 'IdentityRole'),
('6eae9fb2-30e2-4b46-996a-69cee71bb287', 'Admin', 'ADMIN', '473ae8ed-1b9d-42e6-9a6a-4d595ea2ee00', 'IdentityRole'),
('e5d797ac-120f-47b1-9f25-dba92a9e1342', 'Vip', 'VIP', '6a4b485e-2213-469e-9fd2-4770dad32c60', 'IdentityRole');

-- --------------------------------------------------------

--
-- Table structure for table `approleclaim`
--

CREATE TABLE `approleclaim` (
  `Id` int(11) NOT NULL,
  `RoleId` text DEFAULT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `approleclaim`
--

INSERT INTO `approleclaim` (`Id`, `RoleId`, `ClaimType`, `ClaimValue`) VALUES
(1, '6eae9fb2-30e2-4b46-996a-69cee71bb287', 'canedit', 'user'),
(3, 'e5d797ac-120f-47b1-9f25-dba92a9e1342', 'edit', 'user'),
(4, '0444a10f-bbc4-408e-b805-e535cb3d4a98', 'duocphepxoa', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `appuser`
--

CREATE TABLE `appuser` (
  `Id` varchar(767) NOT NULL,
  `UserName` text DEFAULT NULL,
  `NormalizedUserName` text DEFAULT NULL,
  `Email` text DEFAULT NULL,
  `NormalizedEmail` text DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `address` varchar(200) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuser`
--

INSERT INTO `appuser` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `address`, `birthday`) VALUES
('33bf0004-8313-44fe-a5d5-0aecf2ea7a58', 'haidangtr1501@gmail.com', 'HAIDANGTR1501@GMAIL.COM', 'haidangtr1501@gmail.com', 'HAIDANGTR1501@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEMv2GYNfmhuvUSUXy7YAz8DV28TzlIvYLTkvz9212Mip5JvhcZWpQ5+dYykVNthmOQ==', '4INEJGGKECYOQXES24KUXXI2VLIDGEFT', '3445603c-7053-465e-959e-d2fb4a0c9758', NULL, 0, 0, NULL, 1, 0, NULL, NULL),
('a634d1cd-f8c5-42ca-ac4c-85f86c25de36', 'haidang15012001@gmail.com', 'HAIDANG15012001@GMAIL.COM', 'haidang15012001@gmail.com', 'HAIDANG15012001@GMAIL.COM', 1, NULL, 'UADECAS2W3FGOAKJIXNXEI6CSFSJOES6', 'fe114c2e-dbb1-49bf-8082-1aec2bb74f29', NULL, 0, 0, NULL, 1, 0, NULL, NULL),
('a88ce81e-968c-4be8-83a8-234be543fa90', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', 1, 'AQAAAAEAACcQAAAAED1vDZ2bRHnM6Lby4s9kCoawvkqUKg7m9FVcZ2mFBZi3O87KBnTfioMLrfqp0w5mkw==', 'HWOOIVCXGEJ3X6H73HPFRB5OIP2KXIVO', '9f52f1a6-e714-4241-a5cb-78577f49f07c', '+84123456', 0, 0, NULL, 1, 0, 'Đồng Tháp', '2001-01-15 20:32:00'),
('f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 'HaiDang', 'HAIDANG', 'abc@gmail.com', 'ABC@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEEYoVGDZ69shx2kvMJn/G/UqYP/s6cZJzvsu8pvFoOGUY80kD5NeXxdF/tpmR8dVxw==', '6H33K3OEUUPEWI67YNK5JGPCBJ72G5YO', 'd77dcb06-cb47-42d1-8eff-1d11afbbc8bf', '123456789', 0, 0, NULL, 1, 0, 'abc', '2021-12-14 23:28:00');

-- --------------------------------------------------------

--
-- Table structure for table `appuserclaim`
--

CREATE TABLE `appuserclaim` (
  `Id` int(11) NOT NULL,
  `UserId` text DEFAULT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuserclaim`
--

INSERT INTO `appuserclaim` (`Id`, `UserId`, `ClaimType`, `ClaimValue`) VALUES
(1, 'a88ce81e-968c-4be8-83a8-234be543fa90', 'NoiSinh', 'DongThap1');

-- --------------------------------------------------------

--
-- Table structure for table `appuserlogin`
--

CREATE TABLE `appuserlogin` (
  `UserId` varchar(100) NOT NULL,
  `LoginProvider` text DEFAULT NULL,
  `ProviderKey` text DEFAULT NULL,
  `ProviderDisplayName` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuserlogin`
--

INSERT INTO `appuserlogin` (`UserId`, `LoginProvider`, `ProviderKey`, `ProviderDisplayName`) VALUES
('33bf0004-8313-44fe-a5d5-0aecf2ea7a58', 'Google', '116194913539978270769', 'Google'),
('a634d1cd-f8c5-42ca-ac4c-85f86c25de36', 'Facebook', '3079733455641739', 'Facebook');

-- --------------------------------------------------------

--
-- Table structure for table `appuserrole`
--

CREATE TABLE `appuserrole` (
  `UserId` varchar(100) NOT NULL,
  `RoleId` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuserrole`
--

INSERT INTO `appuserrole` (`UserId`, `RoleId`) VALUES
('a88ce81e-968c-4be8-83a8-234be543fa90', '0444a10f-bbc4-408e-b805-e535cb3d4a98'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '166b3f9d-a7f7-4154-8374-30980d66df15'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '7de294a7-6391-40bc-a16c-7418567216ab'),
('a88ce81e-968c-4be8-83a8-234be543fa90', 'e5d797ac-120f-47b1-9f25-dba92a9e1342'),
('D1DFEBA3-BBA8-48D9-87E6-8EE1AD1C9F14', 'A44641C4-B68C-43D8-8ECD-E001276D9148'),
('f5ebe639-df16-4e3e-bbc9-8e7dc9400707', '6eae9fb2-30e2-4b46-996a-69cee71bb287');

-- --------------------------------------------------------

--
-- Table structure for table `appusertoken`
--

CREATE TABLE `appusertoken` (
  `UserId` varchar(100) NOT NULL,
  `LoginProvider` text DEFAULT NULL,
  `Name` text DEFAULT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `userId` varchar(767) NOT NULL,
  `courseId` int(11) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `evaluate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `courseId` int(11) NOT NULL,
  `courseName` varchar(50) NOT NULL,
  `discription` varchar(1000) NOT NULL,
  `price` int(11) NOT NULL DEFAULT 0,
  `originalPrice` int(11) NOT NULL,
  `imgCourse` varchar(50) NOT NULL,
  `totalTime` varchar(100) NOT NULL,
  `totalStudent` int(11) NOT NULL,
  `topicId` int(11) NOT NULL,
  `discountId` int(11) NOT NULL,
  `rating` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`courseId`, `courseName`, `discription`, `price`, `originalPrice`, `imgCourse`, `totalTime`, `totalStudent`, `topicId`, `discountId`, `rating`) VALUES
(1, 'Lập trình hướng đối tượng trong C++\r\n', 'Khóa học C++ OOP giúp các lập trình viên học được kỹ thuật lập trình mà tất cả logic, yêu cầu thực tế đều được xây dựng xoay quanh các đối tượng. Hiểu được cách thức hoạt động của C++ OOP sẽ làm đơn giản hóa việc bảo trì và dễ dàng mở rộng trong việc thiết kế phần mềm.\r\n', 0, 200000, '', '100 giờ', 5000, 3, 3, 9),
(2, 'Truyền thông và Mạng máy tính', 'Khóa học cung cấp cho lập trình viên những kiến thức cơ bản và dễ hiểu về mạng máy tính và truyền thông dữ liệu.\r\n', 0, 500000, '', '115 giờ 15 phút', 545, 3, 1, 7),
(3, 'Phần mềm máy tính', 'Phần mềm luôn là công cụ cần thiết trong mọi lĩnh vực, khóa học này sẽ giúp bạn hiểu được các khái niệm về phần mềm và các phần mềm phổ biến hiện nay.\r\n', 0, 800000, '', '80 giờ', 890, 3, 3, 9),
(4, 'Phần cứng máy tính', 'Khóa học này tập trung vào việc cung cấp các kiến thức chung về các bộ phận của máy tính để bạn có thể áp dụng vào việc lựa chọn và sử dụng máy tính.\r\n', 0, 500000, '', '150 giờ', 545, 3, 2, 8),
(5, 'C cho người mới bắt đầu', 'Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.\r\n', 0, 750000, '', '200 giờ', 1500, 4, 1, 9),
(6, 'C++ cho người mới bắt đầu', 'Khóa học lập trình C++ cơ bản cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản, dễ hiểu nhất về ngôn ngữ lập trình C++.\r\n', 0, 500000, '', '200 giờ', 2000, 4, 4, 10),
(7, 'Làm quen với SQL', 'Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).\r\n', 0, 650000, '', '150 giờ', 2000, 4, 2, 9),
(8, 'Javascript căn bản', 'Giúp học viên nắm vững các nguyên tắc và cú pháp cơ bản trong Javascript - ngôn ngữ lập trình phổ biến nhất trên thế giới.\r\n', 0, 750000, '', '175 giờ ', 1500, 4, 5, 7),
(9, 'Python cơ bản', 'Khóa học lập trình Python cơ bản với các bài tập và lý thuyết dễ hiểu, học xong bạn có thể tự tin để tới với các chủ đề nâng cao hơn của Python.\r\n', 0, 550000, '', '130 giờ', 1300, 4, 2, 9),
(10, 'C# cơ bản', 'Khóa học lập trình C# kèm thực hành, khóa học sẽ giúp bạn làm quen với lập trình cũng như tạo nền tảng tư duy và kỹ năng cơ bản khi giải các bài tập.\r\n', 0, 750000, '', '140 giờ', 1500, 4, 2, 10),
(11, 'Java cơ bản', 'Khóa học lập trình Java cơ bản cho người mới bắt đầu, khóa học này sẽ là nền tảng cho khóa Java nâng cao để tiến tới Java Web hay lập trình Android, …\r\n', 0, 800000, '', '200 giờ', 2500, 4, 4, 9),
(12, 'Thuật toán căn bản', 'Với khóa học thuật toán cơ bản, bạn sẽ học được cách tư duy và giải quyết các bài toán lập trình cơ bản mà một lập trình viên cần có.\r\n', 0, 850000, '', '175 giờ', 500, 6, 1, 8),
(13, 'Thực hành với SQL', 'Khóa học này sẽ giúp bạn biết về một số chức năng chính cần thiết để sắp xếp, lọc và phân loại thông tin trong cơ sở dữ liệu quan hệ, mở rộng bộ công cụ SQL của bạn và giúp bạn có khả năng giải quyết các vấn đề phức tạp hơn thông qua bộ công cụ này. Yêu cầu: Bạn cần hoàn thành khóa Làm quen với SQL để có kiến thức cơ bản trước khi\r\n', 0, 800000, '', '250 giờ 15 phút', 1400, 6, 2, 9),
(14, 'Cấu trúc dữ liệu và giải thuật', 'Khóa học này sẽ giúp các bạn hiểu thuật toán cũng như hiểu rõ bản chất của các cấu trúc dữ liệu - điều kiện để trở thành lập trình viên giỏi.\r\n', 0, 200000, '', '150 giờ', 2000, 4, 3, 8),
(15, 'Lập trình hướng đối tượng trong Java', 'Lập trình hướng đối tượng (Object-Oriented-Programming) là phương pháp lập trình dựa trên đối tượng để tìm ra bản chất của vấn đề. Khóa học Java OOP giúp các lập trình viên học được kỹ thuật lập trình mà tất cả logic, yêu cầu thực tế đều được xây dựng xoay quanh các đối tượng. Hiểu được cách thức hoạt động của Java OOP sẽ làm đơn giản hóa việc bảo trì và dễ dàng mở rộng trong việc thiết kế phần mềm.\r\n', 0, 800000, '', '200 giờ', 1500, 6, 3, 8),
(16, 'yếu tố cần thiết cho đám mây', 'Khóa học sẽ cung cấp cái nhìn cơ bản và tổng quan về lĩnh vực điện toán đám mây và các công nghệ điện toán đám mây mới nổi.', 0, 850000, '', '250 giờ', 545, 7, 5, 9);

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `discountId` int(11) NOT NULL,
  `discription` varchar(1000) NOT NULL,
  `time` datetime NOT NULL,
  `sale` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `discount`
--

INSERT INTO `discount` (`discountId`, `discription`, `time`, `sale`) VALUES
(1, 'Khuyến mãi ngày valentine', '2021-12-16 04:49:04', 0.8),
(2, 'Kỉ niệm 10 năm thành lập', '2021-11-01 00:00:00', 0.2),
(3, 'Khuyến mãi ngày tết', '2021-11-02 00:00:00', 0.15),
(4, 'Siêu sale back to school', '2021-11-20 00:00:00', 0.1),
(5, 'Mừng trung thu', '2021-11-01 00:00:00', 0.05),
(6, 'Khuyến mãi lần đầu đăng kí', '2021-11-01 00:00:00', 0.25);

-- --------------------------------------------------------

--
-- Table structure for table `exercise`
--

CREATE TABLE `exercise` (
  `exerciseId` int(11) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `deadline` date NOT NULL,
  `lessonId` int(11) NOT NULL,
  `teacherId` varchar(767) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `exerciseinuser`
--

CREATE TABLE `exerciseinuser` (
  `exerciseId` int(11) NOT NULL,
  `studentId` varchar(767) NOT NULL,
  `submit` datetime NOT NULL,
  `scores` float NOT NULL,
  `status` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `lesson`
--

CREATE TABLE `lesson` (
  `lessonId` int(11) NOT NULL,
  `title` varchar(200) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `courseId` int(11) NOT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE `receipt` (
  `receiptId` int(11) NOT NULL,
  `totalPrice` float NOT NULL DEFAULT 0,
  `timeReceipt` datetime NOT NULL,
  `registerId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `register`
--

CREATE TABLE `register` (
  `registerId` int(11) NOT NULL,
  `timeReg` datetime NOT NULL,
  `userId` varchar(100) NOT NULL,
  `courseId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `topic`
--

CREATE TABLE `topic` (
  `topicId` int(11) NOT NULL,
  `topicName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `topic`
--

INSERT INTO `topic` (`topicId`, `topicName`) VALUES
(3, 'Basic knowledge'),
(4, 'Basic programming'),
(5, 'Advanced programming'),
(6, 'Problem Solving'),
(7, 'Advanced Skills');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211120083840_MyCourse', '3.1.21'),
('20211120132739_MyCourse1', '3.1.21'),
('20211120141633_MyCourse2', '3.1.21'),
('20211120143044_MyCourse3', '3.1.21'),
('20211128041820_identity', '3.1.21'),
('20211128045858_identitynew', '3.1.21'),
('20211128050338_identitynew1', '3.1.21'),
('20211128050538_identitynew2', '3.1.21'),
('20211128051445_identitynew3', '3.1.21'),
('20211128085942_new', '3.1.21'),
('20211205124723_new1', '3.1.21'),
('20211206044011_new2', '3.1.21'),
('20211208080032_new3', '3.1.21'),
('20211214154704_addcontactmodel', '3.1.21'),
('20211217075108_new4', '3.1.21'),
('20211217084053_new5', '3.1.21');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `approle`
--
ALTER TABLE `approle`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `approleclaim`
--
ALTER TABLE `approleclaim`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuser`
--
ALTER TABLE `appuser`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuserclaim`
--
ALTER TABLE `appuserclaim`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuserlogin`
--
ALTER TABLE `appuserlogin`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `appuserrole`
--
ALTER TABLE `appuserrole`
  ADD PRIMARY KEY (`UserId`,`RoleId`);

--
-- Indexes for table `appusertoken`
--
ALTER TABLE `appusertoken`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`courseId`,`userId`),
  ADD KEY `IX_comment_userId` (`userId`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`courseId`),
  ADD KEY `IX_course_discountId` (`discountId`),
  ADD KEY `IX_course_topicId` (`topicId`);

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`discountId`);

--
-- Indexes for table `exercise`
--
ALTER TABLE `exercise`
  ADD PRIMARY KEY (`exerciseId`),
  ADD KEY `IX_exercise_lessonId` (`lessonId`),
  ADD KEY `IX_exercise_teacherId` (`teacherId`);

--
-- Indexes for table `exerciseinuser`
--
ALTER TABLE `exerciseinuser`
  ADD PRIMARY KEY (`exerciseId`),
  ADD KEY `IX_exerciseInUser_exerciseId` (`exerciseId`),
  ADD KEY `FK_exerciseInUser_AppUser_studentId` (`studentId`);

--
-- Indexes for table `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lessonId`),
  ADD KEY `IX_lesson_courseId` (`courseId`);

--
-- Indexes for table `receipt`
--
ALTER TABLE `receipt`
  ADD PRIMARY KEY (`receiptId`),
  ADD KEY `IX_receipt_registerId` (`registerId`);

--
-- Indexes for table `register`
--
ALTER TABLE `register`
  ADD PRIMARY KEY (`registerId`),
  ADD KEY `IX_register_courseId` (`courseId`),
  ADD KEY `IX_register_userId` (`userId`);

--
-- Indexes for table `topic`
--
ALTER TABLE `topic`
  ADD PRIMARY KEY (`topicId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `approleclaim`
--
ALTER TABLE `approleclaim`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `appuserclaim`
--
ALTER TABLE `appuserclaim`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `courseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `discountId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `exercise`
--
ALTER TABLE `exercise`
  MODIFY `exerciseId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `lesson`
--
ALTER TABLE `lesson`
  MODIFY `lessonId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `receipt`
--
ALTER TABLE `receipt`
  MODIFY `receiptId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `register`
--
ALTER TABLE `register`
  MODIFY `registerId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `topic`
--
ALTER TABLE `topic`
  MODIFY `topicId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `FK_comment_AppUser_userId` FOREIGN KEY (`userId`) REFERENCES `appuser` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_comment_course_courseId` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`) ON DELETE CASCADE;

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `FK_course_discount_discountId` FOREIGN KEY (`discountId`) REFERENCES `discount` (`discountId`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_course_topic_topicId` FOREIGN KEY (`topicId`) REFERENCES `topic` (`topicId`) ON DELETE CASCADE;

--
-- Constraints for table `exercise`
--
ALTER TABLE `exercise`
  ADD CONSTRAINT `FK_exercise_lesson_lessonId` FOREIGN KEY (`lessonId`) REFERENCES `lesson` (`lessonId`) ON DELETE CASCADE;

--
-- Constraints for table `exerciseinuser`
--
ALTER TABLE `exerciseinuser`
  ADD CONSTRAINT `FK_exerciseInUser_AppUser_studentId` FOREIGN KEY (`studentId`) REFERENCES `appuser` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_exerciseInUser_exercise_exerciseId` FOREIGN KEY (`exerciseId`) REFERENCES `exercise` (`exerciseId`) ON DELETE CASCADE;

--
-- Constraints for table `lesson`
--
ALTER TABLE `lesson`
  ADD CONSTRAINT `FK_lesson_course_courseId` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`) ON DELETE CASCADE;

--
-- Constraints for table `receipt`
--
ALTER TABLE `receipt`
  ADD CONSTRAINT `FK_receipt_register_registerId` FOREIGN KEY (`registerId`) REFERENCES `register` (`registerId`) ON DELETE CASCADE;

--
-- Constraints for table `register`
--
ALTER TABLE `register`
  ADD CONSTRAINT `FK_register_course_courseId` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
