namespace TransNeftEnergo.WebAPI
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                Data.SeedData.EnsurePopulated(scope);
            }
        }
    }
}
