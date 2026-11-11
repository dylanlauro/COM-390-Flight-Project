USE [FlightDB];
GO

IF OBJECT_ID(N'dbo.JakeFlightRegressionData', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.JakeFlightRegressionData
    (
        FlightID int NOT NULL,
        ObservationID int NOT NULL,
        X1 float NOT NULL,
        X2 float NOT NULL,
        Y float NOT NULL,
        PRIMARY KEY (FlightID, ObservationID),
        FOREIGN KEY (FlightID) REFERENCES dbo.FLIGHT (FlightID)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.JakeFlightRegressionData WHERE FlightID = 1)
BEGIN
    INSERT INTO dbo.JakeFlightRegressionData (FlightID, ObservationID, X1, X2, Y)
    VALUES
        (1, 1, 67, 175, 418),
        (1, 2, 66, 166, 418),
        (1, 3, 65, 160, 428),
        (1, 4, 64, 164, 428),
        (1, 5, 63, 163, 429),
        (1, 6, 62, 163, 429),
        (1, 7, 61, 162, 428),
        (1, 8, 60, 161, 428),
        (1, 9, 59, 161, 438),
        (1, 10, 58, 161, 438),
        (1, 11, 57, 162, 438),
        (1, 12, 56, 161, 448),
        (1, 13, 55, 159, 438),
        (1, 14, 54, 159, 438),
        (1, 15, 53, 157, 438),
        (1, 16, 52, 153, 438),
        (1, 17, 51, 148, 438),
        (1, 18, 50, 148, 438),
        (1, 19, 49, 148, 438),
        (1, 20, 48, 147, 438),
        (1, 21, 47, 146, 438),
        (1, 22, 46, 145, 438),
        (1, 23, 45, 142, 448),
        (1, 24, 44, 140, 453),
        (1, 25, 43, 138, 453),
        (1, 26, 42, 140, 453),
        (1, 27, 41, 140, 453),
        (1, 28, 40, 141, 438),
        (1, 29, 39, 139, 438),
        (1, 30, 38, 140, 448),
        (1, 31, 37, 136, 438),
        (1, 32, 36, 132, 438),
        (1, 33, 35, 129, 438),
        (1, 34, 34, 128, 438),
        (1, 35, 33, 129, 448),
        (1, 36, 32, 129, 458),
        (1, 37, 31, 128, 468),
        (1, 38, 30, 127, 488),
        (1, 39, 29, 127, 488),
        (1, 40, 28, 127, 488),
        (1, 41, 27, 125, 488),
        (1, 42, 26, 122, 488),
        (1, 43, 25, 125, 488),
        (1, 44, 24, 124, 488),
        (1, 45, 23, 119, 488),
        (1, 46, 22, 118, 488),
        (1, 47, 21, 118, 488),
        (1, 48, 20, 115, 538),
        (1, 49, 19, 106, 538),
        (1, 50, 18, 108, 538),
        (1, 51, 17, 105, 538),
        (1, 52, 16, 101, 538),
        (1, 53, 15, 98, 629),
        (1, 54, 14, 101, 669),
        (1, 55, 13, 104, 669),
        (1, 56, 12, 97, 626),
        (1, 57, 11, 96, 626),
        (1, 58, 10, 95, 631),
        (1, 59, 9, 91, 631);
END;
GO

CREATE OR ALTER PROCEDURE dbo.GetJakeFlightRegressionData
AS
BEGIN
    SELECT X1, X2, Y
    FROM dbo.JakeFlightRegressionData
    WHERE FlightID = 1
    ORDER BY ObservationID;
END;
GO

IF OBJECT_ID(N'dbo.DylanFlightRegressionData', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DylanFlightRegressionData
    (
        FlightID int NOT NULL,
        ObservationID int NOT NULL,
        X1 float NOT NULL,
        X2 float NOT NULL,
        Y float NOT NULL,
        PRIMARY KEY (FlightID, ObservationID),
        FOREIGN KEY (FlightID) REFERENCES dbo.FLIGHT (FlightID)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.DylanFlightRegressionData WHERE FlightID = 2)
BEGIN
    INSERT INTO dbo.DylanFlightRegressionData (FlightID, ObservationID, X1, X2, Y)
    VALUES
        (2, 1, 67, 66, 194),
        (2, 2, 67, 66, 194),
        (2, 3, 67, 66, 194),
        (2, 4, 66, 66, 194),
        (2, 5, 65, 66, 204),
        (2, 6, 65, 66, 145),
        (2, 7, 64, 66, 145),
        (2, 8, 64, 64, 145),
        (2, 9, 64, 64, 145),
        (2, 10, 63, 64, 145),
        (2, 11, 63, 64, 145),
        (2, 12, 62, 64, 145),
        (2, 13, 62, 64, 145),
        (2, 14, 61, 64, 145),
        (2, 15, 61, 63, 145),
        (2, 16, 60, 63, 145),
        (2, 17, 60, 63, 145),
        (2, 18, 59, 63, 249),
        (2, 19, 59, 63, 145),
        (2, 20, 58, 63, 249),
        (2, 21, 58, 63, 145),
        (2, 22, 57, 63, 145),
        (2, 23, 57, 63, 145),
        (2, 24, 56, 63, 249),
        (2, 25, 56, 63, 145),
        (2, 26, 56, 63, 145),
        (2, 27, 55, 63, 249),
        (2, 28, 55, 62, 145),
        (2, 29, 54, 62, 249),
        (2, 30, 54, 62, 145),
        (2, 31, 53, 62, 145),
        (2, 32, 53, 59, 145),
        (2, 33, 52, 59, 145),
        (2, 34, 52, 59, 145),
        (2, 35, 51, 59, 249),
        (2, 36, 51, 59, 145),
        (2, 37, 50, 59, 249),
        (2, 38, 50, 59, 249),
        (2, 39, 49, 59, 249),
        (2, 40, 49, 59, 249),
        (2, 41, 48, 59, 249),
        (2, 42, 48, 55, 249),
        (2, 43, 47, 55, 249),
        (2, 44, 47, 55, 249),
        (2, 45, 46, 55, 249),
        (2, 46, 46, 55, 249),
        (2, 47, 45, 55, 249),
        (2, 48, 45, 55, 249),
        (2, 49, 44, 55, 249),
        (2, 50, 44, 55, 249),
        (2, 51, 43, 55, 249),
        (2, 52, 43, 55, 249),
        (2, 53, 42, 55, 249),
        (2, 54, 42, 55, 249),
        (2, 55, 41, 55, 249),
        (2, 56, 41, 54, 249),
        (2, 57, 40, 54, 249),
        (2, 58, 40, 54, 249),
        (2, 59, 39, 54, 249),
        (2, 60, 39, 54, 249),
        (2, 61, 38, 53, 249),
        (2, 62, 38, 53, 249),
        (2, 63, 37, 53, 249),
        (2, 64, 37, 53, 249),
        (2, 65, 37, 53, 249),
        (2, 66, 36, 53, 249),
        (2, 67, 36, 53, 249),
        (2, 68, 35, 53, 249),
        (2, 69, 35, 53, 249),
        (2, 70, 34, 53, 249),
        (2, 71, 34, 50, 249),
        (2, 72, 33, 50, 249),
        (2, 73, 33, 50, 249),
        (2, 74, 32, 49, 249);
END;
GO

CREATE OR ALTER PROCEDURE dbo.GetDylanFlightRegressionData
AS
BEGIN
    SELECT X1, X2, Y
    FROM dbo.DylanFlightRegressionData
    WHERE FlightID = 2
    ORDER BY ObservationID;
END;
GO
