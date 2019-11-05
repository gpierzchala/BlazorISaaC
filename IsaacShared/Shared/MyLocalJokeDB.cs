namespace IsaacDemo.Shared
{
    using IsaacDemo.Shared.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public static class MyLocalJokeDb
    {
        public static Dictionary<int, GoodJokeViewModel> JokeList{ get; set; }
    }
}
