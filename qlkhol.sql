-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2021 at 03:31 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qlkh`
--

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `user_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `content` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `evaluate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`user_id`, `course_id`, `content`, `evaluate`) VALUES
(5, 1, 'course assessment', 100),
(6, 3, 'course assessment', 100),
(7, 4, 'course assessment', 100),
(8, 2, 'course assessment', 100),
(9, 5, 'course assessment', 100);

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `discription` varchar(1000) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `original_price` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `total_student` int(11) NOT NULL,
  `total_time` date NOT NULL,
  `img_course` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `topic_id` int(11) NOT NULL,
  `discount_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `course_name`, `discription`, `original_price`, `price`, `total_student`, `total_time`, `img_course`, `topic_id`, `discount_id`) VALUES
(1, '	 Web Applications Development', 'Web Applications Developmen', 2000000, 1800000, 100, '2022-02-28', '', 1, 1),
(2, 'Mobile Applications Developmen', 'course for 3 months', 2000000, 1800000, 100, '2022-02-28', '', 2, 2),
(3, 'Distributed database systems', 'course for 3 months\r\n', 2000000, 1800000, 100, '2022-02-28', '', 3, 3),
(4, 'Advanced Data Mining Applications', 'course for 3 months', 2000000, 1800000, 100, '2022-02-28', '', 4, 4),
(5, 'Decision support and business intelligence applica', 'course for 3 months', 2000000, 1800000, 100, '2022-02-28', '', 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `ct_exercise_user`
--

CREATE TABLE `ct_exercise_user` (
  `user_id` int(11) NOT NULL,
  `exercise_id` int(11) NOT NULL,
  `submit` date NOT NULL,
  `scores` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `ct_exercise_user`
--

INSERT INTO `ct_exercise_user` (`user_id`, `exercise_id`, `submit`, `scores`) VALUES
(6, 1, '2021-12-31', 8),
(6, 2, '2021-12-31', 9),
(7, 3, '2021-12-31', 10),
(8, 4, '2021-12-31', 8.5),
(9, 5, '2021-12-31', 7);

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `discount_id` int(11) NOT NULL,
  `discription` varchar(500) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `time` date NOT NULL,
  `sale` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `discount`
--

INSERT INTO `discount` (`discount_id`, `discription`, `time`, `sale`) VALUES
(1, 'discount 20%', '2021-11-01', 0.2),
(2, 'discount 15%', '2021-11-02', 0.15),
(3, 'discount 10%', '2021-11-20', 0.1),
(4, 'discount 5%', '2021-11-01', 0.05),
(5, 'discount 0%', '2021-11-01', 0);

-- --------------------------------------------------------

--
-- Table structure for table `exercise`
--

CREATE TABLE `exercise` (
  `exercise_id` int(11) NOT NULL,
  `content` varchar(1000) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `deadline` date NOT NULL,
  `lesson_id` int(11) NOT NULL,
  `teacher_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `exercise`
--

INSERT INTO `exercise` (`exercise_id`, `content`, `deadline`, `lesson_id`, `teacher_id`) VALUES
(1, 'What industry sites and blogs do you read regularly?', '2021-12-01', 1, 2),
(2, 'Do you prefer to work alone or on a team?', '2021-12-01', 2, 3),
(3, 'How comfortable are you with writing HTML entirely by hand?', '2021-12-01', 3, 4),
(4, 'What is the w3c?', '2021-12-01', 4, 2),
(5, 'Can you write table-less XHTML? Do you validate your code?', '2021-12-01', 5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `lesson`
--

CREATE TABLE `lesson` (
  `lesson_id` int(11) NOT NULL,
  `title` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `author` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `content` varchar(1000) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `course_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `lesson`
--

INSERT INTO `lesson` (`lesson_id`, `title`, `author`, `content`, `course_id`) VALUES
(1, '\r\nExercise 1', 'nguyen thi b', 'Exercises 1', 1),
(2, '\r\nExercise 2', 'nguyen van c', 'Exercises 2', 2),
(3, '\r\nExercise 3', 'nguyen thi d', 'Exercises 3', 3),
(4, '\r\nExercise 4', 'nguyen van e', 'Exercises 4', 4),
(5, '\r\nExercise 5', 'nguyen van c', 'Exercises 5', 5);

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE `receipt` (
  `receipt_id` int(11) NOT NULL,
  `total_price` int(11) NOT NULL,
  `status` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `time_receipt` date NOT NULL,
  `register_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `receipt`
--

INSERT INTO `receipt` (`receipt_id`, `total_price`, `status`, `time_receipt`, `register_id`) VALUES
(1, 1800000, 'customer invoice 1', '2021-10-02', 1),
(2, 1800000, 'customer invoice 2', '2021-10-02', 2),
(3, 1800000, 'customer invoice 3', '2021-10-02', 3),
(4, 1800000, 'customer invoice 4', '2021-10-02', 4),
(5, 1800000, 'customer invoice 5', '2021-10-02', 5);

-- --------------------------------------------------------

--
-- Table structure for table `register`
--

CREATE TABLE `register` (
  `register_id` int(11) NOT NULL,
  `time_reg` date NOT NULL,
  `status` varchar(100) CHARACTER SET utf32 COLLATE utf32_unicode_ci DEFAULT NULL,
  `course_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `register`
--

INSERT INTO `register` (`register_id`, `time_reg`, `status`, `course_id`, `user_id`) VALUES
(1, '2021-10-01', 'registration course 1', 1, 5),
(2, '2021-10-01', 'registration course 2', 2, 6),
(3, '2021-10-01', 'registration course 3', 3, 7),
(4, '2021-10-01', 'registration course 4', 4, 8),
(5, '2021-10-01', 'registration course 5', 5, 9);

-- --------------------------------------------------------

--
-- Table structure for table `topic`
--

CREATE TABLE `topic` (
  `topic_id` int(11) NOT NULL,
  `name_id` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `topic`
--

INSERT INTO `topic` (`topic_id`, `name_id`) VALUES
(1, 'MSIS 207: Web Applications Development'),
(2, 'CS 4153Mobile Applications Developmen'),
(3, 'CS 5433: Distributed database systems'),
(4, 'MKTG 5883: Advanced Data Mining Applications'),
(5, 'MSIS 4263: Decision support and business intellige');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `name_user` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `full_name` varchar(45) CHARACTER SET utf32 COLLATE utf32_unicode_ci NOT NULL,
  `address` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `brithday` date NOT NULL,
  `mail` int(11) NOT NULL,
  `gender` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `sdt` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `qualifications` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  `start_working` date DEFAULT NULL,
  `role_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name_user`, `password`, `full_name`, `address`, `brithday`, `mail`, `gender`, `sdt`, `qualifications`, `salary`, `start_working`, `role_id`) VALUES
(1, 'Van A', '123', 'Nguyen Van A', 'Tp.HoChiMinh', '2000-01-01', 0, 'Male', '0123456789', 'director', 20000000, '2021-01-01', 1),
(2, 'Thi B', '123', 'Nguyen Thi B', 'Tp.HoChiMinh', '2000-02-02', 0, 'Female', '0223456789', 'teacher', 20000000, '2021-02-02', 1),
(3, 'Van C', '123', 'Nguyen Van C', 'Gia Lai', '2000-03-03', 0, 'Male', '0323456789', 'teacher', 10000000, '2021-03-03', 1),
(4, 'Thi D', '123', 'Nguyen Thi D', 'Ha Noi', '2000-04-04', 0, 'Female', '0423456789', 'teacher', 10000000, '2021-04-04', 1),
(5, 'Van E', '123', 'Nguyen Van E', 'Tien Giang', '2000-05-05', 0, 'Male', '0523456789', 'teacher\r\n', 10000000, '2021-05-05', 1),
(6, 'Thi F', '123', 'Nguyen Thi F', 'Da Nang', '2000-06-06', 0, 'Female', '0623456789', 'student\r\n', NULL, '2021-06-06', 1),
(7, 'Van G', '123', 'Nguyen Van G', 'Hue', '2000-07-07', 0, 'Male', '0723456789', 'custom', NULL, '2021-07-07', 1),
(8, 'Thi H', '123', 'Nguyen Thi H', 'Khanh Hoa', '2000-08-08', 0, 'Female', '0823456789', 'student', NULL, '2021-08-08', 1),
(9, 'Van I', '123', 'Nguyen Van I', 'Binh Dinh', '2000-09-09', 0, 'Male', '0923456789', 'student\r\n', NULL, '2021-09-09', 1),
(10, 'Thi K', '123', 'Nguyen Thi K', 'Dak lak', '2000-10-10', 0, 'Female', '0103456789', 'student\r\n', NULL, '2021-10-10', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD KEY `fk_comment_user` (`user_id`),
  ADD KEY `fk_comment_course` (`course_id`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`),
  ADD KEY `fk_course_topic` (`topic_id`),
  ADD KEY `fk_course_discount` (`discount_id`);

--
-- Indexes for table `ct_exercise_user`
--
ALTER TABLE `ct_exercise_user`
  ADD KEY `fk_ct_user` (`user_id`),
  ADD KEY `fk_ct_exercise` (`exercise_id`);

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`discount_id`);

--
-- Indexes for table `exercise`
--
ALTER TABLE `exercise`
  ADD PRIMARY KEY (`exercise_id`),
  ADD KEY `fk_exercise_lesson` (`lesson_id`),
  ADD KEY `fk_exercise_teacher` (`teacher_id`);

--
-- Indexes for table `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lesson_id`),
  ADD KEY `fk_lesson_course` (`course_id`);

--
-- Indexes for table `receipt`
--
ALTER TABLE `receipt`
  ADD PRIMARY KEY (`receipt_id`),
  ADD KEY `fk_receipt_register` (`register_id`);

--
-- Indexes for table `register`
--
ALTER TABLE `register`
  ADD PRIMARY KEY (`register_id`),
  ADD KEY `fk_register_course` (`course_id`),
  ADD KEY `fk_register_user` (`user_id`);

--
-- Indexes for table `topic`
--
ALTER TABLE `topic`
  ADD PRIMARY KEY (`topic_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `fk_user_role` (`role_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `discount_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `exercise`
--
ALTER TABLE `exercise`
  MODIFY `exercise_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `lesson`
--
ALTER TABLE `lesson`
  MODIFY `lesson_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `receipt`
--
ALTER TABLE `receipt`
  MODIFY `receipt_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `register`
--
ALTER TABLE `register`
  MODIFY `register_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `topic`
--
ALTER TABLE `topic`
  MODIFY `topic_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `fk_comment_course` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  ADD CONSTRAINT `fk_comment_user` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `fk_course_discount` FOREIGN KEY (`discount_id`) REFERENCES `discount` (`discount_id`),
  ADD CONSTRAINT `fk_course_topic` FOREIGN KEY (`topic_id`) REFERENCES `topic` (`topic_id`);

--
-- Constraints for table `ct_exercise_user`
--
ALTER TABLE `ct_exercise_user`
  ADD CONSTRAINT `fk_ct_exercise` FOREIGN KEY (`exercise_id`) REFERENCES `exercise` (`exercise_id`),
  ADD CONSTRAINT `fk_ct_user` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);

--
-- Constraints for table `exercise`
--
ALTER TABLE `exercise`
  ADD CONSTRAINT `fk_exercise_lesson` FOREIGN KEY (`lesson_id`) REFERENCES `lesson` (`lesson_id`),
  ADD CONSTRAINT `fk_exercise_teacher` FOREIGN KEY (`teacher_id`) REFERENCES `user` (`user_id`);

--
-- Constraints for table `lesson`
--
ALTER TABLE `lesson`
  ADD CONSTRAINT `fk_lesson_course` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`);

--
-- Constraints for table `receipt`
--
ALTER TABLE `receipt`
  ADD CONSTRAINT `fk_receipt_register` FOREIGN KEY (`register_id`) REFERENCES `register` (`register_id`);

--
-- Constraints for table `register`
--
ALTER TABLE `register`
  ADD CONSTRAINT `fk_register_course` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  ADD CONSTRAINT `fk_register_user` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
