SELECT cust.CustomerId, cust.RegistrationDateTime
FROM Customers cust
INNER JOIN
Purchaises p1
ON (cust.CustomerId = p1.CustomerId
AND p1.ProductName = 'milk' )
LEFT OUTER JOIN Purchaises p2
ON (p1.CustomerId = p2.CustomerId
AND p2.ProductName = 'sour cream' AND p2.PurchaiseDatetime >= DATEADD(MONTH, -1, GETDATE()))
WHERE p2.PurchaiseId IS NULL