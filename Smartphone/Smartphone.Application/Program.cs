using System;
using Smartphone.Application.Factories;

namespace Smartphone.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartPhoneFactory = new AppleSmartphoneFactory(new AppleSmartphoneComponentsFactory());

            var smartphone = smartPhoneFactory.CreateOne();
        }
    }
}