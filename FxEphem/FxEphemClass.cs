using System;

namespace FxEphem
{
	internal static class FxEphemClass
	{
		// all constants here

		/* 1. CALENDRIAL CALCULATIONS */

		// Julian Date

		public static double CalcJulianDate(DateTime date)
		{
			return date.ToOADate() + 2415018.5;
		}

		public static double CalcJulianDate()
		{
			return DateTime.Now.ToOADate() + 2415018.5;
		}

		// Modified Julian Date

		public static double CalcModifiedJulianDate(DateTime date)
		{
			return CalcJulianDate(date: date) - 2400000.5;
		}

		public static double CalcModifiedJulianDate()
		{
			return CalcJulianDate() - 2400000.5;
		}

		// Centuries since 1st Januar 2000 12 p.m.

		public static double CalcCenturiesSince2000()
		{
			return (CalcJulianDate() - 2451545) / 36525;
		}

		public static double CalcCenturiesSince2000(DateTime date)
		{
			return (CalcJulianDate(date: date) - 2451545) / 36525;
		}
	}
}
