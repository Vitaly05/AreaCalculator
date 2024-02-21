### Answer to the third question about SQL query:

```
SELECT P.name AS 'Product name', C.name AS 'Category name'
FROM Products AS P
LEFT JOIN Categories AS C
ON C.id IN (
    SELECT PC.category_id FROM ProductsCategories AS PC
    WHERE PC.product_id = P.id
);

```
