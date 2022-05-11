using Module = Autofac.Module;
using BlogSite.Core.Repositories;
using BlogSite.Core.Services;
using BlogSite.Core.UnitOfWorks;
using BlogSite.Repository.Repositories;
using BlogSite.Repository.UnitOfWorks;
using BlogSite.Service.Repositories;
using System.Reflection;
using Autofac;
using BlogSite.Repository;
using BlogSite.Service.Mapping;

namespace BlogSite.WebAPI.Modules
{
    public class RepoServiceModule : Module // Module sınıfı Autofac'ten geliyor. Fakat burada dikkat etmen gereken konu şudur: Module sınıfı reflection içerisinde de var
                                            // ambiguous match hatasını önlemek için. using'i  using Module=Autofac.Module; ile yazıyoruz.
    {
        protected override void Load(ContainerBuilder builder) // override ettiğimiz method
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope(); // Repository sınıfının generic tipi olarak register ediyoruz.
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope(); // Service sınıfının generic tipi olarak register ediyoruz.

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope(); // UnitOfWork sınıfının generic tipi olmadan register ediyoruz. Çünkü UnitOfWork sınıfını generic değil.

            // Assembly'lerin (katmanların) yolunu belirtiyoruz. Burada Assembly.GetExecutingAssembly() metodu ile bulunduğumuz katmanının yolunu alıyoruz.
            // GetAssemblye(typeof()) metodu ile o sınıfın bulunduğu assembly'inin yolunu alıyoruz alıyoruz. Burada hangi sınıfı belirttiğimiz önemli değil. Hangi assembly'i belirttiğimiz önemli.
            var apiAssembly = Assembly.GetExecutingAssembly();
            //  var repoAssembly = Assembly.Load("NLayer.Repository"); // bu şekilde de Assembly ismini alabiliriz ama best practice olanı aşağıdaki gibidir.
            //  var serviceAssembly = Assembly.Load("NLayer.Service");
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            // burada da yolunu belirttiğimiz assembly'leri register et ve bu assembly'lerin içerisinde bulunduğu sınıfların isimlerinin sonu Repository veya Service ile bitenleri ve bu sınıfların miras aldığı intafece'leri al diyoruz.
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
              .Where(t => t.Name.EndsWith("Service"))
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

       

        }


    }
}
