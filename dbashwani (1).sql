-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 10:08 AM
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
  `id` bigint(11) UNSIGNED NOT NULL,
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
  `id` bigint(11) UNSIGNED NOT NULL,
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
(7, 'Tang Buaya', 'Alat', 'Non-Elektrik', 21, 133000, 'Tang Buaya nih bos', 'Tang Buaya.jpg'),
(10, 'Kawat', 'Bahan', 'Bangunan', 12, 30000, 'Kawat', 'Kawat.jpg'),
(11, 'Meteran', 'Alat', 'Non-Elektrik', 12, 32000, 'Meteran lllllll', 'Meteran.jpg'),
(12, 'Arko', 'Alat', 'Non-Elektrik', 12, 659000, 'Gerobak Dorong untuk mengangkut pasir', 'Arko.jpg');

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
  `id` bigint(11) UNSIGNED NOT NULL,
  `id_user` bigint(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkeranjang`
--

INSERT INTO `tbkeranjang` (`id`, `id_user`) VALUES
(8, 1),
(11, 9);

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang_item`
--

CREATE TABLE `tbkeranjang_item` (
  `idkeranjang` bigint(11) UNSIGNED NOT NULL,
  `idbarang` bigint(11) UNSIGNED NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi`
--

CREATE TABLE `tbtransaksi` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `id_user` bigint(20) UNSIGNED NOT NULL,
  `tanggal` text NOT NULL,
  `status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbtransaksi`
--

INSERT INTO `tbtransaksi` (`id`, `id_user`, `tanggal`, `status`) VALUES
(1, 1, '24/Mei/2023', 'SELESAI'),
(2, 9, '24/Mei/2023', 'DIBATALKAN'),
(6, 1, '24/Mei/2023', 'REQUEST BATAL'),
(7, 1, '24/Mei/2023', 'DIBATALKAN'),
(9, 9, '24/Mei/2023', 'SELESAI'),
(10, 9, '24/Mei/2023', 'SELESAI');

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi_item`
--

CREATE TABLE `tbtransaksi_item` (
  `idtransaksi` bigint(20) UNSIGNED NOT NULL,
  `item` text NOT NULL,
  `qty` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `foto` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbtransaksi_item`
--

INSERT INTO `tbtransaksi_item` (`idtransaksi`, `item`, `qty`, `harga`, `foto`) VALUES
(1, 'Martil', 1, 75000, 'Martil.jpg'),
(1, 'Paku', 14, 3000, 'Paku.jpg'),
(6, 'Semen', 1, 170000, 'Semen.jpg'),
(6, 'test pen', 1, 30000, 'test pen.jpg'),
(7, 'Tang Buaya', 2, 133000, 'Tang Buaya.jpg'),
(7, 'Kawat', 1, 30000, 'Kawat.jpg'),
(2, 'Sekop Pasir', 1, 95000, 'Sekop Pasir.jpg'),
(2, 'Kawat', 1, 30000, 'Kawat.jpg'),
(9, 'Martil', 1, 75000, 'Martil.jpg'),
(9, 'Arko', 1, 659000, 'Arko.jpg'),
(10, 'Martil', 4, 75000, 'Martil.jpg'),
(10, 'test pen', 4, 30000, 'test pen.jpg');

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
  ADD PRIMARY KEY (`id`);

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
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `tbkeranjang_item`
--
ALTER TABLE `tbkeranjang_item`
  ADD KEY `idbarang` (`idbarang`),
  ADD KEY `idkeranjang` (`idkeranjang`);

--
-- Indexes for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `tbtransaksi_item`
--
ALTER TABLE `tbtransaksi_item`
  ADD KEY `idtransaksi` (`idtransaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id` bigint(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbbarang`
--
ALTER TABLE `tbbarang`
  MODIFY `id` bigint(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id` bigint(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD CONSTRAINT `tbkeranjang_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `tbakun` (`id`);

--
-- Constraints for table `tbkeranjang_item`
--
ALTER TABLE `tbkeranjang_item`
  ADD CONSTRAINT `tbkeranjang_item_ibfk_1` FOREIGN KEY (`idbarang`) REFERENCES `tbbarang` (`id`),
  ADD CONSTRAINT `tbkeranjang_item_ibfk_2` FOREIGN KEY (`idkeranjang`) REFERENCES `tbkeranjang` (`id`);

--
-- Constraints for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD CONSTRAINT `tbtransaksi_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `tbakun` (`id`);

--
-- Constraints for table `tbtransaksi_item`
--
ALTER TABLE `tbtransaksi_item`
  ADD CONSTRAINT `tbtransaksi_item_ibfk_1` FOREIGN KEY (`idtransaksi`) REFERENCES `tbtransaksi` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
