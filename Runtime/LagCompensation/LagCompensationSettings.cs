using UnityEngine;

namespace HalalStudio.NetickLagCompensation
{
    [CreateAssetMenu(fileName = "LagCompensationSettings", menuName = "Netick/Lag Compensation Settings")]
    public class LagCompensationSettings : ScriptableObject
    {
        [System.Serializable]
        public class Settings
        {
            [Header("Gizmos")]
            public Color HitCollectionColor = Color.yellow;
            public Color HitColliderColor = Color.deepSkyBlue;
            [Header("Debugging")]
            public bool EnableLogging = false;
            public bool CompareAndCalculatePrecision = false;
            public bool SpawnComparison = false;
            public GameObject ServerCube;
            public GameObject ClientCube;
            public float CubeLifetime = 3;
        }

        // [Header("Gizmos")]
        // public Color hitCollectionColor = Color.yellow;
        // public Color hitColliderColor = Color.blue;
        public Settings LCSettings;

#if UNITY_EDITOR
        private void OnValidate()
        {
            UnityEditor.SceneView.RepaintAll();
        }
#endif
    }
}