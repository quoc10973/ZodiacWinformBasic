namespace Services
{
    /// <summary>
    /// class này sẽ chứa hàm để tính toán cung hoàng đạo của bạn
    /// </summary>
    public class IdolZodiacCalculator
    {
        /// <summary>
        /// Đây là hàm trả về Idol cung hoàng đạo của bạn dựa vào ngày và tháng
        /// </summary>
        /// <param name="day">ngày từ 1-31</param>
        /// <param name="month">tháng từ 1-12</param>
        /// <returns></returns>
        public static string GetIdolZodiac(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day < 20) //Jan
                        return "Capricorn"; //Ma kết
                    return "Aquarius"; //Bảo Bình
                case 2: //Feb
                    if (day < 19)
                        return "Aquarius"; //Bảo Bình
                    return "Pisces"; //Song ngư
                case 3: //Mar
                    if (day < 21)
                        return "Pisces"; //Song ngư
                    return "Aries"; //Bạch Dương
                case 4: //Apr
                    if (day < 21)
                        return "Aries"; //Bạch Dương
                    return "Taurus"; //Kim Ngưu
                case 5:
                    if (day < 21)
                        return "Taurus"; //Kim Ngưu
                    return "Gemini"; //Song Tử
                case 6:
                    if (day < 22)
                        return "Gemini"; //Song Tử
                    return "Cancer"; //Cự Giải
                case 7:
                    if (day < 23)
                        return "Cancer"; //Cự Giải
                    return "Leo"; //Sư Tử
                case 8:
                    if (day < 23)
                        return "Leo"; //Sư Tử
                    return "Virgo"; //Xử Nữ
                case 9:
                    if (day < 23)
                        return "Virgo"; //Xử Nữ
                    return "Libra"; //Thiên Bình  
                case 10:
                    if (day < 24)
                        return "Libra"; //Thiên Bình  
                    return "Scorpio"; //Bọ Cạp
                case 11:
                    if (day < 23)
                        return "Scorpio"; //Bọ Cạp
                    return "Sagittarius"; //Nhân mã
                case 12:
                    if (day < 22)
                        return "Sagittarius"; //Nhân mã
                    return "Capricorn"; //Ma Kết
                default:
                    return "cat"; //nhap sai
            }
        }

        public static string GetIdolName(string zodiac)
        {
            string name = "";
            switch (zodiac)
            {
                case "Capricorn":
                    name = "Kim Jennie";
                    break;
                case "Aquarius":
                    name = "Park Bo-young";
                    break;
                case "Pisces":
                    name = "Park Min-young";
                    break;
                case "Aries":
                    name = "Kim Da-mi";
                    break;
                case "Taurus":
                    name = "IU";
                    break;
                case "Gemini":
                    name = "Yoo In-na";
                    break;
                case "Cancer":
                    name = "Kim Go-eun";
                    break;
                case "Leo":
                    name = "Jeon Yeo-been";
                    break;
                case "Virgo":
                    name = "Shin Hye-sun";
                    break;
                case "Libra":
                    name = "Bae Suzy";
                    break;
                case "Scorpio":
                    name = "Han So Hee";
                    break;
                case "Sagittarius":
                    name = "Kim Ye-won";
                    break;
            }
            return name;
        }
    }
}
    
