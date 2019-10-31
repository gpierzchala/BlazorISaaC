namespace IsaacDemo.Shared
{
    using IsaacDemo.Shared.ViewModels;

    using System.Collections.Generic;

    public static class MyLocalJokeDb
    {
        public static Dictionary<int, GoodJokeViewModel> JokeList { get; set; }
    }
}
