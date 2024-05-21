public class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int year, int month, int day)
    {
        if (year < 0 || month < 1 || month > 12 || day < 1 || !IsValidDay(month, day))
        {
            throw new ArgumentOutOfRangeException("Invalid date");
        }

        this.year = year;
        this.month = month;
        this.day = day;
    }

    private bool IsValidDay(int month, int day)
    {
        if (month == 2)
        {
            return IsLeapYear(year) ? day <= 29 : day <= 28;
        }
        else if (month <= 6)
        {
            return day <= 31;
        }
        else
        {
            return day <= 30;
        }
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Date other = (Date)obj;
        return year == other.year && month == other.month && day == other.day;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hashCode = year;
            hashCode = (hashCode * 397) ^ month;
            hashCode = (hashCode * 397) ^ day;
            return hashCode;
        }
    }

    public Date NextDay()
    {
        if (IsEndOfYear())
        {
            return new Date(year + 1, 1, 1);
        }
        else if (IsEndOfMonth())
        {
            return new Date(year, month + 1, 1);
        }
        else
        {
            return new Date(year, month, day + 1);
        }
    }

    private bool IsEndOfMonth()
    {
        return day == DaysInMonth(month, year);
    }

    private bool IsEndOfYear()
    {
        return month == 12 && day == 31;
    }

    private int DaysInMonth(int month, int year)
    {
        if (month == 2)
        {
            return IsLeapYear(year) ? 29 : 28;
        }
        else if (month <= 6)
        {
            return 31;
        }
        else
        {
            return 30;
        }
    }

    public override string ToString()
    {
        return $"{day:00}/{month:00}/{year}";
    }

    public static Date Add(Date date1, Date date2)
    {
        int totalDays = GetTotalDays(date1) + GetTotalDays(date2);
        int year = GetYearFromTotalDays(totalDays);
        int month = GetMonthFromTotalDays(totalDays, year);
        int day = GetDayFromTotalDays(totalDays, year, month);
        return new Date(year, month, day);
    }

    private static int GetTotalDays(Date date)
    {
        int daysInYears = (date.year - 1) * 365 + GetLeapYearsBefore(date.year);
        int daysInMonths = DaysBeforeMonth(date.month, date.year) + date.day;
        return daysInYears + daysInMonths;
    }

    private static int GetLeapYearsBefore(int year)
    {
        year--;
        return year / 4 - year / 100 + year / 400;
    }

    private static int DaysBeforeMonth(int month, int year)
    {
        int days = 0;
        for (int i = 1; i < month; i++)
        {
            days += DaysInMonth(i, year);
        }
        return days;
    }

    private static int GetYearFromTotalDays
