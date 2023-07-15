using System.Collections.Generic;

namespace Constants
{
    public class Consts
    {
        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.TITLE_SCENE] = "Title",
            [SceneNames.INGAME_SCENE] = "InGame",
            [SceneNames.RESULT_SCENE] = "Result",
        };
    }

    public enum SceneNames
    {
        TITLE_SCENE,
        INGAME_SCENE,
        RESULT_SCENE,
    }
}

