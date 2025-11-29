using Microsoft.Extensions.Logging;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;


namespace Databusiness.Mappers
{
    public   class AutoMapperConfigs
    {


        public  static IMapper Mapper { get; private set; }

        static ILoggerFactory loggerFactory;
        public   static void Initialize()
        {
           // التهيئة الصحيحة لـ MapperConfiguration التي لا تعطي خطأ المُنشئ
           var mappingConfig = new MapperConfiguration(expression =>
           {
               expression.AddProfile(new ApplicationProfile());
           });

           // إنشاء كائن الـ Mapper وتخزينه
             Mapper = mappingConfig.CreateMapper(); ;
        }

    }
}