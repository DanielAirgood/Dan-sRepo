INSERT INTO dbo.USER_REGISTRY(USER_NAME,USER_PASSWORD,USER_PRIVLAGE,USER_ONLINE)
VALUES('testUser','123test','0','0');

UPDATE dbo.USER_REGISTRY SET USER_SESSION = NULL WHERE USER_ID = 1;--upload user session

SELECT USER_ID FROM dbo.USER_REGISTRY WHERE USER_NAME = 'testUser';--return userID