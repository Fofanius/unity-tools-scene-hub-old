﻿using System.Collections.Generic;
using System.Linq;
using SceneHub.Editor.Utilities;
using SceneHub.Utilities;
using UnityEditor;

namespace SceneHub.Editor
{
    public partial class SceneHubPopup
    {
        private List<SceneAsset> _scenes = new List<SceneAsset>();

        private void RefreshScenes()
        {
            _scenes = AssetDatabaseUtility.FindScenes().ToList();
        }

        private void DrawScenes()
        {
            if (_scenes.IsNullOrEmpty())
            {
                EditorGUILayout.LabelField("No scenes in project ...");
            }
            else
            {
                foreach (var scene in _scenes)
                {
                    DrawSceneAssetMenu(scene, scene.name, AssetDatabase.GetAssetPath(scene));
                }
            }
        }
    }
}
