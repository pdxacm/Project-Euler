public class EulerNineteen
{
	enum Month { Jan, Feb, Mar, Apr, June, Jul, Aug, Sept, Oct, Nov, Dec };
	public static boolean isLeap(int year)
	{
		if (year % 400 == 0)
			return true;
		else if (year % 100 == 0)
			return false;
		else if (year % 4 == 0)
			return true;
		// Just to satisfy program...
		else
			return false;
	}
	public static void main(String[] args)
	{
		boolean leapYear = false;
		int year = 1901;
		int numSundays = 0;
		int dayOfWeek = 2;
		while (year <= 2000)
		{
			leapYear = isLeap(year);
			for (int month=1; month <= 12; month++)
			{
				if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
				{
					dayOfWeek+=31;
					dayOfWeek %= 7;
				}
				if (month == 2 && leapYear)
				{
					dayOfWeek +=29;
					dayOfWeek %= 7;
				}
				if (month == 2 && !leapYear)
				{
					dayOfWeek+=28;
					dayOfWeek %= 7;
				}
				if (month == 4 || month == 6 || month == 9 || month == 11)
				{
					dayOfWeek += 30;
					dayOfWeek %= 7;
				}
				if (dayOfWeek == 0)
					numSundays++;
			}
			year++;
		}
		System.out.println(numSundays);
	}
}