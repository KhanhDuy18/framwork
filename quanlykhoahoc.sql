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
('a88ce81e-968c-4be8-83a8-234be543fa90', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', 1, 'AQAAAAEAACcQAAAAED1vDZ2bRHnM6Lby4s9kCoawvkqUKg7m9FVcZ2mFBZi3O87KBnTfioMLrfqp0w5mkw==', 'HWOOIVCXGEJ3X6H73HPFRB5OIP2KXIVO', '9f52f1a6-e714-4241-a5cb-78577f49f07c', '+84123456', 0, 0, NULL, 1, 0, '??????ng Tha??p', '2001-01-15 20:32:00'),
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
(1, 'L???p tr??nh h?????ng ?????i t?????ng trong C++\r\n', 'Kh??a h???c C++ OOP gi??p c??c l???p tr??nh vi??n h???c ???????c k??? thu???t l???p tr??nh m?? t???t c??? logic, y??u c???u th???c t??? ?????u ???????c x??y d???ng xoay quanh c??c ?????i t?????ng. Hi???u ???????c c??ch th???c ho???t ?????ng c???a C++ OOP s??? l??m ????n gi???n h??a vi???c b???o tr?? v?? d??? d??ng m??? r???ng trong vi???c thi???t k??? ph???n m???m.\r\n', 0, 200000, '', '100 gi????', 5000, 3, 3, 9),
(2, 'Truy???n th??ng v?? M???ng m??y t??nh', 'Kh??a h???c cung c???p cho l???p tr??nh vi??n nh???ng ki???n th???c c?? b???n v?? d??? hi???u v??? m???ng m??y t??nh v?? truy???n th??ng d??? li???u.\r\n', 0, 500000, '', '115 gi???? 15 phu??t', 545, 3, 1, 7),
(3, 'Ph???n m???m m??y t??nh', 'Ph???n m???m lu??n l?? c??ng c??? c???n thi???t trong m???i l??nh v???c, kh??a h???c n??y s??? gi??p b???n hi???u ???????c c??c kh??i ni???m v??? ph???n m???m v?? c??c ph???n m???m ph??? bi???n hi???n nay.\r\n', 0, 800000, '', '80 gi????', 890, 3, 3, 9),
(4, 'Ph???n c???ng m??y t??nh', 'Kh??a h???c n??y t???p trung v??o vi???c cung c???p c??c ki???n th???c chung v??? c??c b??? ph???n c???a m??y t??nh ????? b???n c?? th??? ??p d???ng v??o vi???c l???a ch???n v?? s??? d???ng m??y t??nh.\r\n', 0, 500000, '', '150 gi????', 545, 3, 2, 8),
(5, 'C cho ng?????i m???i b???t ?????u', 'Kh??a h???c l???p tr??nh C cho ng?????i m???i b???t ?????u. Kh??a h???c n??y s??? cung c???p nh???ng ki???n th???c c?? b???n v?? l?? n???n t???ng ????? b???n ??i xa h??n tr??n con ???????ng l???p tr??nh.\r\n', 0, 750000, '', '200 gi????', 1500, 4, 1, 9),
(6, 'C++ cho ng?????i m???i b???t ?????u', 'Kh??a h???c l???p tr??nh C++ c?? b???n cho ng?????i m???i b???t ?????u. Kh??a h???c n??y s??? cung c???p nh???ng ki???n th???c c?? b???n, d??? hi???u nh???t v??? ng??n ng??? l???p tr??nh C++.\r\n', 0, 500000, '', '200 gi????', 2000, 4, 4, 10),
(7, 'L??m quen v???i SQL', 'Kh??a h???c n??y s??? gi??p c??c l???p tr??nh vi??n n???m ???????c nguy??n t???c, c?? ph??p v?? c??ch th???c ho???t ?????ng c???a SQL (Structured Query Language).\r\n', 0, 650000, '', '150 gi????', 2000, 4, 2, 9),
(8, 'Javascript c??n b???n', 'Gi??p h???c vi??n n???m v???ng c??c nguy??n t???c v?? c?? ph??p c?? b???n trong Javascript - ng??n ng??? l???p tr??nh ph??? bi???n nh???t tr??n th??? gi???i.\r\n', 0, 750000, '', '175 gi???? ', 1500, 4, 5, 7),
(9, 'Python c?? b???n', 'Kh??a h???c l???p tr??nh Python c?? b???n v???i c??c b??i t???p v?? l?? thuy???t d??? hi???u, h???c xong b???n c?? th??? t??? tin ????? t???i v???i c??c ch??? ????? n??ng cao h??n c???a Python.\r\n', 0, 550000, '', '130 gi????', 1300, 4, 2, 9),
(10, 'C# c?? b???n', 'Kh??a h???c l???p tr??nh C# k??m th???c h??nh, kh??a h???c s??? gi??p b???n l??m quen v???i l???p tr??nh c??ng nh?? t???o n???n t???ng t?? duy v?? k??? n??ng c?? b???n khi gi???i c??c b??i t???p.\r\n', 0, 750000, '', '140 gi????', 1500, 4, 2, 10),
(11, 'Java c?? b???n', 'Kh??a h???c l???p tr??nh Java c?? b???n cho ng?????i m???i b???t ?????u, kh??a h???c n??y s??? l?? n???n t???ng cho kh??a Java n??ng cao ????? ti???n t???i Java Web hay l???p tr??nh Android, ???\r\n', 0, 800000, '', '200 gi????', 2500, 4, 4, 9),
(12, 'Thu???t to??n c??n b???n', 'V???i kh??a h???c thu???t to??n c?? b???n, b???n s??? h???c ???????c c??ch t?? duy v?? gi???i quy???t c??c b??i to??n l???p tr??nh c?? b???n m?? m???t l???p tr??nh vi??n c???n c??.\r\n', 0, 850000, '', '175 gi????', 500, 6, 1, 8),
(13, 'Th???c h??nh v???i SQL', 'Kh??a h???c n??y s??? gi??p b???n bi???t v??? m???t s??? ch???c n??ng ch??nh c???n thi???t ????? s???p x???p, l???c v?? ph??n lo???i th??ng tin trong c?? s??? d??? li???u quan h???, m??? r???ng b??? c??ng c??? SQL c???a b???n v?? gi??p b???n c?? kh??? n??ng gi???i quy???t c??c v???n ????? ph???c t???p h??n th??ng qua b??? c??ng c??? n??y. Y??u c???u: B???n c???n ho??n th??nh kh??a L??m quen v???i SQL ????? c?? ki???n th???c c?? b???n tr?????c khi\r\n', 0, 800000, '', '250 gi???? 15 phu??t', 1400, 6, 2, 9),
(14, 'C???u tr??c d??? li???u v?? gi???i thu???t', 'Kh??a h???c n??y s??? gi??p c??c b???n hi???u thu???t to??n c??ng nh?? hi???u r?? b???n ch???t c???a c??c c???u tr??c d??? li???u - ??i???u ki???n ????? tr??? th??nh l???p tr??nh vi??n gi???i.\r\n', 0, 200000, '', '150 gi????', 2000, 4, 3, 8),
(15, 'L???p tr??nh h?????ng ?????i t?????ng trong Java', 'L???p tr??nh h?????ng ?????i t?????ng (Object-Oriented-Programming) l?? ph????ng ph??p l???p tr??nh d???a tr??n ?????i t?????ng ????? t??m ra b???n ch???t c???a v???n ?????. Kh??a h???c Java OOP gi??p c??c l???p tr??nh vi??n h???c ???????c k??? thu???t l???p tr??nh m?? t???t c??? logic, y??u c???u th???c t??? ?????u ???????c x??y d???ng xoay quanh c??c ?????i t?????ng. Hi???u ???????c c??ch th???c ho???t ?????ng c???a Java OOP s??? l??m ????n gi???n h??a vi???c b???o tr?? v?? d??? d??ng m??? r???ng trong vi???c thi???t k??? ph???n m???m.\r\n', 0, 800000, '', '200 gi????', 1500, 6, 3, 8),
(16, 'y???u t??? c???n thi???t cho ????m m??y', 'Kh??a h???c s??? cung c???p c??i nh??n c?? b???n v?? t???ng quan v??? l??nh v???c ??i???n to??n ????m m??y v?? c??c c??ng ngh??? ??i???n to??n ????m m??y m???i n???i.', 0, 850000, '', '250 gi????', 545, 7, 5, 9);

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
(1, 'Khuy????n ma??i nga??y valentine', '2021-12-16 04:49:04', 0.8),
(2, 'Ki?? ni????m 10 n??m tha??nh l????p', '2021-11-01 00:00:00', 0.2),
(3, 'Khuy????n ma??i nga??y t????t', '2021-11-02 00:00:00', 0.15),
(4, 'Si??u sale back to school', '2021-11-20 00:00:00', 0.1),
(5, 'M????ng trung thu', '2021-11-01 00:00:00', 0.05),
(6, 'Khuy????n ma??i l????n ??????u ????ng ki??', '2021-11-01 00:00:00', 0.25);

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
