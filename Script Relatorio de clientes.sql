﻿SELECT 
    CASE
    WHEN CATEGORIA = 1 THEN 'CLIENTE COMUM'
    WHEN CATEGORIA = 2 THEN 'CLIENTE PREFERENCIAL'
    WHEN CATEGORIA = 3 THEN 'CLIENTE EMPRESA'
    WHEN CATEGORIA = 4 THEN 'CLIENTE VIP'
END AS 'NOMECATEGORIA',
COUNT(*) AS 'QUANTIDADECLIENTES'
FROM CLIENTE
WHERE ATIVO = 1
GROUP BY CATEGORIA
ORDER BY QUANTIDADECLIENTES DESC