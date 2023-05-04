using System;

public class Fraction
    {
        // The C# convention is to start member variables with an underscore _
        private int _top;
        private int _bottom;
        
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.


        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }
        public int GetTop()
        {
            return _top;
        }
        public void SetTop(int top)
        {
            _top = top;   
        }
        public int GetBottom()
        {
            return _bottom;
        }
        public void SetBottom(int bottom)
        {
            _bottom = bottom; 
        }
        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }
        public double GetDecimalValue()
        {
            return (double)_top / (double)_bottom;
        }
    }