using PNIPU_C__LAB_14;

var enterprise = DataGenerator.GenerateEnterprise();

Console.WriteLine("=== ВЫБОРКА ===");
EnterpriseQueries.SelectionQuery(enterprise);

Console.WriteLine("\n=== СЧЁТЧИК ===");
EnterpriseQueries.CountEngineers(enterprise);

Console.WriteLine("\n=== ОПЕРАЦИИ НАД МНОЖЕСТВАМИ ===");
EnterpriseQueries.IntersectDepartments(enterprise, "IT", "Engineering");

Console.WriteLine("\n=== АГРЕГАЦИЯ ===");
EnterpriseQueries.MaxAgeQuery(enterprise);

Console.WriteLine("\n=== ГРУППИРОВКА ===");
EnterpriseQueries.GroupByType(enterprise);