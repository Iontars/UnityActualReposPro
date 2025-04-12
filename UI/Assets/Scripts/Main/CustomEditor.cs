#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class CustomHierarchyHighlighter
{
    static CustomHierarchyHighlighter()
    {
        EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
    }

    static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
    {
        GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        if (obj != null && obj.name.StartsWith("[RED]"))
        {
            // Рисуем красным цветом название
            EditorGUI.LabelField(selectionRect, obj.name, new GUIStyle()
            {
                normal = new GUIStyleState() { textColor = Color.red }
            });
        }
    }
}
#endif

