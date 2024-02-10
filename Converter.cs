namespace Convert
{
    public static class Converter
    {
        public static double ConvertToUnit(double inches, string unit)
        {
            return unit switch
            {
                "mm" => inches * 25.4,
                "cm" => inches * 2.54,
                "m"  => inches * 0.0254,
                _    => throw new System.ArgumentException("Invalid unit specified.")
            };
        }
    }
}
