# Agrostream

http://localhost:5276/swagger/index.html- Swagger

1) В каталоге с .sln чтобы создать миграцию:
dotnet ef --startup-project Company.Delivery.Api migrations add Init -p Company.Delivery.Database
2) В каталоге Company.Delivery.Api чтобы выполнить миграцию:  
dotnet ef database update

