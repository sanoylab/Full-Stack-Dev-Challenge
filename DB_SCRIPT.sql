USE [master]
GO
/****** Object:  Database [ph19333445161_aradalejDB]    Script Date: 2021-01-26 7:01:54 PM ******/
CREATE DATABASE [ph19333445161_aradalejDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ph19333445161_aradalejDB', FILENAME = N'E:\MSSQL.MSSQLSERVER\DATA\ph19333445161_aradalejDB.mdf' , SIZE = 3328KB , MAXSIZE = 204800KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ph19333445161_aradalejDB_log', FILENAME = N'D:\MSSQL.MSSQLSERVER\DATA\ph19333445161_aradalejDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 102400KB , FILEGROWTH = 1024KB )
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ph19333445161_aradalejDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET  MULTI_USER 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ph19333445161_aradalejDB]
GO
/****** Object:  User [aradalej_user]    Script Date: 2021-01-26 7:01:55 PM ******/
CREATE USER [aradalej_user] FOR LOGIN [aradalej_user] WITH DEFAULT_SCHEMA=[aradalej_user]
GO
/****** Object:  DatabaseRole [gd_execprocs]    Script Date: 2021-01-26 7:01:56 PM ******/
CREATE ROLE [gd_execprocs]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [aradalej_user]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [aradalej_user]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [aradalej_user]
GO
ALTER ROLE [db_datareader] ADD MEMBER [aradalej_user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [aradalej_user]
GO
/****** Object:  Schema [aradalej_user]    Script Date: 2021-01-26 7:01:56 PM ******/
CREATE SCHEMA [aradalej_user]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2021-01-26 7:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryImage] [ntext] NULL,
	[Name] [nvarchar](350) NULL,
	[Status] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classified]    Script Date: 2021-01-26 7:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classified](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[Title] [ntext] NULL,
	[PictureUrl] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Location] [nvarchar](150) NULL,
	[Price] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[IsRecommended] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (1, N'/Content/images/home/girl1.jpg', N'House', 1)
INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (2, N'/Content/images/home/girl2.jpg', N'Computer', 1)
INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (3, N'/Content/images/home/girl3.jpg', N'Furniture', 1)
INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (4, N'/Content/images/home/girl4.jpg', N'Cars', 1)
INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (5, N'/Content/images/home/girl5.jpg', N'Kids Item', 1)
INSERT [dbo].[Category] ([Id], [CategoryImage], [Name], [Status]) VALUES (6, N'/Content/images/home/girl6.jpg', N'Women Fashion', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Classified] ON 

INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (1, 1, N'1 KENNON Place London, Ontario', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604798126190', N'MLS® #236134 Located on Wellington St, high traffic court, 3 Bedroom, great view of the city. Parking on street and drive way. Call LA for details. (id:24493) The trademarks MLS®, Multiple Listing Service® and the associated logos are owned by The Canadian Real Estate Association (CREA) and identify the quality of services provided by real estate professionals who are members of CREA This listing content provided by REALTOR.ca has been licensed by REALTOR® members of The Canadian Real Estate Association.', N'1 KENNON Place, London, ON, N6C1K7', N'700,000.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (6, 1, N'Three-bedroom two-story home ', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604798460053', N'Three-bedroom two-story home on Half acre property, 2 car garage and large modern shop , city water and septic system. Steps away from St Thomas city limits. 4 bathrooms, laundry on main floor. Granite in the kitchen and 3 designer bathroom vanities. All windows tinted not requiring blinds, providing privacy and UV protection. 1000 foot shop with curb appeal, smooth sealed concrete floors, 3 phase electricity, automatic radiant heat. Fully outfitted

', N' 2-8751 Tike Rd, St Thomas, ON N5P 3S6
', N'495,000.00
 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (7, 1, N'Beautiful 20 acre farm with house on a paved road in Dutton', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604798595202', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604798595202', N' 28286 Duff Line, Dutton, ON N0L 1J0, Canada
', N'774,900.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (8, 1, N'Homes for Sale in Middlesex, London, Ontario', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604798876280', N'You MUST view the 3D tour of this unique corner home! This property is for lovers of Victorian style who also desire reliable additional income from separate rental units and/or an already operating airbnb business. Its 1st unique point is its size, w/ the 2 bdrm aprtmt alone comprising the area of a small house. Second, it was designed, built & multiplexed by a family who developed the Old East Village in 1893. The layout is spacious & sensible, retaining much of its original grandeur. Stained-glass & leaded windows, built-in oak shelves & cabinets, artisanal tile, beamed 10'' ceilings, & oak pocket doors give this fourplex aristocratic charm. Three units can be vacant upon purchase for big airbnb or mrkt rent potential (ask LA for all possible uses and cap rates!). Solar panels & coin operated dryer provide additional income. Building inspected & licensed. (id:24493) The trademarks MLS®, Multiple Listing Service® and the associated logos are owned by The Canadian Real Estate Association (CREA) and identify the quality of services provided by real estate professionals who are members of CREA This listing content provided by REALTOR.ca has been licensed by REALTOR® members of The Canadian Real Estate Association.

', N' 510 QUEBEC Street, London, ON, N5W3Y7
', N'908,078.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (9, 2, N'SELLING MACBOOK AIR - 13 INCH - 2014 - GREAT CONDITION', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604803390554', N'Selling 13 inch Macbook Air -> great condition, no flaws or signs of damage - 1.4ghz Dual-Core Intel i5 - 4gb Ram - 128gb memory - Factory reset - Comes with charger Selling because I recently upgraded, nothing wrong. Happy to meet and let you try it before you buy it..', N' London, ON N5V 4T8', N'600.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (10, 2, N'Apple MacBook Pro 15.4-inch with Touch Bar (Intel i7 2.6GHz, 256GB SSD, 16GB RAM, Silver) - (2019 Model)', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604803551506', N'Apple 15.4-inch MacBook Pro with Touch Bar elevates the notebook to a whole new level of performance and portability. Wherever your ideas take you, you will get there faster than ever with high-performance processors and memory, advanced graphics, blazing-fast storage, and more.About this Apple 15.4-inch MacBook Pro with Touch Bar: - 15.4-inch (diagonal) LED-backlit display with IPS technology; 2880-by-1800 resolution at 220 pixels per inch with support for millions of colors - Intel Core i7-9750H processor with up to 4.5 GHz Turbo Boost and 6-Cores - 256GB PCI-E based flash memory storage; 16GB of 2400MHz DDR4 SDRAM onboard memory - Dual graphics processors - A discrete AMD Radeon Pro graphics card with 4GB dedicated GDDR5 memory and an integrated Intel HD Graphics 630 processor that shares memory with the system for an amazing experience - Built-in FaceTime HD camera for video chatting - Built-in stereo speakers along with omnidirectional microphone, headphone port - Force Touch trackpad for precise cursor control and pressure-sensing capabilities; enables Force clicks, accelerators, pressure-sensitive drawing, and Multi-Touch gestures - I/O Ports: Thunderbolt 3: 4 (via USB Type-C) DisplayPort: 4 (via USB Type-C) 3.5mm Headset Jack: 1 Any questions or if you''d like to come and have a look get in touch.', N' London, ON N5V 4T8', N'750.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (11, 2, N'MacBook Pro 2017 15” Touch Bar 1TB SSD 16GB 3.1Ghz i7 AppleCare', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604803936848', N'Like New Condition 2017 Macbook Pro with 1TB SSD harddrive, 15.4 Retina Display and 3.1GHz i7 Processor. It has the Radeon Pro 560 with 4GB GDDR5 ram. It really is an amazing machine, the only reason I''m selling it is because I just upgraded to the 2020 16 Macbook Pro. I purchased it in January 2018 and it still has AppleCare+ for a few more months. I just got it back from the Apple Store this week, where I had nearly the entire thing refreshed to new. They replaced the logic board (new hard drive, graphics card, CPU & RAM) & the top case (new keyboard & brand new battery.) They put $1500 worth of new parts in it, and the rest of the computer looks great. Includes the computer, AC adapter, and USB-C power cord.', N' London, ON N5V 4T8', N'2,200.00 USD', N'987-654-3210', 1)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (12, 2, N'2018 13” MacBook Pro, 4 Thunderbolt Ports', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604803695917', N'2018 13'' MacBook Pro, 4 Thunderbolt 3 Ports 2.3 GHz Quad-Core Intel Core i5 8 GB RAM 250 GB SSD Touch Bar TouchID Like new condition, everything looks and works great.', N' London, ON N5V 4T8', N'1,400.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (13, 2, N'Gaming Laptop MSI GTX 1050 works great!', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604803792347', N'Check my pictures for more info. Selling a good condition MSI gaming laptop. I don''t use it very much and it would do better in the hands of a gamer. Windows 10. 8GB Ram, Nvidia GTX 1050. 1TB storage. Runs great! Msg me for any other details. Thanks! Pick up only. $650.', N' London, ON N5V 4T8', N'1,400.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (14, 3, N'LONDON MATTRESSES - QUEEN SIZE 2” PILLOW TOP MATTRESS FOR $199', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604884518887', N'LONDON MATTRESSES SALE OF BRAND NEW BEDS AND MATTRESS, BEDS AND MATTRESSES QUEEN MATTRESSES BED ON SALE MATTRESS SALE MATTRESS AND PLATFORM BEDS & QUEEN MATTRESSES QUEEN MATTRESS LIQUIDATION SALE LONDON MATTRESSES - QUEEN SIZE 2” PILLOW TOP MATTRESS FOR $199 ONLY DELIVERED TO YOUR HOUSE ************************************************************************************* * PILLOW TOP MATTRESS AND BOX - QUEEN $259 (MATTRESS & BOX SPRING) - DOUBLE $239 (MATTRESS & BOX SPRING) - SINGLE $209 (MATTRESS & BOX SPRING) - KING $449 (MATTRESS & BOX SPRING) *** PILLOW TOP QUEEN MATTRESS & BOX FOR $259 *** *** FREE DELIVERY *** *** NO TAX *** ***PAYMENT CAN BE MADE WHEN YOUR MATTRESS ARRIVES AT YOUR DOOR AND YOU ARE 100% SATISFIED.*** ************************************************************************************* * [TOP SELLER] ORTHOPEDIC 2” PILLOW TOP MATTRESS AND BOX - QUEEN $299 (MATTRESS & BOX SPRING) - DOUBLE $279 (MATTRESS & BOX SPRING) - SINGLE $239 (MATTRESS & BOX SPRING) - KING $499 (MATTRESS & BOX SPRING) *** ORTHOPEDIC 2” PILLOW TOP QUEEN MATT & BOX FOR $299 *** *** FREE DELIVERY *** *** NO TAX *** ***PAYMENT CAN BE MADE WHEN YOUR MATTRESS ARRIVES AT YOUR DOOR AND YOU ARE 100% SATISFIED.*** ************************************************************************************* BEDS AND MATTRESSES - ALL MODELS COME WITH A MANUFACTURERS 10-YEAR NON-PRORATED WARRANTY. WE DO NOT HAVE HUGH SHOWROOMS, COSTLY ADVERTISING BUDGETS, AND HIGH SALARY SALES STAFF. YOU GET THE BEST QUALITY, CANADIAN MADE MATTRESS FOR THE LOWEST POSSIBLE PRICE. WE MANUFACTURE MORE THEN 20 TYPES INCLUDING MEMORY FOAM, ORGANIC LATEX, POCKET COIL, GEL MEMORY AND ALL ARE MADE IN CANADA ALL SIZES ARE AVAILABLE. Picture 9: Bed - Queen Size Dark Espresso finish Bonded Leather Bed - $199 (ONLY WITH THE PURCHASE OF MATTRESS AND BOX) , MATTRESS & BOX SOLD SEPARATELY Picture 10: Bed - Queen Size Grey Colour linen style fabric Bed - $249, MATTRESS & BOX SOLD SEPARATELY ************************************************************************************* MATTRESS PROTECTOR: PLEASE ASK FOR PROMOTIONAL HEALTH COMFORT WATERPROOF MATTRESS PROTECTOR FOR ONLY $39 ************************************************************************************* PLEASE CALL US @ 647-877-9962 IF YOU HAVE ANY QUESTIONS OR TO SCHEDULE YOUR DELIVERY.', N' London, ON N5V 4T8', N'199.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (15, 3, N'Antique living room set', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604884658920', N'Selling an antique 7 piece wood dinning room set with extendable table piece. Very durable table and chairs, that can seat up to 6 people. Some discolouration on the back of one chair and minor nicks on other parts of chairs Price is negotiable * pick up only', N' London, ON N5V 4T8', N'500.00 USD', N'987-654-3210', 1)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (16, 3, N'Lazyboy Power recliner couch', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604884782611', N'Just cleaned. Smoke free home. New set ordered. Material. Works perfectly. Make an offer', N' London, ON N5V 4T8', N'600.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (17, 3, N'Bedroom set', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604884284537', N'Solid oak well constructed (Mennonite built) king size sleigh bed, dresser w/mirror, chest dresser and 2 night tables mattress not included.', N' London, ON N5V 4T8', N'750.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (18, 3, N'IKEA leather sectional', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604884156792', N'IKEA leather couch. Small stain from metal on cushion which can easily be replaced through ikea.', N' London, ON N5V 4T8', N'1,400.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (22, 4, N'Dodge Caravan 2016', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604885710377', N'Caravan 2016 a vendre, seulement 76355 kilomètres, les freins ont était faites cette été, entretien régulier, antirouille top qualité fait a l''achat, les sièges se cachent sous le plancher, grande surface de charge, quelques détails mineurs d''esthétique, jamais accidenté, voir dans photos, raison de la vente séparation, viens avec les pneus d''hiver encore très bonnes. Belle opportunité pour la famille', N' London, ON N5V 4T8', N'1,400.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (19, 4, N'2015 Audi Q5 Progressive with S Line Package', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604885520662', N'Hard to to find progressive with S LINE Package on it. Spotless running like new. 4 Cylinder turbo engine. Very Good on Gas runs over 600Km with Tank. Accident Free. New Michelin top of the line tires Transmission Oil Changed. Engine Oil changed. Tune Up Done. deliveryOption, youtubeVideo', N' London, ON N5V 4T8', N'750.00 USD', N'987-654-3210', 1)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (20, 4, N'2013 Nissan Rogue SL AWD - Excellent Condition($9000)', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604885623243', N'2013 Nissan Rogue SL AWD 195000 km excellent condition very nice clean car No rust well kept drives amazing All power Ac blows ice cold power driver seats power mirrors/doors, Mileage 195000 Color GRAY', N' London, ON N5V 4T8', N'1,400.00 USD', N'987-654-3210', 0)
INSERT [dbo].[Classified] ([Id], [CategoryId], [Title], [PictureUrl], [Description], [Location], [Price], [PhoneNumber], [IsRecommended]) VALUES (21, 4, N'2008 Pontiac torrent gfx', N'https://aradalej-ad-pictures.s3.eu-central-1.amazonaws.com/1604885793786', N'Has power windows power lock power driver seat, power mirrors ,air,cruise,tilt sunroof, heated front seats and remote start. Mechanical condition is excellent ,front wheel hubs, front and rear brake pads and rotors, drive shaft and spark plugs all replaced in the last two years. Body condition is good, some wear and tear but no dents.Interior is very clean.', N' London, ON N5V 4T8', N'600.00 USD', N'987-654-3210', 0)
SET IDENTITY_INSERT [dbo].[Classified] OFF
GO
USE [master]
GO
ALTER DATABASE [ph19333445161_aradalejDB] SET  READ_WRITE 
GO
