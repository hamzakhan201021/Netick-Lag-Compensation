using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

// public static class LagCompensationSystem
// {
//     private static LagCompensationSettings settings;
//     private const string settingsPath = "LagCompensationSettings";

//     private static void EnsureSettingsExist()
//     {
// #if UNITY_EDITOR
//         if (settings != null) return;

//         settings = Resources.Load<LagCompensationSettings>(settingsPath);
//         if (settings == null)
//         {
//             settings = ScriptableObject.CreateInstance<LagCompensationSettings>();
//             string folder = "Assets/Netick/Resources";
//             if (!System.IO.Directory.Exists(folder))
//                 System.IO.Directory.CreateDirectory(folder);

//             string path = $"{folder}/LagCompensationSettings.asset";
//             AssetDatabase.CreateAsset(settings, path);
//             AssetDatabase.SaveAssets();
//             AssetDatabase.Refresh();
//         }
// #else
//         if (settings == null)
//             settings = Resources.Load<LagCompensationSettings>(settingsPath);
// #endif
//     }

//     public static Color HitCollectionColor { get { EnsureSettingsExist(); return settings.hitCollectionColor; } }
//     public static Color HitColliderColor { get { EnsureSettingsExist(); return settings.hitColliderColor; } }
//     // public static Color HitCapsuleColor { get { EnsureSettingsExist(); return settings.hitCapsuleColor; } }
//     // public static Color HitSphereColor { get { EnsureSettingsExist(); return settings.hitSphereColor; } }
// }

namespace HalalStudio.NetickLagCompensation
{
    public static class LagCompensationSystem
    {
        private static LagCompensationSettings settings;
        private const string RESOURCE_NAME = "NetickLagCompensationConfig";
        private const string FOLDER_PATH = "Assets/HalalStudio/Resources";
        private const string FILE_PATH = "NetickLagCompensationConfig.asset";

        public static LagCompensationSettings GetOrCreateSettings()
        {
#if UNITY_EDITOR
            if (settings != null) return settings;

            settings = Resources.Load<LagCompensationSettings>(RESOURCE_NAME);
            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<LagCompensationSettings>();
                if (!System.IO.Directory.Exists(FOLDER_PATH))
                    System.IO.Directory.CreateDirectory(FOLDER_PATH);

                string path = $"{FOLDER_PATH}/{FILE_PATH}";
                AssetDatabase.CreateAsset(settings, path);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
#else
        if (settings == null)
            settings = Resources.Load<LagCompensationSettings>(RESOURCE_NAME);
#endif
            return settings;
        }
    }
}