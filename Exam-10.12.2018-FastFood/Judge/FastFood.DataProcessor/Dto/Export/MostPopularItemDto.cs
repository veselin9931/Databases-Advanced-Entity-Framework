﻿namespace FastFood.DataProcessor.Dto.Export
{
    using System.Xml.Serialization;

    public class MostPopularItemDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("TotalMade")]
        public decimal TotalMade { get; set; }

        [XmlElement("TimesSold")]
        public int TimesSold { get; set; }
    }
}