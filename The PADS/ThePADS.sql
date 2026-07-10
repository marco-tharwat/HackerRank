SET NOCOUNT ON;

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT Name + "(" + substring(Occupation,1,1) + ")" from OCCUPATIONS order by Name ASC;

select concat('There are a total of ', count(*), ' ', Lower(occupation), 's.') from Occupations group by Occupation order by count(*), occupation asc;


go
