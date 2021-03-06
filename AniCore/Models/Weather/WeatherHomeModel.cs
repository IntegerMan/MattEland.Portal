﻿using System.Collections.Generic;

namespace Ani.Core.Models.Weather
{
    /// <summary>
    /// A model containing information for the main weather view including current conditions and forecasts
    /// </summary>
    public class WeatherHomeModel
    {
        /// <summary>
        /// Gets or sets the the current weather conditions.
        /// </summary>
        /// <value>The weather conditions.</value>
        public WeatherConditionsModel Conditions { get; set; } = new WeatherConditionsModel();

        /// <summary>
        /// Gets or sets the weather forecasts.
        /// </summary>
        /// <value>The weather forecasts.</value>
        public IList<WeatherForecastModel> Forecasts { get; set; } = new List<WeatherForecastModel>();

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the low temperature forecast line data for inclusion in a chart.
        /// </summary>
        /// <value>The low temperature forecast line data.</value>
        public string ForecastLowLineData { get; set; }

        /// <summary>
        /// Gets or sets the high temperature forecast line data for inclusion in a chart.
        /// </summary>
        /// <value>The high forecast line data.</value>
        public string ForecastHighLineData { get; set; }

    }
}