using System;
using UnityEngine;

namespace RayFire
{
    [Serializable]
    public class RFCustom
    {
        // Fragmentation Type
        public enum RFPointCloudSourceType
        {
            ChildrenTransform = 4,
            TransformArray    = 8,
            Vector3Array      = 12
        }
        
        // Fragmentation Type
        public enum RFPointCloudUseType
        {
            VolumePoints = 4,
            //VolumeAroundPath  = 8,
            PointCloud  = 12
        }
        
        // Fragmentation Type
        public enum RFModifierType
        {
            None       = 0,
            Splinters  = 3,
            Slabs      = 6
        }
        
        //public bool info = false;
        
        [Header("  Point Cloud")]
        [Space(2)]

        public RFPointCloudSourceType source = RFPointCloudSourceType.ChildrenTransform;
        [Space(2)]

        public RFPointCloudUseType useAs = RFPointCloudUseType.PointCloud;
        [Space(2)]
        
        [Header("  Volume")]
        [Space(2)]
        
        [Range(3, 1000)] public int amount = 100;
        [Range(0.01f, 4f)] public float radius = 1f;

        [Header("  Preview")]
        [Space(2)]
        
        public bool enable = true;
        [Range(0.01f, 0.4f)] public float size = 0.05f;
        
        [Header("  Arrays")]
        [Space(2)]
        
        public Transform[] transforms;
        public Vector3[] vector3;

        [HideInInspector]
        public bool noPoints = false;
    }
}

