-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 25, 2017 at 05:20 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phinmaui_elections`
--

-- --------------------------------------------------------

--
-- Table structure for table `added_student_logs`
--
DROP DATABASE esc_elections;
CREATE DATABASE esc_elections;
USE esc_elections;
CREATE TABLE `added_student_logs` (
  `ID_No` varchar(50) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `Date_Added` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `eballotno`
--

CREATE TABLE `eballotno` (
  `Number` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `eballotno`
--

INSERT INTO `eballotno` (`Number`) VALUES
('0001');

-- --------------------------------------------------------

--
-- Table structure for table `eballot_archive`
--

CREATE TABLE `eballot_archive` (
  `Ballot_No` varchar(4) NOT NULL,
  `ID_No` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `local_candidates`
--

CREATE TABLE `candidates` (
  `Candidate_ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `Position` varchar(100) NOT NULL,
  `Votes` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `local_candidates`
--

INSERT INTO `candidates` (`Candidate_ID`, `Name`, `Department`, `Position`, `Votes`) VALUES
(1, 'ALMORO, WENDY JOYCE R.', 'CPE', 'PRESIDENT', 0),
(2, 'ANGELES, LIONELLE M.', 'CE', 'PRESIDENT', 0),
(3, 'AROJADO, ROJELL SAINE O.', 'EE', 'VP-INTERNAL', 0),
(4, 'AYALA, LAWRENCE JAMES Z.', 'ECE', 'VP-INTERNAL', 0),
(5, 'CAGUICLA, JOHN MARK GABRIEL N.', 'ME', 'VP-EXTERNAL', 0),
(6, 'CARLOS, CHESTER JOHN R.', 'IE', 'VP-EXTERNAL', 0),
(7, 'JUELAR, JEROME U.', 'CE', 'SECRETARY', 0),
(8, 'KIRIYAMA, ANLLIE C.', 'CPE', 'SECRETARY', 0),
(9, 'MILAN, GEM RYAN C.', 'ECE', 'AUDITOR', 0),
(10, 'MADULA, JOHN JEFFEL Q.', 'EE', 'AUDITOR', 0),
(11, 'NILLO, MARK EZYKIEL B.', 'IE', 'TREASURER', 0),
(12, 'QUILATON, JAMES MARVIN M.', 'ME', 'TREASURER', 0),
(13, 'REFUGIO, JUDY ANN A.', 'CE', 'ASECRETARY', 0),
(14, 'REYES, ANICIA COLEEN S.', 'CPE', 'ASECRETARY', 0),
(15, 'SAMSON, HERVINSON M.', 'ECE', 'BUSMANAGER', 0),
(16, 'SAYO, RYAN REINALD R.', 'EE', 'BUSMANAGER', 0),
(17, 'SIGUE, BRYANT EXEL G.', 'IE', 'BUSMANAGER', 0),
(18, 'ZALDIVAR JR., CHRISTIAN IAN B.', 'ME', 'BUSMANAGER', 0),
(19, 'ALFONSO, KENNETH A.', 'ECE', 'PRO', 0),
(20, 'ALBAN, MARK GEO V.', 'EE', 'PRO', 0),
(21, 'ESPINA, JESSA MAE P.', 'CE', 'PRO', 0),
(22, 'FERNANDEZ, MARK DANIELLE D.', 'CPE', 'PRO', 0),
(23, 'ROSALINAS, JOHN BAIRY', 'IE', 'BOARD MEMBER', 0),
(24, 'REAL, ALDRIN L.', 'ME', 'BOARD MEMBER', 0),
(25, 'GUARIN, DANMARK C.', 'CE', 'BOARD MEMBER', 0),
(26, 'MECIJA, GEMAR JAY K.', 'CPE', 'BOARD MEMBER', 0),
(27, 'CAMACLANG, BENN JAY O.', 'EE', 'BOARD MEMBER', 0);

-- --------------------------------------------------------

--
-- Table structure for table `login_logs`
--

CREATE TABLE `login_logs` (
  `ID` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Logged_In` varchar(100) NOT NULL,
  `Logged_Out` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `log_id`
--

CREATE TABLE `log_id` (
  `ID` varchar(110) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `log_id`
--

INSERT INTO `log_id` (`ID`) VALUES
('001');

-- --------------------------------------------------------

-- --------------------------------------------------------

--
-- Table structure for table `student_data`
--

CREATE TABLE `student_data` (
  `ID_No` varchar(14) NOT NULL,
  `Lastname` varchar(16) DEFAULT NULL,
  `Firstname` varchar(25) DEFAULT NULL,
  `Middlename` varchar(13) DEFAULT NULL,
  `Course` varchar(15) DEFAULT NULL,
  `Password` varchar(25) DEFAULT NULL,
  `Activation` tinyint(1) NOT NULL,
  `Voted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_data`
--

INSERT INTO `student_data` (`ID_No`, `Lastname`, `Firstname`, `Middlename`, `Course`, `Password`, `Activation`, `Voted`) VALUES
('15-0479-929', 'ADANTE', 'RAMON PAUL', '', 'CE', '15-0479-929', 1, 0),
('16-3172-893', 'AGUSTINO', 'IVAN DAVE', 'FAJARDO', 'CE', '16-3172-893', 1, 0),
('14-1155-992', 'ALMADIN', 'ARVIN', 'FONTANILLA', 'CPE', '14-1155-992', 1, 0),
('14-0597-273', 'ALONZO', 'ANA MIKAELA', 'ALVAREZ', 'CPE', '14-0597-273', 1, 0),
('13-1999-960', 'BIONESTA', 'RONNICK BIEN', 'BONDA', 'ECE', '13-1999-960', 1, 0),
('14-1461-802', 'BONGAO', 'MELCHIEZEDHIECK', 'JABAY', 'ECE', '14-1461-802', 1, 0),
('15-1963-779', 'FALLA', 'CHRISTIAN', 'LUMASAC', 'EE', '15-1963-779', 1, 0),
('14-1116-800', 'GILBUENA', 'WENDEL', 'TEMPROSA', 'EE', '14-1116-800', 1, 0),
('14-1425-164', 'GREGANDA', 'JUAN CARLO', 'FELIPE', 'IE', '14-1425-164', 1, 0),
('14-0320-700', 'KARAMIHAN', 'KENNETH', 'CARO', 'IE', '14-0320-700', 1, 0),
('14-2325-266', 'MARTINEZ', 'MARK CHRISTIAN', 'P', 'ME', '14-2325-266', 1, 0),
('13-0042-589', 'OYALES', 'CARL JUSTINE', 'LEAGUE', 'ME', '13-0042-589', 1, 0),
('14-0142-411', 'TUASON', 'FERANGELO', 'CANIESO', 'ME', '14-0142-411', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `voted_logs`
--

CREATE TABLE `voted_logs` (
  `BallotNo` varchar(100) NOT NULL,
  `IDNo` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Course` varchar(100) NOT NULL,
  `Department` varchar(100) NOT NULL,
  `President` varchar(100) NOT NULL,
  `VPInternal` varchar(100) NOT NULL,
  `VPExternal` varchar(100) NOT NULL,
  `Secretary` varchar(100) NOT NULL,
  `Auditor` varchar(100) NOT NULL,
  `Treasurer` varchar(100) NOT NULL,
  `AsstSec` varchar(100) NOT NULL,
  `BusMan1` varchar(100) NOT NULL,
  `BusMan2` varchar(100) NOT NULL,
  `PRO1` varchar(100) NOT NULL,
  `PRO2` varchar(100) NOT NULL,
  `BoardMember1` varchar(100) NOT NULL,
  `BoardMember2` varchar(100) NOT NULL,
  `BoardMember3` varchar(100) NOT NULL,
  `BoardMember4` varchar(100) NOT NULL,
  `BoardMember5` varchar(100) NOT NULL,
  `Time` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `added_student_logs`
--
ALTER TABLE `added_student_logs`
  ADD PRIMARY KEY (`ID_No`);

--
-- Indexes for table `eballot_archive`
--
ALTER TABLE `eballot_archive`
  ADD PRIMARY KEY (`Ballot_No`);

INSERT INTO `eballot_archive` (`Ballot_No`,`ID_No`) VALUES 
(0001,'15-0479-929'),
(0002,'16-3172-893'),
(0003,'14-1155-992'),
(0004,'14-0597-273'),
(0005,'13-1999-960'),
(0006,'14-1461-802'),
(0007,'15-1963-779'),
(0008,'14-1116-800'),
(0009,'14-1425-164'),
(0010,'14-0320-700'),
(0011,'14-2325-266'),
(0012,'13-0042-589'),
(0013,'14-0142-411');

--
-- Indexes for table `local_candidates`
--
ALTER TABLE `candidates`
  ADD PRIMARY KEY (`Candidate_ID`);

--
-- Indexes for table `login_logs`
--
ALTER TABLE `login_logs`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student_data`
--
ALTER TABLE `student_data`
  ADD PRIMARY KEY (`ID_No`);

--
-- Indexes for table `voted_logs`
--
ALTER TABLE `voted_logs`
  ADD PRIMARY KEY (`BallotNo`);

--
-- AUTO_INCREMENT for dumped tables
--

ALTER TABLE `candidates`
  MODIFY `Candidate_ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
