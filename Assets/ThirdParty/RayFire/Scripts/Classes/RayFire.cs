using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RayFire
{
    
    //[Serializable]
    public class RFFrag
    {
        public Mesh mesh;
        public Vector3 pivot;
        //public RFMesh rfMesh;
        public RFDictionary subId;
        public RayfireRigid fragment;
    }
    
    public class RFTri
    {
        public int meshId;
        public int subMeshId = -1;
        public List<int> ids = new List<int>();
        public List<Vector3> vpos = new List<Vector3>();
        public List<Vector3> vnormal = new List<Vector3>();
        public List<Vector2> uvs = new List<Vector2>();
        public List<Vector4> tangents = new List<Vector4>();
        public List<RFTri> neibTris = new List<RFTri>();
    }

    [Serializable]
    public class RFDictionary
    {
        public List<int> keys;
        public List<int> values;

        // Constructor
        public RFDictionary(Dictionary<int, int> dictionary)
        {
            keys = new List<int>();
            values = new List<int>();
            keys = dictionary.Keys.ToList();
            values =  dictionary.Values.ToList();
        }
    }

    /// /////////////////////////////////////////////////////////
    /// Rigid
    /// /////////////////////////////////////////////////////////
    
    // Gluing
    [Serializable]
    public class RFShatterCluster
    {
        [Header ("  Main")]
        [Space (2)]
        
        public bool enable;
        
        [Tooltip ("Amount of clusters defined by random point cloud.")]
        [Range(2, 200)] 
        public int count;
        
        [Tooltip ("Random seed for clusters point cloud generator.")]
        [Range(0, 100)] 
        public int seed;
        
        [Tooltip ("Smooth strength for cluster inner surface.")]
        [Range(0f, 1f)] 
        public float relax;
        
        [Header ("  Debris")]
        [Space (2)]
        
                
        [Tooltip ("Amount of debris in last layer in percents relative to amount of fragments in cluster.")]
        [Range(0, 100)] 
        public int amount;
        
        [Tooltip ("Amount of debris layers at cluster border.")]
        [Range(0, 5)] 
        public int layers;

        [Tooltip ("Scale variation for inner debris.")]
        [Range(0.1f, 1f)] 
        public float scale;
        
        [Tooltip ("Minimum amount of fragments in debris cluster.")]
        [Range(1, 20)] 
        public int min;
        
        [Tooltip ("Maximum amount of fragments in debris cluster.")]
        [Range(1, 20)] 
        public int max;
        
        // Constructor
        public RFShatterCluster()
        {
            enable = false;
            count = 10;
            seed = 1;
            relax = 0.5f;
            
            layers = 0;
            amount = 0;
            scale = 1f;
            min = 1;
            max = 3;
        }
    }

    /// /////////////////////////////////////////////////////////
    /// Shatter
    /// /////////////////////////////////////////////////////////

    [Serializable]
    public class RFVoronoi
    {
        public int amount = 30;
        [Range(0f, 1f)] public float centerBias = 0f;
        
        // Amount
        public int Amount
        {
            get
            {
                if (amount < 1)
                    return 1;
                if (amount > 20000)
                    return 2;
                return amount;
            }
        }
    }

    [Serializable]
    public class RFSplinters
    {
        public AxisType axis = AxisType.YGreen;
        public int amount = 30;
        [Range(0f, 1f)] public float strength = 0.7f;
        [Range(0f, 1f)] public float centerBias = 0f;

        // Amount
        public int Amount
        {
            get
            {
                if (amount < 2)
                    return 2;
                if (amount > 20000)
                    return 2;
                return amount;
            }
        }
    }

    [Serializable]
    public class RFRadial
    {
        [Header("  Common")]
        [Space (2)]
        
        public AxisType centerAxis = AxisType.YGreen;
        [Range(0.01f, 30f)] public float radius = 1f;
        [Range(0f, 1f)] public float divergence = 1f;
        public bool restrictToPlane = true;

        [Header("  Rings")]
        [Space (2)]
        
        [Range(3, 60)]  public int rings = 10;
        [Range(0, 100)] public int focus = 0;
        [Range(0, 100)] public int focusStr = 50;
        [Range(0, 100)] public int randomRings = 50;

        [Header("  Rays")]
        [Space (2)]
        
        [Range(3, 60)]   public int rays = 10;
        [Range(0, 100)]  public int randomRays = 0;
        [Range(-90, 90)] public int twist = 0;
    }

    [Serializable]
    public class RFSlice
    {
        public PlaneType plane = PlaneType.XZ;
        // [Range(0, 30f)] public float rotation = 0f;
        public List<Transform> sliceList;

        // Get axis
        public Vector3 Axis (Transform tm)
        {
            if (plane == PlaneType.YZ)
                return tm.right;
            if (plane == PlaneType.XZ)
                return tm.up;
            return tm.forward;
        }
    }

    [Serializable]
    public class RFTets
    {
        public enum TetType
        {
            Uniform = 0,
            Curved  = 1
        }

        //public Vector3Int density = new Vector3Int(3, 3, 3);
        [HideInInspector]public TetType lattice = TetType.Uniform;
        [Range(1, 30)] public int density = 7;
        [Range(0, 100)] public int noise = 100;
        
    }
}

