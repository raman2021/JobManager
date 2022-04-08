﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using JobManager.Services;
using JobManager.Models;
using JobManager.Droid.Services;
using System.Threading.Tasks;

[assembly: Dependency(typeof(DeviceBatteryService))]
namespace JobManager.Droid.Services
{
    class DeviceBatteryService : IDeviceBatteryService
    {
        public DeviceBattery GetBattery()
        {
            DeviceBattery battery = new DeviceBattery();

            return battery;
        }
    }
}