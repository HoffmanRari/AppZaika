using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using T_Zaika.Business.Operations;
using T_Zaika.Business.Service.Contribution;
using T_Zaika.Business.Service.District;
using T_Zaika.Business.Service.ExpenseManagement;
using T_Zaika.Business.Service.Group;
using T_Zaika.Business.Service.Lodgement;
using T_Zaika.Business.Service.Member;
using T_Zaika.Business.Service.Parish;
using T_Zaika.Business.Service.Programme;
using T_Zaika.Business.Service.Responsability;
using T_Zaika.Business.Service.Security;
using T_Zaika.Business.Service.User;
using T_Zaika.DataAccess.Context;
using T_Zaika.Utilities.Enums;
using T_Zaika.WebAPI.Helper;

namespace T_Zaika.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<TZaikaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IOperations<>), typeof(Operations<>));
            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserProfileService, UserProfileService>();
            services.AddTransient<IUserRoleService, UserRoleService>();
            services.AddTransient<IParishService, ParishService>();
            services.AddTransient<IDistrictService, DistrictService>();
            services.AddTransient<ILodgementService, LodgementService>();
            services.AddTransient<IPlaceService, PlaceService>();
            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IProgrammeService, ProgrammeService>();
            services.AddTransient<ISecurityService, SecurityService>();
            services.AddTransient<IRoleSecurityService, RoleSecurityService>();
            services.AddTransient<IResponsabilityService, ResponsabilityService>();
            services.AddTransient<IContributionService, ContributionService>();
            services.AddTransient<IContributionTypeService, ContributionTypeService>();
            services.AddTransient<IFundingService, FundingService>();
            services.AddTransient<IExpenseManagementService, ExpenseManagementService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.RequireHttpsMetadata = false;
               options.SaveToken = true;
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = Configuration["Jwt:Issuer"],
                   ValidAudience = Configuration["Jwt:Audience"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecretKey"])),
                   ClockSkew = TimeSpan.Zero // Override the default clock skew of 5 mins
                };
               services.AddCors();
           });

            services.AddAuthorization(config =>
            {
                config.AddPolicy(UserRoleEnum.Admin.ToString(), Policies.AdminPolicy());
                config.AddPolicy(UserRoleEnum.Supervisor.ToString(), Policies.SupervisorPolicy());
                config.AddPolicy(UserRoleEnum.User.ToString(), Policies.UserPolicy());
            });

            services.AddControllersWithViews();

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist";
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
