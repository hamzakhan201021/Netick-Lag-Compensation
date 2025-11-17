using UnityEditor;
using UnityEngine;

namespace HalalStudio.NetickLagCompensation
{
    [CustomEditor(typeof(LagCompensationSettings))]
    public class LagCompensationSettingsEditor : Editor
    {
        // public override void OnInspectorGUI()
        // {
        //     var settings = (LagCompensationSettings)target;
        //     bool isPro = EditorGUIUtility.isProSkin;

        //     GUIStyle panel = new GUIStyle(EditorStyles.inspectorDefaultMargins);
        //     panel.padding = new RectOffset(15, 15, 15, 15);

        //     EditorGUILayout.BeginVertical(panel);

        //     EditorGUILayout.Space(10);

        //     // Color mainColor = isPro ? Color.lightGray : Color.black;
        //     Color mainColor = isPro ? Color.skyBlue : Color.black;

        //     GUIStyle bigHeader = new GUIStyle()
        //     {
        //         fontSize = 26,
        //         alignment = TextAnchor.MiddleLeft,
        //         normal = { textColor = mainColor }
        //     };
        //     EditorGUILayout.LabelField("Halal Studio", bigHeader);
        //     EditorGUILayout.Space(10);

        //     // Color subColor = isPro ? new Color(0.5f, 0.9f, 1f) : new Color(0.0f, 0.6f, 1f);
        //     GUIStyle subHeader = new GUIStyle()
        //     {
        //         fontSize = 18,
        //         alignment = TextAnchor.MiddleLeft,
        //         normal = { textColor = mainColor }
        //     };
        //     EditorGUILayout.LabelField("Netick Lag Compensation", subHeader);
        //     // EditorGUILayout.Space(15);

        //     // float rectHeight = 5f;
        //     // Rect sectionRect = EditorGUILayout.GetControlRect(false, rectHeight);

        //     // Color bg = isPro
        //     //     ? new Color(0.15f, 0.15f, 0.15f, 0.85f)
        //     //     : new Color(0.8f, 0.8f, 0.8f, 0.5f);

        //     // EditorGUI.DrawRect(sectionRect, bg);

        //     GUIStyle infoLabel = new GUIStyle(EditorStyles.label)
        //     {
        //         alignment = TextAnchor.MiddleLeft,
        //         fontSize = 15,
        //         padding = new RectOffset(10, 10, 0, 0),
        //         normal = { textColor = isPro ? Color.white : Color.black }
        //     };

        //     // EditorGUI.LabelField(sectionRect, "Settings", infoLabel);

        //     // EditorGUILayout.Space(10);

        //     // EditorGUI.indentLevel++;
        //     serializedObject.Update();
        //     DrawPropertiesExcluding(serializedObject, "m_Script");
        //     serializedObject.ApplyModifiedProperties();
        //     // settings.hitCollectionColor = EditorGUILayout.ColorField("Hit Collection", settings.hitCollectionColor);
        //     // settings.hitColliderColor = EditorGUILayout.ColorField("Hit Collider", settings.hitColliderColor);
        //     // EditorGUI.indentLevel--;

        //     // EditorGUILayout.Space(10);

        //     EditorGUILayout.EndVertical();

        //     if (GUI.changed)
        //     {
        //         EditorUtility.SetDirty(settings);
        //         SceneView.RepaintAll();
        //     }
        // }

        // static bool settingsFoldout = true;

        public override void OnInspectorGUI()
        {
            var settings = (LagCompensationSettings)target;
            bool isPro = EditorGUIUtility.isProSkin;

            GUIStyle panel = new GUIStyle();
            panel.padding = new RectOffset(15, 15, 15, 15);

            GUILayout.BeginVertical(panel);

            GUILayout.Space(10);

            Color mainColor = isPro ? Color.skyBlue : Color.black;

            GUIStyle bigHeader = new GUIStyle()
            {
                fontSize = 26,
                alignment = TextAnchor.MiddleLeft,
                normal = { textColor = mainColor }
            };
            EditorGUILayout.LabelField("Halal Studio", bigHeader);
            GUILayout.Space(10);

            GUIStyle subHeader = new GUIStyle()
            {
                fontSize = 18,
                alignment = TextAnchor.MiddleLeft,
                normal = { textColor = mainColor }
            };
            EditorGUILayout.LabelField("Netick Lag Compensation", subHeader);

            GUILayout.Space(10);

            // GUILayout.BeginVertical(panel);
            // settingsFoldout = EditorGUILayout.Foldout(settingsFoldout, "Settings", true, EditorStyles.foldout);

            GUIStyle settingsPanel = new GUIStyle();
            settingsPanel.padding = new RectOffset(0, 0, 0, 0);

            GUILayout.BeginVertical(settingsPanel);

            // if (settingsFoldout)
            // {
            // GUILayout.BeginVertical();
            serializedObject.Update();
            DrawPropertiesExcluding(serializedObject, "m_Script");
            serializedObject.ApplyModifiedProperties();
            // GUILayout.EndVertical();
            // }

            GUILayout.EndVertical();

            // GUILayout.EndVertical();

            GUILayout.EndVertical();

            if (GUI.changed)
            {
                EditorUtility.SetDirty(settings);
                SceneView.RepaintAll();
            }
        }
    }
}