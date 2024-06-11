
DECLARE CustomerCursor CURSOR For
	SELECT Id, Name, City, State, Sales
		from Customers
		Order by Sales desc;

OPEN CustomerCursor;

DECLARE @Id int, @Name varchar(30), @City varchar(30), @State char(2), @Sales decimal(9,2)

Fetch Next From CustomerCursor INTO @Id, @Name, @City, @State, @Sales;

While @@FETCH_STATUS = 0 BEGIN

	PRINT CONCAT(@Name, ' | ', @Sales);

	Fetch Next From CustomerCursor INTO @Id, @Name, @City, @State, @Sales;

END

PRINT @Name;

CLOSE CustomerCursor;

DEALLOCATE CustomerCursor;