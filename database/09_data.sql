USE Timeline;
GO



INSERT INTO Timeline.[Status] VALUES
	(0,'Does not exist','The thing doesn''t exist anymore. Maybe the URL changed'),
	(1,'Loading','We are working on getting it'),
	(2,'Complete','Whatever we were doing, we''re done with.'),
	(3,'Draft','Nobody can see what you''ve done except you'),
	(4,'Live','Out there for everyone to see'),
	(5,'No longer exists','We were able to load it at one point, but it is not there anymore'),
	(6,'Modified','Something has changed since the last time it was referenced');


INSERT INTO Timeline.MediaType VALUES
	(0,'Image','This can be in any standard format that is supported by web browsers'),
	(1,'Video','A moving picture, or a ''talky'' as the kids like to call it'),
	(2,'Document','Something you probably have to download to see, unless it''s a PDF or something that your browser can open'),
	(3,'HTML','A HTML document that is or was on some site that probably has an article or something'),
	(4,'Tweet','Something someone twote at one point'),
	(5,'YouTube','Something someone posted to YouTube at some point')


--INSERT INTO Timeline.TimeScale VALUES
--	(0,'Calendar','Generic date and time starting at the year 1900. Allows the time to be stored at the year, month, day, hour, minute, and second.)'),
--	(1,'Geological','This will only use years, but there are a lot of them.'),
--	(2,'0 Based','Time starts at zero and seconds, minutes, and hours are added from there.')


INSERT INTO Timeline.Unit VALUES
	(0,'Second','60 of these in a minute'),
	(1,'Minute','60 of these in an hour'),
	(2,'Hour','24 of these in a day'),
	(3,'Day','7 of these in a week'),
	(4,'Week','52 of these in a year'),
	(5,'Month','12 of these in a year'),
	(6,'Year','one rotation of the earth around the sun'),
	(7,'Decade','10 years'),
	(8,'Century','100 years'),
	(9,'Millenium','1000 years'),
	(10,'Millisecond','1/1000th of 1 second'),
	(11,'Microsecond','1 millionth of 1 second'),
	(12,'Nanosecond','1 billionth of 1 second');
