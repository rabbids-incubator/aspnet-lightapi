﻿namespace RabbidsIncubator.LightApi.Domain.Models
{
    public class DeviceModel : IModel
    {
        public string Id { get; set; }

        public string MacAddress { get; set; }
    }
}
