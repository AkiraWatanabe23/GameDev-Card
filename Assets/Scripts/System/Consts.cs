using System.Collections.Generic;

namespace Constants
{
    public class Consts
    {
        public const int SEPlayableLimit = 5;

        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.TitleScene] = "Title",
            [SceneNames.HomeScene] = "Home",
            [SceneNames.InGameScene] = "InGame",
            [SceneNames.ResultScene] = "Result",
        };
    }

    public enum SceneNames
    {
        TitleScene,
        HomeScene,
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
        None,
        TitleBGM,
        HomeBGM,
        InGameBGM,
        ResultBGM,
    }

    public enum SEType
    {
        None,
    }
}

