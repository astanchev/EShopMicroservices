namespace Discount.Grpc.Data;

using Microsoft.EntityFrameworkCore;

public static class Extentions
{
    public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
    {
        try
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var dbContext = scope.ServiceProvider.GetRequiredService<DiscountContext>();
            dbContext.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
;
        }
        

        return app;
    }
}
