using System.ComponentModel.DataAnnotations;

namespace ThermoCal.Core.DTOs;

public class AccelerationWorkRequestDto
{
    public double M { get; set; }
    
    public double A { get; set; }
    
    public double F { get; set; }
    
    public double VFirst { get; set; }
    
    public double VSecond { get; set; }
}