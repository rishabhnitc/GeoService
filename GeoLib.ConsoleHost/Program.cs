﻿using GeoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostGeoManager = new ServiceHost(typeof(GeoManager));
            hostGeoManager.Open();
            Console.WriteLine("Service started. Press anykey to close the service");
            Console.ReadLine();
            hostGeoManager.Close();
        }
    }
}