using UnityEditor;
using UnityEngine;

namespace CompilerDestroyer.Editor.EditorVisual
{
    public static class GlobalVariables
    {
        // Project Paths
        public const string NickName = "Compiler Destroyer";
        public const string packageName = "com.compilerdestroyer";
        public const string UnityEditorVisualsPackageName = packageName + ".unityeditorvisuals";


        public const string ProjectsPath = "Packages/com.compilerbutcher.editortools/Editor Tools/Editor/Projects";
        public const string GUISkinsFolderPath = "Packages/com.compilerbutcher.editortools/Editor Tools/Editor/Data/GUISkins";

        // Custom Editor GUIStyle Names
        public const string HeaderLabelGUIStyleName = "Header Label";
        public const string FoldoutHeaderGUIStyleName = "Foldout Header";


        private static readonly Color defaultLineDarkColor = new Color(0.1215686f, 0.1215686f, 0.1215686f, 1f);
        private static readonly Color defaultLineWhiteColor = new Color(0.6f, 0.6f, 0.6f, 1f);
        public static Color DefaultLineColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin)
                {
                    return defaultLineDarkColor;
                }
                else
                {
                    return defaultLineWhiteColor;
                }
            }
        }

        private static readonly Color defaultBackgroundDarkColor = new Color(0.2352941f, 0.2352941f, 0.2352941f, 1f);
        private static readonly Color defaultBackgroundWhiteColor = new Color(0.7843138f, 0.7843138f, 0.7843138f, 1f);
        public static Color DefaultBackgroundColor
        {
            get
            {
                if (EditorGUIUtility.isProSkin)
                {
                    return defaultBackgroundDarkColor;
                }
                else
                {
                    return defaultBackgroundWhiteColor;
                }
            }
        }

    }
}
