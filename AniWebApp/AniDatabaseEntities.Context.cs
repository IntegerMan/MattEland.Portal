﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AniWebApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AniEntities : DbContext
    {
        public AniEntities()
            : base("name=AniEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TrafficIncident> TrafficIncidents { get; set; }
        public virtual DbSet<GPSLocation> GPSLocations { get; set; }
        public virtual DbSet<LogEntry> LogEntries { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<NodeType> NodeTypes { get; set; }
        public virtual DbSet<Severity> Severities { get; set; }
        public virtual DbSet<TrafficIncidentSeverity> TrafficIncidentSeverities { get; set; }
        public virtual DbSet<TrafficIncidentType> TrafficIncidentTypes { get; set; }
        public virtual DbSet<Transit> Transits { get; set; }
        public virtual DbSet<UserNode> UserNodes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeatherCode> WeatherCodes { get; set; }
        public virtual DbSet<WeatherFrostResult> WeatherFrostResults { get; set; }
        public virtual DbSet<WeatherPrediction> WeatherPredictions { get; set; }
        public virtual DbSet<WeatherSource> WeatherSources { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<ServiceStatu> ServiceStatus { get; set; }
        public virtual DbSet<WeatherRecord> WeatherRecords { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
    
        public virtual ObjectResult<ActiveTrafficIncidentInfoSelect_Result> ActiveTrafficIncidentInfoSelect(Nullable<bool> includeAccidents, Nullable<bool> includeConstruction)
        {
            var includeAccidentsParameter = includeAccidents.HasValue ?
                new ObjectParameter("IncludeAccidents", includeAccidents) :
                new ObjectParameter("IncludeAccidents", typeof(bool));
    
            var includeConstructionParameter = includeConstruction.HasValue ?
                new ObjectParameter("IncludeConstruction", includeConstruction) :
                new ObjectParameter("IncludeConstruction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ActiveTrafficIncidentInfoSelect_Result>("ActiveTrafficIncidentInfoSelect", includeAccidentsParameter, includeConstructionParameter);
        }
    
        public virtual int InsertUpdateTrafficIncident(Nullable<long> incidentID, string description, string congsestion, string detour, string lane, Nullable<bool> roadClosed, Nullable<bool> verified, Nullable<System.DateTime> createdTimeUTC, Nullable<System.DateTime> modifiedTimeUTC, Nullable<System.DateTime> startTimeUTC, Nullable<System.DateTime> endTimeUTC, Nullable<double> locationLat, Nullable<double> locationLng, Nullable<double> endLocationLat, Nullable<double> endLocationLng, Nullable<int> creatorUserNodeID, Nullable<int> severityID, Nullable<int> typeID)
        {
            var incidentIDParameter = incidentID.HasValue ?
                new ObjectParameter("IncidentID", incidentID) :
                new ObjectParameter("IncidentID", typeof(long));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var congsestionParameter = congsestion != null ?
                new ObjectParameter("Congsestion", congsestion) :
                new ObjectParameter("Congsestion", typeof(string));
    
            var detourParameter = detour != null ?
                new ObjectParameter("Detour", detour) :
                new ObjectParameter("Detour", typeof(string));
    
            var laneParameter = lane != null ?
                new ObjectParameter("Lane", lane) :
                new ObjectParameter("Lane", typeof(string));
    
            var roadClosedParameter = roadClosed.HasValue ?
                new ObjectParameter("RoadClosed", roadClosed) :
                new ObjectParameter("RoadClosed", typeof(bool));
    
            var verifiedParameter = verified.HasValue ?
                new ObjectParameter("Verified", verified) :
                new ObjectParameter("Verified", typeof(bool));
    
            var createdTimeUTCParameter = createdTimeUTC.HasValue ?
                new ObjectParameter("CreatedTimeUTC", createdTimeUTC) :
                new ObjectParameter("CreatedTimeUTC", typeof(System.DateTime));
    
            var modifiedTimeUTCParameter = modifiedTimeUTC.HasValue ?
                new ObjectParameter("ModifiedTimeUTC", modifiedTimeUTC) :
                new ObjectParameter("ModifiedTimeUTC", typeof(System.DateTime));
    
            var startTimeUTCParameter = startTimeUTC.HasValue ?
                new ObjectParameter("StartTimeUTC", startTimeUTC) :
                new ObjectParameter("StartTimeUTC", typeof(System.DateTime));
    
            var endTimeUTCParameter = endTimeUTC.HasValue ?
                new ObjectParameter("EndTimeUTC", endTimeUTC) :
                new ObjectParameter("EndTimeUTC", typeof(System.DateTime));
    
            var locationLatParameter = locationLat.HasValue ?
                new ObjectParameter("LocationLat", locationLat) :
                new ObjectParameter("LocationLat", typeof(double));
    
            var locationLngParameter = locationLng.HasValue ?
                new ObjectParameter("LocationLng", locationLng) :
                new ObjectParameter("LocationLng", typeof(double));
    
            var endLocationLatParameter = endLocationLat.HasValue ?
                new ObjectParameter("EndLocationLat", endLocationLat) :
                new ObjectParameter("EndLocationLat", typeof(double));
    
            var endLocationLngParameter = endLocationLng.HasValue ?
                new ObjectParameter("EndLocationLng", endLocationLng) :
                new ObjectParameter("EndLocationLng", typeof(double));
    
            var creatorUserNodeIDParameter = creatorUserNodeID.HasValue ?
                new ObjectParameter("CreatorUserNodeID", creatorUserNodeID) :
                new ObjectParameter("CreatorUserNodeID", typeof(int));
    
            var severityIDParameter = severityID.HasValue ?
                new ObjectParameter("SeverityID", severityID) :
                new ObjectParameter("SeverityID", typeof(int));
    
            var typeIDParameter = typeID.HasValue ?
                new ObjectParameter("TypeID", typeID) :
                new ObjectParameter("TypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateTrafficIncident", incidentIDParameter, descriptionParameter, congsestionParameter, detourParameter, laneParameter, roadClosedParameter, verifiedParameter, createdTimeUTCParameter, modifiedTimeUTCParameter, startTimeUTCParameter, endTimeUTCParameter, locationLatParameter, locationLngParameter, endLocationLatParameter, endLocationLngParameter, creatorUserNodeIDParameter, severityIDParameter, typeIDParameter);
        }
    
        public virtual int InsertUpdateWeatherPrediction(Nullable<System.DateTime> predictionDateUTC, Nullable<int> creatorNodeID, Nullable<int> zipCode, Nullable<double> low, Nullable<double> high, Nullable<int> code, Nullable<double> minutesToDefrost, string description)
        {
            var predictionDateUTCParameter = predictionDateUTC.HasValue ?
                new ObjectParameter("PredictionDateUTC", predictionDateUTC) :
                new ObjectParameter("PredictionDateUTC", typeof(System.DateTime));
    
            var creatorNodeIDParameter = creatorNodeID.HasValue ?
                new ObjectParameter("CreatorNodeID", creatorNodeID) :
                new ObjectParameter("CreatorNodeID", typeof(int));
    
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var lowParameter = low.HasValue ?
                new ObjectParameter("Low", low) :
                new ObjectParameter("Low", typeof(double));
    
            var highParameter = high.HasValue ?
                new ObjectParameter("High", high) :
                new ObjectParameter("High", typeof(double));
    
            var codeParameter = code.HasValue ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(int));
    
            var minutesToDefrostParameter = minutesToDefrost.HasValue ?
                new ObjectParameter("MinutesToDefrost", minutesToDefrost) :
                new ObjectParameter("MinutesToDefrost", typeof(double));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateWeatherPrediction", predictionDateUTCParameter, creatorNodeIDParameter, zipCodeParameter, lowParameter, highParameter, codeParameter, minutesToDefrostParameter, descriptionParameter);
        }
    
        public virtual int WeatherFrostResultsInsert(Nullable<int> creatorUserNodeID, Nullable<bool> rainedOvernight, Nullable<bool> snowedOvernight, Nullable<double> minutesToDefrost, Nullable<int> zipCode, Nullable<System.DateTime> predictionDate)
        {
            var creatorUserNodeIDParameter = creatorUserNodeID.HasValue ?
                new ObjectParameter("CreatorUserNodeID", creatorUserNodeID) :
                new ObjectParameter("CreatorUserNodeID", typeof(int));
    
            var rainedOvernightParameter = rainedOvernight.HasValue ?
                new ObjectParameter("RainedOvernight", rainedOvernight) :
                new ObjectParameter("RainedOvernight", typeof(bool));
    
            var snowedOvernightParameter = snowedOvernight.HasValue ?
                new ObjectParameter("SnowedOvernight", snowedOvernight) :
                new ObjectParameter("SnowedOvernight", typeof(bool));
    
            var minutesToDefrostParameter = minutesToDefrost.HasValue ?
                new ObjectParameter("MinutesToDefrost", minutesToDefrost) :
                new ObjectParameter("MinutesToDefrost", typeof(double));
    
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var predictionDateParameter = predictionDate.HasValue ?
                new ObjectParameter("PredictionDate", predictionDate) :
                new ObjectParameter("PredictionDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("WeatherFrostResultsInsert", creatorUserNodeIDParameter, rainedOvernightParameter, snowedOvernightParameter, minutesToDefrostParameter, zipCodeParameter, predictionDateParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertUser(string iD, Nullable<int> zipCode, string firstName, string lastName)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertUser", iDParameter, zipCodeParameter, firstNameParameter, lastNameParameter);
        }
    
        public virtual int InsertUpdateZipCode(Nullable<int> zipCode, Nullable<double> lat, Nullable<double> lng, string name, string state)
        {
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var latParameter = lat.HasValue ?
                new ObjectParameter("Lat", lat) :
                new ObjectParameter("Lat", typeof(double));
    
            var lngParameter = lng.HasValue ?
                new ObjectParameter("Lng", lng) :
                new ObjectParameter("Lng", typeof(double));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateZipCode", zipCodeParameter, latParameter, lngParameter, nameParameter, stateParameter);
        }
    
        public virtual int RecordWeatherObservation(Nullable<int> zipCode, Nullable<int> weatherCode, Nullable<int> temperature, string desc, Nullable<System.DateTime> recordTimeUTC, Nullable<int> createdUserID, string sunrise, string sunset, Nullable<int> humidity, Nullable<int> visibility, Nullable<double> pressure, Nullable<int> rising, Nullable<int> windChill, Nullable<int> windDirection, Nullable<int> windSpeed, Nullable<double> lat, Nullable<double> lng, Nullable<int> sourceID)
        {
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var weatherCodeParameter = weatherCode.HasValue ?
                new ObjectParameter("WeatherCode", weatherCode) :
                new ObjectParameter("WeatherCode", typeof(int));
    
            var temperatureParameter = temperature.HasValue ?
                new ObjectParameter("Temperature", temperature) :
                new ObjectParameter("Temperature", typeof(int));
    
            var descParameter = desc != null ?
                new ObjectParameter("Desc", desc) :
                new ObjectParameter("Desc", typeof(string));
    
            var recordTimeUTCParameter = recordTimeUTC.HasValue ?
                new ObjectParameter("RecordTimeUTC", recordTimeUTC) :
                new ObjectParameter("RecordTimeUTC", typeof(System.DateTime));
    
            var createdUserIDParameter = createdUserID.HasValue ?
                new ObjectParameter("CreatedUserID", createdUserID) :
                new ObjectParameter("CreatedUserID", typeof(int));
    
            var sunriseParameter = sunrise != null ?
                new ObjectParameter("Sunrise", sunrise) :
                new ObjectParameter("Sunrise", typeof(string));
    
            var sunsetParameter = sunset != null ?
                new ObjectParameter("Sunset", sunset) :
                new ObjectParameter("Sunset", typeof(string));
    
            var humidityParameter = humidity.HasValue ?
                new ObjectParameter("Humidity", humidity) :
                new ObjectParameter("Humidity", typeof(int));
    
            var visibilityParameter = visibility.HasValue ?
                new ObjectParameter("Visibility", visibility) :
                new ObjectParameter("Visibility", typeof(int));
    
            var pressureParameter = pressure.HasValue ?
                new ObjectParameter("Pressure", pressure) :
                new ObjectParameter("Pressure", typeof(double));
    
            var risingParameter = rising.HasValue ?
                new ObjectParameter("Rising", rising) :
                new ObjectParameter("Rising", typeof(int));
    
            var windChillParameter = windChill.HasValue ?
                new ObjectParameter("WindChill", windChill) :
                new ObjectParameter("WindChill", typeof(int));
    
            var windDirectionParameter = windDirection.HasValue ?
                new ObjectParameter("WindDirection", windDirection) :
                new ObjectParameter("WindDirection", typeof(int));
    
            var windSpeedParameter = windSpeed.HasValue ?
                new ObjectParameter("WindSpeed", windSpeed) :
                new ObjectParameter("WindSpeed", typeof(int));
    
            var latParameter = lat.HasValue ?
                new ObjectParameter("Lat", lat) :
                new ObjectParameter("Lat", typeof(double));
    
            var lngParameter = lng.HasValue ?
                new ObjectParameter("Lng", lng) :
                new ObjectParameter("Lng", typeof(double));
    
            var sourceIDParameter = sourceID.HasValue ?
                new ObjectParameter("SourceID", sourceID) :
                new ObjectParameter("SourceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RecordWeatherObservation", zipCodeParameter, weatherCodeParameter, temperatureParameter, descParameter, recordTimeUTCParameter, createdUserIDParameter, sunriseParameter, sunsetParameter, humidityParameter, visibilityParameter, pressureParameter, risingParameter, windChillParameter, windDirectionParameter, windSpeedParameter, latParameter, lngParameter, sourceIDParameter);
        }
    
        public virtual ObjectResult<WeatherFrostDataSelect_Result> WeatherFrostDataSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WeatherFrostDataSelect_Result>("WeatherFrostDataSelect");
        }
    
        public virtual ObjectResult<LatestWeatherEntrySelect_Result> LatestWeatherEntrySelect(Nullable<int> zipCode)
        {
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LatestWeatherEntrySelect_Result>("LatestWeatherEntrySelect", zipCodeParameter);
        }
    
        public virtual ObjectResult<ActiveWeatherPredictionsSelect_Result> ActiveWeatherPredictionsSelect(Nullable<int> zipCode, Nullable<System.DateTime> afterDate)
        {
            var zipCodeParameter = zipCode.HasValue ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(int));
    
            var afterDateParameter = afterDate.HasValue ?
                new ObjectParameter("AfterDate", afterDate) :
                new ObjectParameter("AfterDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ActiveWeatherPredictionsSelect_Result>("ActiveWeatherPredictionsSelect", zipCodeParameter, afterDateParameter);
        }
    }
}
