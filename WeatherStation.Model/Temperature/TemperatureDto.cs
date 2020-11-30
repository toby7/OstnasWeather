﻿namespace WeatherStation.Model.Temperature
{
    using Enums;

    public class TemperatureDto
    {
        public double CurrentTemperature { get; set; }

        public double OldTemperature { get; set; }

        public Trend Trend => this.CurrentTemperature > this.OldTemperature ? Trend.Up : Trend.Down;
    }
}
