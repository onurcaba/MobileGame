using System.Collections.Generic;
using UnityEngine;
using System;

namespace RayFire
{

    // Rigid Sound class
    [Serializable]
    public class RFSound
    {
       
        public float multiplier = 1f;
        public bool cameraCheck = true;

        public bool playOnCollision = false;
        public List<RFCollisionAudio> collisions;

        public bool playOnDemolition = true;
        public List<RFDemolitionAudio> demolition;

        // Filters
        public float minSize;
        public float minDistanceToCamera;
    }
    
    // Collision sound class
    [Serializable]
    public class RFCollisionAudio
    {
        // Collision vars
        public bool byMaterial = false;
        public MaterialType collisionMaterial;
        public float collisionStrength;

        // Sound vars
        public float volume;
        public float range;
        public AudioClip clip;
    }

    // Demolition sound class
    [Serializable]
    public class RFDemolitionAudio
    {
        // Demolition vars
        public float size;
        public int amount;

        // Sound vars
        public float volume;
        public float range;
        public AudioClip clip;
    }
}

