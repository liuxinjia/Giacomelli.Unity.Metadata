//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Giacomelli.Unity.Metadata.Infrastructure.Bootstrap
//{
//    using UnityEditor;
//    using UnityEngine;
//    using UnityEngine.UIElements;
//    using Giacomelli.Unity.Metadata.Domain;
//    using System;
//    using Giacomelli.Unity.Metadata.Infrastructure.Bootstrap;
//    using System.Collections.Generic;

//    public class MissingWinodw : EditorWindow
//    {
//        [MenuItem("Window/UI Toolkit/MissingWinodw #t")]
//        public static void ShowExample()
//        {
//            MissingWinodw wnd = GetWindow<MissingWinodw>();
//            wnd.titleContent = new GUIContent("MissingWinodw");
//        }

//        public void CreateGUI()
//        {
//            // Each editor window contains a root VisualElement object
//            VisualElement root = rootVisualElement;

//            // VisualElements objects can contain other VisualElement following a tree hierarchy.
//            var button = new Button();
//            button.text = "west";

//            button.clicked += () => FindMissing();
//            root.Add(button);
//        }

//        private void FindMissing()
//        {
//            MetadataBootstrap.Setup();

//            var prefabService = MetadataBootstrap.PrefabMetadataService;
//            var prefabs = prefabService.GetPrefabs("Assets/Settings");
//            var typeService = MetadataBootstrap.TypeService;
//            var assetRepository = MetadataBootstrap.AssetRepository;

//            foreach (var prefab in prefabs)
//            {

//                foreach (var item in prefab.MonoBehaviours)
//                {
//                    if (item == null) continue;

//                    if (item.Script == null) continue;
//                    if (string.IsNullOrEmpty(item.Script.FullName)) continue;
//                    if (item.Script.FullName == "TestSO.cs")
//                    {
//                        var destType = typeof(TEstSo24);

//                        ReplaceMonoBehaviours(item, prefab.Path, destType);
//                        break;
//                    }

//                    break;

//                }
//            }
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="prefab"></param>
//        public void ReplaceMonoBehaviours(MonoBehaviourMetadata replacingMonoBehaviour, string prefabPath, Type destType)
//        {
//            var typeService = MetadataBootstrap.TypeService;
//            var prefabService = MetadataBootstrap.PrefabMetadataService;

//            var newGuid = typeService.GetGuid(destType);
//            prefabService.Writer.ReplaceGuid(replacingMonoBehaviour.Script, newGuid, prefabPath);
//        }
//    }

//}
