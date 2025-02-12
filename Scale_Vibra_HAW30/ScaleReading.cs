using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Scale_Vibra_HAW30
{
    /// <summary>
    ///Vibra HAW-30
    ///ST,NT,-  0.597  g
    ///US,NT,-  0.593  g
    ///ST, NT,-  0.597  kg
    ///US, NT,-  0.593  kg
    ///ST, GS,+  0.582  kg
    ///US, GS,+  3.029  kg
    /// </summary>
    public class ScaleReading
    {
        public static string oldData = "";
        public static string pattern = @"(\bST\b|\bUS\b),(\bNT\b|\bGS\b),([+-]\s*\d+(\.\d+)?)\s*(g|kg)";
        public static void GetWeight(out double? WeightValue, out bool? Stable, out bool? Tare, out string Unit, string rawData)
        {
            //Debug.WriteLine(rawData.ToString());

            WeightValue = 0;
            Stable = false;// CountError > 5;
            Tare = false;
            Unit = "KG";

            bool isTrueFormat = !string.IsNullOrEmpty(rawData) &&  rawData.Length >= 12;

            if (isTrueFormat == false  && !string.IsNullOrEmpty(oldData))
            {
                rawData = oldData;
            }

            try
            {
                isTrueFormat = !string.IsNullOrEmpty(rawData) && rawData.Length >= 12;
                if (isTrueFormat)
                {
                    //Debug.WriteLine(rawData);
                    MatchCollection matches = Regex.Matches(rawData, pattern);
                    foreach (Match match in matches)
                    {
                        string stable = match.Groups[1].Value;    // ST hoặc US
                        string ntOrGs = match.Groups[2].Value;    // NT hoặc GS
                        string weightStr = match.Groups[3].Value; // Trọng lượng
                        Debug.WriteLine(weightStr);


                        double weight = ThisToDouble(weightStr.Replace(" ", ""));  // Chuyển đổi trọng lượng sang double

                        string unit = match.Groups[4].Value;                       // Đơn vị cố định

                        Debug.WriteLine($"ST/US: {stable}, NT/GS: {ntOrGs}, Weight: {weight} {unit}");
                        //Đổi tất cả về đơn vị thống nhất về KG
                        if (unit.ToUpper() == "KG")
                            weight = 1 * weight;
                        else if (unit.ToUpper() == "G")
                            weight = 0.001 * weight;
                        else if (unit.ToUpper() == "TON")
                            weight = 1000 * weight;

                        WeightValue = weight;
                        Stable = stable == "ST";
                        Unit = unit.ToUpper();

                    }

                    oldData = rawData;
                }

            }
            catch (Exception ex)
            {
                ;
            }
        }


        private static double ThisToDouble(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            if (value is double doubleValue)
            {
                return doubleValue;
            }


            if (double.TryParse(value.ToString(), NumberStyles.Any, new CultureInfo("en-US"), out double result))
            {
                return result;
            }

            return 0;
        }
    }
}
