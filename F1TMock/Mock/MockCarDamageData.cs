﻿using F1T.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace F1TMock.Mock
{
    class MockCarDamageData
    {
        private CarDamageData GetRandomCarDamageData()
        {
            CarDamageData carDamageData = new CarDamageData();
            float[] testData = { 10.0f, 10.0f, 10.0f, 10.0f };
            carDamageData.m_tyresWear = testData;
            byte[] testData2 = { 10, 10, 10, 10 };
            carDamageData.m_tyresDamage = testData2;
            carDamageData.m_brakesDamage = testData2;
            carDamageData.m_frontLeftWingDamage = 10;
            carDamageData.m_frontRightWingDamage = 10;
            carDamageData.m_rearWingDamage = 10;
            carDamageData.m_floorDamage = 10;
            carDamageData.m_diffuserDamage = 10;
            carDamageData.m_sidepodDamage = 10;
            carDamageData.m_drsFault = DRSFault.Ok;
            carDamageData.m_gearBoxDamage = 10;
            carDamageData.m_engineDamage = 10;
            carDamageData.m_engineMGUHWear = 10;
            carDamageData.m_engineESWear = 10;
            carDamageData.m_engineCEWear = 10;
            carDamageData.m_engineICEWear = 10;
            carDamageData.m_engineMGUKWear = 10;
            carDamageData.m_engineTCWear = 10;
            return carDamageData;
        }

        private PacketCarDamageData GetRandomPacketCarDamageData()
        {
            PacketCarDamageData packet = new PacketCarDamageData();
            packet.m_header = MockHeader.GetPacketHeader(PacketType.CarDamage);
            CarDamageData[] carDamageDatas = new CarDamageData[22];
            for (int i = 0; i < carDamageDatas.Length; i++)
            {
                carDamageDatas[i] = GetRandomCarDamageData();
            }
            packet.m_carDamageData = carDamageDatas;
            return packet;
        }

        public byte[] GetBytesCarDamageData()
        {
            var packet = GetRandomPacketCarDamageData();
            int size = Marshal.SizeOf(packet);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(packet, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
    }
}
