using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using OnlineVotingSystem.BLL;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Controllers;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<HomeController>().InstancePerRequest();
            builder.RegisterType<AccountController>().InstancePerRequest();
            builder.RegisterType<VoteController>().InstancePerRequest();

            // регистрируем споставление типов
            builder.RegisterType<UserRepository>().As<IRepository<User>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<RoleRepository>().As<IRepository<Role>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<VariantRepository>().As<IRepository<Variant>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<VotingRepository>().As<IRepository<Voting>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<VoiceRepository>().As<IRepository<Voice>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<CommentRepository>().As<IRepository<Comment>>().WithParameter("context", new SystemContext()).PreserveExistingDefaults();
            builder.RegisterType<UserService>().As<IUserService>().PreserveExistingDefaults();
            builder.RegisterType<RoleService>().As<IRoleService>().PreserveExistingDefaults();
            builder.RegisterType<VoiceService>().As<IVoiceService>().PreserveExistingDefaults();
            builder.RegisterType<VariantService>().As<IVariantService>().PreserveExistingDefaults();
            builder.RegisterType<VotingService>().As<IVotingService>().PreserveExistingDefaults();
            builder.RegisterType<CommentService>().As<ICommentService>().PreserveExistingDefaults();
            /*builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();*/

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}