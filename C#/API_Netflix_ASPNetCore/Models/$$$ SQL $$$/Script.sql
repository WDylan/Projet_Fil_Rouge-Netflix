--DROP TABLE FILMS;
--DROP TABLE SERIES;
DROP TABLE UTILISATEURS;

CREATE TABLE UTILISATEURS
(
 -------------- Création table UTILISATEURS --------------
 IDUTILISATEUR INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 NOM VARCHAR(50) NOT NULL,
 PRENOM varchar(50) NOT NULL,
 EMAIL VARCHAR(100) NOT NULL,
 MOTDEPASSE VARCHAR(100) NOT NULL,
 STATUT VARCHAR(50) NOT NULL
);


INSERT INTO [dbo].[UTILISATEURS] ([NOM],[PRENOM],[EMAIL],[MOTDEPASSE],[STATUT])
VALUES (N'White', N'Walter', N'walter.white@breakingbad.com', N'Skyler99', N'USER'),
(N'Mulder', N'Fox', N'fox.mulder@fbi.com', N'TrustNo1', N'USER'),
(N'Castle', N'Richard', N'richard.castle@gmail.com', N'NikkiHeat', N'USER'),
(N'Windsor', N'Charles', N'charles.windsor@hotmail.co.uk', N'AtLeast', N'USER'),
(N'Damiens', N'Francois', N'francois.damiens@embrouille.be', N'ForSure', N'USER'),
(N'Papanikolaou', N'Thomas', N'thomas.papanikolaou@papanikolaou.com', N'Hallelujah', N'ADMIN'),
(N'Wikaryjak', N'Dylan', N'wikaryjak.dylan@gmail.com', N'OuiLaFlemme', N'ADMIN')


--CREATE TABLE FILMS
--(
-- -------------- Création table FILM --------------
-- IDFILM INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- TITRE VARCHAR(50) NOT NULL,
-- GENRE VARCHAR(50) NOT NULL,
-- DUREE INT NOT NULL,
-- DATESORTIE DATETIME NOT NULL,
-- SYNOPSIS VARCHAR(250) NOT NULL,
-- ACTEUR_NOM VARCHAR(50) NOT NULL,
-- REALISATEUR_NOM VARCHAR(50) NOT NULL,
-- RECOMMANDATION INT NOT NULL,
-- IMAGE VARCHAR(255) NULL,
-- VIDEO VARCHAR(255) NULL
--);


--INSERT INTO [dbo].[FILMS] ([TITRE],[GENRE],[DUREE],[DATESORTIE],[SYNOPSIS],[ACTEUR_NOM],[REALISATEUR_NOM],[RECOMMANDATION], [IMAGE], [VIDEO])
--VALUES (N'Fight Club','test',139, 1999-11-10, N'Insomniaque, désillusionné par sa vie personnelle et professionnelle, un jeune cadre expert en assurances, mène une vie...', N'Brad Pitt, Edward Norton', N'David Fincher', 95, N'img/Fight_Club.jpg',''),
--(N'Pulp Fiction','test',139, 1999-11-10, N'Une odyssée sanglante, burlesque et cocasse de petits malfrats dans la jungle de Hollywood à travers trois histoires qui se recoupent.', N'John Travolta, Samuel L. Jackson', N'Quentin Tarantino', 94, N'img/Pulp_Fiction.jpg', ''),
--(N'Interstellar', 'test',169, 2014-11-05, N'Alors que la vie sur Terre touche à sa fin, un groupe d’explorateurs s’attelle à la mission la plus importante de l’histoire de l’humanité : franchir les limites de notre galaxie...',N'Matthew McConaughey', N'Christopher Nolan', 93, N'img/Interstellar.jpg', ''),
--(N'Le Parrain','test',175, 1972-18-18, N'New York, 1945. Don Vito Corleone règne sur les familles les plus puissantes de la mafia italo-américaine.', N'Marlon Brando', N'Francis Ford Coppola', 95, N'img/Le_Parrain.jpg', ''),
--(N'Forrest Gump','test',142, 1994-10-05, N'A Savannah, en Géorgie (USA), Forrest Gump, assis sur un banc public, livre à qui veut écouter le récit étrange de sa vie mouvementée.', N'Tom Hanks', N'Robert Zemeckis', 93, N'img/Forrest_Gump.jpg', ''),
--(N'Le Seigneur des Anneaux 3','test',201, 2003-12-17, N'La bataille pour la Terre du Milieu a commencé. Frodon et Sam, guidés par Gollum, poursuivent leur mission à travers les terres du Mordor pour détruire un certain Anneau', N'Vigo Mortensen', N'Peter Jackson', 89, N'img/Seigneur_Anneaux 3.jpg', ''),
--(N'Le bon, la Brute et le Truand','test',179, 1968-03-08, N'Un chasseur de primes rejoint deux hommes dans une alliance précaire. Leur but ? Trouver un coffre rempli de pièces en or dans un cimetière isolé.', N'Clint Eastwood', N'Sergio Leone', 100, N'img/LeBon_laBrute.jpg', ''),
--(N'The Dark Knight','test',152, 2008-08-13, N'Batman vise à éradiquer le crime organisé qui pullule dans la ville.', N'Christian Bale', N'Christopher Nolan', 86, N'img/The_Dark_Knight.jpg', ''),
--(N'Inception','test',148, 2010-07-21, N' Dom Cobb est un voleur expérimenté. Sa spécialité : voler les secrets les plus intimes', N'Leonardo DiCaprio', N'Christopher Nolan', 83, N'img/Inception.jpg', ''),
--(N'Le Seigneur des Anneaux 1','test', 178, 2001-12-19, N'Le jeune hobbit Frodon Sacquet hérite d''un anneau. Il s''agit de l''Anneau Unique, instrument de pouvoir absolu...',N'Elijah Wood', N'Peter Jackson', 82, N'img/Seigneur_anneaux 1.jpg', ''),
--(N'Orange Mécanique','test', 136, 1972-04-01, N'Dans une Angleterre futuriste et inhumaine, un groupe d''adolescents se déchaînent chaque nuit, frappant et violant d''innocentes victimes.', N'Patrick Magee', N'Stanley Kubrick', 88, N'img/Orange_Mecanique.jpg', ''),
--(N'Eternal Sunshine of The Spotless Mind','test', 108, 2004-10-06, N'L''idylle entre Clementine et Joel a pris fin, en raison de leurs caractères trop différents et de la routine. Pour apaiser ses souffrances, Clementine a recours à une clinique d''effacement de la mémoire...',N'Jim Carrey', N'Michel Gondry', 98, N'img/Eternal.jpg', ''),
--(N'Mulholland Dr.','test', 147, 2001-11-21, N'A Hollywood, durant la nuit, Rita, une jeune femme, devient amnésique suite à un accident de voiture sur la route de Mulholland Drive. Elle fait la rencontre de Betty...', N'Naomi Watts', N'David Lynch', 100, N'img/Mulholland_Drive.jpg', ''),
--(N'Matrix','test', 136, 1999-06-23, N'Neo, un des pirates les plus recherchés du cyber-espace, reçoit de mystérieux messages cryptés d''un certain Morpheus. Celui-ci l''exhorte à aller au-delà des apparences...',N'Keanu Reeves', N'Lana Wachowski', 90, N'img/Matrix.jpg', ''),
--(N'Douze Hommes en colère','test', 96, 1957-10-04, N'Douze jurés doivent décider du sort d''un jeune immigré, accusé de parricide. Tous le croient coupable sauf un, qui a de sérieux doutes sur l''enquête.',N'Henry Fonda', N'Sidney Lumet', 92, N'img/12Hommes.jpg', ''),
--(N'Retour vers le futur','test', 116, 1985-10-30, N'En 1985, Marty, un adolescent comme les autres, mène une existence qu''il juge morne et ennuyeuse. Son ami Doc, un savant fou qui prétend avoir inventé une machine à explorer le temps. Un jour, Doc invite Marty à l''essayer.',N'Michael J. Fox', N'Robert Zemeckis', 95, N'img/Retour_futur.jpg', ''),
--(N'Seven','test', 127, 1996-01-31, N' Sur le point de prendre sa retraite, l''inspecteur William Somerset fait équipe avec le jeune David Mills. Tous deux mènent l''enquête sur une série de meurtres...',N'Brad Pitt, Kevin Spacey', N'David Fincher', 87, N'img/Seven.jpg', ''),
--(N'Django Unchained','test', 175, 2013-01-16, N' Un esclave noir est affranchi par un chasseur de primes. Le moment est venu de sauver son épouse d''un riche propriétaire de plantation du Mississipi.',N'Leonardo DiCaprio, Jamie Foxx', N'Quentin Tarantino', 80, N'img/Django.jpg', '')







--CREATE TABLE SERIES
--(
-- -------------- Création table SERIES --------------
-- IDSERIE INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- TITRE VARCHAR(50) NOT NULL,
-- GENRE VARCHAR(50) NOT NULL,
-- NBEPISODES INT NOT NULL,
-- DATESORTIE DATETIME NOT NULL,
-- SYNOPSIS VARCHAR(250) NOT NULL,
-- ACTEUR_NOM VARCHAR(50) NOT NULL,
-- REALISATEUR_NOM VARCHAR(50) NOT NULL,
-- RECOMMANDATION INT NOT NULL,
-- IMAGE VARCHAR(255) NULL,
-- VIDEO VARCHAR(255) NULL,
--);

--INSERT INTO [dbo].[SERIES] ([TITRE],[GENRE], [NBEPISODES], [DATESORTIE], [SYNOPSIS], [ACTEUR_NOM], [REALISATEUR_NOM], [RECOMMANDATION], [IMAGE], [VIDEO])
--VALUES (N'The X-Files','test', 218, 1993-09-10, N'Les agents spéciaux Fox Mulder et Dana Scully travaillent sur des dossiers non classés, des affaires non résolues impliquant des phénomènes paranormaux.', N'David Duchovny, Gillian Anderson', N'Chris Carter', 100, N'img/X_Files.jpg',''),
--(N'Breaking Bad','test', 62, 2008-01-20, N'Walter White, 50 ans, est professeur de chimie. Lorsqu''il apprend qu''il est atteint d''un incurable cancer des poumons, il ne voit plus qu''une solution : mettre ses connaissances en chimie à profit pour fabriquer et vendre de la méthamphétamine.', N'Bryan Cranston', N'Vince Gilligan', 98, N'img/Breaking_Bad.jpg', ''),
--(N'Better Call Saul','test', 63, 2015-02-08, N'Six ans avant de croiser le chemin de Walter White, Saul Goodman est un avocat qui peine à joindre les deux bouts. Pour boucler ses fins de mois, il n''aura d''autres choix que se livrer à quelques petites escroqueries.', N'Bob Odenkirk', N'Vince Gilligan', 100, N'img/Better_Call_Saul.jpg', ''),
--(N'The Bridge, Bron, Broen','test', 38, 2011-09-21, N'Une femme est retrouvée coupée en deux sur le pont de l''Øresund, à la frontière entre le Danemark et la Suède, et force les deux pays à collaborer. La policière Saga Noren s''occupe de cette affaire.', N'Sofia Helin', N'Henrik Georgsson', 100, N'img/The_Bridge_Bron.jpg', ''),
--(N'The Shield','test', 88, 2003-11-23, N'Vic Mackey dirige un groupe de flics très efficace dans la lutte contre le crime. Son abnégation l''oblige souvent à franchir la ligne de la légalité.', N'Michael Chiklis', N'Shawn Ryan', 95, N'img/The_Shield.jpg', ''),
--(N'The Office (US)','test', 201, 2005-03-24, N'Le quotidien des employés de bureau d''une société de vente de papier en Pennsylvanie, Dunder Mifflin, et de leur fantasque responsable, Michael Scott.', N'Steve Carell', N'Greg Daniels', 90, N'img/The_Office.jpg', ''),
--(N'Game of Thrones','test', 73, 20111-06-05, N'Sur le continent de Westeros en proie au retour de l''Hiver, les grands Seigneurs et la fille du roi déchu se disputent le Trône de Fer.', N'Emilia Clarke', N'David Benioff', 50, N'img/Game_of_Thrones.jpg', ''),
--(N'Arcane','test', 9, 2021-11-07, N'Dans un Piltover utopique, et dans les souterrains opprimés de Zaun, l''histoire d''Arcane revient sur les origines de deux champions emblématiques du jeu… et sur la force qui va les séparer.', N'Hailee Seinfled', N'Studio Fortiche', 96, N'img/Arcane.jpg', ''),
--(N'Twin Peaks','test', 48, 1991-04-15, N'Un meurtre a été commis à Twin Peaks, une petite bourgade en apparence tranquille. La jeune Laura Palmer est retrouvée morte nue au bord d''un lac.', N'Kyle MacLachlan', N'David Lynch', 100, N'img/Twin_Peaks.jpg', ''),
--(N'The Sopranos','test', 86, 1999-09-05, N'Après une crise de panique, Tony Soprano, leader de la mafia du New Jersey, se retrouve forcé de consulter une psychiatre.', N'James Gandolfini', N'David Chase', 100, N'img/The_Sopranos.jpg', ''),
--(N'The Wire','test', 60, 2004-01-08, N'À Baltimore, le trafic de drogue est omniprésent. Une unité spéciale est mise en place pour démanteler le réseau de deux caïds de l''ouest de la ville.', N'Idriss Elba', N'David Simon', 80, N'img/The_Wire.jpg', ''),
--(N'Dexter','test', 96, 2007-05-17, N'Spécialiste en hématologie le jour, Dexter se transforme la nuit venue en un tueur sanguinaire, froid, méticuleux et imperturbable.', N'Michael C. Hall, Jennifer Carpenter', N'', 99, N'img/Dexter.jpg', ''),
--(N'Urgences','test', 331, 1994-09-19, N'A Chicago, médecins, infirmières, standardistes et compagnie s''activent pour faire vivre les urgences du Cook County General Hospital.', N'Anthony Edwards, George Clooney', N'Michael Crichton', 80, N'img/Urgences.jpg', ''),
--(N'24','test', 331, 2001-11-06, N'Agent fédéral et responsable de la Cellule Anti-Terroriste de Los Angeles, Jack Bauer a 24 heures pour mener à bien sa mission et empêcher que des terroristes ne mettent leur plan à exécution...', N'Kiefer Sutherland, Elisha Cuthbert', N'Jon Cassar', 99, N'img/24.jpg', '')


