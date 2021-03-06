﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class CreatePublicationViewModel
    {
        [Required]
        [Display(Name = "Название")]
        public string PublicationName { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Discription { get; set; }

        [Required]
        [Display(Name = "Текст")]
        public string PublicationText { get; set; }

        [Required]
        [Display(Name = "Фото")]
        public IFormFile AvatarPost { get; set; }

        [Required]
        [Display(Name = "Фото")]
        public IFormFile AvatarPost2 { get; set; }

        [Display(Name = "Любимое")]
        public bool isFavorite { get; set; }

        public string TopicName { get; set; }
    }
}
