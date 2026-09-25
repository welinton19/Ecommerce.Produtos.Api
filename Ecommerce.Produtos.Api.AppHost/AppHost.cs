var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Ecommerce_Produtos_Api>("ecommerce-produtos-api");

builder.AddProject<Projects.Ecommerce_Pagamentos_Api>("ecommerce-pagamentos-api");

builder.AddProject<Projects.Ecommerce_NotaFiscal_Api>("ecommerce-notafiscal-api");

builder.AddProject<Projects.Ecommerce_Gateway>("ecommerce-gateway");

builder.Build().Run();
