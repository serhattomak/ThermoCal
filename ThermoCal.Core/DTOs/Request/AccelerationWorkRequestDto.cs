using System.ComponentModel.DataAnnotations;

namespace ThermoCal.Core.DTOs;

public class AccelerationWorkRequestDto
{
    [Required]
    public double M { get; set; }

    [Required]
    public double A { get; set; }

    [Required]
    public double F { get; set; }

    [Required]
    public double VFirst { get; set; }

    [Required]
    public double VSecond { get; set; }
}