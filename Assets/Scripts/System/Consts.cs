using System.Collections.Generic;

namespace Constants
{
    public class Consts
    {
        public const int SEPlayableLimit = 5;

        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.TitleScene] = "Title",
            [SceneNames.InGameScene] = "InGame",
            [SceneNames.ResultScene] = "Result",
        };
    }

    public enum SceneNames
    {
        TitleScene,
        InGameScene,
        ResultScene,
    }

    public enum Turn
    {
        None,
        Player,
        Opponent,
    }

    public enum BGMType
    {
        //ここに、各BGMのenumを列挙する
        TitleBGM,
        HomeBGM,
        InGameBGM,
        ResultBGM,
    }

    public enum SEType
    {
        //ここに、各SEのenumを列挙する
    }
}

