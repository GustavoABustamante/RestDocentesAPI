using RestDocentesAPI.Data;

namespace RestDocentesAPI.Extensions
{
    public static class DatabaseContextExtentions
    {
        public static WebApplication EnsureDbCreated(this WebApplication app)
        {
            try
            {
                using (var scope = app.Services.CreateScope())
                {
                    var docentesDbContext = scope.ServiceProvider.GetService<DocentesContext>();

                    if (docentesDbContext is not null)
                    {
                        docentesDbContext.Database.EnsureCreated();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return app;
        }
    }
}
