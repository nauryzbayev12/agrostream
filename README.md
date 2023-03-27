# Agrostream

http://localhost:5000/swagger/index.html- Swagger

1) В каталоге с .sln:
dotnet ef --startup-project Company.Delivery.Api migrations add Init -p Company.Delivery.Database
2) В каталоге Company.Delivery.Api:
dotnet ef database update

