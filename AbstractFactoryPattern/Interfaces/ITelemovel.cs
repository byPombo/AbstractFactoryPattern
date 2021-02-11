using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();

    }

}
