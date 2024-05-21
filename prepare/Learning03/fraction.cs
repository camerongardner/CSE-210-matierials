using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

public class Fraction
{
   private int _top;
   private int _bottom;

   public Fraction()
   {
        _top = 1;
        _bottom = 1;
        Compute();
   }
   public Fraction(int number)
   {
        _top = number;
        _bottom = 1;
        Compute();
   }
   public Fraction(int top, int bottom)
   {
        _top = top;
        _bottom = bottom;
        Compute();

   }
   public string Compute()
   {
        string fraction = $"{_top}/{_bottom}";
        double deci = (double)_top / (double)_bottom;
        return $"The fraction is {fraction} and the decimal is {deci}";
   }
   





}