using System.ComponentModel.DataAnnotations;

namespace Personal_Portfolio.Components.Portfolio;

public sealed class ContactFormModel
{
    [Required(ErrorMessage = "Please enter your full name.")]
    [StringLength(100, ErrorMessage = "Your name must be 100 characters or fewer.")]
    [Display(Name = "Full name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [StringLength(254, ErrorMessage = "Your email address must be 254 characters or fewer.")]
    [Display(Name = "Email address")]
    public string EmailAddress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a subject.")]
    [StringLength(150, ErrorMessage = "Your subject must be 150 characters or fewer.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a message.")]
    [StringLength(3000, MinimumLength = 10, ErrorMessage = "Your message must be between 10 and 3000 characters.")]
    public string Message { get; set; } = string.Empty;
}
