﻿using System;
using UnityEngine;

namespace SceneHub.Editor.Utilities
{
    internal static class EditorGUILayoutUtility
    {
        public static T DrawTabToolbar<T>(T current) where T : struct, Enum
        {
            var type = typeof(T);

            var names = Enum.GetNames(type);
            var index = Convert.ToInt32(current);

            var next = GUILayout.Toolbar(index, names);

            var result = Enum.Parse<T>(names[next]);

            return result;
        }
    }
}