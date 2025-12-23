using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{

    class LightSystem
    {
        public void TurnOnLights()
        {
            Console.WriteLine("Lights are ON");
        }

        public void TurnOffLights()
        {
            Console.WriteLine("Lights are OFF");
        }
    }

    class HeatingSystem
    {
        public void TurnOnHeating()
        {
            Console.WriteLine("Heating is ON");
        }

        public void TurnOffHeating()
        {
            Console.WriteLine("Heating is OFF");
        }
    }

    class SecuritySystem
    {
        public void ActivateAlarm()
        {
            Console.WriteLine("Alarm is ON");
        }

        public void DeactivateAlarm()
        {
            Console.WriteLine("Alarm is OFF");
        }
    }

    class SmartHomeFacade
    {
        private LightSystem lightSystem;
        private HeatingSystem heatingSystem;
        private SecuritySystem securitySystem;

        public SmartHomeFacade(
            LightSystem light,
            HeatingSystem heating,
            SecuritySystem security)
        {
            lightSystem = light;
            heatingSystem = heating;
            securitySystem = security;
        }

        public void StartEveningMode()
        {
            lightSystem.TurnOnLights();
            heatingSystem.TurnOnHeating();
            securitySystem.DeactivateAlarm();
        }

        public void StartNightMode()
        {
            lightSystem.TurnOffLights();
            heatingSystem.TurnOffHeating();
            securitySystem.ActivateAlarm();
        }
    }

    class Program
    {
        static void Main()
        {
            SmartHomeFacade home = new SmartHomeFacade(
                new LightSystem(),
                new HeatingSystem(),
                new SecuritySystem()
            );

            home.StartEveningMode();
            home.StartNightMode();
        }
    }
}
