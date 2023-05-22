-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2023 at 06:04 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbashwani`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `id` int(11) NOT NULL,
  `nama` varchar(40) NOT NULL,
  `email` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `password` text NOT NULL,
  `level` varchar(10) NOT NULL,
  `foto` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`id`, `nama`, `email`, `alamat`, `password`, `level`, `foto`) VALUES
(1, 'Yahya', 'yha@gmail.com', 'Jl Panjaitan', '123', 'USER', 'yha@gmail.com.jpg'),
(2, 'owner', 'owner', 'owner', 'owner', 'OWNER', ''),
(4, 'Asep Gunawan', 'asep@gmail.com', 'Jl Mangkuraja', 'asep', 'KARYAWAN', 'asep@gmail.com.jpg'),
(5, 'Kurniawan Mega', 'awan@gmail.com', 'Jl Panjaitan', '123', 'KARYAWAN', 'awan@gmail.com.jpg'),
(7, 'Pawang Hujan', 'hujan@gmail.com', 'Jl Sukarno Hatta', 'hujan', 'USER', ''),
(8, 'agung', 'agung@gmail.com', 'Jl Kelua', '123', 'USER', ''),
(9, 'suparjan', 'ajan@gmail.com', 'Jl M.Said', '123', 'USER', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbbarang`
--

CREATE TABLE `tbbarang` (
  `id` int(11) NOT NULL,
  `nama` text NOT NULL,
  `tipe` text NOT NULL,
  `jenis` text NOT NULL,
  `stok` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `desk` text NOT NULL,
  `foto` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbbarang`
--

INSERT INTO `tbbarang` (`id`, `nama`, `tipe`, `jenis`, `stok`, `harga`, `desk`, `foto`) VALUES
(2, 'Martil', 'Alat', 'Non-Elektrik', 5, 75000, 'Martil adalah', 'Martil.jpg'),
(3, 'Paku', 'Bahan', 'Bangunan', 120, 3000, 'paku beton', 'Paku.jpg'),
(4, 'Semen', 'Bahan', 'Bangunan', 133, 170000, 'Semen Portland', 'Semen.jpg'),
(5, 'test pen', 'Alat', 'Non-Elektrik', 123, 30000, 'Buat ngecek kabel putus', 'test pen.jpg'),
(6, 'Sekop Pasir', 'Alat', 'Non-Elektrik', 100, 95000, 'Sekop pasir nih bos', 'Sekop Pasir.jpg'),
(7, 'Tang Buaya', 'Alat', 'Non-Elektrik', 21, 133000, 'Tang Buaya nih bos', 'Tang Buaya.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbgawai`
--

CREATE TABLE `tbgawai` (
  `gaji` int(11) NOT NULL,
  `shift` text NOT NULL,
  `email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbgawai`
--

INSERT INTO `tbgawai` (`gaji`, `shift`, `email`) VALUES
(800000, 'Malam', 'asep@gmail.com'),
(600000, 'Malam', 'awan@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkeranjang`
--

INSERT INTO `tbkeranjang` (`id`, `id_user`) VALUES
(1, 1),
(2, 9);

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang_item`
--

CREATE TABLE `tbkeranjang_item` (
  `idkeranjang` int(11) NOT NULL,
  `idbarang` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkeranjang_item`
--

INSERT INTO `tbkeranjang_item` (`idkeranjang`, `idbarang`, `qty`) VALUES
(1, 6, 1),
(1, 7, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `tbbarang`
--
ALTER TABLE `tbbarang`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nama` (`nama`) USING HASH;

--
-- Indexes for table `tbgawai`
--
ALTER TABLE `tbgawai`
  ADD KEY `email` (`email`(768));

--
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_idUser_1` (`id_user`);

--
-- Indexes for table `tbkeranjang_item`
--
ALTER TABLE `tbkeranjang_item`
  ADD KEY `fk_idBarang_1` (`idbarang`),
  ADD KEY `fk_idKeranjang_1` (`idkeranjang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbbarang`
--
ALTER TABLE `tbbarang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD CONSTRAINT `fk_idUser_1` FOREIGN KEY (`id_user`) REFERENCES `tbakun` (`id`);

--
-- Constraints for table `tbkeranjang_item`
--
ALTER TABLE `tbkeranjang_item`
  ADD CONSTRAINT `fk_idBarang_1` FOREIGN KEY (`idbarang`) REFERENCES `tbbarang` (`id`),
  ADD CONSTRAINT `fk_idKeranjang_1` FOREIGN KEY (`idkeranjang`) REFERENCES `tbkeranjang` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
