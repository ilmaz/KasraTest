DROP TABLE IF EXISTS #temp2
SELECT RANK() OVER (ORDER BY Score DESC) AS Ranking,
           Student_ID,
           Score INTO #temp2
    FROM dbo.std_Score WITH (NOLOCK)
SELECT Student_ID,
       Score,
     Ranking
FROM #temp2 WITH (NOLOCK)
WHERE Ranking > 1
      AND Ranking <= 6;
	  
	  