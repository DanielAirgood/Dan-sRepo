

--Drop Tables if they exist
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_NAME = N'USER_REGISTRY')
            BEGIN
            DROP TABLE USER_REGISTRY
            END

--Create tables
CREATE TABLE USER_REGISTRY (
USER_ID INTEGER PRIMARY KEY IDENTITY(1,1),--consider using userName as prime key
USER_NAME VARCHAR(15) UNIQUE NOT NULL, --some way to identify why an insert fail
USER_PASSWORD VARCHAR(30) NOT NULL, --hide this information
USER_PRIVLAGE INT NOT NULL DEFAULT 1,
USER_ONLINE  BIT NOT NULL DEFAULT 0
);