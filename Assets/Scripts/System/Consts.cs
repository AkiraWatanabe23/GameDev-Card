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

    public enum Turn
    {
        NONE,
        PLAYER,
        OPPONENT,
    }

    public enum BGM_TYPE
    {
        //ここに、各BGMのenumを列挙する
        BGM_TITLE,
        BGM_HOME,
        BGM_INGAME,
        BGM_RESULT,
    }

    public enum SE_TYPE
    {
        //ここに、各SEのenumを列挙する
    }
}

