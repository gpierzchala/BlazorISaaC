﻿namespace IsaacDemo.Pages.Jokes.Validation
{
    using System.ComponentModel.DataAnnotations;

    public class CreateJokeViewModel
    {
        [Required]
        [StringLength(maximumLength: 16, ErrorMessage = "Joke to long!")]
        public string JokeContent { get; set; }
    }
}
