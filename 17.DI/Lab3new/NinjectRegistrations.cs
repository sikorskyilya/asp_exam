﻿using Ninject.Modules;

namespace Lab3new
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<TelephoneDll.IPhoneDictionary>().To<TelephoneDll.TelephoneDictionary>().InThreadScope(); // интерфейс реализует наш класс (связываем интерфейс с нашем классом)

            // InTransientScope() - по умолчанию - новый на каждый вызов
            // InSingletonScope() - паттерн Singleton - один на все вызовы
            // InThreadScope() - новый экземпляр на каждый поток
            // InRequestScope() - новый экземпляр на каждый запрос
        }
    }
