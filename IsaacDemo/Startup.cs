namespace IsaacDemo
{
    using IsaacDemo.Shared;
    using IsaacDemo.Shared.ViewModels;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

            MyLocalJokeDb.JokeList = new Dictionary<int, GoodJokeViewModel>();
        }
    }
}
