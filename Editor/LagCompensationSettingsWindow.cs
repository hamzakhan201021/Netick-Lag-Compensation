using UnityEditor;
using UnityEngine;

namespace HalalStudio.NetickLagCompensation
{
    public class LagCompensationSettingsWindow : EditorWindow
    {
        // private LagCompensationSettings settings;

        // [MenuItem("Tools/Netick/HalalStudios/LagCompensation")]
        // public static void OpenWindow()
        // {
        //     GetWindow<LagCompensationSettingsWindow>("Lag Compensation Settings");
        // }

        // private void OnEnable()
        // {
        //     settings = Resources.Load<LagCompensationSettings>("LagCompensationSettings");
        //     if (settings == null)
        //     {
        //         settings = ScriptableObject.CreateInstance<LagCompensationSettings>();
        //         string folder = "Assets/Netick/Resources";
        //         if (!System.IO.Directory.Exists(folder))
        //             System.IO.Directory.CreateDirectory(folder);

        //         string path = $"{folder}/LagCompensationSettings.asset";
        //         AssetDatabase.CreateAsset(settings, path);
        //         AssetDatabase.SaveAssets();
        //         AssetDatabase.Refresh();
        //     }
        // }

        // private void OnGUI()
        // {
        //     if (settings == null)
        //     {
        //         EditorGUILayout.HelpBox("Settings asset not found!", MessageType.Error);
        //         return;
        //     }

        //     EditorGUI.BeginChangeCheck();

        //     settings.hitCollectionColor = EditorGUILayout.ColorField("Hit Collection Color", settings.hitCollectionColor);
        //     settings.hitBoxColor = EditorGUILayout.ColorField("Hit Box Color", settings.hitBoxColor);
        //     settings.hitCapsuleColor = EditorGUILayout.ColorField("Hit Capsule Color", settings.hitCapsuleColor);
        //     settings.hitSphereColor = EditorGUILayout.ColorField("Hit Sphere Color", settings.hitSphereColor);

        //     if (EditorGUI.EndChangeCheck())
        //     {
        //         EditorUtility.SetDirty(settings);
        //         UnityEditor.SceneView.RepaintAll();
        //     }
        // }





        private LagCompensationSettings settings;
        private Editor settingsEditor;

        private const string FOLDER_PATH = "Assets/HalalStudio/Resources";
        private const string FILE_PATH = "NetickLagCompensationConfig.asset";

        [MenuItem("Tools/HalalStudio/Netick Lag Compensation", false, -1)]
        public static void OpenWindow()
        {
            EditorWindow window = GetWindow<LagCompensationSettingsWindow>("Netick LC Settings");
            window.titleContent = new GUIContent("Netick LC Settings", EditorGUIUtility.IconContent("d_Profiler.NetworkMessages@2x").image);
        }

        private void OnEnable()
        {
            // settings = Resources.Load<LagCompensationSettings>("LagCompensationSettings");
            // if (settings == null)
            // {
            //     settings = ScriptableObject.CreateInstance<LagCompensationSettings>();
            //     // string folder = "Assets/Netick/Resources";

            //     if (!System.IO.Directory.Exists(FOLDER_PATH))
            //         System.IO.Directory.CreateDirectory(FOLDER_PATH);

            //     string path = $"{FOLDER_PATH}/{FILE_PATH}";
            //     AssetDatabase.CreateAsset(settings, path);
            //     AssetDatabase.SaveAssets();
            //     AssetDatabase.Refresh();
            // }

            // settingsEditor = Editor.CreateEditor(settings);

            // Use the static accessor to get/create the settings
            settings = LagCompensationSystem.GetOrCreateSettings();

            // Create an Editor for automatic field drawing
            settingsEditor = Editor.CreateEditor(settings);
        }

        private void OnGUI()
        {
            if (settings == null)
            {
                EditorGUILayout.HelpBox("Settings asset not found!", MessageType.Error);
                return;
            }

            settingsEditor.OnInspectorGUI(); // Unity automatically draws all fields
            if (GUI.changed)
            {
                EditorUtility.SetDirty(settings);
                SceneView.RepaintAll();
            }
        }
    }
}