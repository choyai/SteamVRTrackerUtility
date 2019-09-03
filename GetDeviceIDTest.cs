using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Valve.VR;

namespace Valve.VR
{
    public class GetDeviceIDTest : MonoBehaviour
    {
        void Start()
        {
            string id = getID(2);
            Debug.Log("Device 2's id is " + id);
        }
        public string getID(uint index)
        {
            ETrackedPropertyError error = new ETrackedPropertyError();
            StringBuilder sb = new StringBuilder();
            OpenVR.System.GetStringTrackedDeviceProperty(index, ETrackedDeviceProperty.Prop_SerialNumber_String, sb, OpenVR.k_unMaxPropertyStringSize, ref error);
            var probablyUniqueDeviceSerial = sb.ToString();
            return probablyUniqueDeviceSerial;
        }
    }
}