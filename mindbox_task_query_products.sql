select p.Name, c.Name from Products p
left join ProductCategories pc on p.Id = pc.ProductId
left join Categories c on pc.CategoryId = c.Id;
	
	
