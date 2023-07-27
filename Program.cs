using Serilog;

Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), rollingInterval: RollingInterval.Day)
            .CreateLogger();

Log.Debug("Esta é uma mensagem de debug.");

var Id = 1;
var Nome = "Peter Parker";

Log.Information("Informação: {Id} - {Nome}", Id, Nome);

Log.Warning("Aviso! Algo pode estar errado.");

try
{
    throw new InvalidOperationException("Gerando um erro.");
}
catch (Exception ex)
{
    Log.Error(ex, "Ocorreu um erro!");
}

Log.CloseAndFlush();
