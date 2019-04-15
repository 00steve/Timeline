USE Timeline;
GO


INSERT INTO Timeline.[User] VALUES('Testie');




INSERT INTO Timeline.Timeline VALUES(1,'Generic Political Shit','All of the shit that you know happens and is exectly what you would expect',3,6,GETDATE(),GETDATE());


--id 1
INSERT INTO Timeline.Event VALUES(1,'He said it','I have no information about this shit, I is ignant.',CAST('10/2/2018' AS DATETIME),GETDATE(),GETDATE(),NULL);

--id 2, cause by 1
INSERT INTO Timeline.Event VALUES(1,'The contradiction','He said that shit before, but now it''s different.',CAST('11/16/2018' AS DATETIME),GETDATE(),GETDATE(),1);


INSERT INTO Timeline.Event VALUES(1,'He Appologised','Not really, the douche don''t do that shit',CAST('2/9/2019' AS DATETIME),GETDATE(),GETDATE(),2);