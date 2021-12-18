using Courses_MVC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Courses_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Courses_MVC.Security.Requirements;

namespace Courses_MVC
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
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddMvc();`
            //services.Add(new ServiceDescriptor(typeof(CourseContext), new CourseContext(Configuration.GetConnectionString("DefaultConnection"))));
            services.AddDbContext<CoursesContext>(options =>
                    options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            //Cấu hình IEMailSender
            services.AddOptions();
            var mailsetting = Configuration.GetSection("MailSettings");
            services.Configure<MailSettings>(mailsetting);
            services.AddSingleton<IEmailSender, SendMailService>();

            //Đăng kí Identity
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<CoursesContext>()
                .AddDefaultTokenProviders();

            /*services.AddDefaultIdentity<AppUser>()
                .AddEntityFrameworkStores<CourseContext>()
                .AddDefaultTokenProviders();*/

            // Truy cập IdentityOptions
            services.Configure<IdentityOptions>(options => {
                // Thiết lập về Password
                options.Password.RequireDigit = false; // Không bắt phải có số
                options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
                options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
                options.Password.RequireUppercase = false; // Không bắt buộc chữ in
                options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
                options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

                // Cấu hình Lockout - khóa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3); // Khóa 3 phút
                options.Lockout.MaxFailedAccessAttempts = 3; // Thất bại 3 lần thì khóa
                options.Lockout.AllowedForNewUsers = true;

                // Cấu hình về User.
                options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email là duy nhất

                // Cấu hình đăng nhập.
                options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại
                options.SignIn.RequireConfirmedAccount = true; //phải xác thực email khi đăng kí xong mới vào được hệ thống
            });

            //Xác thực quyền truy cập
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login/";
                options.LogoutPath = "/Logout/";
                options.AccessDeniedPath = "/khongduoctruycap.html";
            });

            //Đăng kí các gói dịch vụ đăng kí từ bên thứ 3
            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    var gconfig = Configuration.GetSection("Authentication:Google");
                    options.ClientId = gconfig["ClientId"];
                    options.ClientSecret = gconfig["ClientSecret"];
                    //https://localhost:44346/signin-google
                    options.CallbackPath = "/dang-nhap-tu-google";
                })
                .AddFacebook(options =>
                {
                    var fconfig = Configuration.GetSection("Authentication:Facebook");
                    options.AppId = fconfig["AppId"];
                    options.AppSecret = fconfig["AppSecret"];
                    //https://localhost:44346/signin-google
                    options.CallbackPath = "/dang-nhap-tu-facebook";
                });

            services.AddSingleton<IdentityErrorDescriber, AppIdentityErrorDescriber>(); // thêm dịch vụ thông báo lỗi trong Services/AppidentityErrorDescribrer

            //Tạo ra policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowEditRole", policyBuilder =>
                {
                    //Điều kiện
                    policyBuilder.RequireAuthenticatedUser(); //User phải đăng nhập
                    //policyBuilder.RequireRole("Admin"); //User có vai trò admin
                    policyBuilder.RequireClaim("canedit", "user" );
                });

                options.AddPolicy("ShowAdminMenu", policyBuilder => {
                    policyBuilder.RequireRole("Admin");
                });

            });
            //Đăng kí dịch vụ AuthorizationHandler
            services.AddTransient<IAuthorizationHandler, AppAuthorizationHandler>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();//phục hồi thông tin đã đăng nhập, xác thực, thông tin lưu trữ user, phân quyền user
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=HomePage}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
