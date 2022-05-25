SELECT Id,CONCAT(FirstName, ' ',LastName) AS ClientName, Email
FROM Clients
EXCEPT (SELECT c.Id,CONCAT(FirstName, ' ',LastName) AS ClientName, Email FROM Clients AS c JOIN ClientsCigars AS cc ON cc.ClientId = c.Id)
ORDER BY ClientName


SELECT TOP (5) c.CigarName, c.PriceForSingleCigar, c.ImageURL 
FROM Cigars AS c
JOIN Sizes AS s ON c.SizeId = s.Id
WHERE (s.Length >= 12 AND CHARINDEX('ci', c.CigarName) > 0)
OR	  (c.PriceForSingleCigar > 50 AND s.RingRange > 2.55)
ORDER BY  c.CigarName ASC,c.PriceForSingleCigar DESC

GO


	SELECT c.LastName, AVG(s.Length),CEILING(AVG(s.RingRange))  
	FROM ClientsCigars AS cc
	JOIN Clients AS c ON cc.ClientId = c.Id
	JOIN Cigars AS ci ON cc.CigarId = ci.Id
	JOIN Sizes AS s ON s.Id = ci.SizeId
	GROUP BY c.LastName
	ORDER BY AVG(s.Length) DESC 

	GO

CREATE OR ALTER FUNCTION udf_ClientWithCigars(@name VARCHAR(20))
RETURNS INT AS
BEGIN

DECLARE @COUNT INT 

SET @COUNT = (SELECT COUNT(cc.CigarId) 
FROM Clients AS c 
JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
WHERE c.FirstName = @name)


RETURN @COUNT
END

GO

CREATE OR ALTER PROC usp_SearchByTaste(@taste VARCHAR(20))
AS
BEGIN
		SELECT ci.CigarName, FORMATMESSAGE('$',CAST(ci.PriceForSingleCigar AS VARCHAR(20))), t.TasteType, b.BrandName, FORMATMESSAGE( CAST(s.[Length] AS VARCHAR(20)),'cm'), FORMATMESSAGE( CAST(s.RingRange AS VARCHAR(20)),'cm')  FROM Cigars AS ci
		JOIN Tastes AS t ON ci.TastId = t.Id
		JOIN Sizes AS s ON s.Id = ci.SizeId
		JOIN Brands AS b ON ci.BrandId = b.Id
		WHERE t.TasteType = @taste
		ORDER BY s.[Length], s.RingRange DESC
END

EXEC usp_SearchByTaste 'Woody'
