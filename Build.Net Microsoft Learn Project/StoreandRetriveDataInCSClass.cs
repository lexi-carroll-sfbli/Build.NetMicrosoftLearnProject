using System;

namespace Build.Net_Microsoft_Learn_Project
{
    class StoreandRetriveDataInCSClass
    {
        public string firstName;
        public int numberOfEmails;
    }

    static class SetFirstName
    {
        public static string firstName = "Bob";
    }

    static class SetNumberOfEmails
    {
        public static int numberOfEmails = 3;
    }

    static class SetTemperatureInCelcius
    {
        public static float temperatureInCelcius = 34.4F;
    }

    static class SetTemperatureInFahrenheit
    {
        //public static float temperatureInFahrenheit = 93.92F;
        public static float temperatureInFahrenheit = ((9F / 5F) * SetTemperatureInCelcius.temperatureInCelcius) + 32F;
    }
}