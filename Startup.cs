using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Collectable_Card_Catalogue.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Collectable_Card_Catalogue
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 Namespace=Collectable_Card_Catalogue Type=Startup Member=(Name=.ctor OverloadingParameters=[(@2 Namespace=Microsoft.Extensions.Configuration Type=IConfiguration)]))" Category="CodeSchema_Method" CodeSchemaProperty_IsConstructor="True" CodeSchemaProperty_IsPublic="True" CommonLabel="Startup" Icon="Microsoft.VisualStudio.Method.Public" IsDragSource="True" Label="Startup(IConfiguration)" SourceLocation="(Assembly=&quot;file:///C:/Users/jclyo/source/repos/Collectable Card Catalogue/Startup.cs&quot; StartLineNumber=20 StartCharacterOffset=15 EndLineNumber=20 EndCharacterOffset=22)" />
    <Node Id="(@1 Namespace=Collectable_Card_Catalogue Type=Startup)" Visibility="Hidden" />
  </Nodes>
  <Links>
    <Link Source="(@1 Namespace=Collectable_Card_Catalogue Type=Startup)" Target="(@1 Namespace=Collectable_Card_Catalogue Type=Startup Member=(Name=.ctor OverloadingParameters=[(@2 Namespace=Microsoft.Extensions.Configuration Type=IConfiguration)]))" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Member" Label="Member" Icon="CodeSchema_Field" />
    <Category Id="CodeSchema_Method" Label="Method" BasedOn="CodeSchema_Member" Icon="CodeSchema_Method" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsConstructor" Label="Is Constructor" Description="Flag to indicate the method is a constructor" DataType="System.Boolean" />
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="Member" Label="Member" ValueType="System.Object" />
    <Name Id="Name" Label="Name" ValueType="System.String" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="OverloadingParameters" Label="Parameter" ValueType="Microsoft.VisualStudio.GraphModel.GraphNodeIdCollection" Formatter="NameValueNoEscape" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(66f318b5-2974-4858-a6ed-c6386cf62b9f.OutputPathUri)" />
    <Alias n="2" Uri="Assembly=file:///C:/Program Files/dotnet/sdk/NuGetFallbackFolder/microsoft.extensions.configuration.abstractions/2.2.0/lib/netstandard2.0/Microsoft.Extensions.Configuration.Abstractions.dll" />
  </IdentifierAliases>
  <Paths>
    <Path Id="66f318b5-2974-4858-a6ed-c6386cf62b9f.OutputPathUri" Value="file:///C:/Users/jclyo/source/repos/Collectable Card Catalogue/bin/Debug/netcoreapp2.2/Collectable Card Catalogue.dll" />
  </Paths>
</DirectedGraph>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
