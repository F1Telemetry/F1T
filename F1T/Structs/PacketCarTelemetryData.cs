﻿using System.Runtime.InteropServices;

namespace F1T.Structs
{
    [StructLayout(LayoutKind.Explicit, Pack = 0, Size = 92)]
    public struct PacketCarTelemetryData
    {
        [FieldOffset(0)]
        public PacketHeader m_header;        // Header
        [FieldOffset(24)]
        public CarTelemetryData[] m_carTelemetryData;
        [FieldOffset(89)]
        public byte m_mfdPanelIndex;       // Index of MFD panel open - 255 = MFD closed
                                           // Single player, race – 0 = Car setup, 1 = Pits
                                           // 2 = Damage, 3 =  Engine, 4 = Temperatures
                                           // May vary depending on game mode
        [FieldOffset(90)]
        public byte m_mfdPanelIndexSecondaryPlayer;   // See above
        [FieldOffset(91)]
        public sbyte m_suggestedGear;       // Suggested gear for the player (1-8)
                                            // 0 if no gear suggested
    };
}
