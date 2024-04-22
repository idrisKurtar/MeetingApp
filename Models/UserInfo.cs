using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;

public class UserInfo
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Ad alanı girmek zorunlu")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Telefon numarası girmek zorunlu")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Email adresi girmek zorunlu")]
    [EmailAddress(ErrorMessage =" Email formatı şeklinde giriniz.")]
    public string? Email { get; set; }
    [Required (ErrorMessage ="Lütfen seçim yapınız")]
    public bool? WillAttend { get; set; }
}