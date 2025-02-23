using System;

namespace Challenge_2
{
    class WeatherData
    {
        
        
        private string _scale;
        private int _temperature;
        private int _humidity;
        
        

        public string Scale
        {
            get { return _scale; }
            set
            {
                if (value == "C" || value == "F")
                {
                    _scale = value;
                }
                else
                {
                    Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                }
            }
        }
        
        

        public int Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public int Humidity
        {
            get { return _humidity; }
            set { _humidity = value; }
        }
        
        
        
        public void Convert()
        {
            if (_scale == "C")
            {
                _temperature = (int)((_temperature * 9.0 / 5.0) + 32);
                _scale = "F";
                Console.WriteLine($"Temperature converted to {GetFormattedTemperature()}");
            }
            else
            {
                _temperature = (int)((_temperature - 32) * 5.0 / 9.0);
                _scale = "C";
                Console.WriteLine($"Temperature converted to {GetFormattedTemperature()}");
            }
        }
        
        
        
        public string GetFormattedTemperature()
        {
            return _scale == "C" ? $"{_temperature}°c" : $"{_temperature}°F";
        }
        
        
        

        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            string? input = null;
            
            while (true)
            {
                Console.Write("Please choose scale (C/F): ");
                input = Console.ReadLine()?.ToUpper();

                if (!string.IsNullOrWhiteSpace(input) && (input.Equals("C") || input.Equals("F")))
                {
                    data.Scale = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            Console.WriteLine($"You selected: {data.Scale}");
            
            while (true)
            {
                Console.Write($"Please enter temperature in {data.Scale}: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int temp))
                {
                    if (data.Scale == "C" && (temp < -60 || temp > 60))
                    {
                        Console.WriteLine("A reading mistake must have been made since the value seems unrealistic.");
                    }
                    else if (data.Scale == "F" && (temp < -76 || temp > 140))
                    {
                        Console.WriteLine("A reading mistake must have been made since the value seems unrealistic.");
                    }
                    else
                    {
                        data.Temperature = temp;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine($"Temperature set to {data.GetFormattedTemperature()}");
            
            while (true)
            {
                Console.Write("Please enter humidity: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int h))
                {
                    if (h < 0 || h > 100)
                    {
                        Console.WriteLine("Invalid humidity. Please enter a value between 0 and 100.");
                    }
                    else
                    {
                        data.Humidity = h;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine($"Humidity set to {data.Humidity}%");
            
            Console.Write("\nDo you want to convert the temperature? (Y/N): ");
            input = Console.ReadLine()?.ToUpper();

            if (input == "Y")
            {
                data.Convert();
            }
            
            Console.WriteLine("\nFinal Weather Data:");
            Console.WriteLine($"Temperature: {data.GetFormattedTemperature()}");
            Console.WriteLine($"Humidity: {data.Humidity}%");
        }
    }
}
