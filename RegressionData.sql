USE [FlightDB];
GO

-- X1 = days to departure, X2 = seats available, Y = price.
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
