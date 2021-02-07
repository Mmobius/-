BEGIN TRANSACTION;

CREATE TABLE Pupil
(
PupilID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(25) NOT NULL,
LastName varchar(255) NOT NULL,
Gender Nvarchar(50),
Class Nvarchar(50)
);

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Giorgi','Davitashvili','Male','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Mari','Gogilashvil','Famle','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Qeti','Maisurazde','Male','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Lizi','demetrashvili','Male','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Nuca','Gegechkori','Famle','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Levani','Biganishvili','Famle','5B');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Avto','Axvlediani','Male','5A');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Anano','Maisuradze','Famle','5A');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Achiko','Burduli','Male','5A');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Gega','Gomelauri','Male','5A');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Nino','Gelovani','Famle','5A');

INSERT INTO Pupil(FirstName,LastName,Gender,Class)
VALUES('Giorgi','Gocirizde','Famle','5A');


CREATE TABLE Teacher
(
TeacherID int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
Gender Nvarchar(255),
Category Nvarchar(50)
);

INSERT INTO Teacher(FirstName,LastName,Gender,Category)
VALUES('Nino','Futkaradze','Famle','Mathematic');

INSERT INTO Teacher(FirstName,LastName,Gender,Category)
VALUES('Guja','Jgenti','Male','Physic');

INSERT INTO Teacher(FirstName,LastName,Gender,Category)
VALUES('Aleko','Axobadze','Male','History');

INSERT INTO Teacher(FirstName,LastName,Gender,Category)
VALUES('Nana','Wamalashvili','Famle','Geography');

INSERT INTO Teacher(FirstName,LastName,Gender,Category)
VALUES('Maia','Gegechkori','Famle','Chemistry');


CREATE TABLE CLASS_5A
(
CLASS_5A_id int IDENTITY(1,1) PRIMARY KEY,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
Gender Nvarchar(255)
);

INSERT INTO Class_5A(FirstName,LastName,Gender)
SELECT 
      FirstName,
      LastName,
      Gender
FROM Pupil
WHERE Class='5A';

SELECT * FROM Class_5A;

/*
CREATE TABLE Class_5B
(
Id integer PRIMARY KEY, 
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Gender Nvarchar(50),
Class Nvarchar(50)
);



















