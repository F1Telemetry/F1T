﻿using F1T.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1T.MVVM.ViewModels
{
    public class BaseModuleViewModel : ObservableObject
    {

        public BaseModuleViewModel()
        {
            // TODO
            // Should probably be loading things from a properties file like here:
            // opacity (overlay)
            // size of window (overlay)
            // location of window (overlay)
            // since they are specific to all modules
            // Then in each module specifically, 
            // the properties should be saved and loaded in their constructor
        }

        private PacketViewModel _packetViewModel = PacketViewModel.GetInstance();
        public PacketViewModel PacketViewModel
        {
            get { return _packetViewModel; }
            set
            {
                SetField(ref _packetViewModel, value, "PacketViewModel");
            }
        }

        private bool _overlayVisible;
        public bool OverlayVisible
        {
            get { return _overlayVisible; }
            set { SetField(ref _overlayVisible, value, "OverlayVisible"); }
        }

        private bool _toggled;
        public bool Toggled
        {
            get { return _toggled; }
            set { SetField(ref _toggled, value, "Toggled"); }
        }

        private int _opacitySliderValue;
        public int OpacitySliderValue
        {
            get { return _opacitySliderValue; }
            set
            {
                SetField(ref _opacitySliderValue, value, "OpacitySliderValue");
                Opacity = OpacitySliderValue / 100f;
            }
        }

        private float _opacity;
        public float Opacity
        {
            get { return _opacity; }
            set
            {
                SetField(ref _opacity, value, "Opacity");
            }
        }
    }
}
