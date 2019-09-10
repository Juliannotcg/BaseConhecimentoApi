﻿using System.ComponentModel.DataAnnotations;

namespace BaseConhecimentoApi.Infra.Identity.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
