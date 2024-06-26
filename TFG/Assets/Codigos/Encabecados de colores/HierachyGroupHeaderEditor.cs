using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*using UnityEditor;

[InitializeOnLoad]
public class HierachyGroupHeaderEditor : Editor
{
    public static Color DEFAULT_COLOR_HIERARCHY_SELECTED = Color.green;
    static HierachyGroupHeaderEditor()
    {
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;

    }
    private static void HierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
    {
        GameObject gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        Color backgroundColor = DEFAULT_COLOR_HIERARCHY_SELECTED;

        if (gameObject != null && gameObject.CompareTag("EditorOnly"))
        {
            gameObject.name = gameObject.name.ToUpper();

            HierarchyGroupHeader header = gameObject.GetComponent<HierarchyGroupHeader>();

            if(header != null && Event.current.type == EventType.Repaint)
            {
                backgroundColor = header.backgroundColor;
                EditorGUI.DrawRect(selectionRect, backgroundColor);
                EditorGUI.DropShadowLabel(selectionRect, gameObject.name);
            }
            else 
            {

            EditorGUI.DrawRect(selectionRect, DEFAULT_COLOR_HIERARCHY_SELECTED);
            EditorGUI.DropShadowLabel(selectionRect, gameObject.name);
            }
        }
        EditorApplication.RepaintHierarchyWindow();
    }
}
*/