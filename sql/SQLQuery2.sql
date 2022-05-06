--Get all the product whoes list_price is more than the average price of product of brand 'Strider' or 'Trek'
select  product_name,product_id,list_price from [production].[products]
group by  product_name,product_id,list_price
having list_price>(

select avg(list_price) from [production].[products] prod
inner join [production].[brands] bnd on bnd.brand_id=prod.brand_id
where bnd.brand_name in('Strider', 'Trek')
)
order by list_price

select (first_name + ' '+ last_name) [full Name] from sales.staffs
union
select (first_name + ' '+ last_name) from sales.customers

SELECT product_id
FROM production.products
EXCEPT
SELECT product_id
FROM sales.order_items;