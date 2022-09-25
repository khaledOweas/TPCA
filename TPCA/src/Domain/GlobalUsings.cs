global using TPCA.Domain.Common;
global using TPCA.Domain.Entities;
global using TPCA.Domain.Enums;
global using TPCA.Domain.Events;
global using TPCA.Domain.Exceptions;
global using TPCA.Domain.ValueObjects;


// dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations
// dotnet ef migrations add "AddingNameAndMaxForTodoList" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations
// dotnet ef migrations add "AddingZoba" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations

// dotnet ef  database update --project src\Infrastructure --startup-project src\WebUI  