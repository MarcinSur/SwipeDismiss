using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GoalData)), CanEditMultipleObjects]
public class PropertyHolderEditor : Editor
{

    //public SerializedProperty
    //    state_Prop,
    //    valForAB_Prop,
    //    valForA_Prop,
    //    valForC_Prop,
    //    controllable_Prop;

    //void OnEnable()
    //{
    //    // Setup the SerializedProperties
    //    state_Prop = serializedObject.FindProperty("goalType");
    //    valForAB_Prop = serializedObject.FindProperty("title");
    //    valForA_Prop = serializedObject.FindProperty("goalId");
    //    valForC_Prop = serializedObject.FindProperty("id");
    //    controllable_Prop = serializedObject.FindProperty("desc");
    //}

    //public override void OnInspectorGUI()
    //{
    //    serializedObject.Update();

    //    EditorGUILayout.PropertyField(state_Prop);

    //    GoalType gt = (GoalType)state_Prop.enumValueIndex;

    //    switch (gt)
    //    {
    //        case GoalType.CountDown:
    //            EditorGUILayout.PropertyField(controllable_Prop, new GUIContent("controllable"));
    //            EditorGUILayout.IntSlider(valForA_Prop, 0, 10, new GUIContent("valForA"));
    //            EditorGUILayout.IntSlider(valForAB_Prop, 0, 100, new GUIContent("valForAB"));
    //            break;

    //        case GoalType.FindObject:
    //            EditorGUILayout.PropertyField(controllable_Prop, new GUIContent("controllable"));
    //            EditorGUILayout.IntSlider(valForAB_Prop, 0, 100, new GUIContent("valForAB"));
    //            break;

    //        case GoalType.Boolean:
    //            EditorGUILayout.PropertyField(controllable_Prop, new GUIContent("controllable"));
    //            EditorGUILayout.IntSlider(valForC_Prop, 0, 100, new GUIContent("valForC"));
    //            break;

    //    }


    //    serializedObject.ApplyModifiedProperties();
    //}
}