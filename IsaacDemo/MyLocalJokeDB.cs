namespace IsaacDemo
{
    using System.Collections.Generic;
    using IsaacDemo.Pages.ViewModels;

    public static class MyLocalJokeDb
    {
        public static Dictionary<int, GoodJokeViewModel> JokeList { get; set; }
    }
}
