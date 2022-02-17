﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1T.Settings
{
    [Serializable]
    public class InputTelemetrySettings : BaseSettings
    {
        protected override string Filename => "InputTelemetrySettings.config";
        public InputTelemetrySettings() : base()
        {
            // OVERRIDE DEFAULT SETTINGS
            Height = 125d;
            FramesPerSecond = 35;

            // MODULE DEFAULT SETTINGS
            ThrottleChartVisible = true;
            BrakeChartVisible = true;
            GearChartVisible = false;
        }


        private bool _throttleChartVisible;
        public bool ThrottleChartVisible
        {
            get { return _throttleChartVisible; }
            set { SetField(ref _throttleChartVisible, value, "ThrottleChartVisible"); }
        }

        private bool _brakeChartVisible;
        public bool BrakeChartVisible
        {
            get { return _brakeChartVisible; }
            set { SetField(ref _brakeChartVisible, value, "BrakeChartVisible"); }
        }

        private bool _gearChartVisible;
        public bool GearChartVisible
        {
            get { return _gearChartVisible; }
            set { SetField(ref _gearChartVisible, value, "GearChartVisible"); }
        }
    }
}
