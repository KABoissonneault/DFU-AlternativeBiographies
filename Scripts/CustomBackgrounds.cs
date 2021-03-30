using System;
using UnityEngine;

using DaggerfallWorkshop;
using DaggerfallWorkshop.Utility;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;

namespace CustomBackgrounds
{
    public class CustomBackgrounds : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            new GameObject(initParams.ModTitle).AddComponent<CustomBackgrounds>();
        }

        public void Awake()
        {
            DaggerfallUnity.Instance.TextProvider = new BackgroundTextProvider(DaggerfallUnity.Instance.TextProvider);
            DaggerfallUnity.Instance.MacroDataSourceFactory = new BackgroundMacroDataSourceFactory(DaggerfallUnity.Instance.MacroDataSourceFactory);
        }
    }
}
