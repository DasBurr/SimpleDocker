CREATE TABLE public."Movies"
(
    
	tconst character(100),	titleType character(1000),	primaryTitle character(1000),	originalTitle character(1000),	isAdult boolean,	startYear INTEGER,	endYear INTEGER,	runtimeMinutes INTEGER,	genres character(1000)
);

ALTER TABLE public."Movies"
    OWNER to postgres;
	
copy public."Movies" from '/data.tsv' null as '\N'