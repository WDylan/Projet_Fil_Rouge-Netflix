--DROP TABLE CATEGORIE;
--DROP TABLE REALISATEUR;
--DROP TABLE ACTEUR;
--DROP TABLE FILM;
--DROP TABLE SERIE;

--CREATE TABLE  CATEGORIE 
--(   
---------------- Création table CATEGORIE   --------------
--ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
--NOMCATEGORIE VARCHAR(50) NOT NULL
-- );

 --INSERT INTO [dbo].[CATEGORIE] ([NOMCATEGORIE])
 --VALUES (N'Drame'),
 --(N'Comédie'),
 --(N'Gangster'),
 --(N'Science-fiction'),
 --(N'Aventure'),
 --(N'Film noir'),
 --(N'Thriller'),
 --(N'Policier'),
 --(N'Romance'),
 --(N'Fantasy'),
 --(N'Western'),
 --(N'Guerre'),
 --(N'Animation'),
 --(N'Arts martiaux'),
 --(N'Comédie dramatique'),
 --(N'Péplum'),
 --(N'Biopic'),
 --(N'Road movie'),
 --(N'Médical')

-- CREATE TABLE REALISATEUR
-- (
-- -------------- Création table REALISATEUR --------------
-- ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- NOMREAL VARCHAR (50) NOT NULL,
-- PRENOMREAL VARCHAR (50) NOT NULL,
--);

--INSERT INTO [dbo].[REALISATEUR] ([NOMREAL],[PRENOMREAL])
--VALUES (N'Simon',N'David'),
--(N'Gilligan',N'Vince'),
--(N'Chase',N'David'),
--(N'Linke',N'Christian'),
--(N'Benioff',N'David'),
--(N'Daniels',N'Greg'),
--(N'Ryan',N'Shawn'),
--(N'Georgsson',N'Henrik'),
--(N'Carter',N'Chris'),
--(N'Cassar',N'Jon'),
--(N'Davidson',N'Adam'),
--(N'Hill',N'Sam'),
--(N'Tarantino',N'Quentin'),
--(N'Nolan',N'Christopher'),
--(N'Kubrick',N'Stanley'),
--(N'Coppola',N'Francis Ford'),
--(N'Zemeckis',N'Robert'),
--(N'Jackson',N'Peter'),
--(N'Leone',N'Sergio'),
--(N'Gondry',N'Michel'),
--(N'Miyazaki',N'Hayao'),
--(N'Lynch',N'David'),
--(N'Wachowski',N'Lana'),
--(N'Lumet',N'Sidney'),
--(N'Scorsese',N'Martin'),
--(N'Penn',N'Sean'),
--(N'Spielberg',N'Steven'),
--(N'De Palma',N'Brian'),
--(N'Kitano',N'Takeshi')


--CREATE TABLE ACTEUR
--(
-- -------------- Création table ACTEUR --------------
-- ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- NOMACTEUR VARCHAR (50) NOT NULL,
-- PRENOMACTEUR VARCHAR (50) NOT NULL,
--);

 --INSERT INTO [dbo].[ACTEUR] ([NOMACTEUR], [PRENOMACTEUR])
 --VALUES (N'Helin',N'Sofia'),
-- (N'Hall',N'Michael C.'),
-- (N'Duchovny',N'David'),
-- (N'McLachlan',N'Kyle'),
-- (N'Odenkirk',N'Bob'),
-- (N'Cranston',N'Bryan'),
-- (N'Elba',N'Idriss'),
-- (N'Carell',N'Steve'),
-- (N'Wiles',N'Jason'),
-- (N'Edwards',N'Anthony'),
-- (N'Marciano',N'Avy'),
-- (N'Clarke',N'Emilia'),
-- (N'Chiklis',N'Michael'),
-- (N'Gandolfini',N'James'),
-- (N'Lewis',N'Damian'),
-- (N'Danes',N'Claire'),
-- (N'Seinfeld',N'Hailee'),
-- (N'Spacey',N'Kevin'),
-- (N'Norton',N'Edward'),
--(N'Travolta',N'John'),
--(N'Jackson',N'Samuel Lawrence'),
--(N'McConaughey',N'Matthew'),
--(N'Ford',N'Harrison'),
--(N'Brando',N'Marlon'),
--(N'Hanks',N'Tom'),
--(N'Mortensen',N'Vigo'),
--(N'Wood',N'Elijah'),
--(N'Eastwood',N'Clint'),
--(N'Bale',N'Christian'),
--(N'Di Caprio',N'Leonardo'),
--(N'McKellen',N'Ian'),
--(N'Astin',N'Sean'),
--(N'Duvall',N'Robert'),
--(N'Sheen',N'Martin'),
--(N'Magee',N'Patrick'),
--(N'Carrey',N'Jim'),
--(N'Winslet',N'Kate'),
--(N'Watts',N'Naomi'),
--(N'Reeves',N'Keanu'),
--(N'Fonda',N'Henry'),
--(N'Fox',N'Michael J.'),
--(N'DeNiro',N'Robert'),
--(N'Pacino',N'Al'),
--(N'Crouse',N'Lindsay'),
--(N'Adams',N'Amy')




--CREATE TABLE FILM
--(
-- -------------- Création table FILM --------------
-- ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- TITRE VARCHAR(50) NOT NULL,
-- DUREE INT NOT NULL,
-- DATESORTIE DATETIME NOT NULL,
-- SYNOPSYS VARCHAR(250) NOT NULL,
-- GENRE VARCHAR(50) NOT NULL,
-- ACTEUR_NOM VARCHAR(50) NOT NULL,
-- REALISATEUR_NOM VARCHAR(50) NOT NULL,
-- RECOMMANDATION INT NOT NULL,
-- IMAGES VARCHAR(255) NULL,
-- VIDEOS VARCHAR(255) NULL
--);


--INSERT INTO [dbo].[FILM] ([TITRE],[DUREE],[DATESORTIE],[SYNOPSYS],[GENRE],[ACTEUR_NOM],[REALISATEUR_NOM],[RECOMMANDATION], [IMAGES], [VIDEOS])
--VALUES (N'Fight Club', 139, 1999-11-10, N'Insomniaque, désillusionné par sa vie personnelle et professionnelle, un jeune cadre expert en assurances, mène une vie...', N'Drame', N'Brad Pitt, Edward Norton', N'David Fincher', 95, N'img/Fight_Club.jpg', null),
--(N'Pulp Fiction', 139, 1999-11-10, N'Une odyssée sanglante, burlesque et cocasse de petits malfrats dans la jungle de Hollywood à travers trois histoires qui se recoupent.', N'Comédie', N'John Travolta, Samuel L. Jackson', N'Quentin Tarantino', 94, N'img/Pulp_Fiction.jpg', null),
--(N'Interstellar', 169, 2014-11-05, N'Alors que la vie sur Terre touche à sa fin, un groupe d’explorateurs s’attelle à la mission la plus importante de l’histoire de l’humanité : franchir les limites de notre galaxie...', N'Science-fiction', N'Matthew McConaughey', N'Christopher Nolan', 93, N'img/Interstellar.jpg', null),
--(N'Le Parrain', 175, 1972-18-18, N'New York, 1945. Don Vito Corleone règne sur les familles les plus puissantes de la mafia italo-américaine.', N'Drame', N'Marlon Brando', N'Francis Ford Coppola', 95, N'img/Le_Parrain.jpg', null),
--(N'Forrest Gump', 142, 1994-10-05, N'A Savannah, en Géorgie (USA), Forrest Gump, assis sur un banc public, livre à qui veut écouter le récit étrange de sa vie mouvementée.', N'Drame', N'Tom Hanks', N'Robert Zemeckis', 93, N'img/Forrest_Gump.jpg', null),
--(N'Le Seigneur des Anneaux 3', 201, 2003-12-17, N'La bataille pour la Terre du Milieu a commencé. Frodon et Sam, guidés par Gollum, poursuivent leur mission à travers les terres du Mordor pour détruire un certain Anneau', N'Fantasy', N'Vigo Mortensen', N'Peter Jackson', 89, N'img/Seigneur_Anneaux 3.jpg', null),
--(N'Le bon, la Brute et le Truand', 179, 1968-03-08, N'Un chasseur de primes rejoint deux hommes dans une alliance précaire. Leur but ? Trouver un coffre rempli de pièces en or dans un cimetière isolé.', N'Western', N'Clint Eastwood', N'Sergio Leone', 100, N'img/LeBon_laBrute.jpg', null),
--(N'The Dark Knight', 152, 2008-08-13, N'Batman vise à éradiquer le crime organisé qui pullule dans la ville.', N'Western', N'Christian Bale', N'Christopher Nolan', 86, N'img/The_Dark_Knight.jpg', null),
--(N'Inception', 148, 2010-07-21, N' Dom Cobb est un voleur expérimenté. Sa spécialité : voler les secrets les plus intimes', N'Science-fiction', N'Leonardo DiCaprio', N'Christopher Nolan', 83, N'img/Inception.jpg', null),
--(N'Le Seigneur des Anneaux 1', 178, 2001-12-19, N'Le jeune hobbit Frodon Sacquet hérite d''un anneau. Il s''agit de l''Anneau Unique, instrument de pouvoir absolu...', N'Fantasy', N'Elijah Wood', N'Peter Jackson', 82, N'img/Seigneur_anneaux 1.jpg', null),
--(N'Orange Mécanique', 136, 1972-04-01, N'Dans une Angleterre futuriste et inhumaine, un groupe d''adolescents se déchaînent chaque nuit, frappant et violant d''innocentes victimes.', N'Science-fiction', N'Patrick Magee', N'Stanley Kubrick', 88, N'img/Orange_Mecanique.jpg', null),
--(N'Eternal Sunshine of The Spotless Mind', 108, 2004-10-06, N'L''idylle entre Clementine et Joel a pris fin, en raison de leurs caractères trop différents et de la routine. Pour apaiser ses souffrances, Clementine a recours à une clinique d''effacement de la mémoire...', N'Romance', N'Jim Carrey', N'Michel Gondry', 98, N'img/Eternal.jpg', null),
--(N'Mulholland Dr.', 147, 2001-11-21, N'A Hollywood, durant la nuit, Rita, une jeune femme, devient amnésique suite à un accident de voiture sur la route de Mulholland Drive. Elle fait la rencontre de Betty...', N'Thriller', N'Naomi Watts', N'David Lynch', 100, N'img/Mulholland_Drive.jpg', null),
--(N'Matrix', 136, 1999-06-23, N'Neo, un des pirates les plus recherchés du cyber-espace, reçoit de mystérieux messages cryptés d''un certain Morpheus. Celui-ci l''exhorte à aller au-delà des apparences...', N'Science-fiction', N'Keanu Reeves', N'Lana Wachowski', 90, N'img/Matrix.jpg', null),
--(N'Douze Hommes en colère', 96, 1957-10-04, N'Douze jurés doivent décider du sort d''un jeune immigré, accusé de parricide. Tous le croient coupable sauf un, qui a de sérieux doutes sur l''enquête.', N'Drame', N'Henry Fonda', N'Sidney Lumet', 92, N'img/12Hommes.jpg', null),
--(N'Retour vers le futur', 116, 1985-10-30, N'En 1985, Marty, un adolescent comme les autres, mène une existence qu''il juge morne et ennuyeuse. Son ami Doc, un savant fou qui prétend avoir inventé une machine à explorer le temps. Un jour, Doc invite Marty à l''essayer.', N'Science-fiction', N'Michael J. Fox', N'Robert Zemeckis', 95, N'img/Retour_futur.jpg', null),
--(N'Seven', 127, 1996-01-31, N' Sur le point de prendre sa retraite, l''inspecteur William Somerset fait équipe avec le jeune David Mills. Tous deux mènent l''enquête sur une série de meurtres...', N'Thriller', N'Brad Pitt, Kevin Spacey', N'David Fincher', 87, N'img/Seven.jpg', null),
--(N'Django Unchained', 175, 2013-01-16, N' Un esclave noir est affranchi par un chasseur de primes. Le moment est venu de sauver son épouse d''un riche propriétaire de plantation du Mississipi.', N'Western', N'Leonardo DiCaprio, Jamie Foxx', N'Quentin Tarantino', 80, N'img/Django.jpg', null)







--CREATE TABLE SERIE
--(
-- -------------- Création table SERIE --------------
-- ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
-- TITRE VARCHAR(50) NOT NULL,
-- NBEPISODES INT NOT NULL,
-- DATESORTIE DATETIME NOT NULL,
-- SYNOPSYS VARCHAR(250) NOT NULL,
-- GENRE VARCHAR(50) NOT NULL,
-- ACTEUR_NOM VARCHAR(50) NOT NULL,
-- REALISATEUR_NOM VARCHAR(50) NOT NULL,
-- RECOMMANDATION INT NOT NULL,
-- IMAGES VARCHAR(255) NULL,
-- VIDEOS VARCHAR(255) NULL,
--);

--INSERT INTO [dbo].[SERIE] ([TITRE], [NBEPISODES], [DATESORTIE], [SYNOPSYS], [GENRE], [ACTEUR_NOM], [REALISATEUR_NOM], [RECOMMANDATION], [IMAGES], [VIDEOS])
--VALUES (N'The X-Files', 218, 1993-09-10, N'Les agents spéciaux Fox Mulder et Dana Scully travaillent sur des dossiers non classés, des affaires non résolues impliquant des phénomènes paranormaux.', N'Science-fiction', N'David Duchovny, Gillian Anderson', N'Chris Carter', 100, N'img/X_Files.jpg', null),
--(N'Breaking Bad', 62, 2008-01-20, N'Walter White, 50 ans, est professeur de chimie. Lorsqu''il apprend qu''il est atteint d''un incurable cancer des poumons, il ne voit plus qu''une solution : mettre ses connaissances en chimie à profit pour fabriquer et vendre de la méthamphétamine.', N'Thriller', N'Bryan Cranston', N'Vince Gilligan', 98, N'img/Breaking_Bad.jpg', null),
--(N'Better Call Saul', 63, 2015-02-08, N'Six ans avant de croiser le chemin de Walter White, Saul Goodman est un avocat qui peine à joindre les deux bouts. Pour boucler ses fins de mois, il n''aura d''autres choix que se livrer à quelques petites escroqueries.', N'Drame', N'Bob Odenkirk', N'Vince Gilligan', 100, N'img/Better_Call_Saul.jpg', null),
--(N'The Bridge, Bron, Broen', 38, 2011-09-21, N'Une femme est retrouvée coupée en deux sur le pont de l''Øresund, à la frontière entre le Danemark et la Suède, et force les deux pays à collaborer. La policière Saga Noren s''occupe de cette affaire.', N'Policier', N'Sofia Helin', N'Henrik Georgsson', 100, N'img/The_Bridge_Bron.jpg', null),
--(N'The Shield', 88, 2003-11-23, N'Vic Mackey dirige un groupe de flics très efficace dans la lutte contre le crime. Son abnégation l''oblige souvent à franchir la ligne de la légalité.', N'Policier', N'Michael Chiklis', N'Shawn Ryan', 95, N'img/The_Shield.jpg', null),
--(N'The Office (US)', 201, 2005-03-24, N'Le quotidien des employés de bureau d''une société de vente de papier en Pennsylvanie, Dunder Mifflin, et de leur fantasque responsable, Michael Scott.', N'Comédie', N'Steve Carell', N'Greg Daniels', 90, N'img/The_Office.jpg', null),
--(N'Game of Thrones', 73, 20111-06-05, N'Sur le continent de Westeros en proie au retour de l''Hiver, les grands Seigneurs et la fille du roi déchu se disputent le Trône de Fer.', N'Fantasy', N'Emilia Clarke', N'David Benioff', 50, N'img/Game_of_Thrones.jpg', null),
--(N'Arcane', 9, 2021-11-07, N'Dans un Piltover utopique, et dans les souterrains opprimés de Zaun, l''histoire d''Arcane revient sur les origines de deux champions emblématiques du jeu… et sur la force qui va les séparer.', N'Animation', N'Hailee Seinfled', N'Studio Fortiche', 96, N'img/Arcane.jpg', null),
--(N'Twin Peaks', 48, 1991-04-15, N'Un meurtre a été commis à Twin Peaks, une petite bourgade en apparence tranquille. La jeune Laura Palmer est retrouvée morte nue au bord d''un lac.', N'Thriller', N'Kyle MacLachlan', N'David Lynch', 100, N'img/Twin_Peaks.jpg', null),
--(N'The Sopranos', 86, 1999-09-05, N'Après une crise de panique, Tony Soprano, leader de la mafia du New Jersey, se retrouve forcé de consulter une psychiatre.', N'Drame', N'James Gandolfini', N'David Chase', 100, N'img/The_Sopranos.jpg', null),
--(N'The Wire', 60, 2004-01-08, N'À Baltimore, le trafic de drogue est omniprésent. Une unité spéciale est mise en place pour démanteler le réseau de deux caïds de l''ouest de la ville.', N'Policier', N'Idriss Elba', N'David Simon', 80, N'img/The_Wire.jpg', null),
--(N'Dexter', 96, 2007-05-17, N'Spécialiste en hématologie le jour, Dexter se transforme la nuit venue en un tueur sanguinaire, froid, méticuleux et imperturbable.', N'Thriller', N'Michael C. Hall, Jennifer Carpenter', N'', 99, N'img/Dexter.jpg', null),
--(N'Urgences', 331, 1994-09-19, N'A Chicago, médecins, infirmières, standardistes et compagnie s''activent pour faire vivre les urgences du Cook County General Hospital.', N'Médical', N'Anthony Edwards, George Clooney', N'Michael Crichton', 80, N'img/Urgences.jpg', null),
--(N'24', 331, 2001-11-06, N'Agent fédéral et responsable de la Cellule Anti-Terroriste de Los Angeles, Jack Bauer a 24 heures pour mener à bien sa mission et empêcher que des terroristes ne mettent leur plan à exécution...', N'Thriller', N'Kiefer Sutherland, Elisha Cuthbert', N'Jon Cassar', 99, N'img/24.jpg', null)


