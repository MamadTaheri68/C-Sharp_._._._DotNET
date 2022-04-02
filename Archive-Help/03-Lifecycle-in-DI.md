<div dir="auto" align="right">
   <h1>کنترل طول عمر اشیا در زمان تزریق وابستگی </h1>
</div>

<div dir="auto" align="right">
   <p>
     ما میدانیم که در حالت عادی درخواست ها و پاسخ های وب بدون حالت
     ( Stateless )
      هستند و در هر درخواست اشیا قبلی از دست می روند.
   </p>
   <br />
   <p>
      اما در 
      Asp.Net Core
      می توانیم طول عمر اشیا را کنترل کنیم!!!!!
      برای این کار از
      Dependenct Injection
      و توابعی که در اختیار ما می گذارد به شرح این مقاله استفاده می کنیم.
   </p>
</div>

<div dir="auto" align="right">
   <h4>حالت اول : Transient</h4>
   <h4>حالت دوم : Scoped</h4>
   <h4>حالت سوم : Singleton</h4>
</div>

<div dir="auto" align="right">
<p> _____________________________________________________________________________________________________________________________________________ </p>
</div>

<div dir="auto" align="right">
   <h2>حالت اول : Transient</h2>
   <p>
      این حالت با استفاده از تابع
      AddTransient
      در زمان تزریق وابستگی مشخص می شود.
   </p>
   <p>
       در این حالت که به گذرا هم معروف است، به ازای هر بار صدازده شدن، یک نمونه جدید از سرویس توسط ظرف نگهدارنده سرویس ها ساخته شده
       و مورد استفاده قرار می گیرد.
   </p>
   <p>
      در نتیجه، این نوع از سرویس ها طول عمر پایین تری دارند و بر روی عملکرد
      Garbage Collector
      نیز تاثیر می گذارند و سربار بیشتری ایجاد می کنند.
   </p>
</div>

      public void ConfigureServices(IServiceCollection services)

      {

         services.⭕AddTransient⭕<IPersonRepository>(c=> new NHRepo(new NHContext())) ;

         services.AddControllersWithViews();
         
      }


 <div dir="auto" align="right">
   <h2>حالت دوم : Scoped</h2>
   <p>
      این حالت با استفاده از تابع
      AddScoped
      در زمان تزریق وابستگی مشخص می شود.
   </p>
   <p>
      در این حالت، برخلاف حالت قبل، در طول حیات درخواست جاری(Scoped Request)، یک سرویس ساخته شده و هر کلاسی که به این سرویس نیاز داشته باشد، از همین نمونه ساخته شده استفاده میکند و سرویس جدیدی ساخته نمی شود.
   </p>
   <p>
   به عنوان مثال، معمولا درخواست های مرتبط با عملیات های دیتابیس از این نوع ثبت می شود 
   </p>
</div>

      public void ConfigureServices(IServiceCollection services)

      {

         services.⭕AddScoped⭕<IPersonRepository>(c=> new NHRepo(new NHContext())) ;

         services.AddControllersWithViews();
         
      }


 <div dir="auto" align="right">
   <h2>حالت سوم : Singleton</h2>

   <p>
      این حالت با استفاده از تابع
      AddSingleton
      در زمان تزریق وابستگی مشخص می شود.
   </p>
   <p>
      این سرویس ها دارای بیشترین طول عمر هستند و در طول مدت حیات برنامه، باقی می مانند و فقط یک نمونه از انها ساخته می شود.
      از آنجا که این سرویس ها در طول چرخه حیات نرم افزار باقی مانده و قابل دسترسی هستند، لذا معمولا دسترسی به آنها و سرعت عملکرد انها بیشتر است.
   </p>
</div>

      public void ConfigureServices(IServiceCollection services)

      {

         services.⭕AddSingleton⭕<IPersonRepository>(c=> new NHRepo(new NHContext())) ;

         services.AddControllersWithViews();
         
      }  



Links :

* [تفاوت Transient, Scoped و Singleton در تزریق وابستگی ( Dependency Injection ) دات نت کور](https://virgool.io/@pakdel/%D8%AA%D9%81%D8%A7%D9%88%D8%AA-transient-scoped-%D9%88-singleton-%D8%AF%D8%B1-di-%D8%AF%D8%A7%D8%AA-%D9%86%D8%AA-%DA%A9%D9%88%D8%B1-lc1aam6fcurh)

* [ مقدمه‌ای بر تزریق وابستگی‌ها درASP.NET Core](https://www.dntips.ir/post/2749/%D9%85%D9%82%D8%AF%D9%85%D9%87%E2%80%8C%D8%A7%DB%8C-%D8%A8%D8%B1-%D8%AA%D8%B2%D8%B1%DB%8C%D9%82-%D9%88%D8%A7%D8%A8%D8%B3%D8%AA%DA%AF%DB%8C%E2%80%8C%D9%87%D8%A7-%D8%AF%D8%B1asp-net-core)

* [تزریق وابستگی‌ها در ASP.NET Core - بخش 4 - طول حیات سرویس ها یا Service Lifetime](https://www.dntips.ir/post/3201/%D8%AA%D8%B2%D8%B1%DB%8C%D9%82-%D9%88%D8%A7%D8%A8%D8%B3%D8%AA%DA%AF%DB%8C%E2%80%8C%D9%87%D8%A7-%D8%AF%D8%B1-asp-net-core-%D8%A8%D8%AE%D8%B4-4-%D8%B7%D9%88%D9%84-%D8%AD%DB%8C%D8%A7%D8%AA-%D8%B3%D8%B1%D9%88%DB%8C%D8%B3-%D9%87%D8%A7-%DB%8C%D8%A7-service-lifetime)

* [قدم به قدم تزریق وابستگی و طول عمر سرویس در Net Core.](https://virgool.io/@sokoot.ravi/%D9%82%D8%AF%D9%85-%D8%A8%D9%87-%D9%82%D8%AF%D9%85-%D8%AA%D8%B2%D8%B1%DB%8C%D9%82-%D9%88%D8%A7%D8%A8%D8%B3%D8%AA%DA%AF%DB%8C-%D9%88-%D8%B7%D9%88%D9%84-%D8%B9%D9%85%D8%B1-%D8%B3%D8%B1%D9%88%DB%8C%D8%B3-%D8%AF%D8%B1-net-core-emgfxkkymla9)