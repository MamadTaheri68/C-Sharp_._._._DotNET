<div dir="auto" align="right">
   <h1>کنترل طول عمر اشیا در زمان تزریق وابستگی </h1>
</div>

<div dir="auto" align="right">
   <p>
     ما میدانیم که در حالت عادی درخواست ها و پاسخ های وب بدون حالت
     ( Stateless )
      هستند و در هر درخواست اشیا قبلی از دست می روند
   </p>
   <br />
   <p>
      اما در 
      Asp.Net Core
      می توانیم طول عمر اشیا را کنترل کنیم!!!!!
      برای این کار از
      Dependenct Injection
      استفاده می کنیم و آنرا مشخص می کنیم
   </p>
</div>

<div dir="auto" align="right">
   <h4>حالت اول : Transient</h4>
   <h4>حالت دوم : Scoped</h4>
   <h4>حالت سوم : Singleton</h4>
</div>

<div dir="auto" align="right">
<p>*************************************************************************************</p>
</div>

<div dir="auto" align="right">
   <h2>حالت اول : Transient</h2>
   <p>
      این حالت با استفاده از تابع
      AddTransient
      در زمان تزریق وابستگی مشخص می شود.
       در این حالت که به گذرا هم معروف است، به ازای هر درخواست جدید، یک نمونه جدید از سرویس توسط ظرف نگهدارنده سرویس ها ساخته شده
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


 