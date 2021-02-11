using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcretesFactory
{
    public class Nokia : ITelemovel
    {
        /// <summary>
        /// ConcreteFactory1
        /// </summary>
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
