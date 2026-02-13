use [C:\USERS\XXXSE\DESKTOP\LAB12\LAB12\APP_DATA\DATABASE1.MDF]
CREATE TABLE PerfumeTypes (
    TypeID INT PRIMARY KEY IDENTITY,
    TypeName VARCHAR(50) NOT NULL
);

CREATE TABLE Perfume (
    PerfumeID INT PRIMARY KEY IDENTITY,
    PerfumeName VARCHAR(50) NOT NULL,
    TypeID INT,
    FOREIGN KEY (TypeID) REFERENCES PerfumeTypes(TypeID)
);

CREATE TABLE VolumeType (
    TypeID INT PRIMARY KEY IDENTITY,
    TypeName VARCHAR(50) NOT NULL,
    PerfumeID INT,
    FOREIGN KEY (PerfumeID) REFERENCES Perfume(PerfumeID)
);
use [C:\USERS\XXXSE\DESKTOP\LAB12\LAB12\APP_DATA\DATABASE1.MDF]
Delete from VolumeType;
Delete from Perfume;
Delete from PerfumeTypes;


INSERT INTO PerfumeTypes (TypeName)
VALUES ('Enchanting Elixir'), ('Midnight Whispers'), ('Radiant Bloom');


INSERT INTO Perfume (PerfumeName, TypeID)
VALUES ('Havana', 2),
       ('Maseratti rider', 1),
       ('Pudge', 3),
       ('Turkish delights', 1)


INSERT INTO VolumeType(TypeName, PerfumeID)
VALUES ('50 ml', 1),
       ('75 ml', 2),
       ('100 ml', 3),
       ('250 ml', 4)