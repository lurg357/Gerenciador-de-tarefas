public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<TaskContext>(opt =>
        opt.UseSqlServer(Configuration.GetConnectionString("TaskDatabase")));

    services.AddControllers();
}
